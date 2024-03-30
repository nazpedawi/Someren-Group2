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
            AddSupervisorbtn = new Button();
            SupervisationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SupervisationPanel
            // 
            SupervisationPanel.Controls.Add(AddSupervisorbtn);
            SupervisationPanel.Controls.Add(label2);
            SupervisationPanel.Controls.Add(label1);
            SupervisationPanel.Controls.Add(ListViewNonSupervisors);
            SupervisationPanel.Controls.Add(ListViewSupervisors);
            SupervisationPanel.Location = new Point(74, 32);
            SupervisationPanel.Name = "SupervisationPanel";
            SupervisationPanel.Size = new Size(953, 388);
            SupervisationPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(483, 9);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 6;
            label2.Text = "Non supervisors";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
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
            ListViewNonSupervisors.Location = new Point(483, 37);
            ListViewNonSupervisors.Name = "ListViewNonSupervisors";
            ListViewNonSupervisors.Size = new Size(384, 200);
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
            ListViewSupervisors.Location = new Point(18, 37);
            ListViewSupervisors.Name = "ListViewSupervisors";
            ListViewSupervisors.Size = new Size(384, 200);
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
            // AddSupervisorbtn
            // 
            AddSupervisorbtn.Location = new Point(93, 263);
            AddSupervisorbtn.Name = "AddSupervisorbtn";
            AddSupervisorbtn.Size = new Size(245, 92);
            AddSupervisorbtn.TabIndex = 7;
            AddSupervisorbtn.Text = "Add Supervisor";
            AddSupervisorbtn.UseVisualStyleBackColor = true;
            AddSupervisorbtn.Click += AddSupervisorbtn_Click;
            // 
            // SupervisorsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 524);
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
    }
}