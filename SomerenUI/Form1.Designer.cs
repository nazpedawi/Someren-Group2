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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label1 = new Label();
            SuspendLayout();
            // 
            // ListViewLecturers
            // 
            ListViewLecturers.BackColor = SystemColors.InactiveCaption;
            ListViewLecturers.Columns.AddRange(new ColumnHeader[] { FirstName, LastName, Age, PhoneNumber });
            ListViewLecturers.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewLecturers.Location = new Point(27, 26);
            ListViewLecturers.Margin = new Padding(2, 2, 2, 2);
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
            // listView1
            // 
            listView1.BackColor = SystemColors.InactiveCaption;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(27, 255);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(484, 173);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Room Number";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Building Name";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Room Type";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Number of bed";
            columnHeader4.Width = 120;
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
            Controls.Add(listView1);
            Controls.Add(labelLecturers);
            Controls.Add(ListViewLecturers);
            Margin = new Padding(2, 2, 2, 2);
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
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label1;
    }
}