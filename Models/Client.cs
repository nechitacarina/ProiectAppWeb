using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nechita_Carina_Proiect.Models

{
    public class Client
    {
        public int ID { get; set; }
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "CNP Incorect!"), Required, StringLength(13, MinimumLength = 13)]
        public string CNP { get; set; }
        [RegularExpression(@"^[A-Z][a-z]+$", ErrorMessage = "Numele nu poate contine alte caractere decat litere!"), Required, StringLength(50, MinimumLength = 3)]
        public string nume { get; set; }
        [RegularExpression(@"^[A-Z][a-z]+$", ErrorMessage = "Prenumele nu poate contine alte caractere decat litere!"), Required, StringLength(50, MinimumLength = 3)]
        public string prenume { get; set; }
        [DataType(DataType.Date)]
        public DateTime data_nasterii { get; set; }
        public string ocupatie { get; set; }
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Numarul de telefon trebueie sa fie format doar din cifre!"), Required]
        public string telefon { get; set; }
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email incorect!"), Required]
        public string email { get; set; }
        [DataType(DataType.Date)]
        public DateTime data_inscrierii { get; set; }
        public int TipClientID { get; set; }
        public TipClient TipClient { get; set; }
        public ICollection<Cont> Conturi { get; set; }
    }
}
