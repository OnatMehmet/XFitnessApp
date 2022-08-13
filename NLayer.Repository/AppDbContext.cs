using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using NLayer.Repository.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           // var  m = new Members() { MemberDetails = new MemberDetails() };
           
        }

        public DbSet<Members> Members { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<MemberDetails> MemberDetails { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //bütün Configurationları bulur veuygular

            modelBuilder.ApplyConfiguration(new CategoryConfiguration());//Buda sadece uygulanmak istenen Configuration uygulanıyor


            modelBuilder.Entity<Category>().HasKey(x => x.Id);
            base.OnModelCreating(modelBuilder); 
        }
    }
}
