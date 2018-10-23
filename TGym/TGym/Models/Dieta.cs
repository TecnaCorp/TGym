using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TGym.Models
{
    public class Dieta
    {
        public int Id { get; set; }
        [Required]
        public string NomeRefeicao { get; set; }
        public int RefeicaoOp { get; set; }
        [Required]
        public float ValorCaloria { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual IList<DietaAlimento> DietaAlimento { get; set; }
    }
}