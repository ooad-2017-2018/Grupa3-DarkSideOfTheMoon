using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Web;

namespace DarkWebAspNetMVCAzure.Models
{
    public enum VrstaZahtjeva { FalsifikacijaDokumenata, Hakiranje, IznajmljivanjeDetektiva, UtjerivanjeDuga, BrisanjeRobe, UnosINaplataRobe };
    [Table("Zahtjev")]
    public class Zahtjev
    {
        
        [Required]
        public VrstaZahtjeva vrstaZahtjeva;
        [Key]
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
            else if (vrstaZahtjeva == VrstaZahtjeva.UnosINaplataRobe)
            {
                izlaz += "Unos i naplata robe";
            }
            return izlaz;
        }
        public Zahtjev() { }

        public Zahtjev(VrstaZahtjeva vrsta, string ostaleInfo)
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


        
    }
}