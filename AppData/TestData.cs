using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumismaticsCatalog.Models;

namespace NumismaticsCatalog.AppData
{
    public static class TestData
    {
        public static void LoadTestData()
        {
            List<Country> countries = new();
            countries.Add(new Country("Україна"));
            countries.Add(new Country("США"));
            countries.Add(new Country("Німеччина"));
            countries.Add(new Country("Англія"));

            List<Currency> currencies = new();
            currencies.Add(new Currency("₴"));
            currencies.Add(new Currency("карбованці"));
            currencies.Add(new Currency("$"));
            currencies.Add(new Currency("€"));
            currencies.Add(new Currency("£"));

            List<Metal> metals = new();
            metals.Add(new Metal("мельхіор"));
            metals.Add(new Metal("мідь"));
            metals.Add(new Metal("нікель"));
            metals.Add(new Metal("нейзильбер"));
            metals.Add(new Metal("алюміній"));
            metals.Add(new Metal("бронза"));

            List<Coin> coins = new();
            List<Metal> metal_contents = new();
            metal_contents.Add(metals.Find(x => x.Name == "мідь"));
            metal_contents.Add(metals.Find(x => x.Name == "нікель"));
            Coin coin = new(1995, countries.Find(x => x.Name == "Україна"), 
                250000, currencies.Find(x => x.Name == "карбованці"), 
                200000, metal_contents, "Ювілейна \"Леся Українка\"");
            coins.Add(coin);

            metal_contents = new();
            metal_contents.Add(metals.Find(x => x.Name == "нейзильбер"));
            coin = new(2013, countries.Find(x => x.Name == "Україна"),
                30000, currencies.Find(x => x.Name == "₴"),
                5, metal_contents, "");
            coins.Add(coin);

            metal_contents = new();
            metal_contents.Add(metals.Find(x => x.Name == "мідь"));
            metal_contents.Add(metals.Find(x => x.Name == "нікель"));
            coin = new(1982, countries.Find(x => x.Name == "США"),
                null, currencies.Find(x => x.Name == "$"),
                0.5f, metal_contents, "");
            coins.Add(coin);


            List<Collector> collectors = new();
            Collector collector = new("Андрій Боровий",
                countries.Find(x => x.Name == "Україна"), "+380961276478");
            collector.AddCoin(coin);
            collector.AddCoin(coins.Find(x => x.Notes == "Ювілейна \"Леся Українка\""));
            collectors.Add(collector);

            collector = new("Сергій Мирош",
                countries.Find(x => x.Name == "Україна"), "+380984673545");
            collector.AddCoin(coins.Find(x => x.YearOfIssue == 2013 && x.CoinValue == 5));
            collectors.Add(collector);



            AppData.Load(countries, metals, currencies, coins, collectors);
        }
    }
}
