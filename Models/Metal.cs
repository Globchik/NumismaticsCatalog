using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumismaticsCatalog.Models
{
    public class Metal
    {
        public string Name { get; set; }

        public Metal(string name)
        {
            Name = name;
        }
    }
}
