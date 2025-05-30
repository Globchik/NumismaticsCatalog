using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;

namespace NumismaticsCatalog.AppData
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
            IncludeFields = true
        };

        private static readonly string _currentFilePath = "SavedData/save.json";

        private static void LoadSavedData(string file_path)
        {
            string str_data;
            using (StreamReader sr = new(file_path))
            {
                str_data = sr.ReadToEnd();
            }
            Data = JsonSerializer.Deserialize<AppData>(str_data, _jsonOptions) ??
                throw new Exception("Can not serialize");
        }

        public static void LoadSavedData()
        {
            LoadSavedData(_currentFilePath);
        }

        private static void SaveData(string file_path)
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

    }
}
