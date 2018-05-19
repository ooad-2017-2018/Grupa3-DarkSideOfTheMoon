using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_Web
{
    public enum VrstaIzvjestaja { Pracenje, Hakiranje, UtjerivanjeDuga, Naplata };

    public class Izvjestaj
    {
        public VrstaIzvjestaja vrstaIzvjestaja;
        public string opisIzvjestaja;

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
                izlaz += "Praćenje";
            }
            else if(vrstaIzvjestaja == VrstaIzvjestaja.Hakiranje)
            {
                izlaz += "Hakiranje";
            }
            else if(vrstaIzvjestaja == VrstaIzvjestaja.UtjerivanjeDuga)
            {
                izlaz += "Utjerivanje duga"; 
            }
           
            else if(vrstaIzvjestaja == VrstaIzvjestaja.Naplata)
            {
                izlaz += "Naplata"; 
            }
  
            return izlaz;
        }

    }
    
}
