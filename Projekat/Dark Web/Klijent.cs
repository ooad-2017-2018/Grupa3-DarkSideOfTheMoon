using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_Web
{
    public class Klijent :  Osoba
    {
        public enum VrstaZahtjeva { FalsifikacijaDokumenata, Hakiranje, IznajmljivanjeDetektiva, UtjerivanjeDuga, BrisanjeRobe, UnosINaplataRobe };

        string tajniKod;
        double stanjeRacuna;

        public Klijent(string ime, string prezime, string email, string adresa, string brojTelefona, string korisnickoIme, string lozinka,string tajniKod, double stanjeRacuna) :base(ime, prezime, email, adresa, brojTelefona, korisnickoIme, lozinka)
        {
            this.tajniKod = tajniKod;
            this.stanjeRacuna = stanjeRacuna;
        }
        public void ZahtjevZaLazneDokumente(string ime, DateTime datumRodjenja, string mjestoRodjenja, string drzavljanstvo, string prebivaliste, bool spol, int vrstaDokumenta  /*Image slika*/)
        {
            Zahtjev noviZahtjev = new Zahtjev(); 
        }   
        public void ZahtjevZaPrivatnogDetektiva(string ime, string prezime, string adresaStanovanja, string srodstvo, bool zaposlen, string nazivZaposlen, string adresaZaposlen, bool uUdruzenju,  string nazivUdruzenje, string adresaUdruzenje, string ostaleInformacije)
        {
            Zahtjev noviZahtjev = new Zahtjev(); 
        }
    }
}
