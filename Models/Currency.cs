﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumismaticsCatalog.Models
{
    public class Currency
    {
        public string Name { get; set; }

        public Currency(string name)
        {
            Name = name;
        }
    }
}
