﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WindowsDesktopClientForApi.Models;
using Newtonsoft.Json.Linq;
using System.Linq;
using WindowsDesktopClientForApi.Interfaces;
using System.Net;
/// <summary>
///  Creates an instance of a HttpClient to send GET requests to FamilyMeals API.
///  Provides a GetIngredients and GetIngredient method
/// </summary>

namespace WindowsDesktopClientForApi.Services
{
    class IngredientsHttpService : IIngredientsService
    {

        private readonly HttpClient _client;
        private List<Ingredient> SearchResults { get; set; }
        private Ingredient Ingredient { get; set; } 

        public IngredientsHttpService(HttpClient client) 
        {
            // Injected HttpClient
            _client = client;
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
                HttpResponseMessage response = await _client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var result = await response.Content.ReadAsStringAsync();
                JArray convertedResult = JArray.Parse(result);
                IList<JToken> results = convertedResult[0]["data"]["ingredients"].Children().ToList();
                // serialize Json results into .Net objects
                SearchResults = new List<Ingredient>();
                foreach (JToken searchResult in results)
                {
                    Ingredient ingredient = searchResult.ToObject<Ingredient>();
                    SearchResults.Add(ingredient);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            yield return SearchResults;
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
                HttpResponseMessage response = await _client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                var result = await response.Content.ReadAsStringAsync();

                // Parses the result
                JArray convertedResult = JArray.Parse(result);

                // Extracts just the specific ingredient details from the results
                List<JToken> results = convertedResult[0]["data"]["ingredients"].Children().ToList();

                // Converts the specific ingredient to an Ingredient object
                Ingredient = results[0].ToObject<Ingredient>();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
 
            return Ingredient;
        }

        public async Task<bool> CreateIngredient(Ingredient ingredient)
        {
            var url = $"Ingredients";
            
           
            var json = JsonConvert.SerializeObject(ingredient);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(url, content);

            if (response.StatusCode == HttpStatusCode.Created)
            {
                return true;
            }

            return false;
                
        }

        public async Task<bool> DeleteIngredient(string ingredientId)
        {
            var url = "Ingredients";     
            var response = await _client.DeleteAsync($"{url}/{ingredientId}");
                        
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }

            return false;
        }
    }

    
}