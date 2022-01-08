using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nechita_Carina_Proiect.Models
{
    public class TipClient
    {
        public int ID { get; set; }
        [Display(Name = "tip client")]
        public string descriere { get; set; }
        public ICollection<Client> Clienti { get; set; }
    }
}
