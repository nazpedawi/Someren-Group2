namespace SomerenUI
{
    partial class SomerenForm
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
            ListViewLecturers = new ListView();
            FirstName = new ColumnHeader();
            LastName = new ColumnHeader();
            Age = new ColumnHeader();
            PhoneNumber = new ColumnHeader();
            ListViewRooms = new ListView();
            RoomNumber = new ColumnHeader();
            BuildingName = new ColumnHeader();
            RoomType = new ColumnHeader();
            NumberOfBeds = new ColumnHeader();
            labelRooms = new Label();
            LecturersPanel = new Panel();
            labelLecturers = new Label();
            RoomsPanel = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripRooms = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripStudents = new ToolStripLabel();
            toolStripLecturers = new ToolStripLabel();
            toolStripDrinks = new ToolStripLabel();
            DrinksPanel = new Panel();
            labelDrinks = new Label();
            ListViewDrinks = new ListView();
            DrinkName = new ColumnHeader();
            Type = new ColumnHeader();
            Price = new ColumnHeader();
            StockAmount = new ColumnHeader();
            LecturersPanel.SuspendLayout();
            RoomsPanel.SuspendLayout();
            toolStrip1.SuspendLayout();
            DrinksPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ListViewLecturers
            // 
            ListViewLecturers.BackColor = SystemColors.InactiveCaption;
            ListViewLecturers.Columns.AddRange(new ColumnHeader[] { FirstName, LastName, Age, PhoneNumber });
            ListViewLecturers.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewLecturers.Location = new Point(5, 36);
            ListViewLecturers.Name = "ListViewLecturers";
            ListViewLecturers.Size = new Size(591, 253);
            ListViewLecturers.TabIndex = 0;
            ListViewLecturers.UseCompatibleStateImageBehavior = false;
            ListViewLecturers.View = View.Details;
            // 
            // FirstName
            // 
            FirstName.Text = "First Name";
            FirstName.Width = 140;
            // 
            // LastName
            // 
            LastName.Text = "Last Name";
            LastName.Width = 140;
            // 
            // Age
            // 
            Age.Text = "Age";
            Age.Width = 130;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Text = "Phone Number";
            PhoneNumber.Width = 150;
            // 
            // ListViewRooms
            // 
            ListViewRooms.BackColor = SystemColors.InactiveCaption;
            ListViewRooms.Columns.AddRange(new ColumnHeader[] { RoomNumber, BuildingName, RoomType, NumberOfBeds });
            ListViewRooms.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewRooms.Location = new Point(3, 38);
            ListViewRooms.Name = "ListViewRooms";
            ListViewRooms.Size = new Size(591, 253);
            ListViewRooms.TabIndex = 2;
            ListViewRooms.UseCompatibleStateImageBehavior = false;
            ListViewRooms.View = View.Details;
            // 
            // RoomNumber
            // 
            RoomNumber.Text = "Room Number";
            RoomNumber.Width = 140;
            // 
            // BuildingName
            // 
            BuildingName.Text = "Building Name";
            BuildingName.Width = 140;
            // 
            // RoomType
            // 
            RoomType.Text = "Room Type";
            RoomType.Width = 120;
            // 
            // NumberOfBeds
            // 
            NumberOfBeds.Text = "Number Of Beds";
            NumberOfBeds.Width = 150;
            // 
            // labelRooms
            // 
            labelRooms.AutoSize = true;
            labelRooms.Location = new Point(-1, 0);
            labelRooms.Margin = new Padding(4, 0, 4, 0);
            labelRooms.Name = "labelRooms";
            labelRooms.Size = new Size(68, 25);
            labelRooms.TabIndex = 3;
            labelRooms.Text = "Rooms";
            // 
            // LecturersPanel
            // 
            LecturersPanel.Controls.Add(labelLecturers);
            LecturersPanel.Controls.Add(ListViewLecturers);
            LecturersPanel.Location = new Point(34, 38);
            LecturersPanel.Name = "LecturersPanel";
            LecturersPanel.Size = new Size(609, 291);
            LecturersPanel.TabIndex = 4;
            // 
            // labelLecturers
            // 
            labelLecturers.AutoSize = true;
            labelLecturers.Location = new Point(0, 4);
            labelLecturers.Name = "labelLecturers";
            labelLecturers.Size = new Size(82, 25);
            labelLecturers.TabIndex = 1;
            labelLecturers.Text = "Lecturers";
            // 
            // RoomsPanel
            // 
            RoomsPanel.Controls.Add(ListViewRooms);
            RoomsPanel.Controls.Add(labelRooms);
            RoomsPanel.Location = new Point(649, 36);
            RoomsPanel.Name = "RoomsPanel";
            RoomsPanel.Size = new Size(630, 291);
            RoomsPanel.TabIndex = 6;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripRooms, toolStripSeparator2, toolStripStudents, toolStripLecturers, toolStripDrinks });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1318, 30);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 30);
            // 
            // toolStripRooms
            // 
            toolStripRooms.Name = "toolStripRooms";
            toolStripRooms.Size = new Size(68, 25);
            toolStripRooms.Text = "Rooms";
            toolStripRooms.Click += toolStripRooms_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 30);
            // 
            // toolStripStudents
            // 
            toolStripStudents.Name = "toolStripStudents";
            toolStripStudents.Size = new Size(81, 25);
            toolStripStudents.Text = "Students";
            // 
            // toolStripLecturers
            // 
            toolStripLecturers.Name = "toolStripLecturers";
            toolStripLecturers.Size = new Size(82, 25);
            toolStripLecturers.Text = "Lecturers";
            toolStripLecturers.Click += toolStripLecturers_Click;
            // 
            // toolStripDrinks
            // 
            toolStripDrinks.Name = "toolStripDrinks";
            toolStripDrinks.Size = new Size(62, 25);
            toolStripDrinks.Text = "Drinks";
            toolStripDrinks.Click += toolStripDrinks_Click;
            // 
            // DrinksPanel
            // 
            DrinksPanel.Controls.Add(labelDrinks);
            DrinksPanel.Controls.Add(ListViewDrinks);
            DrinksPanel.Location = new Point(34, 354);
            DrinksPanel.Name = "DrinksPanel";
            DrinksPanel.Size = new Size(624, 305);
            DrinksPanel.TabIndex = 7;
            // 
            // labelDrinks
            // 
            labelDrinks.AutoSize = true;
            labelDrinks.Location = new Point(3, 7);
            labelDrinks.Name = "labelDrinks";
            labelDrinks.Size = new Size(62, 25);
            labelDrinks.TabIndex = 1;
            labelDrinks.Text = "Drinks";
            // 
            // ListViewDrinks
            // 
            ListViewDrinks.BackColor = SystemColors.InactiveCaption;
            ListViewDrinks.Columns.AddRange(new ColumnHeader[] { DrinkName, Type, Price, StockAmount });
            ListViewDrinks.Location = new Point(9, 34);
            ListViewDrinks.Name = "ListViewDrinks";
            ListViewDrinks.Size = new Size(591, 253);
            ListViewDrinks.TabIndex = 0;
            ListViewDrinks.UseCompatibleStateImageBehavior = false;
            ListViewDrinks.View = View.Details;
            // 
            // DrinkName
            // 
            DrinkName.Text = "Name";
            DrinkName.Width = 130;
            // 
            // Type
            // 
            Type.Text = "Type";
            Type.Width = 150;
            // 
            // Price
            // 
            Price.Text = "Price";
            Price.Width = 80;
            // 
            // StockAmount
            // 
            StockAmount.Text = "Stock Amount";
            StockAmount.Width = 140;
            // 
            // SomerenForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 862);
            Controls.Add(DrinksPanel);
            Controls.Add(toolStrip1);
            Controls.Add(LecturersPanel);
            Controls.Add(RoomsPanel);
            Name = "SomerenForm";
            Text = "Someren Form";
            LecturersPanel.ResumeLayout(false);
            LecturersPanel.PerformLayout();
            RoomsPanel.ResumeLayout(false);
            RoomsPanel.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            DrinksPanel.ResumeLayout(false);
            DrinksPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ListViewLecturers;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private ColumnHeader Age;
        private ColumnHeader PhoneNumber;
        private ListView ListViewRooms;
        private ColumnHeader RoomNumber;
        private ColumnHeader BuildingName;
        private ColumnHeader RoomType;
        private ColumnHeader NumberOfBeds;
        private Label labelRooms;
        private Panel LecturersPanel;
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripRooms;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripStudents;
        private Label labelLecturers;
        private Panel RoomsPanel;
        private ToolStripLabel toolStripLecturers;
        private ToolStripLabel toolStripDrinks;
        private Panel DrinksPanel;
        private ListView ListViewDrinks;
        private ColumnHeader DrinkName;
        private ColumnHeader Type;
        private ColumnHeader Price;
        private ColumnHeader StockAmount;
        private Label labelDrinks;
    }
}