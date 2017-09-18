using System;

namespace SYD.Escola.Infrastructure.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void Complete();
    }
}