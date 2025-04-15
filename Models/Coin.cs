using System;
using System.Collections.Generic;

namespace NumismaticsCatalog.Models
{
    public class Coin
    {
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
        public Currency CoinCurrency { get; set; }
        public float CoinValue { get; set; }
        public string CoinValueString {
            get
            {
                return $"{CoinValue} {CoinCurrency.Name}";
            } 
        }

        int _year;
        public int YearOfIssue
        {
            get => _year;
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Wrong Year of issue.");

                _year = value;
            }
        }

        public Country Country { get; set; }
        public string CountryString
        {
            get
            {
                return Country.Name;
            }
        }

        int? _issueAmount;
        public int? AmountIssued
        {
            get => _issueAmount;
            private set
            {
                if (value != null && value < 1)
                    throw new ArgumentException("Wrong coin amount.");

                _issueAmount = value;
            }
        }

        public List<Metal> MetalContent = new();
        public string MetalContentString { 
            get
            {
                string res = "";
                if (MetalContent.Count != 0)
                    res += MetalContent[0].Name;

                for (int i = 1; i < MetalContent.Count;i++)
                    res += ", " + MetalContent[i].Name;
                return res;
            } 
        }

        public string Notes { get; set; }
    }
}
