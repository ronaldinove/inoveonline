using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Atv3._1.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace Atv3._1.Controllers
{
    public class ContatoController : Controller
    {

        private readonly ILogger<ContatoController> _logger;

        public ContatoController(ILogger<ContatoController> logger)
        {
            _logger = logger;
        }

        
        public IActionResult Cadastro()
        {
            return View();
        }
         

        [HttpPost]

        public IActionResult Cadastro (Contato c)
        {
            ContatoService cs = new ContatoService();
            cs.Inserir(c);
            ViewBag.Mensagem = "Mensagem enviada com sucesso!";
            return View();
        }
  
        public IActionResult Listagem()
        {
            Autenticacao.CheckLogin(this);
            ContatoService cs = new ContatoService();
            return View(cs.Listar());
        }

        public IActionResult Deletar (int id)
        {
            ContatoService cs = new ContatoService();
            cs.excluirContato(id);
            return RedirectToAction("Listagem");
        }

        public IActionResult Editar (int id)
        {
            ContatoService cs = new ContatoService(); 
            return View(cs.ObterPorId(id));
        }

        [HttpPost]

        public IActionResult Editar (Contato c)
        {
            ContatoService cs = new ContatoService(); 
            cs.Editar(c);
            return RedirectToAction("Listagem");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login (string login, string senha)
        {
            if(login != "admin" || senha != "123")
            {
                ViewData["Erro"] = "Senha inválida";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("user", "admin");
                return RedirectToAction("Listagem");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        

    }


}