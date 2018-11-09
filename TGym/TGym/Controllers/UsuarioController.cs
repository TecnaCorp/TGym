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
        public int verifLogin(string login, string senha)
        {
            UsuarioDAO uDAO = new UsuarioDAO();
            if (uDAO.testaBD() == false)
            {
                return 2; //mostra que a conexão com o bd ta merda
            }
            else
            {
                try
                {                    
                    Usuario u = uDAO.consultaEmail(login);
                    if (u.Senha == senha)
                        return 1;
                }
                catch { return 0; }
            }
            
            return 0; //login ou senha errada
        }
    }
}