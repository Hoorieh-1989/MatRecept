using Newtonsoft.Json;

namespace MatRecept
{
    public partial class Form1 : Form
    {
        private string filePath = @"Recipe.json"; // Path to your JSON file
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
            listBoxRecipe.DisplayMember = "Name";
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
