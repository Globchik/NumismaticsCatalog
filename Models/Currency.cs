using System;

namespace NumismaticsCatalog.Models
{
    /// <summary>
    /// Currency class stores a currency name.
    /// </summary>
    public class Currency
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

        public Currency(string name)
        {
            Name = name;
        }
    }
}
