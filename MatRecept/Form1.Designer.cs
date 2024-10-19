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
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            buttonEdit = new Button();
            buttonCreate = new Button();
            buttonRemove = new Button();
            comboBoxRecipe = new ComboBox();
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            textBoxIngredients = new TextBox();
            textBoxInstructions = new TextBox();
            comboType = new ComboBox();
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
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(120, 247);
            textBoxSearch.Margin = new Padding(3, 2, 3, 2);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(180, 23);
            textBoxSearch.TabIndex = 11;
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
            //buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.LemonChiffon;
            buttonEdit.Location = new Point(134, 282);
            buttonEdit.Margin = new Padding(3, 2, 3, 2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(98, 20);
            buttonEdit.TabIndex = 13;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.LightCyan;
            buttonCreate.Location = new Point(12, 282);
            buttonCreate.Margin = new Padding(3, 2, 3, 2);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(98, 20);
            buttonCreate.TabIndex = 14;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = false;
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
            // 
            // comboBoxRecipe
            // 
            comboBoxRecipe.FormattingEnabled = true;
            comboBoxRecipe.Location = new Point(10, 48);
            comboBoxRecipe.Name = "comboBoxRecipe";
            comboBoxRecipe.Size = new Size(121, 23);
            comboBoxRecipe.TabIndex = 16;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(390, 62);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(180, 23);
            textBoxName.TabIndex = 17;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(390, 100);
            textBoxDescription.Margin = new Padding(3, 2, 3, 2);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(180, 23);
            textBoxDescription.TabIndex = 18;
            // 
            // textBoxIngredients
            // 
            textBoxIngredients.Location = new Point(390, 141);
            textBoxIngredients.Margin = new Padding(3, 2, 3, 2);
            textBoxIngredients.Multiline = true;
            textBoxIngredients.Name = "textBoxIngredients";
            textBoxIngredients.Size = new Size(180, 74);
            textBoxIngredients.TabIndex = 19;
            // 
            // textBoxInstructions
            // 
            textBoxInstructions.Location = new Point(390, 223);
            textBoxInstructions.Margin = new Padding(3, 2, 3, 2);
            textBoxInstructions.Multiline = true;
            textBoxInstructions.Name = "textBoxInstructions";
            textBoxInstructions.Size = new Size(180, 79);
            textBoxInstructions.TabIndex = 20;
            // 
            // comboType
            // 
            comboType.FormattingEnabled = true;
            comboType.Location = new Point(390, 28);
            comboType.Name = "comboType";
            comboType.Size = new Size(121, 23);
            comboType.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 325);
            Controls.Add(comboType);
            Controls.Add(textBoxInstructions);
            Controls.Add(textBoxIngredients);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(comboBoxRecipe);
            Controls.Add(buttonRemove);
            Controls.Add(buttonCreate);
            Controls.Add(buttonEdit);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
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
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button buttonEdit;
        private Button buttonCreate;
        private Button buttonRemove;
        private ComboBox comboBoxRecipe;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private TextBox textBoxIngredients;
        private TextBox textBoxInstructions;
        private ComboBox comboType;
    }
}
