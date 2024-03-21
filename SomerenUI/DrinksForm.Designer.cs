namespace SomerenUI
{
    partial class DrinksForm
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
            ListViewDrinks = new ListView();
            DrinkID = new ColumnHeader();
            DrinkName = new ColumnHeader();
            Type = new ColumnHeader();
            Price = new ColumnHeader();
            StockAmount = new ColumnHeader();
            Status = new ColumnHeader();
            AddDrinkbtn = new Button();
            DeleteDrinkbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DrinkNametxtbox = new TextBox();
            DrinkPricetxtbox = new TextBox();
            DrinkStocktxtbox = new TextBox();
            Alcoholicbtn = new RadioButton();
            NonAlcoholicbtn = new RadioButton();
            SuspendLayout();
            // 
            // ListViewDrinks
            // 
            ListViewDrinks.BackColor = SystemColors.InactiveCaption;
            ListViewDrinks.Columns.AddRange(new ColumnHeader[] { DrinkID, DrinkName, Type, Price, StockAmount, Status });
            ListViewDrinks.Location = new Point(58, 36);
            ListViewDrinks.Name = "ListViewDrinks";
            ListViewDrinks.Size = new Size(659, 257);
            ListViewDrinks.TabIndex = 7;
            ListViewDrinks.UseCompatibleStateImageBehavior = false;
            ListViewDrinks.View = View.Details;
            // 
            // DrinkID
            // 
            DrinkID.Text = "ID";
            // 
            // DrinkName
            // 
            DrinkName.Text = "Name";
            DrinkName.Width = 100;
            // 
            // Type
            // 
            Type.Text = "Type";
            Type.Width = 100;
            // 
            // Price
            // 
            Price.Text = "Price";
            // 
            // StockAmount
            // 
            StockAmount.Text = "Stock Amount";
            StockAmount.Width = 140;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.Width = 150;
            // 
            // AddDrinkbtn
            // 
            AddDrinkbtn.Location = new Point(570, 347);
            AddDrinkbtn.Name = "AddDrinkbtn";
            AddDrinkbtn.Size = new Size(183, 34);
            AddDrinkbtn.TabIndex = 8;
            AddDrinkbtn.Text = "Add New Drink";
            AddDrinkbtn.UseVisualStyleBackColor = true;
            AddDrinkbtn.Click += AddDrinkbtn_Click;
            // 
            // DeleteDrinkbtn
            // 
            DeleteDrinkbtn.Location = new Point(570, 427);
            DeleteDrinkbtn.Name = "DeleteDrinkbtn";
            DeleteDrinkbtn.Size = new Size(183, 34);
            DeleteDrinkbtn.TabIndex = 9;
            DeleteDrinkbtn.Text = "Delete Drink";
            DeleteDrinkbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 344);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 10;
            label1.Text = "Drink Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 397);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 11;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 447);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 12;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 502);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 13;
            label4.Text = "Stock Amount";
            // 
            // DrinkNametxtbox
            // 
            DrinkNametxtbox.Location = new Point(261, 345);
            DrinkNametxtbox.Name = "DrinkNametxtbox";
            DrinkNametxtbox.Size = new Size(150, 31);
            DrinkNametxtbox.TabIndex = 14;
            // 
            // DrinkPricetxtbox
            // 
            DrinkPricetxtbox.Location = new Point(251, 451);
            DrinkPricetxtbox.Name = "DrinkPricetxtbox";
            DrinkPricetxtbox.Size = new Size(150, 31);
            DrinkPricetxtbox.TabIndex = 15;
            // 
            // DrinkStocktxtbox
            // 
            DrinkStocktxtbox.Location = new Point(247, 500);
            DrinkStocktxtbox.Name = "DrinkStocktxtbox";
            DrinkStocktxtbox.Size = new Size(150, 31);
            DrinkStocktxtbox.TabIndex = 16;
            // 
            // Alcoholicbtn
            // 
            Alcoholicbtn.AutoSize = true;
            Alcoholicbtn.Location = new Point(258, 402);
            Alcoholicbtn.Name = "Alcoholicbtn";
            Alcoholicbtn.Size = new Size(109, 29);
            Alcoholicbtn.TabIndex = 17;
            Alcoholicbtn.TabStop = true;
            Alcoholicbtn.Text = "Alcoholic";
            Alcoholicbtn.UseVisualStyleBackColor = true;
            // 
            // NonAlcoholicbtn
            // 
            NonAlcoholicbtn.AutoSize = true;
            NonAlcoholicbtn.Location = new Point(399, 403);
            NonAlcoholicbtn.Name = "NonAlcoholicbtn";
            NonAlcoholicbtn.Size = new Size(150, 29);
            NonAlcoholicbtn.TabIndex = 18;
            NonAlcoholicbtn.TabStop = true;
            NonAlcoholicbtn.Text = "Non-Alcoholic";
            NonAlcoholicbtn.UseVisualStyleBackColor = true;
            // 
            // DrinksForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 555);
            Controls.Add(NonAlcoholicbtn);
            Controls.Add(Alcoholicbtn);
            Controls.Add(DrinkStocktxtbox);
            Controls.Add(DrinkPricetxtbox);
            Controls.Add(DrinkNametxtbox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DeleteDrinkbtn);
            Controls.Add(AddDrinkbtn);
            Controls.Add(ListViewDrinks);
            Name = "DrinksForm";
            Text = "Drinks Supplies";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView ListViewDrinks;
        private ColumnHeader DrinkID;
        private ColumnHeader DrinkName;
        private ColumnHeader Type;
        private ColumnHeader Price;
        private ColumnHeader StockAmount;
        private ColumnHeader Status;
        private Button AddDrinkbtn;
        private Button DeleteDrinkbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox DrinkNametxtbox;
        private TextBox DrinkPricetxtbox;
        private TextBox DrinkStocktxtbox;
        private RadioButton Alcoholicbtn;
        private RadioButton NonAlcoholicbtn;
    }
}