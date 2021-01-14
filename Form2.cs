using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsDesktopClientForApi.Interfaces;
using WindowsDesktopClientForApi.Models;
using System.Threading.Tasks;

namespace WindowsDesktopClientForApi
{
    public partial class Form2 : Form
    {
        private readonly IIngredientsService _ingredientsService;

        public Form2()
        {
            InitializeComponent();
            _ingredientsService = (IIngredientsService)Program.ServiceProvider.GetService(typeof(IIngredientsService));

        }

        private async void createButton_Click(object sender, EventArgs e)
        {

            
            var newIngredientDetails = new Details()
            {
                name = ingredientNameBox.Text,
                quantity = (int)quantityBox.Value,
                quantityType = quanatityTypeBox.Text,
                keptAt = ingredientStoredBox.Text,
                useByDate = ingredientUseByBox.Value,
            };

            Ingredient newIngredient = new Ingredient
            {
                id = null,
                createdAt = DateTime.Now,
                updatedAt = DateTime.Now,
                details = newIngredientDetails
            };


            var createdIngredient = await _ingredientsService.CreateIngredient(newIngredient);

            if (!createdIngredient.Equals("201"))
            {
                resultText.Text = "There has been an error.";
            }

            resultText.Text = "Successfully created new ingredient.";
        }
    }
}
