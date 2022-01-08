using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Nechita_Carina_Proiect.Data;
using Nechita_Carina_Proiect.Models;

namespace Nechita_Carina_Proiect.Pages.Tranzactii
{
    public class IndexModel : PageModel
    {
        private readonly Nechita_Carina_Proiect.Data.Nechita_Carina_ProiectContext _context;

        public IndexModel(Nechita_Carina_Proiect.Data.Nechita_Carina_ProiectContext context)
        {
            _context = context;
        }

        public IList<Tranzactie> Tranzactie { get;set; }

        public async Task OnGetAsync()
        {
            Tranzactie = await _context.Tranzactie
                .Include(t => t.Cont)
                .Include(t => t.TipTranzactie).ToListAsync();
        }
    }
}
