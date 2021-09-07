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
    public class IndexModel : PageModel
    {
        private readonly CarBazarWebApp.Data.CarBazarDBContext _context;

        public IndexModel(CarBazarWebApp.Data.CarBazarDBContext context)
        {
            _context = context;
        }

        public IList<Model> Model { get;set; }

        public async Task OnGetAsync()
        {
            Model = await _context.Models
                .Include(m => m.Company).ToListAsync();
        }
    }
}
