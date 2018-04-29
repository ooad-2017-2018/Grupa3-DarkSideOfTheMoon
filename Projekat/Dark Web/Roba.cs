using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_Web
{
    public class Roba
    {
        public enum VrstaRobe { Dijamant, Slika, Antikvitet, Nakit}; 
        VrstaRobe vrsta;
        double cijena;
        string naziv, opis;

        public Roba(VrstaRobe vrsta, double cijena, string naziv, string opis)
        {
            this.vrsta = vrsta;
            this.cijena = cijena;
            this.naziv = naziv;
            this.opis = opis;
        }
        //Image slika; 

    }

}
