using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TGym.Models
{
    public class Treino
    {
        public int Id { get; set; }
        [Required]
        public string Categoria { get; set; }
        [Required]
        public string ClassificacaoIntensidade { get; set; }
        public virtual IList<TreinoExercicio> TreinoExercicios { get; set; }
    }
}