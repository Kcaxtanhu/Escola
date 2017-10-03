using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Escola.Domain.Model
{
    public class Nivel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int GrauId { get; set; }
        public Grau Grau { get; set; }
        public IList<Classe> Classes { get; set; }        
    }
}