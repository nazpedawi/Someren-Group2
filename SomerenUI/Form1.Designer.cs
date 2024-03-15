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
            SuspendLayout();
            // 
            // ListViewLecturers
            // 
            ListViewLecturers.BackColor = SystemColors.InactiveCaption;
            ListViewLecturers.Columns.AddRange(new ColumnHeader[] { FirstName, LastName, Age, PhoneNumber });
            ListViewLecturers.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewLecturers.Location = new Point(27, 26);
            ListViewLecturers.Margin = new Padding(2);
            ListViewLecturers.Name = "ListViewLecturers";
            ListViewLecturers.Size = new Size(415, 173);
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
            labelLecturers.Location = new Point(24, 4);
            labelLecturers.Margin = new Padding(2, 0, 2, 0);
            labelLecturers.Name = "labelLecturers";
            labelLecturers.Size = new Size(61, 17);
            labelLecturers.TabIndex = 1;
            labelLecturers.Text = "Lecturers";
            // 
            // ListViewRooms
            // 
            ListViewRooms.BackColor = SystemColors.InactiveCaption;
            ListViewRooms.Columns.AddRange(new ColumnHeader[] { RoomNumber, BuildingName, RoomType, NumberOfBeds });
            ListViewRooms.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewRooms.Location = new Point(27, 255);
            ListViewRooms.Margin = new Padding(2);
            ListViewRooms.Name = "ListViewRooms";
            ListViewRooms.Size = new Size(484, 173);
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
            label1.Location = new Point(24, 226);
            label1.Name = "label1";
            label1.Size = new Size(49, 17);
            label1.TabIndex = 3;
            label1.Text = "Rooms";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 463);
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
    }
}