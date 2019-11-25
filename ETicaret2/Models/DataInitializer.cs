//using System.Data.Entity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using ETicaret2.Models.Model;



//namespace ETicaret2.Models
//{
//    public class DataInitializer : DropCreateDatabaseIfModelChanges<ETicaretDb>
//    {
//        protected override void Seed(ETicaretDb context)
//        {
//            var kategoriler = new List<Category>()
//            {
//                new Category() { Name = "ELBİSE", Description = "Elbise Üürünleri" },
//                new Category() { Name = "JEAN", Description = "Jean Ürünleri" },
//                new Category() { Name = "SPOR ÜRÜNLERİ", Description = "Spor Ürünleri" },
//                new Category() { Name = "GÖMLEK", Description = "Gömlek Üürünleri" },
//                new Category() { Name = "AKSESUAR", Description = "Aksesuar Ürünleri" },
//                new Category() { Name = "AYAKKABI", Description = "Ayakkabı Ürünleri" },
//            };
//            foreach (var item in kategoriler)
//            {
//                context.Categories.Add(item);
//            }
//            context.SaveChanges();

//            var urunler = new List<Product>()
//            {
//                new Product () {Name = "Mavi", Description = "Mavi", Price = 250, Stock = 50, IsHome = true, CategoryId = 1, Image = "1.png", IsApproved = true, IsFeatured = false },
//                new Product () {Name = "Mavi", Description = "Elbise Markalı Elbise Ürünü Renk", Price = 250, Stock = 50, IsHome = true, CategoryId = 2, Image = "2.png", IsApproved = true, IsFeatured = true},
//            };
//            foreach (var item in urunler)
//            {
//                context.Products.Add(item);
//            }
//            context.SaveChanges();
//            base.Seed(context);
//        }
//    }
//}