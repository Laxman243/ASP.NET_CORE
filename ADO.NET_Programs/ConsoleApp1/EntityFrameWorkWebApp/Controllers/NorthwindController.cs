using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFrameWorkWebApp.Models;

namespace EntityFrameWorkWebApp.Controllers
{
    public class NorthwindController : Controller
    {
        NorthWindContext db = new NorthWindContext();
        public ActionResult Index()
        {
            // return the tables 
            db.CategoriesTable.ToList();
            db.ProductsTable.ToList();
            return View();
        }
    }
}