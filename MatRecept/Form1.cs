using Newtonsoft.Json;
using System.Diagnostics.Eventing.Reader;

namespace MatRecept
{
    public partial class Form1 : Form
    {
        private string filePath = @"C:\Users\Milto\Source\Repos\MatRecept\MatRecept\Recipe.json"; // Path to your JSON file
        private List<Recipe> recipes; // List to hold the recipes

        public Form1()
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
            if (File.Exists(filePath))
            {
                string jsonData = ReadFile(filePath); // Read the file using StreamReader

                if (!string.IsNullOrEmpty(jsonData))
                {
                    var recipeCollection = JsonConvert.DeserializeObject<RecipeCollection>(jsonData);
                    recipes = recipeCollection?.Recipes ?? new List<Recipe>(); // Assign the recipes list

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
                }
            }
            else
            {
                MessageBox.Show("Recipe file not found.");
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

        private void Form1_Load(object sender, EventArgs e)
        {
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

        // Method to save updated recipes to JSON file
          private void SaveRecipes()
        {
            try
            {
                var recipeCollection = new RecipeCollection { Recipes = recipes };
                string jsonData = JsonConvert.SerializeObject(recipeCollection, Formatting.Indented);

                // Debug-skrivning
                Console.WriteLine("JSON Data som ska sparas: " + jsonData);

                File.WriteAllText(filePath, jsonData); // Överskriv filen
                Console.WriteLine("Recepten har sparats till filen.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fel vid sparande av recept: {ex.Message}");
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
                SaveRecipes();
                MessageBox.Show("Recipe updated successfully!");
            }
        }


    }

}




