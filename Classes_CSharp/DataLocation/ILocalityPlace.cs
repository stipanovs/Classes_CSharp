using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp.DataLocation
{
    public interface ILocalityPlace
    {
        Country Country { get; set; }
        string Name { get; set; }
    }
}
