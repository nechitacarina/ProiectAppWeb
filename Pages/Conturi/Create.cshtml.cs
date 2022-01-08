using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nechita_Carina_Proiect.Data;
using Nechita_Carina_Proiect.Models;

namespace Nechita_Carina_Proiect.Pages.Conturi
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
            ViewData["TipContBancarID"] = new SelectList(_context.Set<TipContBancar>(), "ID", "descriere");
            ViewData["ClientID"] = new SelectList(_context.Set<Client>(), "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Cont Cont { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cont.Add(Cont);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
