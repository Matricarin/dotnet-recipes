using System;
using System.Collections.Generic;

namespace Recipes.Models
{
    public sealed class Recipe
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Instructions { get; set; }
        public List<Category> Categories { get; set; }

        public Recipe(Guid id, string title, List<string> ingredients, List<string> instructions, List<Category> categories)
        {
            if (id.Equals(Guid.Empty))
            {
                throw new ArgumentException("Invalid Id");
            }

            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException(nameof(title));
            }

            Id = id;
            Title = title;
            Ingredients = ingredients;
            Instructions = instructions;
            Categories = categories;
        }
    }
}