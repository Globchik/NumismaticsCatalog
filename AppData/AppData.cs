using NumismaticsCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NumismaticsCatalog.AppData
{
    public static class AppData
    {
        public static List<Country> Countries = new();
        public static List<Metal> Metals = new();
        public static List<Currency> Currencies = new();

        public static List<Coin> Coins = new();
        public static List<Collector> Collectors = new();

        public static void Load(List<Country> countries, List<Metal> metals, List<Currency> currencies,
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
