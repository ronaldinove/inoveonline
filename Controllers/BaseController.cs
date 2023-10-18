using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;

namespace Atv3._1.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if(string.IsNullOrEmpty(HttpContext.Session.GetString("user")))
            {
                filterContext.HttpContext.Response.Redirect("/Contato/Login");
            }
        }
    }
}
