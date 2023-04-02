using ExApiRest.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ExApiRest.DataAccess
{
    internal class DbContext<T> : IDbContext<T> where T : IEntity
    {

        IList<T> _data;

        public DbContext() 
        { 
            _data = new List<T>();
        }
        public void Delete(int id)
        {
           var e = _data.Where(u => u.Id.Equals (id)).FirstOrDefault();
           if(e != null)
            {
                _data.Remove(e);
            }
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            return _data;
        }

        public T GetById(int id)
        {
            return (T)_data.Where(e => e.Id.Equals(id)).FirstOrDefault();
        }

        public T Save(T entity)
        {
            if (entity.Id.Equals(0))
            {
                _data.Add(entity);
            }
            else
            {
                
            }
            return entity;
        }
    }
}
