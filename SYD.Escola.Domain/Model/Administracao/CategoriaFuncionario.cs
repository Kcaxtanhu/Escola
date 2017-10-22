using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Escola.Domain.Model.Administracao
{
    public class CategoriaFuncionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IList<Funcionario> Funcionarios { get; set; }
    }
}