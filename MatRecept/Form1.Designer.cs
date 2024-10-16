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
            SuspendLayout();
            // 
            // listBoxMeat
            // 
            listBoxMeat.FormattingEnabled = true;
            listBoxMeat.Location = new Point(15, 95);
            listBoxMeat.Name = "listBoxMeat";
            listBoxMeat.Size = new Size(123, 204);
            listBoxMeat.TabIndex = 0;
            // 
            // listBoxFish
            // 
            listBoxFish.FormattingEnabled = true;
            listBoxFish.Location = new Point(152, 95);
            listBoxFish.Name = "listBoxFish";
            listBoxFish.Size = new Size(123, 204);
            listBoxFish.TabIndex = 1;
            // 
            // listBoxSalad
            // 
            listBoxSalad.FormattingEnabled = true;
            listBoxSalad.Location = new Point(296, 95);
            listBoxSalad.Name = "listBoxSalad";
            listBoxSalad.Size = new Size(123, 204);
            listBoxSalad.TabIndex = 2;
            // 
            // listBoxSoup
            // 
            listBoxSoup.FormattingEnabled = true;
            listBoxSoup.Location = new Point(438, 95);
            listBoxSoup.Name = "listBoxSoup";
            listBoxSoup.Size = new Size(123, 204);
            listBoxSoup.TabIndex = 3;
            // 
            // listBoxDessert
            // 
            listBoxDessert.FormattingEnabled = true;
            listBoxDessert.Location = new Point(585, 84);
            listBoxDessert.Name = "listBoxDessert";
            listBoxDessert.Size = new Size(123, 204);
            listBoxDessert.TabIndex = 4;
          //  listBoxDessert.SelectedIndexChanged += listBoxDessert_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 62);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 5;
            label1.Text = "Meat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 62);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 6;
            label2.Text = "Fish";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 62);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 7;
            label3.Text = "Salad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(438, 62);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 8;
            label4.Text = "Soup";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(585, 50);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 9;
            label5.Text = "Dessert";
            // 
            // buttonAdmin
            // 
            buttonAdmin.Location = new Point(12, 12);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(126, 29);
            buttonAdmin.TabIndex = 10;
            buttonAdmin.Text = "Admin";
            buttonAdmin.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 360);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 11;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(62, 360);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(109, 32);
            buttonSearch.TabIndex = 12;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 433);
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
    }
}
