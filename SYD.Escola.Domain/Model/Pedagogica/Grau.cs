using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Escola.Domain.Model.Pedagogica
{
    public class Grau
    {
        public int GrauId { get; set; }
        public string Nome { get; set; }
        public IList<Curso> Cursos { get; set; }
        public IList<Nivel> Niveis { get; set; }
    }
}