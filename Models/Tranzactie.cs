using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nechita_Carina_Proiect.Models
{
    public class Tranzactie
    {
        [Display(Name = "numar tranzactie")]
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime data_tranzactie { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal suma { get; set; }
        public int TipTranzactieID { get; set; }
        public TipTranzactie TipTranzactie { get; set; }
        public int ContID { get; set; }
        [Display(Name = "numar cont")]
        public Cont Cont { get; set; }
    }
}
