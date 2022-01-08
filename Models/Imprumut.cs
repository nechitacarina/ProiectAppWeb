using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nechita_Carina_Proiect.Models
{
    public class Imprumut
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime data_inceput { get; set; }
        [DataType(DataType.Date)]
        public DateTime data_final { get; set; }
        public int durata { get; set; }
        public double suma_imprumutata { get; set; }
        public double suma_datorata { get; set; }
        public int ContID { get; set; }
        [Display(Name = "numar cont")]
        public Cont Cont { get; set; }        
        [Display(Name = "tip credit")]
        public int TipImprumutID { get; set; }
        [Display(Name = "tip credit")]
        public TipImprumut TipImprumut { get; set; }
    }
}
