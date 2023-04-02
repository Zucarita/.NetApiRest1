using System;
using System.Collections;
using System.Collections.Generic;

namespace ExApiRest.Abstractions
{
    public interface ICrud<T>
    {
        T Save(T entity);
        IList<T> GetAll();
        T GetById(int id);
        void DeleteById(int id);

    }
}
