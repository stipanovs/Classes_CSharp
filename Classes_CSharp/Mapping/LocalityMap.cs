using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using CargoLogistic.Domain;

namespace Classes_CSharp.Mapping
{
    public class LocalityMap : ClassMap<Locality>
    {
        public LocalityMap()
        {
            Table("Locality");
           
            Id(x => x.Id).GeneratedBy.Identity();
            References(x => x.LocalityPlace).Column("LocalyPlaceId");
            Map(x => x.AddressDetail).Column("AddressDetail");
        }
    }
}
