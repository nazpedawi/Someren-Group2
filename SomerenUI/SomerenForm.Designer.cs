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
            ListViewRooms = new ListView();
            RoomNumber = new ColumnHeader();
            BuildingName = new ColumnHeader();
            RoomType = new ColumnHeader();
            NumberOfBeds = new ColumnHeader();
            labelRooms = new Label();
            RoomsPanel = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripRooms = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripStudents = new ToolStripLabel();
            toolStripLecturers = new ToolStripLabel();
            toolStripDrinks = new ToolStripLabel();
            StudentsPanel = new Panel();
            labelLecturers = new Label();
            ListViewStudents = new ListView();
            StudentNumber = new ColumnHeader();
            FirstName = new ColumnHeader();
            LastName = new ColumnHeader();
            Class = new ColumnHeader();
            PhoneNumber = new ColumnHeader();
            LecturersPanel = new Panel();
            label1 = new Label();
            ListViewLecturers = new ListView();
            LecturerFirstName = new ColumnHeader();
            LecturerLastName = new ColumnHeader();
            Age = new ColumnHeader();
            LecturerPhoneNumber = new ColumnHeader();
            RoomsPanel.SuspendLayout();
            toolStrip1.SuspendLayout();
            StudentsPanel.SuspendLayout();
            LecturersPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ListViewRooms
            // 
            ListViewRooms.BackColor = SystemColors.InactiveCaption;
            ListViewRooms.Columns.AddRange(new ColumnHeader[] { RoomNumber, BuildingName, RoomType, NumberOfBeds });
            ListViewRooms.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewRooms.Location = new Point(33, 43);
            ListViewRooms.Name = "ListViewRooms";
            ListViewRooms.Size = new Size(591, 348);
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
            labelRooms.Location = new Point(33, 15);
            labelRooms.Margin = new Padding(4, 0, 4, 0);
            labelRooms.Name = "labelRooms";
            labelRooms.Size = new Size(68, 25);
            labelRooms.TabIndex = 3;
            labelRooms.Text = "Rooms";
            // 
            // RoomsPanel
            // 
            RoomsPanel.Controls.Add(labelRooms);
            RoomsPanel.Controls.Add(ListViewRooms);
            RoomsPanel.Location = new Point(0, 34);
            RoomsPanel.Name = "RoomsPanel";
            RoomsPanel.Size = new Size(735, 433);
            RoomsPanel.TabIndex = 6;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripRooms, toolStripSeparator2, toolStripStudents, toolStripLecturers, toolStripDrinks });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1407, 30);
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
            toolStripStudents.Click += toolStripStudents_Click;
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
            toolStripDrinks.Size = new Size(126, 25);
            toolStripDrinks.Text = "Drink Supplies";
            toolStripDrinks.Click += toolStripDrinks_Click;
            // 
            // StudentsPanel
            // 
            StudentsPanel.Controls.Add(labelLecturers);
            StudentsPanel.Controls.Add(ListViewStudents);
            StudentsPanel.Location = new Point(12, 42);
            StudentsPanel.Name = "StudentsPanel";
            StudentsPanel.Size = new Size(748, 439);
            StudentsPanel.TabIndex = 7;
            // 
            // labelLecturers
            // 
            labelLecturers.AutoSize = true;
            labelLecturers.Location = new Point(33, 24);
            labelLecturers.Name = "labelLecturers";
            labelLecturers.Size = new Size(81, 25);
            labelLecturers.TabIndex = 1;
            labelLecturers.Text = "Students";
            // 
            // ListViewStudents
            // 
            ListViewStudents.BackColor = SystemColors.InactiveCaption;
            ListViewStudents.Columns.AddRange(new ColumnHeader[] { StudentNumber, FirstName, LastName, Class, PhoneNumber });
            ListViewStudents.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewStudents.Location = new Point(33, 52);
            ListViewStudents.Name = "ListViewStudents";
            ListViewStudents.Size = new Size(636, 348);
            ListViewStudents.TabIndex = 0;
            ListViewStudents.UseCompatibleStateImageBehavior = false;
            ListViewStudents.View = View.Details;
            // 
            // StudentNumber
            // 
            StudentNumber.Text = "Student Number";
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
            // Class
            // 
            Class.Text = "Class";
            Class.Width = 130;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Text = "Phone Number";
            PhoneNumber.Width = 150;
            // 
            // LecturersPanel
            // 
            LecturersPanel.Controls.Add(label1);
            LecturersPanel.Controls.Add(ListViewLecturers);
            LecturersPanel.Location = new Point(12, 33);
            LecturersPanel.Name = "LecturersPanel";
            LecturersPanel.Size = new Size(682, 437);
            LecturersPanel.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 16);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Lecturers";
            // 
            // ListViewLecturers
            // 
            ListViewLecturers.BackColor = SystemColors.InactiveCaption;
            ListViewLecturers.Columns.AddRange(new ColumnHeader[] { LecturerFirstName, LecturerLastName, Age, LecturerPhoneNumber });
            ListViewLecturers.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewLecturers.Location = new Point(13, 49);
            ListViewLecturers.Name = "ListViewLecturers";
            ListViewLecturers.Size = new Size(591, 348);
            ListViewLecturers.TabIndex = 8;
            ListViewLecturers.UseCompatibleStateImageBehavior = false;
            ListViewLecturers.View = View.Details;
            // 
            // LecturerFirstName
            // 
            LecturerFirstName.Text = "First Name";
            LecturerFirstName.Width = 140;
            // 
            // LecturerLastName
            // 
            LecturerLastName.Text = "Last Name";
            LecturerLastName.Width = 140;
            // 
            // Age
            // 
            Age.Text = "Age";
            Age.Width = 120;
            // 
            // LecturerPhoneNumber
            // 
            LecturerPhoneNumber.Text = "PhoneNumber";
            LecturerPhoneNumber.Width = 150;
            // 
            // SomerenForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 1050);
            Controls.Add(toolStrip1);
            Controls.Add(RoomsPanel);
            Controls.Add(LecturersPanel);
            Controls.Add(StudentsPanel);
            Name = "SomerenForm";
            Text = "Someren Form";
            RoomsPanel.ResumeLayout(false);
            RoomsPanel.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            StudentsPanel.ResumeLayout(false);
            StudentsPanel.PerformLayout();
            LecturersPanel.ResumeLayout(false);
            LecturersPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView ListViewRooms;
        private ColumnHeader RoomNumber;
        private ColumnHeader BuildingName;
        private ColumnHeader RoomType;
        private ColumnHeader NumberOfBeds;
        private Label labelRooms;
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripRooms;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripStudents;
        private Panel RoomsPanel;
        private ToolStripLabel toolStripLecturers;
        private ToolStripLabel toolStripDrinks;
        private Panel StudentsPanel;
        private Label labelLecturers;
        private ListView ListViewStudents;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private ColumnHeader Class;
        private ColumnHeader PhoneNumber;
        private ColumnHeader StudentNumber;
        private Label label1;
        private ListView ListViewLecturers;
        private ColumnHeader LecturerFirstName;
        private ColumnHeader LecturerLastName;
        private ColumnHeader Age;
        private ColumnHeader LecturerPhoneNumber;
        private Panel LecturersPanel;
    }
}