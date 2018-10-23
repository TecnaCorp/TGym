using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TGym.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [MinLength(8), Required]
        public string Senha { get; set; }
        [Required, EmailAddress]
        [Remote("ValidarEmailUnico", "HomeLogin", ErrorMessage = "E-mail já cadastrado")]
        public string Email { get; set; }
        [Required, DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime dataNasc { get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
        public string Objetivo { get; set; }
    }
}