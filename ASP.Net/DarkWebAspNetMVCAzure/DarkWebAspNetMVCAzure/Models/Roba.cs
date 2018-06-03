using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Web;

namespace DarkWebAspNetMVCAzure.Models
{
    public enum VrstaRobe { Dijamant, Slika, Antikvitet, Nakit };
    [Table("Roba")]
    public class Roba
    {
        
        [Required]
        public VrstaRobe vrsta;
        [Required]
        public double cijena;
        [Key]
        
        public string naziv;
        [Required]
        public string opis;
        public Image slika;

        

        public Roba(VrstaRobe vrsta, double cijena, string naziv, string opis)
        {
            this.vrsta = vrsta;
            this.cijena = cijena;
            this.naziv = naziv;
            this.opis = opis;
        }
    }
}