using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Dark_Web
{
    public enum VrstaRobe { Dijamant, Slika, Antikvitet, Nakit };

    public class Roba
    {
        VrstaRobe vrsta;
        double cijena;
        string naziv, opis;
        Image slika;

        public VrstaRobe Vrsta { get => vrsta; set => vrsta = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Opis { get => opis; set => opis = value; }
        public Image Slika { get => slika; set => slika = value; }

        public Roba(VrstaRobe vrsta, double cijena, string naziv, string opis)
        {
            this.vrsta = vrsta;
            this.cijena = cijena;
            this.naziv = naziv;
            this.opis = opis;
        }
       

    }

}
