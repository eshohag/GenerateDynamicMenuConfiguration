using DynamicMenuMVC.Models;
using DynamicMenuMVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicMenuMVC.Controllers
{
    public class NavbarController : Controller
    {
        private readonly ApplicationDbContext db;
        public NavbarController()
        {
            db = new ApplicationDbContext();
        }
        // GET: Navbar
        //[OutputCache(Duration = 60)]
        public ActionResult Navbar()
        {
            var items = db.MenuConfigs.ToList();
            return PartialView("_Navbar", items);
        }
    }
}