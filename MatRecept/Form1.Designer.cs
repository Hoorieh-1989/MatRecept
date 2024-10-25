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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // listBoxRecipe
            // 
            listBoxRecipe.FormattingEnabled = true;

            listBoxRecipe.Location = new Point(18, 158);
            listBoxRecipe.Margin = new Padding(5, 5, 5, 5);
            listBoxRecipe.Name = "listBoxRecipe";
            listBoxRecipe.Size = new Size(529, 292);
            listBoxRecipe.TabIndex = 0;
            // 
            // buttonAdmin
            // 
            buttonAdmin.BackColor = Color.Chocolate;

            buttonAdmin.Location = new Point(18, 19);
            buttonAdmin.Margin = new Padding(5, 5, 5, 5);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(205, 46);

            buttonAdmin.TabIndex = 10;
            buttonAdmin.Text = "Admin";
            buttonAdmin.UseVisualStyleBackColor = false;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // textBoxSearch
            // 

            textBoxSearch.Location = new Point(223, 526);
            textBoxSearch.Margin = new Padding(5, 5, 5, 5);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(331, 39);

            textBoxSearch.TabIndex = 11;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.PaleGreen;


            buttonSearch.Location = new Point(24, 526);
            buttonSearch.Margin = new Padding(5, 5, 5, 5);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(177, 51);
            buttonSearch.TabIndex = 12;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;

            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.LemonChiffon;

            buttonEdit.Location = new Point(249, 602);
            buttonEdit.Margin = new Padding(5, 5, 5, 5);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(182, 43);

            buttonEdit.TabIndex = 13;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.LightCyan;

            buttonCreate.Location = new Point(23, 602);
            buttonCreate.Margin = new Padding(5, 5, 5, 5);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(182, 43);

            buttonCreate.TabIndex = 14;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = false;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.IndianRed;

            buttonRemove.Location = new Point(499, 602);
            buttonRemove.Margin = new Padding(5, 5, 5, 5);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(182, 43);

            buttonRemove.TabIndex = 15;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // comboBoxRecipe
            // 
            comboBoxRecipe.FormattingEnabled = true;

            comboBoxRecipe.Location = new Point(18, 102);
            comboBoxRecipe.Margin = new Padding(5, 6, 5, 6);
            comboBoxRecipe.Name = "comboBoxRecipe";
            comboBoxRecipe.Size = new Size(222, 40);

            comboBoxRecipe.TabIndex = 16;
            // 
            // textBoxName
            // 

            textBoxName.Location = new Point(725, 139);
            textBoxName.Margin = new Padding(5, 5, 5, 5);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(331, 39);

            textBoxName.TabIndex = 17;
            // 
            // textBoxDescription
            // 

            textBoxDescription.Location = new Point(725, 222);
            textBoxDescription.Margin = new Padding(5, 5, 5, 5);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(331, 39);

            textBoxDescription.TabIndex = 18;
            // 
            // textBoxIngredients
            // 

            textBoxIngredients.Location = new Point(725, 330);
            textBoxIngredients.Margin = new Padding(5, 5, 5, 5);
            textBoxIngredients.Multiline = true;
            textBoxIngredients.Name = "textBoxIngredients";
            textBoxIngredients.Size = new Size(331, 153);

            textBoxIngredients.TabIndex = 19;
            // 
            // textBoxInstructions
            // 

            textBoxInstructions.Location = new Point(725, 526);
            textBoxInstructions.Margin = new Padding(5, 5, 5, 5);
            textBoxInstructions.Multiline = true;
            textBoxInstructions.Name = "textBoxInstructions";
            textBoxInstructions.Size = new Size(331, 164);

            textBoxInstructions.TabIndex = 20;
            // 
            // comboType
            // 
            comboType.FormattingEnabled = true;

            comboType.Location = new Point(725, 38);
            comboType.Margin = new Padding(5, 6, 5, 6);
            comboType.Name = "comboType";
            comboType.Size = new Size(222, 40);

            comboType.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;

            label1.Location = new Point(725, 102);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);

            label1.TabIndex = 22;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;

            label2.Location = new Point(725, 187);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);

            label2.TabIndex = 23;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;

            label3.Location = new Point(723, 293);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 32);

            label3.TabIndex = 24;
            label3.Text = "Ingridients";
            // 
            // label4
            // 
            label4.AutoSize = true;

            label4.Location = new Point(725, 490);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 32);

            label4.TabIndex = 25;
            label4.Text = "Instruction";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";

            label5.Size = new Size(0, 32);

            label5.TabIndex = 26;
            // 
            // Form1
            // 

            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 752);

            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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

            Margin = new Padding(5, 5, 5, 5);

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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}