using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CarBazarWebApp.BusinessLayer;
using CarBazarWebApp.Data;

namespace CarBazarWebApp.Pages.Reviews
{
    public class CreateModel : PageModel
    {
        private readonly CarBazarWebApp.Data.CarBazarDBContext _context;

        public CreateModel(CarBazarWebApp.Data.CarBazarDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ModelID"] = new SelectList(_context.Models, "Id", "ModelName");
            return Page();
        }

        [BindProperty]
        public Review Review { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Reviews.Add(Review);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
