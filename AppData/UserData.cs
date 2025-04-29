using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;

namespace NumismaticsCatalog.AppData
{
    public static class UserData
    {
        public static readonly string SAVE_LOCATION = "SavedData/save.json";
        public static AppData Data = new();
        public static readonly JsonSerializerOptions json_options = new() 
        {
            ReferenceHandler = ReferenceHandler.Preserve,
            WriteIndented = true,
            IncludeFields = true
        };

        public static void LoadSavedData()
        {
            string str_data;
            using (StreamReader sr = new(SAVE_LOCATION))
            {
                str_data = sr.ReadToEnd();
            }
            Data = JsonSerializer.Deserialize<AppData>(str_data, json_options)?? 
                throw new Exception("Can not serialize");
        }

        public static void SaveData()
        {
            string res = JsonSerializer.Serialize(Data, json_options);
            using (StreamWriter sr = new(SAVE_LOCATION))
            {
                sr.Write(res);
            }
        }

    }
}
