using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DarkWebAspNetMVCAzure.Models
{
    public class Osoba
    {
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
        public Osoba() { }

        public Osoba(string ime, string prezime, string email, string adresa, string brojTelefona, string korisnickoIme, string lozinka)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.adresa = adresa;
            this.brojTelefona = brojTelefona;
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
        }
       

        
    }
}