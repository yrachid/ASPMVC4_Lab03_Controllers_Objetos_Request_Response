using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {

        public void Agente()
        {
            string agent = Request.Browser.Browser;
            string useragent = Request.UserAgent;
            string source = Request.UserHostAddress;

            Response.Write("<H1>Hello MVC!</H1>"); 
            Response.Write("<h2>Welcome, you are using "); 
            Response.Write(agent); 
            Response.Write(" and your address is "); 
            Response.Write(source); 
            Response.Write("! </h2>"); 
            Response.Write("<h2>User agent: "); 
            Response.Write(useragent + "</h2>");
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
