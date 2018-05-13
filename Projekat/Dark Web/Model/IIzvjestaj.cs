using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_Web.Model
{
    public interface IIzvjestaj
    {
        void napisiIzvjestaj(); 
        string dajIzvjestaj(VrstaIzvjestaja vrsta); 
    }
}
