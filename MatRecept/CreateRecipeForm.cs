using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MatRecept.Form1;

namespace MatRecept
{
    public partial class CreateRecipeForm : Form
    {
        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Recipe.json");
        // Points to the directory where the executable is located (i.e., bin\Debug or bin\Release), so the application can find and update Recipe.json
        private List<Recipe> recipes; // List to hold the recipes

        public CreateRecipeForm()
        {
            InitializeComponent();
            PopulateComboType();
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboType.SelectedItem != null)
            {
                // Clear other text fields
                textBoxName.Clear();
                textBoxDescription.Clear();
                textBoxIngredients.Clear();
                textBoxInstructions.Clear();
            }

        }
        private void PopulateComboType()
        {
            comboType.Items.Clear();
            comboType.Items.Add("Meat");
            comboType.Items.Add("Fish");
            comboType.Items.Add("Soup");
            comboType.Items.Add("Salad");
            comboType.Items.Add("Dessert");
            comboType.SelectedIndex = -1; // No default selection
            comboType.Text = "Type"; // Placeholder text

           
            comboType.SelectedIndexChanged += comboType_SelectedIndexChanged;
        }




        private void buttonSave_Click(object sender, EventArgs e)
        {
            // All fields must be filled out
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxDescription.Text) ||
                comboType.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields and select a type.");
                return;
            }

            // Create a new recipe object
            var newRecipe = new Form1.Recipe
            {
                Name = textBoxName.Text,
                Description = textBoxDescription.Text,
                Ingredients = textBoxIngredients.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList(),
                Instructions = textBoxInstructions.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList(),
                Type = comboType.SelectedItem.ToString()
            };

            // Pass the new recipe back to Form1
            if (Owner is Form1 mainForm) // Make sure the owner is Form1
            {
                mainForm.AddRecipe(newRecipe); // Add the recipe to the main list in Form1
                mainForm.SaveRecipesToFile(); // Call SaveRecipes in Form1 to save the updated list to JSON
                MessageBox.Show("Recipe created and saved successfully!");
                this.Close(); // Close CreateRecipeForm after saving
            }
            else
            {
                MessageBox.Show("Unable to save the recipe. Please try again.");
            }
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Close CreateRecipeForm, returning to Form1
            this.Close();
        }

    }
}
