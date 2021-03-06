using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Nechita_Carina_Proiect.Data;
using Nechita_Carina_Proiect.Models;

namespace Nechita_Carina_Proiect.Pages.Conturi
{
    public class DetailsModel : PageModel
    {
        private readonly Nechita_Carina_Proiect.Data.Nechita_Carina_ProiectContext _context;

        public DetailsModel(Nechita_Carina_Proiect.Data.Nechita_Carina_ProiectContext context)
        {
            _context = context;
        }

        public Cont Cont { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cont = await _context.Cont
                .Include(c => c.Client)
                .Include(c => c.TipContBancar).FirstOrDefaultAsync(m => m.ID == id);

            if (Cont == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
