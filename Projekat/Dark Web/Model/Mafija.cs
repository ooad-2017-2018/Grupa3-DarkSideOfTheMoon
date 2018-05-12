using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_Web
{
    public class Mafija
    {
        private List<Osoba> listaUposlenikaMafije;
        private List<Klijent> listaKlijenataMafije;
        private List<Roba> listaRobe;
        private List<Zahtjev> listaZahtjeva;
        private List<Izvjestaj> listaIzvjestaja; 

        public Mafija()
        {
            listaUposlenikaMafije = new List<Osoba>();
            listaKlijenataMafije = new List<Klijent>();
            listaRobe = new List<Roba>();
            listaZahtjeva = new List<Zahtjev>();
            listaIzvjestaja = new List<Izvjestaj>(); 
        }

        public Mafija(List<Osoba> listaUposlenikaMafije, List<Klijent> listaKlijenataMafije, List<Roba> listaRobe, List<Zahtjev> listaZahtjeva, List<Izvjestaj> listaIzvjestaja)
        {
            this.listaUposlenikaMafije = listaUposlenikaMafije;
            this.listaKlijenataMafije = listaKlijenataMafije;
            this.listaRobe = listaRobe;
            this.listaZahtjeva = listaZahtjeva;
            this.listaIzvjestaja = listaIzvjestaja;
        }
        public void DodajUposlenika(Osoba noviUposlenik)
        {
            listaUposlenikaMafije.Add(noviUposlenik); 
        }
        public void DodajKlijenta(Klijent noviKlijent)
        {
            listaKlijenataMafije.Add(noviKlijent); 
        }
        public void DodajRobu(Roba novaRoba)
        {
            listaRobe.Add(novaRoba); 
        }
        public void DodajZahtjev(Zahtjev noviZahtjev)
        {
            listaZahtjeva.Add(noviZahtjev); 
        }
        public void DodajIzvjestaj (Izvjestaj noviIzvjestaj)
        {
            listaIzvjestaja.Add(noviIzvjestaj); 
        }

    }
}
