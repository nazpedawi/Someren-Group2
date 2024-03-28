namespace SomerenUI
{
    partial class UpdateStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStudentForm));
            panel1 = new Panel();
            UpdateStudentbtn = new Button();
            StudentNumbertxtbox = new MaskedTextBox();
            PhoneNumbertxtbox = new MaskedTextBox();
            RoomNumbercombobox = new ComboBox();
            Classcombobox = new ComboBox();
            Studentnumberlbl = new Label();
            LastNametxtbox = new TextBox();
            lastnamelbl = new Label();
            FirstNametxtbox = new TextBox();
            label4 = new Label();
            phonenumberlbl = new Label();
            classlbl = new Label();
            firstnamelbl = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(UpdateStudentbtn);
            panel1.Controls.Add(StudentNumbertxtbox);
            panel1.Controls.Add(PhoneNumbertxtbox);
            panel1.Controls.Add(RoomNumbercombobox);
            panel1.Controls.Add(Classcombobox);
            panel1.Controls.Add(Studentnumberlbl);
            panel1.Controls.Add(LastNametxtbox);
            panel1.Controls.Add(lastnamelbl);
            panel1.Controls.Add(FirstNametxtbox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(phonenumberlbl);
            panel1.Controls.Add(classlbl);
            panel1.Controls.Add(firstnamelbl);
            panel1.Location = new Point(40, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 347);
            panel1.TabIndex = 2;
            // 
            // UpdateStudentbtn
            // 
            UpdateStudentbtn.BackColor = Color.FromArgb(0, 192, 0);
            UpdateStudentbtn.Cursor = Cursors.Hand;
            UpdateStudentbtn.ForeColor = Color.White;
            UpdateStudentbtn.Image = (Image)resources.GetObject("UpdateStudentbtn.Image");
            UpdateStudentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            UpdateStudentbtn.Location = new Point(465, 245);
            UpdateStudentbtn.Name = "UpdateStudentbtn";
            UpdateStudentbtn.Size = new Size(135, 64);
            UpdateStudentbtn.TabIndex = 14;
            UpdateStudentbtn.Text = "Update";
            UpdateStudentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            UpdateStudentbtn.UseVisualStyleBackColor = false;
            UpdateStudentbtn.Click += UpdateStudentbtn_Click;
            // 
            // StudentNumbertxtbox
            // 
            StudentNumbertxtbox.BackColor = Color.FromArgb(255, 192, 255);
            StudentNumbertxtbox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            StudentNumbertxtbox.Location = new Point(205, 29);
            StudentNumbertxtbox.Mask = "000000";
            StudentNumbertxtbox.Name = "StudentNumbertxtbox";
            StudentNumbertxtbox.Size = new Size(106, 37);
            StudentNumbertxtbox.TabIndex = 1;
            StudentNumbertxtbox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // PhoneNumbertxtbox
            // 
            PhoneNumbertxtbox.BackColor = Color.FromArgb(255, 192, 255);
            PhoneNumbertxtbox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumbertxtbox.Location = new Point(297, 190);
            PhoneNumbertxtbox.Mask = "000000000";
            PhoneNumbertxtbox.Name = "PhoneNumbertxtbox";
            PhoneNumbertxtbox.Size = new Size(128, 37);
            PhoneNumbertxtbox.TabIndex = 5;
            // 
            // RoomNumbercombobox
            // 
            RoomNumbercombobox.BackColor = SystemColors.InactiveCaption;
            RoomNumbercombobox.Cursor = Cursors.Hand;
            RoomNumbercombobox.FormattingEnabled = true;
            RoomNumbercombobox.Items.AddRange(new object[] { "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120" });
            RoomNumbercombobox.Location = new Point(205, 246);
            RoomNumbercombobox.Name = "RoomNumbercombobox";
            RoomNumbercombobox.Size = new Size(178, 33);
            RoomNumbercombobox.TabIndex = 6;
            RoomNumbercombobox.Text = "-- Select a room";
            // 
            // Classcombobox
            // 
            Classcombobox.BackColor = SystemColors.InactiveCaption;
            Classcombobox.Cursor = Cursors.Hand;
            Classcombobox.FormattingEnabled = true;
            Classcombobox.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F" });
            Classcombobox.Location = new Point(205, 135);
            Classcombobox.Name = "Classcombobox";
            Classcombobox.Size = new Size(178, 33);
            Classcombobox.TabIndex = 4;
            Classcombobox.Text = "-- Select a class";
            // 
            // Studentnumberlbl
            // 
            Studentnumberlbl.AutoSize = true;
            Studentnumberlbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Studentnumberlbl.Location = new Point(25, 29);
            Studentnumberlbl.Name = "Studentnumberlbl";
            Studentnumberlbl.Size = new Size(173, 30);
            Studentnumberlbl.TabIndex = 13;
            Studentnumberlbl.Text = "Student Number";
            // 
            // LastNametxtbox
            // 
            LastNametxtbox.BackColor = Color.FromArgb(255, 192, 255);
            LastNametxtbox.Location = new Point(501, 88);
            LastNametxtbox.Name = "LastNametxtbox";
            LastNametxtbox.Size = new Size(161, 31);
            LastNametxtbox.TabIndex = 3;
            // 
            // lastnamelbl
            // 
            lastnamelbl.AutoSize = true;
            lastnamelbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lastnamelbl.Location = new Point(379, 88);
            lastnamelbl.Name = "lastnamelbl";
            lastnamelbl.Size = new Size(114, 30);
            lastnamelbl.TabIndex = 10;
            lastnamelbl.Text = "Last Name";
            // 
            // FirstNametxtbox
            // 
            FirstNametxtbox.BackColor = Color.FromArgb(255, 192, 255);
            FirstNametxtbox.Location = new Point(205, 88);
            FirstNametxtbox.Name = "FirstNametxtbox";
            FirstNametxtbox.Size = new Size(155, 31);
            FirstNametxtbox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 245);
            label4.Name = "label4";
            label4.Size = new Size(156, 30);
            label4.TabIndex = 3;
            label4.Text = "Room Number";
            // 
            // phonenumberlbl
            // 
            phonenumberlbl.AutoSize = true;
            phonenumberlbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            phonenumberlbl.Location = new Point(25, 190);
            phonenumberlbl.Name = "phonenumberlbl";
            phonenumberlbl.Size = new Size(250, 30);
            phonenumberlbl.TabIndex = 2;
            phonenumberlbl.Text = "Phone Number (9 digits)";
            // 
            // classlbl
            // 
            classlbl.AutoSize = true;
            classlbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            classlbl.Location = new Point(25, 135);
            classlbl.Name = "classlbl";
            classlbl.Size = new Size(61, 30);
            classlbl.TabIndex = 1;
            classlbl.Text = "Class";
            // 
            // firstnamelbl
            // 
            firstnamelbl.AutoSize = true;
            firstnamelbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            firstnamelbl.Location = new Point(25, 88);
            firstnamelbl.Name = "firstnamelbl";
            firstnamelbl.Size = new Size(117, 30);
            firstnamelbl.TabIndex = 0;
            firstnamelbl.Text = "First Name";
            // 
            // UpdateStudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "UpdateStudentForm";
            Text = "Update Student Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaskedTextBox StudentNumbertxtbox;
        private MaskedTextBox PhoneNumbertxtbox;
        private ComboBox RoomNumbercombobox;
        private ComboBox Classcombobox;
        private Label Studentnumberlbl;
        private TextBox LastNametxtbox;
        private Label lastnamelbl;
        private TextBox FirstNametxtbox;
        private Label label4;
        private Label phonenumberlbl;
        private Label classlbl;
        private Label firstnamelbl;
        private Button UpdateStudentbtn;
    }
}