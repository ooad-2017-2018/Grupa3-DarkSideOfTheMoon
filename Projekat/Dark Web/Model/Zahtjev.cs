
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
        public VrstaZahtjeva vrstaZahtjeva;
        public string ostaleInformacije;
        public Image slika;

        public string ispisiInfo()
        {
            return ostaleInformacije;
        }
        public override string ToString()
        {
            string izlaz = "";
            if (vrstaZahtjeva == VrstaZahtjeva.FalsifikacijaDokumenata)
            {
                izlaz += "Falsificiranje dokumenata";
            }
            else if (vrstaZahtjeva == VrstaZahtjeva.Hakiranje)
            {
                izlaz += "Hakiranje";
            }
            else if (vrstaZahtjeva == VrstaZahtjeva.IznajmljivanjeDetektiva)
            {
                izlaz += "Iznajmljivanje detektiva";
            }
            else if (vrstaZahtjeva == VrstaZahtjeva.UtjerivanjeDuga)
            {
                izlaz += "Utjerivanje duga";
            }
            else if (vrstaZahtjeva == VrstaZahtjeva.BrisanjeRobe)
            {
                izlaz += "Brisanje robe";
            }
            else if(vrstaZahtjeva == VrstaZahtjeva.UnosINaplataRobe)
            {
                izlaz += "Unos i naplata robe"; 
            }
            return izlaz;
        }
        public Zahtjev() { }

        public Zahtjev (VrstaZahtjeva vrsta, string ostaleInfo)
        {
            VrstaZahtjeva1 = vrsta;
            OstaleInformacije1 = ostaleInfo;
            
        }
        public Zahtjev(VrstaZahtjeva vrsta, string ostaleInfo, Image slikica)
        {
            VrstaZahtjeva1 = vrsta;
            OstaleInformacije1 = ostaleInfo;
            Slika1 = slikica; 

        }
       

        public VrstaZahtjeva VrstaZahtjeva { get => VrstaZahtjeva1; set => VrstaZahtjeva1 = value; }
        public string OstaleInformacije { get => OstaleInformacije1; set => OstaleInformacije1 = value; }
        public Image Slika { get => Slika1; set => Slika1 = value; }
        public VrstaZahtjeva VrstaZahtjeva1 { get => vrstaZahtjeva; set => vrstaZahtjeva = value; }
        public string OstaleInformacije1 { get => ostaleInformacije; set => ostaleInformacije = value; }
        public Image Slika1 { get => slika; set => slika = value; }
    }
}
