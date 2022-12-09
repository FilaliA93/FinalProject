using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinalProject.Pages_Recipes.Recipe
{
    public class ChefNamePageModel : PageModel
    {
        public SelectList ChefNameList { get; set; }

        public void  PopulateChefsDDL(FinalProject.Models.RecipeContext context)
        {
            var chefs = context.Chefs.ToList();

            ChefNameList = new SelectList(chefs, nameof(Models.Chef.ChefId), nameof(Models.Chef.ChefName));
        }
    }
}