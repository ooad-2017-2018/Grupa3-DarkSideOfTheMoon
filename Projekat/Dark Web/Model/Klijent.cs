using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Dark_Web.Model;
namespace Dark_Web
{
    public class Klijent :  Osoba, IZahtjev
    {
        string tajniKod;
        double stanjeRacuna;

        public Klijent(string ime, string prezime, string email, string adresa, string brojTelefona, string korisnickoIme, string lozinka,string tajniKod, double stanjeRacuna) :base(ime, prezime, email, adresa, brojTelefona, korisnickoIme, lozinka)
        {
            this.tajniKod = tajniKod;
            this.stanjeRacuna = stanjeRacuna;
        }
        public void ZahtjevZaLazneDokumente(string ime, string prezime, DateTime datumRodjenja, string mjestoRodjenja, string drzavljanstvo, string prebivaliste, bool spol, int vrstaDokumenta, Image slika)
        {
            string ostaleinfo = ime + " " + prezime + " " + datumRodjenja.ToString() + " " + mjestoRodjenja + " " + drzavljanstvo + " " + prebivaliste;
            if (spol == true) ostaleinfo += " Musko";
            else ostaleinfo += " Zensko";
            Zahtjev noviZahtjev = new Zahtjev(VrstaZahtjeva.FalsifikacijaDokumenata, ostaleinfo, slika);
            GlobalnaMafija.mafija.listaZahtjevaFalsifikator.Add(noviZahtjev); 
        }   
        public void ZahtjevZaPrivatnogDetektiva(string ime, string prezime, string adresaStanovanja, string srodstvo, bool zaposlen, string nazivZaposlen, string adresaZaposlen, bool uUdruzenju,  string nazivUdruzenje, string adresaUdruzenje, string ostaleInformacije, Image slika)
        {
            string ostaleinfo = ime + " " + prezime + " " + adresaStanovanja + " " + srodstvo + " " ;
            if (zaposlen)
            
                ostaleinfo += nazivZaposlen + " " + adresaZaposlen +" ";
            if (uUdruzenju)
                ostaleinfo += nazivUdruzenje + " " + adresaUdruzenje+ " ";
            ostaleinfo += ostaleInformacije; 
            Zahtjev noviZahtjev = new Zahtjev(VrstaZahtjeva.IznajmljivanjeDetektiva, ostaleinfo, slika);
            GlobalnaMafija.mafija.listaZahtjevaPracenje.Add(noviZahtjev); 
        }
        public string ispisiZahtjev(Zahtjev zahtjev)
        {
            return "nista";
        }
    }
}
