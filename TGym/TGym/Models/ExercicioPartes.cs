using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TGym.Models
{
    public class ExercicioPartes
    {
        public int ExercicioId { get; set; }
        public virtual Exercicio Exercicio { get; set; }
        public int ParteId { get; set; }
        public virtual PartesCorpo PartesCorpo { get; set; }
    }
}