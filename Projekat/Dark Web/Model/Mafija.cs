using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_Web
{
    public class Mafija
    {
        public List<Osoba> listaUposlenikaMafije;
        public List<Klijent> listaKlijenataMafije;
        public List<Roba> listaRobe;

        public List<Zahtjev> listaZahtjevaHakiranje;
        public List<Zahtjev> listaZahtjevaPracenje;
        public List<Zahtjev> listaZahtjevaUtjerivanje;
        public List<Zahtjev> listaZahtjevaBrisanje;
        public List<Zahtjev> listaZahtjevaFalsifikator;
        public List<Zahtjev> listaZahtjevaUnosNove;

        public List<Izvjestaj> listaIzvjestajaPracenje;
        public List<Izvjestaj> listaIzvjestajaHakiranje;
        public List<Izvjestaj> listaIzvjestajaUtjerivanjeDuga;
        public List<Izvjestaj> listaIzvjestajaNaplata;

        public Mafija()
        {
            listaUposlenikaMafije = new List<Osoba>();
            listaKlijenataMafije = new List<Klijent>();
            listaRobe = new List<Roba>();
            listaZahtjevaHakiranje = new List<Zahtjev>();
            listaZahtjevaBrisanje = new List<Zahtjev>();
            listaZahtjevaFalsifikator = new List<Zahtjev>();
            listaZahtjevaPracenje = new List<Zahtjev>();
            listaZahtjevaUtjerivanje = new List<Zahtjev>();
            listaZahtjevaUnosNove = new List<Zahtjev>(); 

        listaIzvjestajaHakiranje = new List<Izvjestaj>(); 
            listaIzvjestajaPracenje = new List<Izvjestaj>();
            listaIzvjestajaNaplata = new List<Izvjestaj>();
            listaIzvjestajaUtjerivanjeDuga = new List<Izvjestaj>(); 
        }

        public Mafija(List<Osoba> listaUposlenikaMafije, List<Klijent> listaKlijenataMafije, List<Roba> listaRobe, List<Zahtjev> listaZahtjevaHakiranje, List<Zahtjev> listaZahtjevaPracenje, List<Zahtjev> listaZahtjevaUtjerivanje, List<Zahtjev> listaZahtjevaBrisanje, List<Zahtjev> listaZahtjevaFalsifikator, List<Zahtjev> listaZahtjevaUnosNove, List<Izvjestaj> listaIzvjestajaPracenje, List<Izvjestaj> listaIzvjestajaHakiranje, List<Izvjestaj> listaIzvjestajaUtjerivanjeDuga, List<Izvjestaj> listaIzvjestajaNaplata)
        {
            this.listaUposlenikaMafije = listaUposlenikaMafije;
            this.listaKlijenataMafije = listaKlijenataMafije;
            this.listaRobe = listaRobe;
            this.listaZahtjevaHakiranje = listaZahtjevaHakiranje;
            this.listaZahtjevaPracenje = listaZahtjevaPracenje;
            this.listaZahtjevaUtjerivanje = listaZahtjevaUtjerivanje;
            this.listaZahtjevaBrisanje = listaZahtjevaBrisanje;
            this.listaZahtjevaFalsifikator = listaZahtjevaFalsifikator;
            this.listaZahtjevaUnosNove = listaZahtjevaUnosNove;
            this.listaIzvjestajaPracenje = listaIzvjestajaPracenje;
            this.listaIzvjestajaHakiranje = listaIzvjestajaHakiranje;
            this.listaIzvjestajaUtjerivanjeDuga = listaIzvjestajaUtjerivanjeDuga;
            this.listaIzvjestajaNaplata = listaIzvjestajaNaplata;
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
        public void obrisiRobu(Roba roba)
        {
            foreach (Roba r in listaRobe){
                if (r.Naziv == roba.Naziv)
                    listaRobe.Remove(roba);
            }
        }

    }
}
