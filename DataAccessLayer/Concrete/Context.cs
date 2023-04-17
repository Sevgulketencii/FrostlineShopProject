using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<AboutMe> AboutDbSet { get; set; }
        public DbSet<Contact> ContactDbSet { get; set; }
        public DbSet<Discount> DiscountDbSet { get; set; }
        public DbSet<Product> ProductDbSet { get; set; }
        public DbSet<Category> CategoryDbSet { get; set; }
        public DbSet<Feature> FeatureDbSet { get; set; }
        public DbSet<User> UserDbSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KCH0A99;database=FrostlineProject;integrated security=true");
        }
    }
}
