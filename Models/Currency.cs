using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NumismaticsCatalog.Models
{
    public class Currency
    {
        /// <summary>
        /// Currency class stores a currency name.
        /// </summary>
        public string Name { get; set; }

        public Currency(string name)
        {
            Name = name;
        }
    }
}
