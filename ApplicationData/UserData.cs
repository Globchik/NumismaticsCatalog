using System;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;
using NumismaticsCatalog.Models;

namespace NumismaticsCatalog.ApplicationData
{
    /// <summary>
    /// UserData class encapsulates an AppData object that
    /// is currently used by the application. It also provides 
    /// ways to load this data.
    /// </summary>
    public static class UserData
    {
        public static AppData Data = new();

        private static readonly JsonSerializerOptions _jsonOptions = new()
        {
            ReferenceHandler = ReferenceHandler.Preserve,
            WriteIndented = true,
            IncludeFields = true,
        };

        private static readonly string _currentFilePath = "SavedData/save.json";

        public static void LoadSavedData(string file_path)
        {
            string str_data;
            using (StreamReader sr = new(file_path))
            {
                str_data = sr.ReadToEnd();
            }
            Data = JsonSerializer.Deserialize<AppData>(str_data, _jsonOptions) ??
                throw new Exception("Can not serialize");

            if (Data.Coins.Count == 0 && Data.Currencies.Count == 0 &&
                Data.Metals.Count == 0 && Data.Collectors.Count == 0 &&
                Data.Countries.Count == 0 && Data.Metals.Count == 0 &&
                Data.MyCoins.Count == 0)
                throw new Exception("Empty object");
        }

        public static void LoadSavedData()
        {
            try
            {
                LoadSavedData(_currentFilePath);
            }
            catch (Exception ex)
            {
                if (ex.Message == "Empty object")
                    return;
                else
                    throw;
            }
        }

        public static void SaveData(string file_path)
        {
            string res = JsonSerializer.Serialize(Data, _jsonOptions);
            using (StreamWriter sr = new(file_path))
            {
                sr.Write(res);
            }
        }

        public static void SaveData()
        {
            SaveData(_currentFilePath);
        }

        public static void AddCoinToPersonal(Coin coin)
        {
            if (Data.MyCoins.Find(x => x == coin) == null)
                Data.MyCoins.Add(coin);
        }

        public static void RemoveCountry(Country c)
        {
            Data.Countries.Remove(c);
            foreach (Coin coin in Data.Coins)
                if (coin.Country == c)
                    coin.Country = null;
            foreach (Collector col in Data.Collectors)
                if (col.Country == c)
                    col.Country = null;
        }
        public static void RemoveCurrency(Currency c)
        {
            Data.Currencies.Remove(c);
            foreach (Coin coin in Data.Coins)
                if (coin.CoinCurrency == c)
                    coin.CoinCurrency = null;
        }

        public static void RemoveMetal(Metal m)
        {
            Data.Metals.Remove(m);
            foreach (Coin coin in Data.Coins)
                coin.MetalContent.Remove(m);
        }
    }
}
