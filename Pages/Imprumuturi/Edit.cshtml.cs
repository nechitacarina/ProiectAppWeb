using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nechita_Carina_Proiect.Data;
using Nechita_Carina_Proiect.Models;

namespace Nechita_Carina_Proiect.Pages.Imprumuturi
{
    public class EditModel : PageModel
    {
        private readonly Nechita_Carina_Proiect.Data.Nechita_Carina_ProiectContext _context;

        public EditModel(Nechita_Carina_Proiect.Data.Nechita_Carina_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Imprumut Imprumut { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Imprumut = await _context.Imprumut
                .Include(i => i.Cont)
                .Include(i => i.TipImprumut).FirstOrDefaultAsync(m => m.ID == id);

            if (Imprumut == null)
            {
                return NotFound();
            }
           ViewData["ContID"] = new SelectList(_context.Cont, "ID", "ID");
           ViewData["TipImprumutID"] = new SelectList(_context.Set<TipImprumut>(), "ID", "descriere");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Imprumut).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImprumutExists(Imprumut.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ImprumutExists(int id)
        {
            return _context.Imprumut.Any(e => e.ID == id);
        }
    }
}
