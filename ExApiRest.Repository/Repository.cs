using ExApiRest.Abstractions;
using System;
using System.Collections.Generic;

namespace ExApiRest.Repository
{
    public interface IRepository<T> : ICrud<T>
    {

    }
    public class Repository<T> : IRepository<T> where T : IEntity
    {
        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T Save(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
