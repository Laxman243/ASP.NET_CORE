using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        //GET  /home/index
        // [ActionName("home")] // action selector , is useful when u call a action method with different names
        [OutputCache(Duration = 10)]
        //  [Authorize] // This attribute will restrict unauthorized user access.The application redirects to the login page for authentication.
        public ActionResult Index()
        {
            return View();
        }
        // mapping url also called routing
        // GET /home/about
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        // GET
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public string Welcome()
        {
            return "Hello, welcome to my Store again";
        }
        public string ShowMusic(string MusicTitle)
        {
            return "You selected " + MusicTitle + " Music";
        }
    }
}