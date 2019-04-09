using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using RecipeBox3._0.Models;

namespace RecipeBox3._0.Data
{
    public class RecipeDbContext : DbContext
    {
        public RecipeDbContext(DbContextOptions<RecipeDbContext> options) : base(options)
        {

        }
        public DbSet<Recipe> Recipes {get; set;}
        public DbSet<Instructions> Instructions { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<RecipeIngredients> RecipeIngredients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeIngredients>().HasKey(ri => new { ri.RecipeId, ri.IngredientId });
            modelBuilder.Entity<RecipeIngredients>()
                .HasOne(ri => ri.Recipe)
                .WithMany(r => r.Ingredients)
                .HasForeignKey(ri => ri.RecipeId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<RecipeIngredients>()
                .HasOne(ri => ri.Ingredient)
                .WithMany(r => r.Recipes)
                .HasForeignKey(ri => ri.IngredientId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Instructions>().ToTable("Instructions");
            modelBuilder.Entity<Ingredient>().ToTable("Ingredients");
            modelBuilder.Entity<Recipe>().ToTable("Recipes");
            modelBuilder.Entity<RecipeIngredients>().ToTable("Recipe Ingredients");
            modelBuilder.Entity<Recipe>().HasIndex(t => t.Instructions).IsUnique();
        }
      

           

}
}
