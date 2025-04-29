using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace NumismaticsCatalog.Models
{
    public class Collector
    {
        public string Name { get; set; }
        public Country? Country { get; set; }
        public string ContactInformation { get; set; }
        public List<Coin> CoinCollection = new();

        public Collector()
        {
            Name = "";
            Country = null;
            ContactInformation = "";
        }

        public Collector(string name, Country country, string contact_information = "")
        {
            Name = name;
            Country = country;
            ContactInformation = contact_information;
        }

        [JsonIgnore]
        public string CountryString { get => Country.Name; }

        public void AddCoin(Coin coin)
        {
            if (CoinCollection.Find(x => x == coin) == null)
                CoinCollection.Add(coin);
        }
    }
}
