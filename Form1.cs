using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsDesktopClientForApi.Models;
using WindowsDesktopClientForApi.Services;
using WindowsDesktopClientForApi.Interfaces;

namespace WindowsDesktopClientForApi
{
    public partial class Form1 : Form
    {
        private readonly IIngredientsService _ingredientsService;
        private List<string> ingredientIds;


        public Form1()
        {
            _ingredientsService = (IIngredientsService)Program.ServiceProvider.GetService(typeof(IIngredientsService));
            InitializeComponent();
        }

    private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstIngredients.Items.Count == 0)
            {
                //var ingredientsService = new IngredientsHttpService();
                var listOfIngredients = _ingredientsService.GetIngredients();
                ingredientIds = new List<string>();
                try
                {
                    await foreach (var ingredient in listOfIngredients)
                    {
                        foreach (var item in ingredient)
                        {
                            lstIngredients.Items.Add(item.details.name);
                            ingredientIds.Add(item.id);
                        }

                    }

                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
            

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ingredientUseByDate_Click(object sender, EventArgs e)
        {

        }

        private async void lstIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            
         
            var id = lstIngredients.SelectedIndex;
            string chosenIngredientId = ingredientIds[id];

            //var ingredientService = new IngredientsHttpService();
            var ingredient = await _ingredientsService.GetIngredient(chosenIngredientId);


            ingredientName.Text = ingredient.details.name;
            ingredientKeptAt.Text = ingredient.details.keptAt;
            ingredientUseByDate.Text = ingredient.details.useByDate.ToString();

        }
    }
}
