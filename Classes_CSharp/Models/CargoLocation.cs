﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp.Models
{
    class CargoLocation<T> where T: class
    {
        public Country CountryFrom { get; private set; }

    }
}
