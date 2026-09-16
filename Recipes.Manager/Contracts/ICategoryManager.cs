using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Recipes.Models;

namespace Recipes.Manager.Contracts
{
    public interface ICategoryManager
    {
        Task<bool> CreateCategoryAsync(string title);

        Task<List<Category>> GetCategoriesAsync();

        Task<bool> EditCategoryAsync(Guid id, string newTitle);
    }
}