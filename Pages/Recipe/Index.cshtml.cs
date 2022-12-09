using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Pages_Recipes.Recipe
{
    public class IndexModel : PageModel
    {
        private readonly FinalProject.Models.RecipeContext _context;

        private readonly int defaultPageSize = 10;

        public IndexModel(FinalProject.Models.RecipeContext context)
        {
            _context = context;
        }

        public string CurrentSearch { get; set; }
        public int PageIndex { get; set; }
        public string NameSort { get; set; }


        public int TotalPages { get; set; }

        public IList<Models.Recipe> Recipes { get; set; } = default!;


        public async Task OnGetAsync(string sortOrder, string search, int pageIndex)
        {
            NameSort = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            CurrentSearch = search;
            pageIndex = pageIndex == 0 ? 1 : pageIndex;
            PageIndex = pageIndex;

            var recipesQuery = _context.Recipes.Include(x => x.Chef).AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                recipesQuery = recipesQuery.Where(x => x.RecipeName.ToLower().Contains(search.ToLower()));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    recipesQuery = recipesQuery.OrderByDescending(x => x.RecipeName);
                    break;

                default:
                    recipesQuery = recipesQuery.OrderBy(x => x.RecipeName);
                    break;
            }

            var count = await recipesQuery.CountAsync();
            var totalPages = (int)Math.Ceiling(count / (double)defaultPageSize);
            TotalPages = totalPages;

            var skip = (pageIndex - 1) * defaultPageSize;

            recipesQuery = recipesQuery.Skip(skip).Take(defaultPageSize);

            Recipes = await recipesQuery.ToListAsync();
        }
    }
}