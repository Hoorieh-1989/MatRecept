using Newtonsoft.Json;
using System.Diagnostics.Eventing.Reader;

namespace MatRecept
{
    public partial class MainUI : Form
    {
        private string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Recipe.json");
        // Points to the directory where the executable is located (i.e., bin\Debug or bin\Release), so the application can find and update Recipe.json
        private List<Recipe> recipes; // List to hold the recipes

        public MainUI()
        {
            InitializeComponent();

            buttonCreate.Visible = false;
            buttonEdit.Visible = false;
            buttonRemove.Visible = false;

            PopulateComboBox();
            LoadRecipes(); // Load recipes from the JSON file

            // Add event handler for ListBox selection change
            listBoxRecipe.SelectedIndexChanged += listBoxRecipe_SelectedIndexChanged;
        }

        private void PopulateComboBox()
        {
            comboBoxRecipe.Items.Clear();
            comboBoxRecipe.Items.Add("Meat");
            comboBoxRecipe.Items.Add("Fish");
            comboBoxRecipe.Items.Add("Soup");
            comboBoxRecipe.Items.Add("Salad");
            comboBoxRecipe.Items.Add("Dessert");
            comboBoxRecipe.SelectedIndexChanged += comboBoxRecipe_SelectedIndexChanged;
        }

        private void LoadRecipes()
        {
            if (File.Exists(_filePath))
            {
                string jsonData = File.ReadAllText(_filePath); // Changed to use File.ReadAllText instead of an external ReadFile method

                if (!string.IsNullOrEmpty(jsonData))
                {
                    var recipeCollection = JsonConvert.DeserializeObject<RecipeCollection>(jsonData);
                    recipes = recipeCollection?.Recipes ?? new List<Recipe>(); // Assign the recipes list

                    // Changed to ensure recipes list is initialized even if deserialization fails
                    recipes = recipeCollection?.Recipes ?? new List<Recipe>();

                    // Populate the ListBox with the loaded recipes
                    DisplayRecipes(comboBoxRecipe.SelectedItem?.ToString());

                    // Optionally, select the first recipe if available
                    if (listBoxRecipe.Items.Count > 0)
                    {
                        listBoxRecipe.SelectedIndex = 0; // Select the first recipe
                    }
                }
                else
                {
                    MessageBox.Show("No data found in the recipe file.");

                    // Changed to initialize an empty list if no data is found in JSON
                    recipes = new List<Recipe>();
                }
            }
            else
            {
                MessageBox.Show("Recipe file not found.");

                // Changed to initialize an empty list if the file doesn't exist
                recipes = new List<Recipe>();
            }
        }

        private string ReadFile(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    return reader.ReadToEnd(); // Read the entire file content
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}");
                return null;
            }
        }

        private void DisplayRecipes(string category)
        {
            if (string.IsNullOrEmpty(category))
                return;

            var filteredRecipes = recipes
                .Where(r => r.Type.Equals(category, StringComparison.OrdinalIgnoreCase))
                .ToList();

            listBoxRecipe.DataSource = null; // Clear previous data
            listBoxRecipe.DataSource = filteredRecipes; // Bind new filtered recipes
            listBoxRecipe.DisplayMember = "Name"; // Display the "Name" property of each recipe
        }

        private void comboBoxRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayRecipes(comboBoxRecipe.SelectedItem?.ToString());
            // Optionally, select the first recipe if any are available
            if (listBoxRecipe.Items.Count > 0)
            {
                listBoxRecipe.SelectedIndex = 0; // Select the first recipe
            }
        }

        private void listBoxRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRecipe.SelectedItem is Recipe selectedRecipe)
            {
                // Display the recipe details in the text boxes
                textBoxName.Text = selectedRecipe.Name;
                textBoxDescription.Text = selectedRecipe.Description;
                textBoxIngredients.Text = string.Join(Environment.NewLine, selectedRecipe.Ingredients);
                textBoxInstructions.Text = string.Join(Environment.NewLine, selectedRecipe.Instructions);
            }
        }

        public void ShowAdminButtons()
        {
            buttonCreate.Visible = true;
            buttonEdit.Visible = true;
            buttonRemove.Visible = true;

        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            LoginForum loginForum = new LoginForum(this);
            loginForum.ShowDialog();
        }

     

        public class Recipe
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public List<string> Ingredients { get; set; }
            public List<string> Instructions { get; set; }
            public string Type { get; set; }
        }

        public class RecipeCollection
        {
            public List<Recipe> Recipes { get; set; }
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Ta direkt söktexten from textBoxSearch och trimma eventuella extra mellanslag
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                // Om searrch box is empty show all the categoies we want to choose
                DisplayRecipes(comboBoxRecipe.SelectedItem?.ToString());
                return;
            }

            // Filtrera recepten  baserat på textBoxSearch.Text utan använda en extra variabel
            var filteredRecipes = recipes
                .Where(r => r.Name.ToLower().Contains(textBoxSearch.Text.Trim().ToLower()) ||
                            r.Ingredients.Any(i => i.ToLower().Contains(textBoxSearch.Text.Trim().ToLower())))
                .ToList();

            // Kontrollera några matchningar hittades
            if (filteredRecipes.Count > 0)
            {
                // Uppdatera ListBox med  filtrerade resultaten
                listBoxRecipe.DataSource = null;  // Rensa tidigare data
                listBoxRecipe.DataSource = filteredRecipes;  // Bind de filtrerade recepten
                listBoxRecipe.DisplayMember = "Name";  // Visa namnen på recepten
            }
            else
            {
                // show message box om no match is found
                MessageBox.Show("No matching recipes found.");
                listBoxRecipe.DataSource = null;  // clear the box if nothing is in search found
            }
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // Ensure a recipe is selected 
            if (listBoxRecipe.SelectedItem is Recipe selectedRecipe)
            {
                // Corfirm delete
                DialogResult result = MessageBox.Show($"Are you sure you want to remove '{selectedRecipe.Name}'?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Delete the recipe from the list 
                    recipes.Remove(selectedRecipe);

                    // Update the file JSON after deleting the recipe
                    SaveRecipesToFile();

                    // Refresh the ListBox to display updated recipes 
                    DisplayRecipes(comboBoxRecipe.SelectedItem?.ToString());

                    MessageBox.Show($"{selectedRecipe.Name} has been removed.", "Recipe Removed");

                    // Select the first recipe after deleting if there are more recipes
                    if (listBoxRecipe.Items.Count > 0)
                    {
                        listBoxRecipe.SelectedIndex = 0; // Select the first  ítem
                    }
                    else
                    {
                        // Clear the fields if there are no recipes left
                        ClearRecipeDetails();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a recipe to remove.", "No Selection");
            }
        }



      


        private void buttonEdit_Click(object sender, EventArgs e)
        {


            if (listBoxRecipe.SelectedItem is Recipe selectedRecipe)
            {
                // Update the selected recipe's details from the text boxes
                selectedRecipe.Name = textBoxName.Text;
                selectedRecipe.Description = textBoxDescription.Text;
                selectedRecipe.Ingredients = textBoxIngredients.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();
                selectedRecipe.Instructions = textBoxInstructions.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

                // Save the updated recipes list back to the JSON file
                SaveRecipesToFile();
                MessageBox.Show("Recipe updated successfully!");
            }
        }
        // Method to save updated recipes to JSON file
        public void SaveRecipesToFile()
        {
            try
            {
                var recipeCollection = new RecipeCollection { Recipes = recipes };
                string jsonData = JsonConvert.SerializeObject(recipeCollection, Formatting.Indented);

                // Write to JSON content to the file 
                File.WriteAllText(_filePath, jsonData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}");
            }
        }

        // Method to clear recipe details in the interface 
        private void ClearRecipeDetails()
        {
            textBoxName.Clear();
            textBoxDescription.Clear();
            textBoxIngredients.Clear();
            textBoxInstructions.Clear();
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                buttonSearch_Click(sender, e); // Trigger the search
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                DisplayAllRecipes(); // Show all recipes when the search box is empty
            }
            else
            {
                DisplayRecipes(comboBoxRecipe.SelectedItem?.ToString()); // Filter by selected category
            }
        }



        private void DisplayAllRecipes()
        {
            listBoxRecipe.DataSource = null; // Clear previous data
            listBoxRecipe.DataSource = recipes; // Bind all recipes directly
            listBoxRecipe.DisplayMember = "Name"; // Display the "Name" property of each recipe
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateRecipeForm createRecipeForm = new CreateRecipeForm();
            createRecipeForm.Owner = this; // Set Form1 as the owner to access AddRecipe
            createRecipeForm.ShowDialog(); // Open CreateRecipeForm as a dialog
        }

        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);       // Add the new recipe to the list
            SaveRecipesToFile();       // Save updated recipes to JSON
            DisplayAllRecipes();       // Refresh display to show new recipe
        }
    }



}



