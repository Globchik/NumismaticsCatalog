using NumismaticsCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NumismaticsCatalog.ApplicationData
{
    /// <summary>
    /// AppData represents a combined collection
    /// of all data, that is used by the
    /// application (Collectors, Coins, Countries,
    /// Metals, Currencies)
    /// </summary>
    public class AppData
    {
        public List<Country> Countries = new();
        public List<Metal> Metals = new();
        public List<Currency> Currencies = new();
        public List<Coin> Coins = new();
        public List<Collector> Collectors = new();
        public List<Coin> MyCoins = new();

    }
}
