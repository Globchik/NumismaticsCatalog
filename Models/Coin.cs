using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

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
        public Country? Country { get; set; }
        public string Notes { get; set; } = String.Empty;

        float _coin_value;
        public float CoinValue
        {
            get => _coin_value;
            set
            {
                if (Math.Truncate(value * 100) != value * 100 || value <= 0)
                    throw new ArgumentException("Wrong coin value format");

                _coin_value = value;
            }
        }

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

        int? _year;
        public int? YearOfIssue
        {
            get => _year;
            set
            {
                if (value != null && (value < 0 || value > 9999))
                    throw new ArgumentException("Wrong year of issue format.");

                _year = value;
            }
        }


        [JsonIgnore]
        public string CountryString
        {
            get
            {
                return Country == null ? String.Empty : Country.Name;
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

        public override string ToString()
        {
            return $"{YearOfIssue};{CountryString};" +
                $"{CoinValueString};{MetalContentString}.";
        }
    }
}
