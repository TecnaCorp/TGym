using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TGym.Models
{
    public class Exercicio
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string Categoria { get; set; }
        [Required]
        public string ClassificacaoIntensidade { get; set; }
        public int PartesCorpoId { get; set; }
        public virtual IList<ExercicioPartes> PartesCorpos { get; set; }
        public virtual IList<TreinoExercicio> TreinoExercicios { get; set; }
    }
}