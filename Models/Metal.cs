using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NumismaticsCatalog.Models
{
    /// <summary>
    /// Metal class stores a metal name.
    /// </summary>
    public class Metal
    {
        public string Name { get; set; }

        public Metal(string name)
        {
            Name = name;
        }
    }
}
