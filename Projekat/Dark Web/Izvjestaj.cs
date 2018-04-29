using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_Web
{
    public class Izvjestaj
    {
        public enum VrstaIzvjestaja { Pracenje, Hakiranje, UtjerivanjeDuga, NaplataKarticom, NaplataGotovinom };
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
