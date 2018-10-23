using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TGym.Models;

namespace TGym.DAO
{
    public class UsuarioDAO
    {
        EntidadeContext context;
        public UsuarioDAO()
        {
            context = new EntidadeContext();
        }

        public void Cadastrar(Usuario u)
        {
            context.Usuarios.Add(u);
            context.SaveChanges();
        }
    }
}