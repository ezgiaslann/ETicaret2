using ETicaret2.Models;
using ETicaret2.Models.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI;

namespace ETicaret2.Controllers
{
    public class HomeController : Controller
    {
        ETicaretDb db = new ETicaretDb();


        // GET: Home
        public ActionResult Index()
        {
            var urun = db.Products.Where(i => i.IsHome && i.IsApproved).Select(i => new ProductModel()
            {
                Id = i.Id,
                Name = i.Name,
                Description = i.Description.Length > 25 ? i.Description.Substring(0, 20) + "..." : i.Description,
                Price = i.Price,
                Stock = i.Stock,
                Image = i.Image,

                CategoryId = i.CategoryId
            }
            ).ToList();
            return View(urun);
        }
        public PartialViewResult _Slider()
        {
            return PartialView(db.Products.Where(x => x.Slider && x.IsApproved).ToList());
        }
        public ActionResult ProductList(int id)
        {
            return View(db.Products.Where(i => i.CategoryId == id).ToList());
        }
        public PartialViewResult FeaturedProductList()
        {
            return PartialView(db.Products.Where(x => x.IsFeatured && x.IsApproved).ToList());
        }
        //public ActionResult _Slider(int id)
        // {
        // return View(db.Products.Where(x => x.Slider && x.IsApproved).ToList());
        //}
        public ActionResult ProductDetails(int id)
        {
            return View(db.Products.Where(i => i.Id == id).FirstOrDefault());
        }

        public ActionResult Search(string q)
        {

            var p = db.Products.Where(i => i.IsApproved == true);
            if (!string.IsNullOrEmpty(q))
            {
                 p = p.Where(i => i.Name.Contains(q) || i.Description.Contains(q));
                

            }
            return View(p.ToList());
            //if(string.IsNullOrEmpty(q))
            //{
                
            //}
            
            //else
            //{
            //    Response.Redirect("Search");
            //}

          }   
        public ActionResult SearchHata(string q)
        {
            var p = db.Products.Where(i => i.IsApproved == true);
            if (string.IsNullOrEmpty(q))
            {

                Response.Redirect("SearchHata.cshtml");

            }
            return View(p.ToList());

        }

          


       
        
            //[HttpPost]
            //public ActionResult Checkout(string q)
            //{
            //    if (string.IsNullOrEmpty(q))
            //    {
            //        ModelState.AddModelError("UrunYokError", "Sepetinizde ürün bulunmamaktadır..");
            //    }
            //    return View();

            //}


            //else
            //{

            //ModelState.AddModelError("RegisterUserError", "Kullanıcı oluşturma hatası..");
            //return Json(new { Status = false, Msg = "Ürün bulunamadı" }, JsonRequestBehavior.AllowGet);
            //}


            public ActionResult Product()
        {
            var urun = db.Products.Where(i => i.IsApproved).Select(i => new ProductModel()
            {
                Id = i.Id,
                Name = i.Name,
                Description = i.Description.Length > 25 ? i.Description.Substring(0, 20) + "..." : i.Description,
                Price = i.Price,
                Stock = i.Stock,
                Image = i.Image,
                CategoryId = i.CategoryId
            }
          ).ToList();
            return View(urun);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //public ActionResult Login()
        //{
        //    return View();
        //}


        //[HttpPost]
        //public ActionResult Login(Login model)
        //{
        //    RegisterRepository registerRepository = new RegisterRepository();
        //    var register = registerRepository.FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password);
        //    if (register != null)
        //    {
        //        public ActionResult Liste()
        //        {
        //            var routeValues = new RouteAreaAttribute ValueDictionary(); 
        //            return RedirectToAction("Main", new RouteValueDictionary());
        //            new { controller = "Views/Home", action = "Main", Id = Id };
        //        }
        //        //ReDirectToaction
        //    }
        //    else
        //    {

        //    }

        //    return View(model);
        //}
    }
}