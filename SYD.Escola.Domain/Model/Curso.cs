using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Escola.Domain.Model
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Nome { get; set; }
        public int GrauId { get; set; }
        public Grau Grau { get; set; }
    }
}