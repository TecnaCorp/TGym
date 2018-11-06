using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TGym.DAO;
using TGym.Models;

namespace TGym.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Site()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public void CadastroUsuario(Usuario u, string Nasc)
        {            
            DateTime dataNasc = DateTime.Parse(Nasc);
            u.dataNasc = dataNasc;
            UsuarioDAO uDAO = new UsuarioDAO();
            uDAO.Cadastrar(u);
        }

        public bool verifData(string dia, string mes, string ano)
        {
            try
            {
                DateTime dt = DateTime.Parse(dia + mes + ano);
                if (dt < DateTime.Now)
                    return true;
                else
                    return false;
            }
            catch { return false; }
        }

        public ActionResult Perfil()
        {
            return View();
        }

        public ActionResult Historico()
        {
            return View();
        }

        public ActionResult Dieta()
        {
            return View();
        }

        public ActionResult Treino()
        {
            return View();
        }

        public void CadastraUsuario(Usuario u, string dia, string mes, string ano)
        {
            DateTime dataNasc = DateTime.Parse(dia + mes + ano);
            u.dataNasc = dataNasc;
            UsuarioDAO uDAO = new UsuarioDAO();
            uDAO.Cadastrar(u);
        }
        public bool verifLogin(string login, string senha)
        {
            try
            {
                UsuarioDAO uDAO = new UsuarioDAO();
                Usuario u = uDAO.consultaEmail(login);
                if (u.Senha == senha)
                    return true;
            }
            catch { return false; }
            
            return false;
        }
    }
}