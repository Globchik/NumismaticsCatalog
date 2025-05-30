using System;

namespace NumismaticsCatalog.Models
{
    /// <summary>
    /// Country class stores a country name.
    /// </summary>
    public class Country
    {
        public string Name { get; set; }

        public Country(string name)
        {
            Name = name;
        }
    }
}
