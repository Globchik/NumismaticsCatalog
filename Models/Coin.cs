﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace NumismaticsCatalog.Models
{
    /// <summary>
    /// Coin class represents a coin,
    /// it has coin`s country, currency, date of issue,
    /// metal contents and notes.
    /// </summary>
    public class Coin
    {
        public List<Metal> MetalContent = new();
        public Currency? CoinCurrency { get; set; }
        public float CoinValue { get; set; }
        public Country? Country { get; set; }
        public string Notes { get; set; }

        int? _issueAmount;
        public int? AmountIssued
        {
            get => _issueAmount;
            set
            {
                if (value != null && value < 1)
                    throw new ArgumentException("Wrong coin amount.");

                _issueAmount = value;
            }
        }

        int _year;
        public int YearOfIssue
        {
            get => _year;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Wrong Year of issue.");

                _year = value;
            }
        }

        public Coin()
        {
            Country = null;
            Notes = "";
        }

        public Coin(int year_of_issue, Country country, int? amount_issued, Currency currency,
            float coin_value, List<Metal> metal_content, string notes = "")
        {
            YearOfIssue = year_of_issue;
            Country = country;
            AmountIssued = amount_issued;
            CoinCurrency = currency;
            CoinValue = coin_value;
            MetalContent = metal_content;
            Notes = notes;
        }

        [JsonIgnore]
        public string? CountryString
        {
            get
            {
                return Country?.Name;
            }
        }

        [JsonIgnore]
        public string CoinValueString
        {
            get
            {
                return $"{CoinValue} {CoinCurrency?.Name}";
            }
        }

        [JsonIgnore]
        public string MetalContentString
        {
            get
            {
                string res = "";
                if (MetalContent.Count != 0)
                    res += MetalContent[0].Name;

                for (int i = 1; i < MetalContent.Count; i++)
                    res += ", " + MetalContent[i].Name;
                return res;
            }
        }
    }
}
