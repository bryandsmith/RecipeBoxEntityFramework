using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeBox3._0.Models
{
    public class Instructions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InstrutionsId { get; set; }
        public string InstructionSet { get; set; }
        //foreign key
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
