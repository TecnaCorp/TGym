using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TGym.Models
{
    public class Alimento
    {
        public string Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string CategoriaRefeicao { get; set; }
        [Required]
        public float ValorCalorico { get; set; }
        public virtual IList<DietaAlimento> DietaAlimento { get; set; }
    }
}