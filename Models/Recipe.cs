using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string RecipeName { get; set; } = string.Empty;

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [StringLength(30)]
        [Required]

        public string MealType { get; set; } = string.Empty;
        public string Tags { get; set; } = string.Empty;


        [Display(Name = "Chef")]
        [Required]
        public int ChefId { get; set; }
        public Chef? Chef { get; set; }
    }
}