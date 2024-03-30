namespace SomerenUI
{
    partial class AddDrinksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDrinksForm));
            panel1 = new Panel();
            NonAlcoholicbtn = new RadioButton();
            Alcoholicbtn = new RadioButton();
            AddDrinkbtn = new Button();
            DrinkStockAmounttxtbox = new TextBox();
            DrinkPricetxtbox = new TextBox();
            DrinkNametxtbox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(NonAlcoholicbtn);
            panel1.Controls.Add(Alcoholicbtn);
            panel1.Controls.Add(AddDrinkbtn);
            panel1.Controls.Add(DrinkStockAmounttxtbox);
            panel1.Controls.Add(DrinkPricetxtbox);
            panel1.Controls.Add(DrinkNametxtbox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 18);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 225);
            panel1.TabIndex = 0;
            // 
            // NonAlcoholicbtn
            // 
            NonAlcoholicbtn.AutoSize = true;
            NonAlcoholicbtn.Location = new Point(341, 75);
            NonAlcoholicbtn.Margin = new Padding(2, 2, 2, 2);
            NonAlcoholicbtn.Name = "NonAlcoholicbtn";
            NonAlcoholicbtn.Size = new Size(126, 24);
            NonAlcoholicbtn.TabIndex = 9;
            NonAlcoholicbtn.TabStop = true;
            NonAlcoholicbtn.Text = "Non-Alcoholic";
            NonAlcoholicbtn.UseVisualStyleBackColor = true;
            // 
            // Alcoholicbtn
            // 
            Alcoholicbtn.AutoSize = true;
            Alcoholicbtn.Location = new Point(184, 75);
            Alcoholicbtn.Margin = new Padding(2, 2, 2, 2);
            Alcoholicbtn.Name = "Alcoholicbtn";
            Alcoholicbtn.Size = new Size(92, 24);
            Alcoholicbtn.TabIndex = 8;
            Alcoholicbtn.TabStop = true;
            Alcoholicbtn.Text = "Alcoholic";
            Alcoholicbtn.UseVisualStyleBackColor = true;
            // 
            // AddDrinkbtn
            // 
            AddDrinkbtn.BackColor = Color.FromArgb(0, 192, 0);
            AddDrinkbtn.Cursor = Cursors.Hand;
            AddDrinkbtn.ForeColor = Color.White;
            AddDrinkbtn.Image = (Image)resources.GetObject("AddDrinkbtn.Image");
            AddDrinkbtn.ImageAlign = ContentAlignment.MiddleLeft;
            AddDrinkbtn.Location = new Point(414, 129);
            AddDrinkbtn.Margin = new Padding(2, 2, 2, 2);
            AddDrinkbtn.Name = "AddDrinkbtn";
            AddDrinkbtn.Size = new Size(125, 66);
            AddDrinkbtn.TabIndex = 7;
            AddDrinkbtn.Text = "Add Drink";
            AddDrinkbtn.TextAlign = ContentAlignment.MiddleRight;
            AddDrinkbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddDrinkbtn.UseVisualStyleBackColor = false;
            AddDrinkbtn.Click += AddDrinkbtn_Click;
            // 
            // DrinkStockAmounttxtbox
            // 
            DrinkStockAmounttxtbox.BackColor = Color.FromArgb(255, 192, 255);
            DrinkStockAmounttxtbox.Location = new Point(184, 168);
            DrinkStockAmounttxtbox.Margin = new Padding(2, 2, 2, 2);
            DrinkStockAmounttxtbox.Name = "DrinkStockAmounttxtbox";
            DrinkStockAmounttxtbox.Size = new Size(88, 27);
            DrinkStockAmounttxtbox.TabIndex = 6;
            // 
            // DrinkPricetxtbox
            // 
            DrinkPricetxtbox.BackColor = Color.FromArgb(255, 192, 255);
            DrinkPricetxtbox.Location = new Point(184, 121);
            DrinkPricetxtbox.Margin = new Padding(2, 2, 2, 2);
            DrinkPricetxtbox.Name = "DrinkPricetxtbox";
            DrinkPricetxtbox.Size = new Size(74, 27);
            DrinkPricetxtbox.TabIndex = 5;
            // 
            // DrinkNametxtbox
            // 
            DrinkNametxtbox.BackColor = Color.FromArgb(255, 192, 255);
            DrinkNametxtbox.Location = new Point(184, 30);
            DrinkNametxtbox.Margin = new Padding(2, 2, 2, 2);
            DrinkNametxtbox.Name = "DrinkNametxtbox";
            DrinkNametxtbox.Size = new Size(143, 27);
            DrinkNametxtbox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(40, 168);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 3;
            label4.Text = "Stock Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 119);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 72);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 1;
            label2.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // AddDrinksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 251);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AddDrinksForm";
            Text = "AddDrinksForm";
            Load += AddDrinksForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private RadioButton NonAlcoholicbtn;
        private RadioButton Alcoholicbtn;
        private Button AddDrinkbtn;
        private TextBox DrinkStockAmounttxtbox;
        private TextBox DrinkPricetxtbox;
        private TextBox DrinkNametxtbox;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}