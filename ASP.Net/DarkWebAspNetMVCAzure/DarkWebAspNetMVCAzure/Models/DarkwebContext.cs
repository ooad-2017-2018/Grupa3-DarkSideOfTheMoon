using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace DarkWebAspNetMVCAzure.Models
{
    public class DarkwebContext : DbContext
    {
        public DarkwebContext () :base("AzureConnection") //AzureConnection je naziv connection stringa u Web.config-u
        {
        }
        //dodavanjem klasa iz modela kao DbSet iste će biti mapirane u bazu podataka
        public DbSet<Klijent> Klijent { get; set; }
        public DbSet<Roba> Roba { get; set; }
        public DbSet<Zahtjev> Zahtjev { get; set; }

        //Ova funkcija se koriste da bi se ukinulo automatsko dodavanje množine u nazive
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}