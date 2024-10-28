namespace MatRecept
{
    partial class LoginForum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSignIn = new Button();
            buttonCancel = new Button();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            labelUsernameLogInForum = new Label();
            labelPasswordLoginForum = new Label();
            SuspendLayout();
            // 
            // buttonSignIn
            // 
            buttonSignIn.Location = new Point(24, 143);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(71, 25);
            buttonSignIn.TabIndex = 0;
            buttonSignIn.Text = "Sign in";
            buttonSignIn.UseVisualStyleBackColor = true;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(101, 143);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(73, 25);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(24, 46);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(150, 23);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(24, 99);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(150, 23);
            textBoxPassword.TabIndex = 3;
            // 
            // labelUsernameLogInForum
            // 
            labelUsernameLogInForum.AutoSize = true;
            labelUsernameLogInForum.Location = new Point(21, 28);
            labelUsernameLogInForum.Name = "labelUsernameLogInForum";
            labelUsernameLogInForum.Size = new Size(60, 15);
            labelUsernameLogInForum.TabIndex = 4;
            labelUsernameLogInForum.Text = "Username";
            // 
            // labelPasswordLoginForum
            // 
            labelPasswordLoginForum.AutoSize = true;
            labelPasswordLoginForum.Location = new Point(24, 81);
            labelPasswordLoginForum.Name = "labelPasswordLoginForum";
            labelPasswordLoginForum.Size = new Size(57, 15);
            labelPasswordLoginForum.TabIndex = 5;
            labelPasswordLoginForum.Text = "Password";
            // 
            // LoginForum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 215);
            Controls.Add(labelPasswordLoginForum);
            Controls.Add(labelUsernameLogInForum);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSignIn);
            Name = "LoginForum";
            Text = "LoginForum";
            Load += LoginForum_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSignIn;
        private Button buttonCancel;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label labelUsernameLogInForum;
        private Label labelPasswordLoginForum;
    }
}