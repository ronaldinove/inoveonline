using System;
using System.Collections.Generic;
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
        public IActionResult Contato()
        {
            return View();
        }
         

        [HttpPost]

        public IActionResult Contato (ItemContato item)
        {
            ContatoRepository cR = new ContatoRepository();
            cR.Inserir(item);
            ViewBag.Mensagem = "Mensagem enviada com sucesso!";
            return RedirectToAction("Contato");
        }
  
        public IActionResult Listagem()
        {
            Autenticacao.CheckLogin(this);
            ContatoRepository cR = new ContatoRepository();
            return View(cR.Listagem());
        }

        public IActionResult Deletar (int idContato)
        {
            ContatoRepository cR = new ContatoRepository();
            cR.Deletar(idContato);
            return RedirectToAction("Listagem");
        }

        public IActionResult Editar (int idContato)
        {
            ContatoRepository cR = new ContatoRepository(); 
            return View(cR.BuscarPorId(idContato));
        }

        [HttpPost]

        public IActionResult Editar (ItemContato c)
        {
            ContatoRepository cR = new ContatoRepository(); 
            cR.Editar(c);
            return RedirectToAction("Listagem");//alterado
        }

        public IActionResult Login (string login, string senha)
        {
            if(login != "admin" || senha != "1234")
            {
                ViewData["Erro"] = "Senha inválida";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("user", "admin");
                return RedirectToAction("Index");
            }

        }
        
    }


}