using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_Web
{
    public enum VrstaIzvjestaja { Pracenje, Hakiranje, UtjerivanjeDuga, NaplataKarticom, NaplataGotovinom };

    public class Izvjestaj
    {
        VrstaIzvjestaja vrstaIzvjestaja;
        string opisIzvjestaja;

        public Izvjestaj() { }

        public Izvjestaj(VrstaIzvjestaja vrsta, string ostaleInfo)
        {
            vrstaIzvjestaja = vrsta; 
            opisIzvjestaja = ostaleInfo; 
        }
    }
    
}
