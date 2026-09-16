using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Recipes.Models;

namespace Recipes.Manager.Contracts
{
    public interface IRecipeManager
    {
        Task<bool> CreateRecipeAsync(string title, List<string> ingredients, List<string> instructions, List<Category> categories);
        Task<List<Recipe>> GetRecipesAsync();
        Task<bool> EditRecipeAsync(Guid id, string newTitle, List<string> newIngredients, List<string> newInstructions, List<Category> newCategories);
        Task<bool> DeleteRecipeAsync(Guid id);
    }
}