using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Escola.Domain.Model.Pedagogica
{
    public class Classe
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int NivelId { get; set; }
        public Nivel Nivel { get; set; }
        public IList<Turma> Turmas { get; set; }
    }   
}