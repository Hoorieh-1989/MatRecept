using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatRecept
{
    public partial class LoginForum : Form
    {

        private Form1 mainform;

        public LoginForum(Form1 form1)
        {
            InitializeComponent();
            this.mainform = form1;
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Grattis du är nu Inloggad som Admin");
                mainform.ShowAdminButtons();
                Close();
            }
            else
            {
                MessageBox.Show("Felaktig inloggning");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
