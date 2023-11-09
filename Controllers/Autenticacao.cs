using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Atv3._1.Models;
using System.Linq;
using System.Collections.Generic;


namespace Atv3._1.Controllers
{
    public class Autenticacao
    {
        public static void CheckLogin(Controller controller)
        {   
            if(string.IsNullOrEmpty(controller.HttpContext.Session.GetString("user"))) //
            {
                controller.Request.HttpContext.Response.Redirect("/Contato/Login");
            }
        }
    }
}