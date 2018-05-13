using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_Web.Model
{
    public class Haker : Osoba, IIzvjestaj
    {
        public Haker(string ime, string prezime, string email, string adresa, string brojTelefona, string korisnickoIme, string lozinka): base(ime, prezime, email, adresa, brojTelefona, korisnickoIme, lozinka)
        {

        }
        public void napisiIzvjestaj()
        {

        }
        public string dajIzvjestaj(VrstaIzvjestaja vrsta)
        {
            return "nista"; 
        }
    }
}
