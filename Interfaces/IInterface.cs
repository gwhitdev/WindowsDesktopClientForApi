using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsDesktopClientForApi.Interfaces
{
    public interface IInterface
    {
        public List<string> IngredientIds { get; set; }
        public void SetLoadingText(bool loading);
        public void OpenNewForm(string formName);
        public void UpdateIngredientsList();
        public void ClearIngredientsList();
        public void UpdateIngredient();
        public void CreateIngredient();
        public void DeleteIngredient();
    }
}
