namespace MatRecept
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();


            buttonCreate.Visible = false;
            buttonEdit.Visible = false;
            buttonRemove.Visible = false;


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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
          
        }
    }
}