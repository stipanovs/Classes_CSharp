using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp.Repository
{
    class LocationRepository : IRepository<Location>
    {
        private readonly List<Location> _locations;

        public LocationRepository()
        {
            _locations = new List<Location>();
        }
        public void Create(Location loc)
        {
            _locations.Add(loc);
        }

        public void Delete(Location loc)
        {
            _locations.Remove(loc);
        }

        public IEnumerable<Location> GetAll()
        {
            return _locations;
        }

        public Location GetById(int id)
        {
            return _locations[id];
        }

        public void Update(Location loc)
        {
            int index = _locations.IndexOf(loc);
            _locations[index] = loc;
        }
    }
}
