using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_Web.Model
{
    public class Uprava : Osoba, IBazaPodataka, IUprava, IZahtjev
    {
        public Uprava(string ime, string prezime, string email, string adresa, string brojTelefona, string korisnickoIme, string lozinka) : base(ime, prezime, email, adresa, brojTelefona, korisnickoIme, lozinka)
        {

        }
        public void unesiRobu(Roba roba)
        {
            GlobalnaMafija.mafija.DodajRobu(roba);
        }
        public void obrisiRobu(Roba roba)
        {
            GlobalnaMafija.mafija.obrisiRobu(roba);
        }
        public void dodajUposlenika(Osoba noviUposlenik)
        {
            GlobalnaMafija.mafija.DodajUposlenika(noviUposlenik);
        }
        public void AzurirajBazu(Osoba osoba)
        {

        }
        public void odobriZahtjev(Zahtjev zahtjev)
        {

        }
        public void idbaciZahtjev(Zahtjev zahtjev)
        {

        }
        public void podnesiZahtjevZaBrisanje()
        {

        }
        public void podnesiZahtjevZaUtjerivanjeDuga()
        {

        }
        public string ispisiZahtjev(Zahtjev zahtjev)
        {
            return "nista";
        }
    }
}
