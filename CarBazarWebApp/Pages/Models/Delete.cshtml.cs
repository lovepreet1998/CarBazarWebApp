using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarBazarWebApp.BusinessLayer;
using CarBazarWebApp.Data;

namespace CarBazarWebApp.Pages.Models
{
    public class DeleteModel : PageModel
    {
        private readonly CarBazarWebApp.Data.CarBazarDBContext _context;

        public DeleteModel(CarBazarWebApp.Data.CarBazarDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Model Model { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Model = await _context.Models
                .Include(m => m.Company).FirstOrDefaultAsync(m => m.Id == id);

            if (Model == null)
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

            Model = await _context.Models.FindAsync(id);

            if (Model != null)
            {
                _context.Models.Remove(Model);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
