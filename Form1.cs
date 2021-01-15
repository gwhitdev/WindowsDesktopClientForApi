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
        public List<string> IngredientIds { get; set; } = new List<string>();
        public string ChosenIngredientId { get; set; }
        public List<string> IngredientNames { get; set; } = new List<string>();
        public int SelectedIndex { get; set; }
        public Ingredient ChosenIngredient { get; set; }
        public bool IngredientsChanged { get; set; } = true;
        public string ChosenName { get; set; }
        public Form1()
        {
            _ingredientsService = (IIngredientsService)Program.ServiceProvider.GetService(typeof(IIngredientsService));
            
            InitializeComponent();
        }
        public static string SetLoadingText(bool loading)
        {
            return loading ? "Loading..." : "";
        }

        public static string SetDeletingText(bool deleting)
        {
            return deleting ? "Deleting..." : "";
        }

        private static string DeletingSuccessMessage(bool success, string id)
        {
            return success ? $"Ingredient with ID {id} was deleted." : $"Ingredient with ID {id} could not be deleted.";
        }

        private static string UpdateSuccessMessage(bool success)
        {
            return success ? "Ingredients list updated." : "Ingredients list not updated";
        }
        private void ClearTextBoxes()
        {
            ingredientNameBox.Clear();
            ingredientStoredBox.Clear();
            ingredientUseByBox.Clear();
            quanatityTypeBox.Clear();
            quantityBox.Clear();
        }
        private async Task GetListOfIngredients()
        {
            IAsyncEnumerable<List<Ingredient>> listOfIngredients = _ingredientsService.GetIngredients();
            
            if (IngredientsChanged)
            {
                toolStripStatusLabel1.Text = SetLoadingText(true);

                await foreach (var ingredient in listOfIngredients)
                {
                    foreach (var item in ingredient)
                    {
                        if (IngredientNames.Contains(item.details.name)) return;

                        IngredientIds.Add(item.id);
                        IngredientNames.Add(item.details.name);
                    }
                }

                IngredientsChanged = false;
                toolStripStatusLabel1.Text = SetLoadingText(false);
            }
        }

        private void AddIngredientNamesToListBox()
        {
            if (IngredientNames.Count > 0)
            {
                foreach (var name in IngredientNames)
                {
                    lstIngredients.Items.Add(name);
                }
            }
        }

        public async Task<string> UpdateListBoxOfIngredients()
        {
            if (IngredientsChanged == false && lstIngredients.Items.Count > 0 && IngredientNames.Count > 0)
            {
                foreach (var name in IngredientNames)
                {
                    if (!lstIngredients.Items.Contains(name)) lstIngredients.Items.Add(name);
                    
                }
               
            }
            else
            {
                await GetListOfIngredients();
                if (IngredientNames.Count > 0)
                {
                    foreach (var name in IngredientNames)
                    {
                        if (!lstIngredients.Items.Contains(name)) lstIngredients.Items.Remove(name);  
                    }
                }
                else
                {
                    lstIngredients.Items.Clear();
                }
                
            }
            return toolStripStatusLabel1.Text = UpdateSuccessMessage(true);
        }

        private async Task<string> DeleteIngredient(string id)
        {
            toolStripStatusLabel1.Text = SetDeletingText(true);
            var deleteIngredientResponse = await _ingredientsService.DeleteIngredient(id); // Removes selected item from DB through API
            toolStripStatusLabel1.Text = SetDeletingText(false);

            if (!deleteIngredientResponse) return DeletingSuccessMessage(false, id);

            IngredientsChanged = true;
            
            IngredientNames.RemoveAt(SelectedIndex);
            
            return DeletingSuccessMessage(true, id);
            
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstIngredients.Items.Count == 0 && IngredientNames.Count == 0)
            {
               await GetListOfIngredients();
               AddIngredientNamesToListBox();
            }
            else
            {
                await UpdateListBoxOfIngredients();
            }
        }

        private async void lstIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {

            SelectedIndex = lstIngredients.SelectedIndex; // setting the SelectedIndex property
            ChosenName = IngredientNames[SelectedIndex];
            ChosenIngredientId = IngredientIds[SelectedIndex];

            // REFACTOR BELOW INTO STAND ALONE METHOD AND CALL HERE WITH ID
            

            try
            {
                SetLoadingText(true);
                ChosenIngredient = await _ingredientsService.GetIngredient(ChosenIngredientId);
                SetLoadingText(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            ingredientNameBox.Text = ChosenIngredient.details.name;
            ingredientStoredBox.Text = ChosenIngredient.details.keptAt;
            ingredientUseByBox.Text = ChosenIngredient.details.useByDate.ToString();
            quanatityTypeBox.Text = ChosenIngredient.details.quantityType;
            quantityBox.Text = ChosenIngredient.details.quantity.ToString();

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var createIngredientForm = new Form2();
            createIngredientForm.Show();
            
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            
            toolStripStatusLabel1.Text = await DeleteIngredient(ChosenIngredientId);
            toolStripStatusLabel1.Text = await UpdateListBoxOfIngredients();
            ClearTextBoxes();
        }

        private void ingredientsChangedButton_Click(object sender, EventArgs e)
        {
            IngredientsChanged = !IngredientsChanged;
            toolStripStatusLabel1.Text = IngredientsChanged.ToString();
        }
    }
}
