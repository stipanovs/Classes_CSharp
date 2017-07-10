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
        readonly List<Country> _countries; // db.context

        public CountryRepository()
        {
            _countries = new List<Country>();
        }

        public void Create(Country country)
        {
            _countries.Add(country);
        }

        public void Delete(Country country)
        {
            _countries.Remove(country);
        }

        public Country GetById(int id)
        {
            int index = id;
            return _countries[index];
        }

        public IEnumerable<Country> GetAll()
        {
            return _countries;
        }

        public void Update(Country country)
        {
            int index = _countries.IndexOf(country);
            _countries[index] = country;
        }

    }
}
