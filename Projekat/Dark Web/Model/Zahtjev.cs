using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Dark_Web
{
    public enum VrstaZahtjeva { FalsifikacijaDokumenata, Hakiranje, IznajmljivanjeDetektiva, UtjerivanjeDuga, BrisanjeRobe, UnosINaplataRobe };

    public class Zahtjev
    {
        VrstaZahtjeva vrstaZahtjeva;
        string ostaleInformacije;
        Image slika; 

        public Zahtjev() { }

        public Zahtjev (VrstaZahtjeva vrsta, string ostaleInfo)
        {
            vrstaZahtjeva = vrsta;
            ostaleInformacije = ostaleInfo;
            
        }
        public Zahtjev(VrstaZahtjeva vrsta, string ostaleInfo, Image slikica)
        {
            vrstaZahtjeva = vrsta;
            ostaleInformacije = ostaleInfo;
            slika = slikica; 

        }

        public VrstaZahtjeva VrstaZahtjeva { get => vrstaZahtjeva; set => vrstaZahtjeva = value; }
        public string OstaleInformacije { get => ostaleInformacije; set => ostaleInformacije = value; }
        public Image Slika { get => slika; set => slika = value; }
    }
}
