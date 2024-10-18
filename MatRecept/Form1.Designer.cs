namespace MatRecept
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxRecipe = new ListBox();
            buttonAdmin = new Button();
            textBox1 = new TextBox();
            buttonSearch = new Button();
            buttonEdit = new Button();
            buttonCreate = new Button();
            buttonRemove = new Button();
            comboBoxRecipe = new ComboBox();
            SuspendLayout();
            // 
            // listBoxRecipe
            // 
            listBoxRecipe.FormattingEnabled = true;
            listBoxRecipe.ItemHeight = 15;
            listBoxRecipe.Location = new Point(13, 76);
            listBoxRecipe.Margin = new Padding(3, 2, 3, 2);
            listBoxRecipe.Name = "listBoxRecipe";
            listBoxRecipe.Size = new Size(287, 139);
            listBoxRecipe.TabIndex = 0;
            // 
            // buttonAdmin
            // 
            buttonAdmin.BackColor = Color.Chocolate;
            buttonAdmin.Location = new Point(10, 9);
            buttonAdmin.Margin = new Padding(3, 2, 3, 2);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(110, 22);
            buttonAdmin.TabIndex = 10;
            buttonAdmin.Text = "Admin";
            buttonAdmin.UseVisualStyleBackColor = false;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 247);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 11;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.PaleGreen;
            buttonSearch.Location = new Point(13, 247);
            buttonSearch.Margin = new Padding(3, 2, 3, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(95, 24);
            buttonSearch.TabIndex = 12;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.LemonChiffon;
            buttonEdit.Location = new Point(10, 282);
            buttonEdit.Margin = new Padding(3, 2, 3, 2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(98, 20);
            buttonEdit.TabIndex = 13;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.LightCyan;
            buttonCreate.Location = new Point(143, 282);
            buttonCreate.Margin = new Padding(3, 2, 3, 2);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(98, 20);
            buttonCreate.TabIndex = 14;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.IndianRed;
            buttonRemove.Location = new Point(269, 282);
            buttonRemove.Margin = new Padding(3, 2, 3, 2);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(98, 20);
            buttonRemove.TabIndex = 15;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // comboBoxRecipe
            // 
            comboBoxRecipe.FormattingEnabled = true;
            comboBoxRecipe.Location = new Point(10, 48);
            comboBoxRecipe.Name = "comboBoxRecipe";
            comboBoxRecipe.Size = new Size(121, 23);
            comboBoxRecipe.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 325);
            Controls.Add(comboBoxRecipe);
            Controls.Add(buttonRemove);
            Controls.Add(buttonCreate);
            Controls.Add(buttonEdit);
            Controls.Add(buttonSearch);
            Controls.Add(textBox1);
            Controls.Add(buttonAdmin);
            Controls.Add(listBoxRecipe);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxRecipe;
        private Button buttonAdmin;
        private TextBox textBox1;
        private Button buttonSearch;
        private Button buttonEdit;
        private Button buttonCreate;
        private Button buttonRemove;
        private ComboBox comboBoxRecipe;
    }
}
