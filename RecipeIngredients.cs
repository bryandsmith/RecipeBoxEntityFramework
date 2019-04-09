using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RecipeBox3._0.Models
{
    public class RecipeIngredients
    {
        public int? RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        public int? IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}