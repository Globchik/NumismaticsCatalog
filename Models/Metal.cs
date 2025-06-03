using System;

namespace NumismaticsCatalog.Models
{
    /// <summary>
    /// Metal class stores a metal name.
    /// </summary>
    public class Metal
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

        public Metal(string name)
        {
            Name = name;
        }
    }
}
