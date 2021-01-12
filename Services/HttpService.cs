using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WindowsDesktopClientForApi.Models;
using Newtonsoft.Json.Linq;
using System.Linq;
/// <summary>
///  Creates an instance of a HttpClient to send GET requests to FamilyMeals API.
///  Provides a GetIngredients and GetIngredient method
/// </summary>

namespace WindowsDesktopClientForApi.Services
{
    class HttpService
    {

        private static readonly HttpClient client;
        private List<Ingredient> searchResults;
        private Ingredient ingredient;

        static HttpService() //Initialise the HttpClient
        {
            // These values must not be changed later in the class
            client = new HttpClient();
            client.BaseAddress = new Uri("https://familymealsapi.azurewebsites.net/api/");
            client.Timeout = TimeSpan.FromSeconds(5);
            client.MaxResponseContentBufferSize = 10000;
            client.DefaultRequestHeaders.Add("User-Agent", "WinFormTestApp");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Method to get all ingredients from API
        /// </summary>
        /// <returns>Enumarble list of ingredients</returns>
        public async IAsyncEnumerable<List<Ingredient>> GetIngredients()
        {

            var url = "Ingredients";

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var result = await response.Content.ReadAsStringAsync();
                JArray convertedResult = JArray.Parse(result);
                IList<JToken> results = convertedResult[0]["data"]["ingredients"].Children().ToList();
                // serialize Json results into .Net objects
                searchResults = new List<Ingredient>();
                foreach (JToken searchResult in results)
                {
                    Ingredient ingredient = searchResult.ToObject<Ingredient>();
                    searchResults.Add(ingredient);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            yield return searchResults;
        }

        /// <summary>
        /// Method to get a specific ingredient from the API
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An async ingredient</returns>
        public async Task<Ingredient> GetIngredient(string id)
        {     
            var url = $"Ingredients/{id}";
  
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                var result = await response.Content.ReadAsStringAsync();

                // Parses the result
                JArray convertedResult = JArray.Parse(result);

                // Extracts just the specific ingredient details from the results
                List<JToken> results = convertedResult[0]["data"]["ingredients"].Children().ToList();

                // Converts the specific ingredient to an Ingredient object
                ingredient = results[0].ToObject<Ingredient>();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
 
            return ingredient;
        }
    }
}