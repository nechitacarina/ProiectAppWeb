using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nechita_Carina_Proiect.Models
{
    public class Cont
    {
        [Display(Name = "numar cont")]
        public int ID { get; set; }
        public string numar_cont { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal sold { get; set; }
        [DataType(DataType.Date)]
        public DateTime data_deschiderii { get; set; }
        [Display(Name = "id client")]
        public int ClientID { get; set; }
        [Display(Name = "id client")]
        public Client Client { get; set; }
        [Display(Name = "tip cont")]
        public int TipContBancarID { get; set; }
        [Display(Name = "tip cont")]
        public TipContBancar TipContBancar { get; set; }
        public ICollection<Tranzactie> Tranzactii { get; set; }
        public ICollection<Imprumut> Imprumuturi { get; set; }
        public ICollection<Card> Carduri { get; set; }
    }
}
