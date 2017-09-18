using System;

namespace SYD.Escola.Infrastructure.Data
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Remove(T entity);
        T GetById(int id);
    }
}