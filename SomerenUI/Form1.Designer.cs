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
            SuspendLayout();
            // 
            // ListViewLecturers
            // 
            ListViewLecturers.BackColor = SystemColors.InactiveCaption;
            ListViewLecturers.Columns.AddRange(new ColumnHeader[] { FirstName, LastName, Age, PhoneNumber });
            ListViewLecturers.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewLecturers.Location = new Point(38, 38);
            ListViewLecturers.Name = "ListViewLecturers";
            ListViewLecturers.Size = new Size(445, 253);
            ListViewLecturers.TabIndex = 0;
            ListViewLecturers.UseCompatibleStateImageBehavior = false;
            ListViewLecturers.View = View.Details;
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
            labelLecturers.Location = new Point(34, 6);
            labelLecturers.Name = "labelLecturers";
            labelLecturers.Size = new Size(82, 25);
            labelLecturers.TabIndex = 1;
            labelLecturers.Text = "Lecturers";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 681);
            Controls.Add(labelLecturers);
            Controls.Add(ListViewLecturers);
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
    }
}