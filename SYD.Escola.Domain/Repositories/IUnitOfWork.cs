using System;

namespace SYD.Escola.Domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoriaFuncionarioRepository Categorias { get; set; }
        IFuncionarioRepository Funcionarios { get; set; }

        void Complete();
    }
}