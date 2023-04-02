using ExApiRest.Abstractions;
using ExApiRest.Repository;
using System;
using System.Collections.Generic;

namespace ExApiRest.Application
{
    public interface IApplication<T> : ICrud<T>
    {

    }

    public class Application<T> : IApplication<T> where T : IEntity
    {
        IRepository<T> _repository;
        public Application(IRepository<T> repostory ) 
        {
            _repository = repostory;
        }
        public void DeleteById(int id)
        {
            _repository.DeleteById(id);
        }

        public IList<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
           return _repository.GetById(id);
        }

        public T Save(T entity)
        {
            return _repository.Save(entity);
        }
    }
}
