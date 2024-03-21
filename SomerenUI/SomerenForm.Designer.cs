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
            panel1 = new Panel();
            ListViewStudents = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label1 = new Label();
            columnHeader5 = new ColumnHeader();
            LecturersPanel.SuspendLayout();
            RoomsPanel.SuspendLayout();
            toolStrip1.SuspendLayout();
            DrinksPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ListViewLecturers
            // 
            ListViewLecturers.BackColor = SystemColors.InactiveCaption;
            ListViewLecturers.Columns.AddRange(new ColumnHeader[] { FirstName, LastName, Age, PhoneNumber });
            ListViewLecturers.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewLecturers.Location = new Point(4, 29);
            ListViewLecturers.Margin = new Padding(2, 2, 2, 2);
            ListViewLecturers.Name = "ListViewLecturers";
            ListViewLecturers.Size = new Size(474, 203);
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
            ListViewRooms.Location = new Point(2, 30);
            ListViewRooms.Margin = new Padding(2, 2, 2, 2);
            ListViewRooms.Name = "ListViewRooms";
            ListViewRooms.Size = new Size(474, 203);
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
            labelRooms.Name = "labelRooms";
            labelRooms.Size = new Size(55, 20);
            labelRooms.TabIndex = 3;
            labelRooms.Text = "Rooms";
            // 
            // LecturersPanel
            // 
            LecturersPanel.Controls.Add(labelLecturers);
            LecturersPanel.Controls.Add(ListViewLecturers);
            LecturersPanel.Location = new Point(27, 30);
            LecturersPanel.Margin = new Padding(2, 2, 2, 2);
            LecturersPanel.Name = "LecturersPanel";
            LecturersPanel.Size = new Size(487, 233);
            LecturersPanel.TabIndex = 4;
            // 
            // labelLecturers
            // 
            labelLecturers.AutoSize = true;
            labelLecturers.Location = new Point(0, 3);
            labelLecturers.Margin = new Padding(2, 0, 2, 0);
            labelLecturers.Name = "labelLecturers";
            labelLecturers.Size = new Size(68, 20);
            labelLecturers.TabIndex = 1;
            labelLecturers.Text = "Lecturers";
            // 
            // RoomsPanel
            // 
            RoomsPanel.Controls.Add(ListViewRooms);
            RoomsPanel.Controls.Add(labelRooms);
            RoomsPanel.Location = new Point(519, 29);
            RoomsPanel.Margin = new Padding(2, 2, 2, 2);
            RoomsPanel.Name = "RoomsPanel";
            RoomsPanel.Size = new Size(504, 233);
            RoomsPanel.TabIndex = 6;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripRooms, toolStripSeparator2, toolStripStudents, toolStripLecturers, toolStripDrinks });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1054, 25);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripRooms
            // 
            toolStripRooms.Name = "toolStripRooms";
            toolStripRooms.Size = new Size(55, 22);
            toolStripRooms.Text = "Rooms";
            toolStripRooms.Click += toolStripRooms_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripStudents
            // 
            toolStripStudents.Name = "toolStripStudents";
            toolStripStudents.Size = new Size(66, 22);
            toolStripStudents.Text = "Students";
            // 
            // toolStripLecturers
            // 
            toolStripLecturers.Name = "toolStripLecturers";
            toolStripLecturers.Size = new Size(68, 22);
            toolStripLecturers.Text = "Lecturers";
            toolStripLecturers.Click += toolStripLecturers_Click;
            // 
            // toolStripDrinks
            // 
            toolStripDrinks.Name = "toolStripDrinks";
            toolStripDrinks.Size = new Size(50, 22);
            toolStripDrinks.Text = "Drinks";
            toolStripDrinks.Click += toolStripDrinks_Click;
            // 
            // DrinksPanel
            // 
            DrinksPanel.Controls.Add(labelDrinks);
            DrinksPanel.Controls.Add(ListViewDrinks);
            DrinksPanel.Location = new Point(27, 283);
            DrinksPanel.Margin = new Padding(2, 2, 2, 2);
            DrinksPanel.Name = "DrinksPanel";
            DrinksPanel.Size = new Size(499, 244);
            DrinksPanel.TabIndex = 7;
            // 
            // labelDrinks
            // 
            labelDrinks.AutoSize = true;
            labelDrinks.Location = new Point(2, 6);
            labelDrinks.Margin = new Padding(2, 0, 2, 0);
            labelDrinks.Name = "labelDrinks";
            labelDrinks.Size = new Size(50, 20);
            labelDrinks.TabIndex = 1;
            labelDrinks.Text = "Drinks";
            // 
            // ListViewDrinks
            // 
            ListViewDrinks.BackColor = SystemColors.InactiveCaption;
            ListViewDrinks.Columns.AddRange(new ColumnHeader[] { DrinkName, Type, Price, StockAmount });
            ListViewDrinks.Location = new Point(7, 27);
            ListViewDrinks.Margin = new Padding(2, 2, 2, 2);
            ListViewDrinks.Name = "ListViewDrinks";
            ListViewDrinks.Size = new Size(474, 203);
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
            // panel1
            // 
            panel1.Controls.Add(ListViewStudents);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(539, 289);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 233);
            panel1.TabIndex = 8;
            // 
            // ListViewStudents
            // 
            ListViewStudents.BackColor = SystemColors.InactiveCaption;
            ListViewStudents.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            ListViewStudents.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewStudents.Location = new Point(2, 28);
            ListViewStudents.Margin = new Padding(2);
            ListViewStudents.Name = "ListViewStudents";
            ListViewStudents.Size = new Size(474, 203);
            ListViewStudents.TabIndex = 2;
            ListViewStudents.UseCompatibleStateImageBehavior = false;
            ListViewStudents.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Student Number";
            columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "First Name";
            columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Last Name";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Class";
            columnHeader4.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-1, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 3;
            label1.Text = "Students";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Phone No.";
            columnHeader5.Width = 150;
            // 
            // SomerenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 690);
            Controls.Add(panel1);
            Controls.Add(DrinksPanel);
            Controls.Add(toolStrip1);
            Controls.Add(LecturersPanel);
            Controls.Add(RoomsPanel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "SomerenForm";
            Text = "Someren Form";
            Load += SomerenForm_Load;
            LecturersPanel.ResumeLayout(false);
            LecturersPanel.PerformLayout();
            RoomsPanel.ResumeLayout(false);
            RoomsPanel.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            DrinksPanel.ResumeLayout(false);
            DrinksPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private ListView ListViewStudents;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label1;
    }
}