using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using WindowsDesktopClientForApi.Models;

namespace WindowsDesktopClientForApi.Interfaces
{
    public interface IIngredientsService
    {        
        IAsyncEnumerable<List<Ingredient>> GetIngredients();
        Task<Ingredient> GetIngredient(string id);

        Task<bool> CreateIngredient(Ingredient ingredient);
        Task<bool> DeleteIngredient(string Id);
       // void UpdateIngredient(string Id);
    }
}
