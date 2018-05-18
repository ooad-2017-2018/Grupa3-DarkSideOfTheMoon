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
        public override string ToString()
        {
            string izlaz = ""; 
            if(vrstaIzvjestaja == VrstaIzvjestaja.Pracenje)
            {
                izlaz += "Praćenje: ";
            }
            else if(vrstaIzvjestaja == VrstaIzvjestaja.Hakiranje)
            {
                izlaz += "Hakiranje: ";
            }
            else if(vrstaIzvjestaja == VrstaIzvjestaja.UtjerivanjeDuga)
            {
                izlaz += "Utjerivanje duga: "; 
            }
            else if(vrstaIzvjestaja == VrstaIzvjestaja.NaplataGotovinom)
            {
                izlaz += "Naplata gotovinom: "; 
            }
            else if(vrstaIzvjestaja == VrstaIzvjestaja.NaplataKarticom)
            {
                izlaz += "Naplata karticom: "; 
            }
            izlaz += opisIzvjestaja; 
            return izlaz;
        }

    }
    
}
