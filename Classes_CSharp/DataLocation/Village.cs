using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp.DataLocation
{
    public class Village : EntityBase, IUnitLocality
    {
        public string Name  { get; set; }

        public Village(string name)
        {
            Name = name;
        }
    }
}
