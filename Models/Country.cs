using System;

namespace NumismaticsCatalog.Models
{
    /// <summary>
    /// Country class stores a country name.
    /// </summary>
    public class Country
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

        public Country(string name)
        {
            Name = name;
        }
    }
}
