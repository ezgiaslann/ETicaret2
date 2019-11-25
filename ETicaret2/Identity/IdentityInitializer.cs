using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using ETicaret2.Models.Model;

namespace ETicaret2.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {


        protected override void Seed(IdentityDataContext context)
        {


            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "admin", Description = "admin rolü" };
                manager.Create(role);
            }
            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Description = "user rolü" };
                manager.Create(role);
            }
            if (!context.Users.Any(i => i.Name == "ezgiaslan"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "ezgi", Surname = "aslan", Email = "ezgiasl08@gmail.com", UserName = "ezgiaslan" };
                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");

            }
            if (!context.Users.Any(i => i.Name == "busraayverdi"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "busra", Surname = "ayverdi", Email = "busraayverdi.95@gmail.com", UserName = "busraayverdi" };
                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "user");

            }
            if (!context.Users.Any(i => i.Name == "hasanaslan"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "hasan", Surname = "aslan", Email = "hasanaslan@gmail.com", UserName = "hasanaslan" };
                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "user");

            }
        }

    }
}