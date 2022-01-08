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
    public class DeleteModel : PageModel
    {
        private readonly Nechita_Carina_Proiect.Data.Nechita_Carina_ProiectContext _context;

        public DeleteModel(Nechita_Carina_Proiect.Data.Nechita_Carina_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cont = await _context.Cont.FindAsync(id);

            if (Cont != null)
            {
                _context.Cont.Remove(Cont);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
