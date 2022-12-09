using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Pages_Recipes.Chef
{
    public class IndexModel : PageModel
    {
        private readonly FinalProject.Models.RecipeContext _context;

        public IndexModel(FinalProject.Models.RecipeContext context)
        {
            _context = context;
        }

        public IList<Models.Chef> Chefs { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Recipes != null)
            {
                Chefs = await _context.Chefs.Include(x => x.Recipes).ToListAsync();
            }
        }
    }
}