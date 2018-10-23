using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TGym.Models
{
    public class TreinoExercicio
    {
        public int TreinoId { get; set; }
        public virtual Treino Treino { get; set; }
        public int ExercicioId { get; set; }
        public virtual Exercicio Exercicios { get; set; }
    }
}