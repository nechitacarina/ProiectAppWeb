using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Nechita_Carina_Proiect.Models
{
    public class Card
    {
        public int ID { get; set; }
        public int PIN { get; set; }
        public int TipCardID { get; set; }
        public TipCard TipCard { get; set; }
        public int ContID { get; set; }
        public Cont Cont { get; set; }
    }
}
