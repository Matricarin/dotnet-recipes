using System.Collections.Generic;
using System.Threading.Tasks;

namespace Recipes.Storage.Contracts
{
    public interface IStorage<T>
    {
        Task<bool> Save(List<T> values);
        Task<List<T>> Load();
    }
}