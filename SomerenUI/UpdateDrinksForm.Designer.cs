namespace SomerenUI
{
    partial class UpdateDrinksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDrinksForm));
            panel1 = new Panel();
            NonAlcoholicbtn = new RadioButton();
            Alcoholicbtn = new RadioButton();
            UpdateDrinkbtn = new Button();
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
            panel1.Controls.Add(UpdateDrinkbtn);
            panel1.Controls.Add(DrinkStockAmounttxtbox);
            panel1.Controls.Add(DrinkPricetxtbox);
            panel1.Controls.Add(DrinkNametxtbox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(40, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 281);
            panel1.TabIndex = 1;
            // 
            // NonAlcoholicbtn
            // 
            NonAlcoholicbtn.AutoSize = true;
            NonAlcoholicbtn.Location = new Point(426, 94);
            NonAlcoholicbtn.Name = "NonAlcoholicbtn";
            NonAlcoholicbtn.Size = new Size(150, 29);
            NonAlcoholicbtn.TabIndex = 9;
            NonAlcoholicbtn.TabStop = true;
            NonAlcoholicbtn.Text = "Non-Alcoholic";
            NonAlcoholicbtn.UseVisualStyleBackColor = true;
            // 
            // Alcoholicbtn
            // 
            Alcoholicbtn.AutoSize = true;
            Alcoholicbtn.Location = new Point(230, 94);
            Alcoholicbtn.Name = "Alcoholicbtn";
            Alcoholicbtn.Size = new Size(109, 29);
            Alcoholicbtn.TabIndex = 8;
            Alcoholicbtn.TabStop = true;
            Alcoholicbtn.Text = "Alcoholic";
            Alcoholicbtn.UseVisualStyleBackColor = true;
            // 
            // UpdateDrinkbtn
            // 
            UpdateDrinkbtn.BackColor = Color.FromArgb(0, 192, 0);
            UpdateDrinkbtn.Cursor = Cursors.Hand;
            UpdateDrinkbtn.ForeColor = Color.White;
            UpdateDrinkbtn.Image = (Image)resources.GetObject("UpdateDrinkbtn.Image");
            UpdateDrinkbtn.ImageAlign = ContentAlignment.MiddleLeft;
            UpdateDrinkbtn.Location = new Point(488, 187);
            UpdateDrinkbtn.Name = "UpdateDrinkbtn";
            UpdateDrinkbtn.Size = new Size(135, 64);
            UpdateDrinkbtn.TabIndex = 7;
            UpdateDrinkbtn.Text = "Update";
            UpdateDrinkbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            UpdateDrinkbtn.UseVisualStyleBackColor = false;
            UpdateDrinkbtn.Click += UpdateDrinkbtn_Click;
            // 
            // DrinkStockAmounttxtbox
            // 
            DrinkStockAmounttxtbox.BackColor = Color.FromArgb(255, 192, 255);
            DrinkStockAmounttxtbox.Location = new Point(230, 210);
            DrinkStockAmounttxtbox.Name = "DrinkStockAmounttxtbox";
            DrinkStockAmounttxtbox.Size = new Size(109, 31);
            DrinkStockAmounttxtbox.TabIndex = 6;
            // 
            // DrinkPricetxtbox
            // 
            DrinkPricetxtbox.BackColor = Color.FromArgb(255, 192, 255);
            DrinkPricetxtbox.Location = new Point(230, 151);
            DrinkPricetxtbox.Name = "DrinkPricetxtbox";
            DrinkPricetxtbox.Size = new Size(91, 31);
            DrinkPricetxtbox.TabIndex = 5;
            // 
            // DrinkNametxtbox
            // 
            DrinkNametxtbox.BackColor = Color.FromArgb(255, 192, 255);
            DrinkNametxtbox.Location = new Point(230, 37);
            DrinkNametxtbox.Name = "DrinkNametxtbox";
            DrinkNametxtbox.Size = new Size(178, 31);
            DrinkNametxtbox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(50, 210);
            label4.Name = "label4";
            label4.Size = new Size(148, 30);
            label4.TabIndex = 3;
            label4.Text = "Stock Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 149);
            label3.Name = "label3";
            label3.Size = new Size(60, 30);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 90);
            label2.Name = "label2";
            label2.Size = new Size(60, 30);
            label2.TabIndex = 1;
            label2.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 36);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // UpdateDrinksForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "UpdateDrinksForm";
            Text = "Update Drinks Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RadioButton NonAlcoholicbtn;
        private RadioButton Alcoholicbtn;
        private Button UpdateDrinkbtn;
        private TextBox DrinkStockAmounttxtbox;
        private TextBox DrinkPricetxtbox;
        private TextBox DrinkNametxtbox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}