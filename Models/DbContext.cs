using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class RecipeContext : DbContext
    {
        public RecipeContext (DbContextOptions<RecipeContext> options)
            : base (options)
            {
            }
        
        public DbSet<Recipe> Recipes {get; set;} = default!;
        public DbSet<Chef> Chefs {get; set;} = default!;
    }
}