namespace SomerenUI
{
    partial class OrdersForm
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
            PanelOrders = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ListViewDrinks = new ListView();
            DrinkName = new ColumnHeader();
            DrinkType = new ColumnHeader();
            DrinkPrice = new ColumnHeader();
            StockAmount = new ColumnHeader();
            Status = new ColumnHeader();
            ListViewStudents = new ListView();
            StudentNumber = new ColumnHeader();
            FirstName = new ColumnHeader();
            LastName = new ColumnHeader();
            Class = new ColumnHeader();
            Phone = new ColumnHeader();
            PanelOrders.SuspendLayout();
            SuspendLayout();
            // 
            // PanelOrders
            // 
            PanelOrders.Controls.Add(button1);
            PanelOrders.Controls.Add(textBox1);
            PanelOrders.Controls.Add(label3);
            PanelOrders.Controls.Add(label2);
            PanelOrders.Controls.Add(label1);
            PanelOrders.Controls.Add(ListViewDrinks);
            PanelOrders.Controls.Add(ListViewStudents);
            PanelOrders.Location = new Point(15, 66);
            PanelOrders.Margin = new Padding(4);
            PanelOrders.Name = "PanelOrders";
            PanelOrders.Size = new Size(1296, 612);
            PanelOrders.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(419, 478);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(291, 77);
            button1.TabIndex = 14;
            button1.Text = "Place order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(596, 420);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 31);
            textBox1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(307, 418);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(240, 30);
            label3.TabIndex = 12;
            label3.Text = "Enter number of drinks:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(581, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 30);
            label2.TabIndex = 11;
            label2.Text = "Select drink";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 30);
            label1.TabIndex = 10;
            label1.Text = "Select student";
            // 
            // ListViewDrinks
            // 
            ListViewDrinks.Activation = ItemActivation.OneClick;
            ListViewDrinks.BackColor = SystemColors.GradientActiveCaption;
            ListViewDrinks.Columns.AddRange(new ColumnHeader[] { DrinkName, DrinkType, DrinkPrice, StockAmount, Status });
            ListViewDrinks.FullRowSelect = true;
            ListViewDrinks.GridLines = true;
            ListViewDrinks.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewDrinks.Location = new Point(586, 40);
            ListViewDrinks.Margin = new Padding(2);
            ListViewDrinks.Name = "ListViewDrinks";
            ListViewDrinks.Size = new Size(700, 332);
            ListViewDrinks.TabIndex = 9;
            ListViewDrinks.UseCompatibleStateImageBehavior = false;
            ListViewDrinks.View = View.Details;
            ListViewDrinks.SelectedIndexChanged += ListViewDrinks_SelectedIndexChanged;
            // 
            // DrinkName
            // 
            DrinkName.Text = "Name";
            DrinkName.Width = 140;
            // 
            // DrinkType
            // 
            DrinkType.Text = "Type";
            DrinkType.Width = 140;
            // 
            // DrinkPrice
            // 
            DrinkPrice.Text = "Price";
            DrinkPrice.Width = 90;
            // 
            // StockAmount
            // 
            StockAmount.Text = "Stock Amount";
            StockAmount.Width = 130;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.Width = 190;
            // 
            // ListViewStudents
            // 
            ListViewStudents.Activation = ItemActivation.OneClick;
            ListViewStudents.BackColor = SystemColors.GradientActiveCaption;
            ListViewStudents.Columns.AddRange(new ColumnHeader[] { StudentNumber, FirstName, LastName, Class, Phone });
            ListViewStudents.FullRowSelect = true;
            ListViewStudents.GridLines = true;
            ListViewStudents.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewStudents.Location = new Point(15, 42);
            ListViewStudents.Margin = new Padding(4);
            ListViewStudents.Name = "ListViewStudents";
            ListViewStudents.Size = new Size(525, 332);
            ListViewStudents.TabIndex = 0;
            ListViewStudents.UseCompatibleStateImageBehavior = false;
            ListViewStudents.View = View.Details;
            ListViewStudents.SelectedIndexChanged += ListViewStudents_SelectedIndexChanged;
            // 
            // StudentNumber
            // 
            StudentNumber.Text = "Student No.";
            StudentNumber.Width = 90;
            // 
            // FirstName
            // 
            FirstName.Text = "First Name";
            FirstName.Width = 100;
            // 
            // LastName
            // 
            LastName.Text = "Last Name";
            LastName.Width = 100;
            // 
            // Class
            // 
            Class.Text = "Class";
            Class.Width = 50;
            // 
            // Phone
            // 
            Phone.Text = "Phone No.";
            Phone.Width = 100;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 694);
            Controls.Add(PanelOrders);
            Margin = new Padding(4);
            Name = "OrdersForm";
            Text = "OrdersForm";
            Load += OrdersForm_Load;
            PanelOrders.ResumeLayout(false);
            PanelOrders.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelOrders;
        private ListView ListViewStudents;
        private ColumnHeader StudentNumber;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private ColumnHeader Class;
        private ColumnHeader Phone;
        private ListView ListViewDrinks;
        private ColumnHeader DrinkName;
        private ColumnHeader DrinkType;
        private ColumnHeader DrinkPrice;
        private ColumnHeader StockAmount;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private ColumnHeader Status;
    }
}