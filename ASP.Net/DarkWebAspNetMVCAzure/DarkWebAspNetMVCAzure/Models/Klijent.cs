using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DarkWebAspNetMVCAzure.Models
{
    [Table("Klijenti") ]
    public class Klijent : Osoba
    {
        [Key]
        [Required]

        public String tajniKod { get; set; }
        [ScaffoldColumn(false) ]
        public double stanjeRacuna { get; set; }

        public Klijent(string ime, string prezime, string email, string adresa, string brojTelefona, string korisnickoIme, string lozinka,string tajniKod,double stanjeRacuna) : base(ime, prezime, email, adresa, brojTelefona, korisnickoIme, lozinka)
        {
            this.tajniKod = tajniKod;
            this.stanjeRacuna = stanjeRacuna;
        }
        public Klijent() { }

        public string ImePrezime { get { return string.Format("{0} {1}", ime, prezime); } }


    }
}