using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TGym.Models
{
    public class Historico
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataInserida { get; set; }
        [DisplayFormat(DataFormatString = "00.00")]
        public float Peso { get; set; }
        [DisplayFormat(DataFormatString = "00.00")]
        public float Altura { get; set; }
    }
}