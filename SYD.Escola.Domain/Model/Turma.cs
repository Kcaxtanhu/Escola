using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Escola.Domain.Model
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int TurnoId { get; set; }
        public Turno Turno { get; set; }
        public int ClasseId { get; set; }
        public Classe Classe { get; set; }
        public EstadoTurma Estado { get; set; }

        public enum EstadoTurma
        {
            ACTIVA = 1,
            INACTIVA = 2
        }
    }
}