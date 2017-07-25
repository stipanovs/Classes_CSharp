﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp;

namespace Classes_CSharp.Repository
{
    public interface IRepository<T> where T: EntityBase
    {
        T GetById(long id);
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
        IEnumerable<T> GetAll();
        //save
        void SaveToFile(T entity, string filename);
    }
}
