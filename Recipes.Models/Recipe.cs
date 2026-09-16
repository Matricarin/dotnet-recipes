using System;
using System.Collections.Generic;

namespace Recipes.Models
{
    public sealed class Recipe
    {
        public Guid Id { get;  }
        public string Title { get;  } 
        public List<Ingredient> Ingredients { get;  } 
        public List<string> Instructions { get;  } 
        public List<Category> Categories { get; } 

        public Recipe(Guid id, string title, List<Ingredient> ingredients, List<string> instructions, List<Category> categories)
        {
            if(id.Equals(Guid.Empty))
            {
                throw new ArgumentException("Invalid Id");
            }

            if(string.IsNullOrWhiteSpace(title))
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