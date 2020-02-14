using Soru2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Soru2.Controllers
{
    public class HomeController : Controller
    {
        MenuDbContext db = new MenuDbContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            var menu = db.Menus.ToList();
            return View(menu);
        }
    }
}