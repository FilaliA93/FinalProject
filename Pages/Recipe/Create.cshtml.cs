using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject.Pages_Recipes.Recipe
{
    public class CreateModel : ChefNamePageModel
    {
        private readonly FinalProject.Models.RecipeContext _context;

        public CreateModel(FinalProject.Models.RecipeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Recipe Recipe { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            PopulateChefsDDL(_context);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                PopulateChefsDDL(_context);
                return Page();
            }

            _context.Recipes.Add(Recipe);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}