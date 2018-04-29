using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_Web
{
    public class Osoba
    {
        private string ime, prezime, email, adresa, brojTelefona, korisnickoIme, lozinka;

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
