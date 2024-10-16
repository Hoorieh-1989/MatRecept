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
            listBoxMeat = new ListBox();
            listBoxFish = new ListBox();
            listBoxSalad = new ListBox();
            listBoxSoup = new ListBox();
            listBoxDessert = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonAdmin = new Button();
            textBox1 = new TextBox();
            buttonSearch = new Button();
            buttonEdit = new Button();
            buttonCreate = new Button();
            buttonRemove = new Button();
            SuspendLayout();
            // 
            // listBoxMeat
            // 
            listBoxMeat.FormattingEnabled = true;
            listBoxMeat.Location = new Point(15, 95);
            listBoxMeat.Name = "listBoxMeat";
            listBoxMeat.Size = new Size(123, 204);
            listBoxMeat.TabIndex = 0;
            listBoxMeat.SelectedIndexChanged += listBoxMeat_SelectedIndexChanged;
            // 
            // listBoxFish
            // 
            listBoxFish.FormattingEnabled = true;
            listBoxFish.Location = new Point(152, 95);
            listBoxFish.Name = "listBoxFish";
            listBoxFish.Size = new Size(123, 204);
            listBoxFish.TabIndex = 1;
            listBoxFish.SelectedIndexChanged += listBoxFish_SelectedIndexChanged;
            // 
            // listBoxSalad
            // 
            listBoxSalad.FormattingEnabled = true;
            listBoxSalad.Location = new Point(296, 95);
            listBoxSalad.Name = "listBoxSalad";
            listBoxSalad.Size = new Size(123, 204);
            listBoxSalad.TabIndex = 2;
            listBoxSalad.SelectedIndexChanged += listBoxSalad_SelectedIndexChanged;
            // 
            // listBoxSoup
            // 
            listBoxSoup.FormattingEnabled = true;
            listBoxSoup.Location = new Point(438, 95);
            listBoxSoup.Name = "listBoxSoup";
            listBoxSoup.Size = new Size(123, 204);
            listBoxSoup.TabIndex = 3;
            listBoxSoup.SelectedIndexChanged += listBoxSoup_SelectedIndexChanged;
            // 
            // listBoxDessert
            // 
            listBoxDessert.FormattingEnabled = true;
            listBoxDessert.Location = new Point(585, 95);
            listBoxDessert.Name = "listBoxDessert";
            listBoxDessert.Size = new Size(123, 204);
            listBoxDessert.TabIndex = 4;
            listBoxDessert.SelectedIndexChanged += listBoxDessert_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 62);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 5;
            label1.Text = "Meat";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 62);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 6;
            label2.Text = "Fish";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 62);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 7;
            label3.Text = "Salad";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(438, 62);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 8;
            label4.Text = "Soup";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(585, 62);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 9;
            label5.Text = "Dessert";
            label5.Click += label5_Click;
            // 
            // buttonAdmin
            // 
            buttonAdmin.BackColor = Color.Chocolate;
            buttonAdmin.Location = new Point(12, 12);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(126, 29);
            buttonAdmin.TabIndex = 10;
            buttonAdmin.Text = "Admin";
            buttonAdmin.UseVisualStyleBackColor = false;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 329);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.PaleGreen;
            buttonSearch.Location = new Point(15, 329);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(109, 32);
            buttonSearch.TabIndex = 12;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.LemonChiffon;
            buttonEdit.Location = new Point(12, 376);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(112, 27);
            buttonEdit.TabIndex = 13;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.LightCyan;
            buttonCreate.Location = new Point(163, 376);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(112, 27);
            buttonCreate.TabIndex = 14;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.IndianRed;
            buttonRemove.Location = new Point(307, 376);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(112, 27);
            buttonRemove.TabIndex = 15;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 433);
            Controls.Add(buttonRemove);
            Controls.Add(buttonCreate);
            Controls.Add(buttonEdit);
            Controls.Add(buttonSearch);
            Controls.Add(textBox1);
            Controls.Add(buttonAdmin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxDessert);
            Controls.Add(listBoxSoup);
            Controls.Add(listBoxSalad);
            Controls.Add(listBoxFish);
            Controls.Add(listBoxMeat);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxMeat;
        private ListBox listBoxFish;
        private ListBox listBoxSalad;
        private ListBox listBoxSoup;
        private ListBox listBoxDessert;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonAdmin;
        private TextBox textBox1;
        private Button buttonSearch;
        private Button buttonEdit;
        private Button buttonCreate;
        private Button buttonRemove;
    }
}
