using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace NumismaticsCatalog.Models
{
    /// <summary>
    /// Collector class represents a coin collector,
    /// it has information about collector
    /// (name, country, contact information) and
    /// their coin collection.
    /// </summary>
    public class Collector
    {
        private string _name = String.Empty;
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length > 100)
                    throw new ArgumentException("Too long");
                _name = value;
            }
        }
        public Country? Country { get; set; } = null;

        public List<Coin> CoinCollection = new();

        private string _contactInfo = String.Empty;
        public string ContactInformation 
        { 
            get => _contactInfo; 
            set
            {
                if (value.Length > 100)
                    throw new ArgumentException("Too long");

                _contactInfo = value;
            }
        }
       
        public Collector()
        {
            Name = String.Empty;
            Country = null;
            ContactInformation = String.Empty;
        }

        public Collector(string name, Country country, string contact_information = "")
        {
            Name = name;
            Country = country;
            ContactInformation = contact_information;
        }


        [JsonIgnore]
        public string CountryString { get => Country == null ? "" : Country.Name; }

        public void AddCoin(Coin coin)
        {
            if (CoinCollection.Find(x => x == coin) == null)
                CoinCollection.Add(coin);
        }
    }
}
