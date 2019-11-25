//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using ETicaret2.Models;
//using ETicaret2.Models.Model;

//namespace ETicaret2.Controllers
//{
//    public class AltCategoryController : Controller
//    {
//        private ETicaretDb db = new ETicaretDb();

//        // GET: AltCategory
//        public ActionResult Index()
//        {
//            return View(db.AltCategories.ToList());
//        }
//        public PartialViewResult _AltCategoryList()
//        {
//            var altkategoriler = db.AltCategories.Select(x => new AltCategoryModel()
//            {
//                Id = x.Id,
//                Name = x.Name,
//                Count = x.Products.Count()

//            }
//            ).ToList();

//            return PartialView(altkategoriler);
//        }
//        // GET: AltCategory/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            AltCategory altCategory = db.AltCategories.Find(id);
//            if (altCategory == null)
//            {
//                return HttpNotFound();
//            }
//            return View(altCategory);
//        }

//        // GET: AltCategory/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: AltCategory/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Id,AltCategoryId,Name")] AltCategory altCategory)
//        {
//            if (ModelState.IsValid)
//            {
//                db.AltCategories.Add(altCategory);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(altCategory);
//        }

//        // GET: AltCategory/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            AltCategory altCategory = db.AltCategories.Find(id);
//            if (altCategory == null)
//            {
//                return HttpNotFound();
//            }
//            return View(altCategory);
//        }

//        // POST: AltCategory/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Id,AltCategoryId,Name")] AltCategory altCategory)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(altCategory).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(altCategory);
//        }

//        // GET: AltCategory/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            AltCategory altCategory = db.AltCategories.Find(id);
//            if (altCategory == null)
//            {
//                return HttpNotFound();
//            }
//            return View(altCategory);
//        }

//        // POST: AltCategory/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            AltCategory altCategory = db.AltCategories.Find(id);
//            db.AltCategories.Remove(altCategory);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}
