using ETicaret2.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Ticaret.Controllers
{
    public class AdminController : Controller
    {
        ETicaretDb db = new ETicaretDb();
        // GET: Admin
        public ActionResult Index()
        {
            var sorgu = db.Categories.ToList();
            return View(sorgu);
        }
    }
}