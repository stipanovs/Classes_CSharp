using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Classes_CSharp;

namespace Classes_CSharp.Repository 
{
    class CountryRepository : IRepository<Country>
    {
        public List<Country> _countries = new List<Country>();

        public void Create(Country entity)
        {
            _countries.Add(entity);
        }

        public void Delete(Country entity)
        {
            _countries.Remove(entity);
        }

        public Country GetById(int id)
        {
            int index = id;
            return _countries[index];
        }

        public void Update(Country entity)
        {
            
        }
    }
}
