using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private ViewModel viewModel;
        public Form1()
        {
            _ingredientsService = (IIngredientsService)Program.ServiceProvider.GetService(typeof(IIngredientsService));
            ViewModel viewModel = new ViewModel();
            InitializeComponent();
        }
        
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            viewModel.UpdateIngredientsList();
            if (lstIngredients.Items.Count > 0)
            {
                lstIngredients.Items.Clear();
            }
            
            var listOfIngredients = _ingredientsService.GetIngredients();
            ingredientIds = new List<string>();
            try
            {
                SetLoadingText(true);
                await foreach (var ingredient in listOfIngredients)
                {
                    foreach (var item in ingredient)
                    {
                        lstIngredients.Items.Add(item.details.name);
                        ingredientIds.Add(item.id);
                    }
                }
            SetLoadingText(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                   
        }



        private async void lstIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {

            var id = lstIngredients.SelectedIndex;
            string chosenIngredientId = ingredientIds[id];
            
            try
            {
                SetLoadingText(true);
                var ingredient = await _ingredientsService.GetIngredient(chosenIngredientId);
                ingredientNameBox.Text = ingredient.details.name;
                ingredientStoredBox.Text = ingredient.details.keptAt;
                ingredientUseByBox.Text = ingredient.details.useByDate.ToString();
                quanatityTypeBox.Text = ingredient.details.quantityType;
                quantityBox.Text = ingredient.details.quantity.ToString();
                SetLoadingText(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void SetLoadingText(bool loading)
        {
            if (loading == true)
            {
                toolStripStatusLabel1.Text = "Loading...";
            }
            if (loading == false)
            {
                toolStripStatusLabel1.Text = "";
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var createIngredientForm = new Form2();
            createIngredientForm.Show();
            
        }
    }
}
