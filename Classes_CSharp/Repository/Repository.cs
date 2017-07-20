using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Classes_CSharp.Repository
{
    class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly List<T> _contextList; // DbSet
        public void Create(T entity)
        {
            _contextList.Add(entity);
        }

        public void Delete(T entity)
        {
            _contextList.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _contextList;
        }

        public T GetById(int id)
        {
            return _contextList.FirstOrDefault(x => x.ID == id);
        }

        
        public void SaveToFile(T entity, string filename)
        {
            FileInfo f = new FileInfo(filename);
            using (StreamWriter stream = f.AppendText())
            {
                stream.WriteLine(entity.ToString());
            }
            
            
        }

        public void Update(T entity)
        {
            int index = _contextList.IndexOf(entity);
            _contextList[index] = entity;
        }
    }
}
