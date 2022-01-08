using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nechita_Carina_Proiect.Models
{
    public class TipImprumut
    {
        public int ID { get; set; }
        [Display(Name = "tip credit")]
        public string descriere { get; set; }
        public ICollection<Imprumut> Imprumuturi { get; set; }
    }
}
