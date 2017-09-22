using System;

namespace SYD.Escola.Domain.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Remove(T entity);
        T GetById(int id);
    }
}