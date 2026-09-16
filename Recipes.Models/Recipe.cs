using System;
using System.Collections.Generic;

namespace Recipes.Models
{
    public sealed class Recipe
    {
        public Guid Id {get;}
        public string Title { get; } 
        public List<Ingredient> Ingredients{get;}
        public List<string> Instructions{get;}
        public List<Category> Categories {get;}

    }
}