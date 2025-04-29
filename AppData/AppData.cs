using NumismaticsCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NumismaticsCatalog.AppData
{
    public class AppData
    {
        public List<Country> Countries = new();
        public List<Metal> Metals = new();
        public List<Currency> Currencies = new();
        public List<Coin> Coins = new();
        public List<Collector> Collectors = new();

        public void Load(List<Country> countries, List<Metal> metals, List<Currency> currencies,
            List<Coin> coins, List<Collector> collectors)
        {
            Countries = countries;
            Metals = metals;
            Currencies = currencies;
            Coins = coins;
            Collectors = collectors;
        }
    }
}
