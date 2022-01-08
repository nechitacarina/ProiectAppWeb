using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Nechita_Carina_Proiect.Data;
using Nechita_Carina_Proiect.Models;

namespace Nechita_Carina_Proiect.Pages.Imprumuturi
{
    public class IndexModel : PageModel
    {
        private readonly Nechita_Carina_Proiect.Data.Nechita_Carina_ProiectContext _context;

        public IndexModel(Nechita_Carina_Proiect.Data.Nechita_Carina_ProiectContext context)
        {
            _context = context;
        }

        public IList<Imprumut> Imprumut { get;set; }

        public async Task OnGetAsync()
        {
            Imprumut = await _context.Imprumut
                .Include(i => i.Cont)
                .Include(i => i.TipImprumut).ToListAsync();
        }
    }
}
