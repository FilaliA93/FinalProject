using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RecipeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RecipeContext>>()))
            {
                if (context == null || context.Recipes == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }


                // Look for any movies.
                if (context.Recipes.Any())
                {
                    return;   // DB has been seeded
                }

                var chef1 = new Chef
                {
                    ChefName = "John Doe"
                };

                var chef2 = new Chef
                {
                    ChefName = "malek Smith"
                };

                var chef3 = new Chef
                {
                    ChefName = "George Washington"
                };

                var chef4 = new Chef
                {
                    ChefName = "Michael Don"
                };

                var chef5 = new Chef
                {
                    ChefName = "Samir Long"
                };

                context.Chefs.AddRange(chef1, chef2, chef3, chef4, chef5 );

                context.Recipes.AddRange(
                    new Recipe
                    {
                        RecipeName = "Pizza au fromage",
                        ReleaseDate = DateTime.Parse("2022-11-18"),
                        MealType = "food",
                        Tags = "Italy",
                        Chef = chef1
                    },

                     new Recipe
                     {
                         RecipeName = "Pizza au bonbon",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "Italy",
                         Chef = chef1
                     },

                     new Recipe
                     {
                         RecipeName = "Pizza au calamar",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "Italy",
                         Chef = chef1
                     },

                     new Recipe
                     {
                         RecipeName = "Pizza au tomate",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "Italy",
                         Chef = chef1
                     },

                     new Recipe
                     {
                         RecipeName = "Spagheti au Fromage",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "Italy",
                         Chef = chef2
                     },

                     new Recipe
                     {
                         RecipeName = "Couscouss",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "Morocco",
                         Chef = chef2
                     },

                     new Recipe
                     {
                         RecipeName = "Ham Burger",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "USA",
                         Chef = chef2
                     },

                     new Recipe
                     {
                         RecipeName = "Chicken Burger",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "USA",
                         Chef = chef2
                     },

                     new Recipe
                     {
                         RecipeName = "Beef Shaqarma",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "Midle east",
                         Chef = chef2
                     },

                     new Recipe
                     {
                         RecipeName = "Chicken Shawrma",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "Midle east",
                         Chef = chef3
                     },

                     new Recipe
                     {
                         RecipeName = "Houmouss",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "Lebanon",
                         Chef = chef3
                     },

                     new Recipe
                     {
                         RecipeName = "Fried Eggs",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "USA",
                         Chef = chef3
                     },

                     new Recipe
                     {
                         RecipeName = "Chicken Alfredo Pasta",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "USA",
                         Chef = chef3
                     },

                     new Recipe
                     {
                         RecipeName = "Maklouba",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "Midle East",
                         Chef = chef3
                     },

                     new Recipe
                     {
                         RecipeName = "Grilled Fish",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "USA",
                         Chef = chef4
                     },

                     new Recipe
                     {
                         RecipeName = "Seafood Mix",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "USA",
                         Chef = chef4
                     },

                     new Recipe
                     {
                         RecipeName = "Shrimp au tomate",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "French",
                         Chef = chef4
                     },

                     new Recipe
                     {
                         RecipeName = "Chocolate Cake",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "Appetizer",
                         Tags = "USA",
                         Chef = chef4
                     },

                     new Recipe
                     {
                         RecipeName = "Breakfast Burito",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "Mexico",
                         Chef = chef4
                     },

                     new Recipe
                     {
                         RecipeName = "Gambo soup",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "Mexico",
                         Chef = chef5
                     },

                     new Recipe
                     {
                         RecipeName = "Egg Tacos",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "Mexico",
                         Chef = chef5
                     },

                     new Recipe
                     {
                         RecipeName = "Chciken Tacos",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "Mexico",
                         Chef = chef5
                     },

                     new Recipe
                     {
                         RecipeName = "Beef Tacos",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "Mexico",
                         Chef = chef5
                     },

                     new Recipe
                     {
                         RecipeName = "Shrimp Taco",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "Mexico",
                         Chef = chef5
                     },

                     new Recipe
                     {
                         RecipeName = "Casadia",
                         ReleaseDate = DateTime.Parse("2022-11-18"),
                         MealType = "food",
                         Tags = "Mexico",
                         Chef = chef5
                     }
                );
                context.SaveChanges();
            }
        }
    }
}