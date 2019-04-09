using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeBox3._0.Models
{
    public class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecipeId { get; set; }
        public string Owner { get; set; }
        public string Name { get; set; }
        public ICollection<RecipeIngredients> Ingredients { get; set; }
        public ICollection<Instructions> Instructions { get; set; }
    }
}
