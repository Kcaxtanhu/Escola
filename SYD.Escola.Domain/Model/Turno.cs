using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Escola.Domain.Model
{
    public class Turno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdadeMaxima { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public IList<Turma> Turmas { get; set; }
    }
}