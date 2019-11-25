using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace ETicaret2.Identity
{
    public class ApplicationUser : IdentityUser
    {
        
        public string Name { get; internal set; }
        public string Surname { get; internal set; }


        //    public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AspNetUser> manager)
        //    {
        //        // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType  
        //        var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
        //        // Add custom user claims here  
        //        return userIdentity;
        //    }
        //}

        //public partial class AppDbContext : IdentityDbContext<AspNetUser>
        //{
        //    public AppDbContext()
        //        : base("name=AppDbContext")
        //    {
        //    }

        //    public static AppDbContext Create()
        //    {
        //        return new AppDbContext();
        //    }

        //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //    {
        //        throw new UnintentionalCodeFirstException();
        //    }


        //public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }  
        //public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }  
        //public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }  
        //public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }  
    }

}