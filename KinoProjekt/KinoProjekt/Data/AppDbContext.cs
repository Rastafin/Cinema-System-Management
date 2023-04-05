using Microsoft.EntityFrameworkCore;
using KinoProjekt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProjekt.Data
{
    
    public class AppDbContext : DbContext
    {
        public DbSet<Klient> DbKlient { get; set; }
        public DbSet<Bilet> DbBilet { get; set; }
        public DbSet<Pracownik> DbPracownik { get; set; }
        public DbSet<Opinia> DbOpinia { get; set; }
        public DbSet<Seans> DbSeans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //STRING DO UŻYWANIA PODCZAS MIGRACJI
            //string CustomPath = Directory.GetCurrentDirectory() + "\\..\\Databases\\MainDb.db";

            //STRING DO NORMALNEGO UŻYTKU
            string CustomPath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\..\\Databases\\MainDb.db";

            optionsBuilder.UseSqlite(@"Data Source = "+CustomPath);


        }
        public string TestString()
        {
            return (Directory.GetCurrentDirectory() + "\\..\\Databases\\MainDb.db");
        }
    }
    
}
