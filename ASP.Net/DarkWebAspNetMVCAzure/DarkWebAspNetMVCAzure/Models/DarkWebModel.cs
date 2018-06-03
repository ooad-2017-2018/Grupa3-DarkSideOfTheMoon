namespace DarkWebAspNetMVCAzure.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DarkWebModel : DbContext
    {
        public DarkWebModel()
            : base("name=OOADModel")
        {
        }

        public virtual DbSet<Klijenti> Klijenti { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
