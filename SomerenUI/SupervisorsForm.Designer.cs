namespace SomerenUI
{
    partial class SupervisorsForm
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
            SupervisationPanel = new Panel();
            DeleteSupervisorbtn = new Button();
            AddSupervisorbtn = new Button();
            label2 = new Label();
            label1 = new Label();
            ListViewNonSupervisors = new ListView();
            name = new ColumnHeader();
            last = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            ListViewSupervisors = new ListView();
            FirstName = new ColumnHeader();
            LastName = new ColumnHeader();
            Age = new ColumnHeader();
            PhoneNumber = new ColumnHeader();
            SupervisationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SupervisationPanel
            // 
            SupervisationPanel.Controls.Add(DeleteSupervisorbtn);
            SupervisationPanel.Controls.Add(AddSupervisorbtn);
            SupervisationPanel.Controls.Add(label2);
            SupervisationPanel.Controls.Add(label1);
            SupervisationPanel.Controls.Add(ListViewNonSupervisors);
            SupervisationPanel.Controls.Add(ListViewSupervisors);
            SupervisationPanel.Location = new Point(65, 27);
            SupervisationPanel.Name = "SupervisationPanel";
            SupervisationPanel.Size = new Size(834, 330);
            SupervisationPanel.TabIndex = 0;
            // 
            // DeleteSupervisorbtn
            // 
            DeleteSupervisorbtn.BackColor = Color.Red;
            DeleteSupervisorbtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteSupervisorbtn.ForeColor = SystemColors.Control;
            DeleteSupervisorbtn.Location = new Point(464, 224);
            DeleteSupervisorbtn.Name = "DeleteSupervisorbtn";
            DeleteSupervisorbtn.Size = new Size(214, 78);
            DeleteSupervisorbtn.TabIndex = 8;
            DeleteSupervisorbtn.Text = "Delete supervisor";
            DeleteSupervisorbtn.UseVisualStyleBackColor = false;
            DeleteSupervisorbtn.Click += DeleteSupervisorbtn_Click;
            // 
            // AddSupervisorbtn
            // 
            AddSupervisorbtn.BackColor = Color.FromArgb(0, 192, 0);
            AddSupervisorbtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            AddSupervisorbtn.ForeColor = SystemColors.Control;
            AddSupervisorbtn.Location = new Point(88, 224);
            AddSupervisorbtn.Name = "AddSupervisorbtn";
            AddSupervisorbtn.Size = new Size(214, 78);
            AddSupervisorbtn.TabIndex = 7;
            AddSupervisorbtn.Text = "Add Supervisor";
            AddSupervisorbtn.UseVisualStyleBackColor = false;
            AddSupervisorbtn.Click += AddSupervisorbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(423, 8);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 6;
            label2.Text = "Non supervisors";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 8);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 5;
            label1.Text = "Supervisors";
            // 
            // ListViewNonSupervisors
            // 
            ListViewNonSupervisors.Activation = ItemActivation.OneClick;
            ListViewNonSupervisors.BackColor = SystemColors.GradientActiveCaption;
            ListViewNonSupervisors.Columns.AddRange(new ColumnHeader[] { name, last, columnHeader3, columnHeader1 });
            ListViewNonSupervisors.FullRowSelect = true;
            ListViewNonSupervisors.GridLines = true;
            ListViewNonSupervisors.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewNonSupervisors.Location = new Point(423, 31);
            ListViewNonSupervisors.Name = "ListViewNonSupervisors";
            ListViewNonSupervisors.Size = new Size(336, 171);
            ListViewNonSupervisors.TabIndex = 4;
            ListViewNonSupervisors.UseCompatibleStateImageBehavior = false;
            ListViewNonSupervisors.View = View.Details;
            // 
            // name
            // 
            name.Text = "First Name ";
            name.Width = 110;
            // 
            // last
            // 
            last.Text = "Last Name";
            last.Width = 110;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Age";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Phone No.";
            columnHeader1.Width = 100;
            // 
            // ListViewSupervisors
            // 
            ListViewSupervisors.Activation = ItemActivation.OneClick;
            ListViewSupervisors.BackColor = SystemColors.GradientActiveCaption;
            ListViewSupervisors.Columns.AddRange(new ColumnHeader[] { FirstName, LastName, Age, PhoneNumber });
            ListViewSupervisors.FullRowSelect = true;
            ListViewSupervisors.GridLines = true;
            ListViewSupervisors.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewSupervisors.Location = new Point(16, 31);
            ListViewSupervisors.Name = "ListViewSupervisors";
            ListViewSupervisors.Size = new Size(336, 171);
            ListViewSupervisors.TabIndex = 3;
            ListViewSupervisors.UseCompatibleStateImageBehavior = false;
            ListViewSupervisors.View = View.Details;
            // 
            // FirstName
            // 
            FirstName.Text = "First Name";
            FirstName.Width = 110;
            // 
            // LastName
            // 
            LastName.Text = "Last Name";
            LastName.Width = 110;
            // 
            // Age
            // 
            Age.Text = "Age";
            // 
            // PhoneNumber
            // 
            PhoneNumber.Text = "Phone No.";
            PhoneNumber.Width = 100;
            // 
            // SupervisorsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 445);
            Controls.Add(SupervisationPanel);
            Name = "SupervisorsForm";
            Text = "SupervisorsForm";
            SupervisationPanel.ResumeLayout(false);
            SupervisationPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SupervisationPanel;
        private ListView ListViewNonSupervisors;
        private ColumnHeader name;
        private ColumnHeader last;
        private ColumnHeader columnHeader3;
        private ListView ListViewSupervisors;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private ColumnHeader Age;
        private ColumnHeader PhoneNumber;
        private ColumnHeader columnHeader1;
        private Label label2;
        private Label label1;
        private Button AddSupervisorbtn;
        private Button DeleteSupervisorbtn;
    }
}