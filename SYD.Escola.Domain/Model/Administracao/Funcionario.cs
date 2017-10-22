using System;

namespace SYD.Escola.Domain.Model.Administracao
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataIngresso { get; set; }
        public int CategoriaId { get; set; }
        public CategoriaFuncionario Categoria { get; set; }
        
    }
}