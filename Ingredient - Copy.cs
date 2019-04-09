using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RecipeBox3._0.Models
{
    public class Ingredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IngredientId { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        public string Name { get; set; }
       
        
       public ICollection<RecipeIngredients> Recipes { get; set; }
      
        //public ICollection<RecipeIngredients> RecipeIngredients { get; set; }
     
        
    }
}
