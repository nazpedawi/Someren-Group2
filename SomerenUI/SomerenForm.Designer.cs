﻿namespace SomerenUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenForm));
            ListViewRooms = new ListView();
            RoomNumber = new ColumnHeader();
            BuildingName = new ColumnHeader();
            RoomType = new ColumnHeader();
            NumberOfBeds = new ColumnHeader();
            labelRooms = new Label();
            RoomsPanel = new Panel();
            LecturersPanel = new Panel();
            label1 = new Label();
            ListViewLecturers = new ListView();
            LecturerFirstName = new ColumnHeader();
            LecturerLastName = new ColumnHeader();
            Age = new ColumnHeader();
            LecturerPhoneNumber = new ColumnHeader();
            StudentsPanel = new Panel();
            AddStudentbtn = new Button();
            UpdateStudentbtn = new Button();
            DeleteStudentbtn = new Button();
            ListViewStudents = new ListView();
            StudentNumber = new ColumnHeader();
            FirstName = new ColumnHeader();
            LastName = new ColumnHeader();
            Class = new ColumnHeader();
            PhoneNumber = new ColumnHeader();
            labelStudents = new Label();
            pictureBox1 = new PictureBox();
            toolStripStudents = new ToolStripLabel();
            toolStripLecturers = new ToolStripLabel();
            toolStripRooms = new ToolStripLabel();
            toolStripDrinks = new ToolStripLabel();
            toolStrip1 = new ToolStrip();
            toolStripOrders = new ToolStripLabel();
            toolStripRevenue = new ToolStripLabel();
            toolStripActivity = new ToolStripLabel();
            DrinksPanel = new Panel();
            DeleteDrinkbtn = new Button();
            UpdateDrinkbtn = new Button();
            AddDrinkbtn = new Button();
            ListViewDrinks = new ListView();
            DrinkName = new ColumnHeader();
            DrinkType = new ColumnHeader();
            DrinkPrice = new ColumnHeader();
            StockAmount = new ColumnHeader();
            Status = new ColumnHeader();
            Drinkslbl = new Label();
            ActivitiesPanel = new Panel();
            Participantbtn = new Button();
            Supervisorsbtn = new Button();
            ListViewActivities = new ListView();
            ActivityName = new ColumnHeader();
            StartDateTime = new ColumnHeader();
            EndDateTime = new ColumnHeader();
            label2 = new Label();
            RoomsPanel.SuspendLayout();
            LecturersPanel.SuspendLayout();
            StudentsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            DrinksPanel.SuspendLayout();
            ActivitiesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ListViewRooms
            // 
            ListViewRooms.BackColor = SystemColors.GradientActiveCaption;
            ListViewRooms.Columns.AddRange(new ColumnHeader[] { RoomNumber, BuildingName, RoomType, NumberOfBeds });
            ListViewRooms.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewRooms.Location = new Point(14, 35);
            ListViewRooms.Margin = new Padding(1);
            ListViewRooms.Name = "ListViewRooms";
            ListViewRooms.Size = new Size(593, 348);
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
            labelRooms.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelRooms.Location = new Point(11, 1);
            labelRooms.Margin = new Padding(4, 0, 4, 0);
            labelRooms.Name = "labelRooms";
            labelRooms.Size = new Size(79, 30);
            labelRooms.TabIndex = 3;
            labelRooms.Text = "Rooms";
            // 
            // RoomsPanel
            // 
            RoomsPanel.Controls.Add(labelRooms);
            RoomsPanel.Controls.Add(ListViewRooms);
            RoomsPanel.Location = new Point(111, 151);
            RoomsPanel.Margin = new Padding(1);
            RoomsPanel.Name = "RoomsPanel";
            RoomsPanel.Size = new Size(624, 396);
            RoomsPanel.TabIndex = 6;
            // 
            // LecturersPanel
            // 
            LecturersPanel.Controls.Add(label1);
            LecturersPanel.Controls.Add(ListViewLecturers);
            LecturersPanel.Location = new Point(110, 154);
            LecturersPanel.Margin = new Padding(1);
            LecturersPanel.Name = "LecturersPanel";
            LecturersPanel.Size = new Size(619, 396);
            LecturersPanel.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 0);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 30);
            label1.TabIndex = 0;
            label1.Text = "Lecturers";
            // 
            // ListViewLecturers
            // 
            ListViewLecturers.BackColor = SystemColors.GradientActiveCaption;
            ListViewLecturers.Columns.AddRange(new ColumnHeader[] { LecturerFirstName, LecturerLastName, Age, LecturerPhoneNumber });
            ListViewLecturers.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewLecturers.Location = new Point(11, 35);
            ListViewLecturers.Margin = new Padding(1);
            ListViewLecturers.Name = "ListViewLecturers";
            ListViewLecturers.Size = new Size(593, 333);
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
            // StudentsPanel
            // 
            StudentsPanel.Controls.Add(AddStudentbtn);
            StudentsPanel.Controls.Add(UpdateStudentbtn);
            StudentsPanel.Controls.Add(DeleteStudentbtn);
            StudentsPanel.Controls.Add(ListViewStudents);
            StudentsPanel.Controls.Add(labelStudents);
            StudentsPanel.Location = new Point(51, 154);
            StudentsPanel.Margin = new Padding(1);
            StudentsPanel.Name = "StudentsPanel";
            StudentsPanel.Size = new Size(765, 679);
            StudentsPanel.TabIndex = 7;
            // 
            // AddStudentbtn
            // 
            AddStudentbtn.BackColor = Color.FromArgb(0, 192, 0);
            AddStudentbtn.Cursor = Cursors.Hand;
            AddStudentbtn.ForeColor = Color.Transparent;
            AddStudentbtn.Location = new Point(5, 563);
            AddStudentbtn.Margin = new Padding(1);
            AddStudentbtn.Name = "AddStudentbtn";
            AddStudentbtn.Size = new Size(181, 62);
            AddStudentbtn.TabIndex = 14;
            AddStudentbtn.Text = "Add New Student";
            AddStudentbtn.UseVisualStyleBackColor = false;
            AddStudentbtn.Click += AddStudentbtn_Click;
            // 
            // UpdateStudentbtn
            // 
            UpdateStudentbtn.BackColor = SystemColors.ControlDark;
            UpdateStudentbtn.Cursor = Cursors.Hand;
            UpdateStudentbtn.ForeColor = Color.Transparent;
            UpdateStudentbtn.Location = new Point(273, 563);
            UpdateStudentbtn.Margin = new Padding(1);
            UpdateStudentbtn.Name = "UpdateStudentbtn";
            UpdateStudentbtn.Size = new Size(226, 62);
            UpdateStudentbtn.TabIndex = 13;
            UpdateStudentbtn.Text = "Update Student";
            UpdateStudentbtn.UseVisualStyleBackColor = false;
            UpdateStudentbtn.Click += UpdateStudentbtn_Click;
            // 
            // DeleteStudentbtn
            // 
            DeleteStudentbtn.BackColor = Color.Red;
            DeleteStudentbtn.Cursor = Cursors.Hand;
            DeleteStudentbtn.ForeColor = Color.Transparent;
            DeleteStudentbtn.Location = new Point(597, 563);
            DeleteStudentbtn.Margin = new Padding(1);
            DeleteStudentbtn.Name = "DeleteStudentbtn";
            DeleteStudentbtn.Size = new Size(164, 62);
            DeleteStudentbtn.TabIndex = 12;
            DeleteStudentbtn.Text = "Delete Student";
            DeleteStudentbtn.UseVisualStyleBackColor = false;
            DeleteStudentbtn.Click += DeleteStudentbtn_Click;
            // 
            // ListViewStudents
            // 
            ListViewStudents.Activation = ItemActivation.OneClick;
            ListViewStudents.BackColor = SystemColors.GradientActiveCaption;
            ListViewStudents.Columns.AddRange(new ColumnHeader[] { StudentNumber, FirstName, LastName, Class, PhoneNumber });
            ListViewStudents.Cursor = Cursors.Hand;
            ListViewStudents.FullRowSelect = true;
            ListViewStudents.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewStudents.Location = new Point(11, 35);
            ListViewStudents.Margin = new Padding(1);
            ListViewStudents.MultiSelect = false;
            ListViewStudents.Name = "ListViewStudents";
            ListViewStudents.Size = new Size(744, 507);
            ListViewStudents.TabIndex = 0;
            ListViewStudents.UseCompatibleStateImageBehavior = false;
            ListViewStudents.View = View.Details;
            // 
            // StudentNumber
            // 
            StudentNumber.Text = "Student Number";
            StudentNumber.Width = 160;
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
            Class.Width = 100;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Text = "Phone Number";
            PhoneNumber.Width = 150;
            // 
            // labelStudents
            // 
            labelStudents.AutoSize = true;
            labelStudents.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelStudents.Location = new Point(6, 1);
            labelStudents.Margin = new Padding(1, 0, 1, 0);
            labelStudents.Name = "labelStudents";
            labelStudents.Size = new Size(96, 30);
            labelStudents.TabIndex = 1;
            labelStudents.Text = "Students";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Enabled = false;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(34, 4);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 103);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // toolStripStudents
            // 
            toolStripStudents.BackColor = SystemColors.ControlDark;
            toolStripStudents.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripStudents.ForeColor = SystemColors.Control;
            toolStripStudents.Margin = new Padding(30, 2, 0, 3);
            toolStripStudents.Name = "toolStripStudents";
            toolStripStudents.Size = new Size(109, 68);
            toolStripStudents.Text = "Students";
            toolStripStudents.Click += toolStripStudents_Click;
            // 
            // toolStripLecturers
            // 
            toolStripLecturers.AutoSize = false;
            toolStripLecturers.ForeColor = SystemColors.Control;
            toolStripLecturers.Margin = new Padding(20, 2, 0, 3);
            toolStripLecturers.Name = "toolStripLecturers";
            toolStripLecturers.Size = new Size(114, 36);
            toolStripLecturers.Text = "Lecturers";
            toolStripLecturers.Click += toolStripLecturers_Click;
            // 
            // toolStripRooms
            // 
            toolStripRooms.AutoSize = false;
            toolStripRooms.ForeColor = SystemColors.Control;
            toolStripRooms.Margin = new Padding(20, 2, 0, 3);
            toolStripRooms.Name = "toolStripRooms";
            toolStripRooms.Size = new Size(87, 36);
            toolStripRooms.Text = "Rooms";
            toolStripRooms.Click += toolStripRooms_Click;
            // 
            // toolStripDrinks
            // 
            toolStripDrinks.AutoSize = false;
            toolStripDrinks.ForeColor = SystemColors.Control;
            toolStripDrinks.Margin = new Padding(20, 2, 0, 3);
            toolStripDrinks.Name = "toolStripDrinks";
            toolStripDrinks.Size = new Size(170, 36);
            toolStripDrinks.Text = "Drink Supplies";
            toolStripDrinks.Click += toolStripDrinks_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = SystemColors.WindowFrame;
            toolStrip1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripStudents, toolStripLecturers, toolStripRooms, toolStripDrinks, toolStripOrders, toolStripRevenue, toolStripActivity });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(200, 21, 10, 21);
            toolStrip1.Size = new Size(1486, 115);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripOrders
            // 
            toolStripOrders.AutoSize = false;
            toolStripOrders.ForeColor = Color.White;
            toolStripOrders.Margin = new Padding(20, 2, 0, 3);
            toolStripOrders.Name = "toolStripOrders";
            toolStripOrders.Size = new Size(73, 57);
            toolStripOrders.Text = "Orders";
            toolStripOrders.Click += toolStripOrders_Click;
            // 
            // toolStripRevenue
            // 
            toolStripRevenue.ForeColor = SystemColors.Control;
            toolStripRevenue.Margin = new Padding(20, 2, 0, 3);
            toolStripRevenue.Name = "toolStripRevenue";
            toolStripRevenue.Size = new Size(107, 68);
            toolStripRevenue.Text = "Revenue";
            toolStripRevenue.Click += toolStripRevenue_Click_1;
            // 
            // toolStripActivity
            // 
            toolStripActivity.ForeColor = SystemColors.Control;
            toolStripActivity.Margin = new Padding(20, 1, 0, 2);
            toolStripActivity.Name = "toolStripActivity";
            toolStripActivity.Size = new Size(112, 70);
            toolStripActivity.Text = "Activities";
            toolStripActivity.Click += toolStripActivity_Click;
            // 
            // DrinksPanel
            // 
            DrinksPanel.Controls.Add(DeleteDrinkbtn);
            DrinksPanel.Controls.Add(UpdateDrinkbtn);
            DrinksPanel.Controls.Add(AddDrinkbtn);
            DrinksPanel.Controls.Add(ListViewDrinks);
            DrinksPanel.Controls.Add(Drinkslbl);
            DrinksPanel.Location = new Point(56, 154);
            DrinksPanel.Margin = new Padding(1);
            DrinksPanel.Name = "DrinksPanel";
            DrinksPanel.Size = new Size(760, 504);
            DrinksPanel.TabIndex = 10;
            // 
            // DeleteDrinkbtn
            // 
            DeleteDrinkbtn.BackColor = Color.Red;
            DeleteDrinkbtn.Cursor = Cursors.Hand;
            DeleteDrinkbtn.ForeColor = Color.Transparent;
            DeleteDrinkbtn.Location = new Point(586, 421);
            DeleteDrinkbtn.Margin = new Padding(1);
            DeleteDrinkbtn.Name = "DeleteDrinkbtn";
            DeleteDrinkbtn.Size = new Size(164, 62);
            DeleteDrinkbtn.TabIndex = 11;
            DeleteDrinkbtn.Text = "Delete Drink";
            DeleteDrinkbtn.UseVisualStyleBackColor = false;
            DeleteDrinkbtn.Click += DeleteDrinkbtn_Click;
            // 
            // UpdateDrinkbtn
            // 
            UpdateDrinkbtn.BackColor = SystemColors.ControlDark;
            UpdateDrinkbtn.Cursor = Cursors.Hand;
            UpdateDrinkbtn.ForeColor = Color.Transparent;
            UpdateDrinkbtn.Location = new Point(266, 421);
            UpdateDrinkbtn.Margin = new Padding(1);
            UpdateDrinkbtn.Name = "UpdateDrinkbtn";
            UpdateDrinkbtn.Size = new Size(226, 62);
            UpdateDrinkbtn.TabIndex = 10;
            UpdateDrinkbtn.Text = "Update Drink";
            UpdateDrinkbtn.UseVisualStyleBackColor = false;
            UpdateDrinkbtn.Click += UpdateDrinkbtn_Click;
            // 
            // AddDrinkbtn
            // 
            AddDrinkbtn.BackColor = Color.FromArgb(0, 192, 0);
            AddDrinkbtn.Cursor = Cursors.Hand;
            AddDrinkbtn.ForeColor = Color.Transparent;
            AddDrinkbtn.Location = new Point(11, 421);
            AddDrinkbtn.Margin = new Padding(1);
            AddDrinkbtn.Name = "AddDrinkbtn";
            AddDrinkbtn.Size = new Size(181, 62);
            AddDrinkbtn.TabIndex = 9;
            AddDrinkbtn.Text = "Add New Drink";
            AddDrinkbtn.UseVisualStyleBackColor = false;
            AddDrinkbtn.Click += AddDrinkbtn_Click;
            // 
            // ListViewDrinks
            // 
            ListViewDrinks.Activation = ItemActivation.OneClick;
            ListViewDrinks.BackColor = SystemColors.GradientActiveCaption;
            ListViewDrinks.Columns.AddRange(new ColumnHeader[] { DrinkName, DrinkType, DrinkPrice, StockAmount, Status });
            ListViewDrinks.FullRowSelect = true;
            ListViewDrinks.GridLines = true;
            ListViewDrinks.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewDrinks.Location = new Point(11, 35);
            ListViewDrinks.Margin = new Padding(1);
            ListViewDrinks.MultiSelect = false;
            ListViewDrinks.Name = "ListViewDrinks";
            ListViewDrinks.Size = new Size(730, 311);
            ListViewDrinks.TabIndex = 8;
            ListViewDrinks.UseCompatibleStateImageBehavior = false;
            ListViewDrinks.View = View.Details;
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
            // Drinkslbl
            // 
            Drinkslbl.AutoSize = true;
            Drinkslbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Drinkslbl.Location = new Point(11, 1);
            Drinkslbl.Margin = new Padding(1, 0, 1, 0);
            Drinkslbl.Name = "Drinkslbl";
            Drinkslbl.Size = new Size(73, 30);
            Drinkslbl.TabIndex = 0;
            Drinkslbl.Text = "Drinks";
            // 
            // ActivitiesPanel
            // 
            ActivitiesPanel.Controls.Add(Participantbtn);
            ActivitiesPanel.Controls.Add(Supervisorsbtn);
            ActivitiesPanel.Controls.Add(ListViewActivities);
            ActivitiesPanel.Controls.Add(label2);
            ActivitiesPanel.Location = new Point(67, 153);
            ActivitiesPanel.Margin = new Padding(4);
            ActivitiesPanel.Name = "ActivitiesPanel";
            ActivitiesPanel.Size = new Size(637, 466);
            ActivitiesPanel.TabIndex = 11;
            // 
            // Participantbtn
            // 
            Participantbtn.BackColor = Color.FromArgb(0, 192, 0);
            Participantbtn.ForeColor = SystemColors.Control;
            Participantbtn.Location = new Point(346, 334);
            Participantbtn.Margin = new Padding(4);
            Participantbtn.Name = "Participantbtn";
            Participantbtn.Size = new Size(197, 84);
            Participantbtn.TabIndex = 4;
            Participantbtn.Text = "Check Participants";
            Participantbtn.UseVisualStyleBackColor = false;
            Participantbtn.Click += Participantbtn_Click;
            // 
            // Supervisorsbtn
            // 
            Supervisorsbtn.BackColor = Color.FromArgb(0, 192, 0);
            Supervisorsbtn.ForeColor = SystemColors.Control;
            Supervisorsbtn.Location = new Point(54, 334);
            Supervisorsbtn.Margin = new Padding(4);
            Supervisorsbtn.Name = "Supervisorsbtn";
            Supervisorsbtn.Size = new Size(197, 84);
            Supervisorsbtn.TabIndex = 3;
            Supervisorsbtn.Text = "Check supervisors";
            Supervisorsbtn.UseVisualStyleBackColor = false;
            Supervisorsbtn.Click += Supervisorsbtn_Click;
            // 
            // ListViewActivities
            // 
            ListViewActivities.Activation = ItemActivation.OneClick;
            ListViewActivities.BackColor = SystemColors.GradientActiveCaption;
            ListViewActivities.Columns.AddRange(new ColumnHeader[] { ActivityName, StartDateTime, EndDateTime });
            ListViewActivities.FullRowSelect = true;
            ListViewActivities.GridLines = true;
            ListViewActivities.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewActivities.Location = new Point(23, 54);
            ListViewActivities.Margin = new Padding(4);
            ListViewActivities.Name = "ListViewActivities";
            ListViewActivities.Size = new Size(568, 250);
            ListViewActivities.TabIndex = 2;
            ListViewActivities.UseCompatibleStateImageBehavior = false;
            ListViewActivities.View = View.Details;
            // 
            // ActivityName
            // 
            ActivityName.Text = "Activity Name ";
            ActivityName.Width = 190;
            // 
            // StartDateTime
            // 
            StartDateTime.Text = "Start Date and Time";
            StartDateTime.Width = 180;
            // 
            // EndDateTime
            // 
            EndDateTime.Text = "End Date and Time";
            EndDateTime.Width = 180;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 21);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(173, 30);
            label2.TabIndex = 0;
            label2.Text = "Select an activity";
            // 
            // SomerenForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 843);
            Controls.Add(ActivitiesPanel);
            Controls.Add(DrinksPanel);
            Controls.Add(LecturersPanel);
            Controls.Add(RoomsPanel);
            Controls.Add(StudentsPanel);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            Margin = new Padding(1);
            Name = "SomerenForm";
            Text = "Someren Form";
            RoomsPanel.ResumeLayout(false);
            RoomsPanel.PerformLayout();
            LecturersPanel.ResumeLayout(false);
            LecturersPanel.PerformLayout();
            StudentsPanel.ResumeLayout(false);
            StudentsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            DrinksPanel.ResumeLayout(false);
            DrinksPanel.PerformLayout();
            ActivitiesPanel.ResumeLayout(false);
            ActivitiesPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListView ListViewRooms;
        private ColumnHeader RoomNumber;
        private ColumnHeader BuildingName;
        private ColumnHeader RoomType;
        private ColumnHeader NumberOfBeds;
        private Label labelRooms;
        private Panel RoomsPanel;
        private Panel StudentsPanel;
        private Label labelStudents;
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
        private PictureBox pictureBox1;
        private ToolStripLabel toolStripStudents;
        private ToolStripLabel toolStripLecturers;
        private ToolStripLabel toolStripRooms;
        private ToolStripLabel toolStripDrinks;
        private ToolStrip toolStrip1;
        private Panel DrinksPanel;
        private ListView ListViewDrinks;
        private ColumnHeader DrinkName;
        private ColumnHeader DrinkType;
        private ColumnHeader DrinkPrice;
        private ColumnHeader StockAmount;
        private ColumnHeader Status;
        private Label Drinkslbl;
        private Button DeleteDrinkbtn;
        private Button UpdateDrinkbtn;
        private Button AddDrinkbtn;
        private ToolStripLabel toolStripOrders;
        private ToolStripLabel toolStripRevenue;
        private Panel ActivitiesPanel;
        private Label label2;
        private ListView ListViewActivities;
        private ColumnHeader ActivityName;
        private ColumnHeader StartDateTime;
        private ColumnHeader EndDateTime;
        private ToolStripLabel toolStripActivity;
        private Button Supervisorsbtn;
        private Button Participantbtn;
        private Button DeleteStudentbtn;
        private Button AddStudentbtn;
        private Button UpdateStudentbtn;
    }
}