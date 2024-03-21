namespace SomerenUI
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
            ListViewLecturers = new ListView();
            FirstName = new ColumnHeader();
            LastName = new ColumnHeader();
            Age = new ColumnHeader();
            PhoneNumber = new ColumnHeader();
            labelLecturers = new Label();
            ListViewRooms = new ListView();
            RoomNumber = new ColumnHeader();
            BuildingName = new ColumnHeader();
            RoomType = new ColumnHeader();
            NumberOfBeds = new ColumnHeader();
            label1 = new Label();
            ListViewStudents = new ListView();
            columnHeader1 = new ColumnHeader();
            Studentlabel = new Label();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // ListViewLecturers
            // 
            ListViewLecturers.BackColor = SystemColors.InactiveCaption;
            ListViewLecturers.Columns.AddRange(new ColumnHeader[] { FirstName, LastName, Age, PhoneNumber });
            ListViewLecturers.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewLecturers.Location = new Point(31, 31);
            ListViewLecturers.Margin = new Padding(2);
            ListViewLecturers.Name = "ListViewLecturers";
            ListViewLecturers.Size = new Size(474, 203);
            ListViewLecturers.TabIndex = 0;
            ListViewLecturers.UseCompatibleStateImageBehavior = false;
            ListViewLecturers.View = View.Details;
            ListViewLecturers.SelectedIndexChanged += ListViewLecturers_SelectedIndexChanged;
            // 
            // FirstName
            // 
            FirstName.Text = "First Name";
            FirstName.Width = 120;
            // 
            // LastName
            // 
            LastName.Text = "Last Name";
            LastName.Width = 120;
            // 
            // Age
            // 
            Age.Text = "Age";
            Age.Width = 50;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Text = "Phone No.";
            PhoneNumber.Width = 120;
            // 
            // labelLecturers
            // 
            labelLecturers.AutoSize = true;
            labelLecturers.Location = new Point(27, 5);
            labelLecturers.Margin = new Padding(2, 0, 2, 0);
            labelLecturers.Name = "labelLecturers";
            labelLecturers.Size = new Size(68, 20);
            labelLecturers.TabIndex = 1;
            labelLecturers.Text = "Lecturers";
            // 
            // ListViewRooms
            // 
            ListViewRooms.BackColor = SystemColors.InactiveCaption;
            ListViewRooms.Columns.AddRange(new ColumnHeader[] { RoomNumber, BuildingName, RoomType, NumberOfBeds });
            ListViewRooms.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewRooms.Location = new Point(31, 300);
            ListViewRooms.Margin = new Padding(2);
            ListViewRooms.Name = "ListViewRooms";
            ListViewRooms.Size = new Size(553, 203);
            ListViewRooms.TabIndex = 2;
            ListViewRooms.UseCompatibleStateImageBehavior = false;
            ListViewRooms.View = View.Details;
            ListViewRooms.SelectedIndexChanged += ListViewRooms_SelectedIndexChanged_1;
            // 
            // RoomNumber
            // 
            RoomNumber.Text = "Room Number";
            RoomNumber.Width = 120;
            // 
            // BuildingName
            // 
            BuildingName.Text = "Building Name";
            BuildingName.Width = 120;
            // 
            // RoomType
            // 
            RoomType.Text = "Room Type";
            RoomType.Width = 120;
            // 
            // NumberOfBeds
            // 
            NumberOfBeds.Text = "Number Of Beds";
            NumberOfBeds.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 266);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 3;
            label1.Text = "Rooms";
            // 
            // ListViewStudents
            // 
            ListViewStudents.BackColor = SystemColors.InactiveCaption;
            ListViewStudents.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            ListViewStudents.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewStudents.Location = new Point(534, 31);
            ListViewStudents.Margin = new Padding(2);
            ListViewStudents.Name = "ListViewStudents";
            ListViewStudents.Size = new Size(424, 203);
            ListViewStudents.TabIndex = 0;
            ListViewStudents.UseCompatibleStateImageBehavior = false;
            ListViewStudents.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "First Name";
            columnHeader1.Width = 90;
            // 
            // Studentlabel
            // 
            Studentlabel.AutoSize = true;
            Studentlabel.Location = new Point(534, 5);
            Studentlabel.Name = "Studentlabel";
            Studentlabel.Size = new Size(66, 20);
            Studentlabel.TabIndex = 5;
            Studentlabel.Text = "Students";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Last Name";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Phone No.";
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Class";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 545);
            Controls.Add(Studentlabel);
            Controls.Add(ListViewStudents);
            Controls.Add(label1);
            Controls.Add(ListViewRooms);
            Controls.Add(labelLecturers);
            Controls.Add(ListViewLecturers);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private ListView ListViewLecturers;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private ColumnHeader Age;
        private ColumnHeader PhoneNumber;
        private Label labelLecturers;
        private ListView ListViewRooms;
        private ColumnHeader RoomNumber;
        private ColumnHeader BuildingName;
        private ColumnHeader RoomType;
        private ColumnHeader NumberOfBeds;
        private Label label1;
        private ListView ListViewStudents;
        private ColumnHeader columnHeader1;
        private Label Studentlabel;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}