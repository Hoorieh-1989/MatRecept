namespace MatRecept
{
    public partial class Form1 : Form
    {
        //trying to push the latest version so everything works for json
        public Form1()
        {
            InitializeComponent();

            buttonCreate.Visible = false;
            buttonEdit.Visible = false;
            buttonRemove.Visible = false;

       
            PopulateComboBox();
        }

     
        private void PopulateComboBox()
        {
            comboBoxRecipe.Items.Clear();

      
            comboBoxRecipe.Items.Add("Meat");
            comboBoxRecipe.Items.Add("Fish");
            comboBoxRecipe.Items.Add("Soup");
            comboBoxRecipe.Items.Add("Salad");
            comboBoxRecipe.Items.Add("Dessert");

            comboBoxRecipe.SelectedIndex = 0;
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


        
    }
}
