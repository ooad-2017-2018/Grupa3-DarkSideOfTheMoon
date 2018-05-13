using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_Web.Model
{
   public  class Detektiv : Osoba
    {
        public Detektiv(string ime, string prezime, string email, string adresa, string brojTelefona, string korisnickoIme, string lozinka): base(ime, prezime, email, adresa, brojTelefona, korisnickoIme, lozinka)
        {

        }
        public void napisiIzvjestaj()
        {
            string izvjestaj = "pokupio iz textboxa";
            Izvjestaj noviIzvjestaj = new Izvjestaj(VrstaIzvjestaja.Hakiranje, izvjestaj); 
            GlobalnaMafija.mafija.DodajIzvjestaj(noviIzvjestaj); 
        }
        public void zahtjevZaHakiranje(Zahtjev zahtjev)
        {
            GlobalnaMafija.mafija.DodajZahtjev(zahtjev);
        }
    }
}
