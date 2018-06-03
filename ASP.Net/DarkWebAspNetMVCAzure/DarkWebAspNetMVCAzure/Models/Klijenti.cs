namespace DarkWebAspNetMVCAzure.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Klijenti")]
    public partial class Klijenti
    {
        [Key]
        public string tajniKod { get; set; }

        public double stanjeRacuna { get; set; }

        [Required]
        public string ime { get; set; }

        [Required]
        public string prezime { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string adresa { get; set; }

        [Required]
        public string brojTelefona { get; set; }

        [Required]
        public string korisnickoIme { get; set; }

        [Required]
        public string lozinka { get; set; }
    }
}
