using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_Web.Model
{
    public interface IUprava
    {
        void odobriZahtjev(Zahtjev zahtjev);
        void idbaciZahtjev(Zahtjev zahtjev);
        void podnesiZahtjevZaBrisanje();
        void podnesiZahtjevZaUtjerivanjeDuga(); 
    }
}
