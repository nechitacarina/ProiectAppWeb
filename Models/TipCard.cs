using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nechita_Carina_Proiect.Models
{
    public class TipCard
    {
        public int ID { get; set; }
        public string descriere { get; set; }
        public ICollection<Card> Carduri { get; set; }
    }
}
