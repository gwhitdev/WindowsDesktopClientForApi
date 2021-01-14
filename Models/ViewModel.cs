using System;
using System.Collections.Generic;
using System.Text;
using WindowsDesktopClientForApi.Interfaces;

namespace WindowsDesktopClientForApi.Models
{
    class ViewModel : IInterface
    {
        public List<string> IngredientIds { get; set; }
        public void SetLoadingText(bool loading)
        {

        }

        public void OpenNewForm(string formName)
        {

        }

        public void UpdateIngredientsList()
        {

        }

        public void ClearIngredientsList()
        {

        }

        public void UpdateIngredient()
        {

        }

        public void CreateIngredient()
        {

        }

        public void DeleteIngredient()
        {

        }
    }
}
