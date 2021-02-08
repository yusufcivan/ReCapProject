using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarDatabaseContext:DbContext
    {
        //Context : Db tabloları ile proje classlarını bağlamak
        //EntityFramework ile gelen DbContext ekliyoruz

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //@"Server=175.45.2.12" gerçek projede ip olur
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CarDatabase;Trusted_Connection=true");
        }
        //Benim Car nesnemi veritabanındaki Cars ile bağla demek
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }

    }
}
