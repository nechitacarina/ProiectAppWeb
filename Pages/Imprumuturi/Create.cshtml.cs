using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nechita_Carina_Proiect.Data;
using Nechita_Carina_Proiect.Models;

namespace Nechita_Carina_Proiect.Pages.Imprumuturi
{
    public class CreateModel : PageModel
    {
        private readonly Nechita_Carina_Proiect.Data.Nechita_Carina_ProiectContext _context;

        public CreateModel(Nechita_Carina_Proiect.Data.Nechita_Carina_ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ContID"] = new SelectList(_context.Cont, "ID", "ID");
        ViewData["TipImprumutID"] = new SelectList(_context.Set<TipImprumut>(), "ID", "descriere");
            return Page();
        }

        [BindProperty]
        public Imprumut Imprumut { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Imprumut.Add(Imprumut);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
