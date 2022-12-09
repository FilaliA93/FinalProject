using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject.Pages_Recipes.Chef
{
    public class CreateModel : PageModel
    {
        private readonly FinalProject.Models.RecipeContext _context;

        public CreateModel(FinalProject.Models.RecipeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Chef Chef { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Chefs.Add(Chef);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}