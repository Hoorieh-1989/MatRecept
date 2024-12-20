﻿namespace MatRecept
{
    partial class CreateRecipeForm
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
            textBoxInstructions = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            comboType = new ComboBox();
            textBoxIngredients = new TextBox();
            textBoxDescription = new TextBox();
            textBoxName = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBoxInstructions
            // 
            textBoxInstructions.Location = new Point(385, 260);
            textBoxInstructions.Margin = new Padding(3, 2, 3, 2);
            textBoxInstructions.Multiline = true;
            textBoxInstructions.Name = "textBoxInstructions";
            textBoxInstructions.Size = new Size(180, 79);
            textBoxInstructions.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(385, 248);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 34;
            label1.Text = "Instruction";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(384, 155);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 33;
            label3.Text = "Ingridients";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(385, 106);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 32;
            label2.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(385, 66);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 31;
            label5.Text = "Name";
            // 
            // comboType
            // 
            comboType.FormattingEnabled = true;
            comboType.Location = new Point(385, 36);
            comboType.Name = "comboType";
            comboType.Size = new Size(121, 23);
            comboType.TabIndex = 30;
            // 
            // textBoxIngredients
            // 
            textBoxIngredients.Location = new Point(385, 172);
            textBoxIngredients.Margin = new Padding(3, 2, 3, 2);
            textBoxIngredients.Multiline = true;
            textBoxIngredients.Name = "textBoxIngredients";
            textBoxIngredients.Size = new Size(180, 74);
            textBoxIngredients.TabIndex = 29;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(385, 122);
            textBoxDescription.Margin = new Padding(3, 2, 3, 2);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(180, 23);
            textBoxDescription.TabIndex = 28;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(385, 83);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(180, 23);
            textBoxName.TabIndex = 27;
            // 
            // button1
            // 
            button1.Location = new Point(46, 305);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 35;
            button1.Text = "Go back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonBack_Click;
            // 
            // button2
            // 
            button2.Location = new Point(163, 305);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 36;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonSave_Click;
            // 
            // CreateRecipeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(comboType);
            Controls.Add(textBoxIngredients);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(textBoxInstructions);
            Name = "CreateRecipeForm";
            Text = "CreateRecipeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInstructions;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label5;
        private ComboBox comboType;
        private TextBox textBoxIngredients;
        private TextBox textBoxDescription;
        private TextBox textBoxName;
        private Button button1;
        private Button button2;
    }
}