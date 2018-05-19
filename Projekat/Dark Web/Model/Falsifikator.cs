using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_Web.Model
{
    public class Falsifikator : Osoba
    {
        public Falsifikator(string ime, string prezime, string email, string adresa, string brojTelefona, string korisnickoIme, string lozinka): base(ime, prezime, email, adresa, brojTelefona, korisnickoIme, lozinka)
        {

        }
        public void izradiDokument(Zahtjev zahtjev)
        {
            GlobalnaMafija.mafija.listaZahtjevaFalsifikator.Remove(zahtjev); 
        }
    }
}
