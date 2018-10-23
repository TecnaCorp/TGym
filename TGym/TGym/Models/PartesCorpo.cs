using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TGym.Models
{
    public class PartesCorpo
    {
        public int Id { get; set; }
        [Required]
        public int Nome { get; set; }
        public IList<ExercicioPartes> Exercicios { get; set; }
    }
}