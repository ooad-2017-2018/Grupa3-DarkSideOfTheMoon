using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_Web
{
    public class Zahtjev
    {
        public enum VrstaZahtjeva { FalsifikacijaDokumenata, Hakiranje, IznajmljivanjeDetektiva, UtjerivanjeDuga, BrisanjeRobe, UnosINaplataRobe};
        VrstaZahtjeva vrstaZahtjeva;
        string ostaleInformacije;

        public Zahtjev() { }

        public Zahtjev (VrstaZahtjeva vrsta, string ostaleInfo)
        {
            vrstaZahtjeva = vrsta;
            ostaleInformacije = ostaleInfo; 
        }
    }
}
