using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TGym.Models
{
    public class DietaAlimento
    {
        public int DietaId { get; set; }
        public virtual Dieta Dieta { get; set; }
        public int AlimentoId { get; set; }
        public virtual Alimento Alimento { get; set; }
    }
}