using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Chef
    {
        // Primary Key for Review entity class
        public int ChefId { get; set; }

        [Display(Name = "Chef Name")]
        [Required]
        public string ChefName { get; set; }

        public List<Recipe> Recipes { get; set; } = new List<Recipe>();
    }
}