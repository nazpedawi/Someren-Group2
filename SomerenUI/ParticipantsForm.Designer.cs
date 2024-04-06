namespace SomerenUI
{
    partial class ParticipantsForm
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
            ParticipationPanel = new Panel();
            DeleteParticipantbtn = new Button();
            AddParticipantbtn = new Button();
            label2 = new Label();
            label1 = new Label();
            ListViewNonParticipants = new ListView();
            name = new ColumnHeader();
            last = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            ListViewParticipants = new ListView();
            FirstName = new ColumnHeader();
            LastName = new ColumnHeader();
            Class = new ColumnHeader();
            PhoneNumber = new ColumnHeader();
            ParticipationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ParticipationPanel
            // 
            ParticipationPanel.Controls.Add(DeleteParticipantbtn);
            ParticipationPanel.Controls.Add(AddParticipantbtn);
            ParticipationPanel.Controls.Add(label2);
            ParticipationPanel.Controls.Add(label1);
            ParticipationPanel.Controls.Add(ListViewNonParticipants);
            ParticipationPanel.Controls.Add(ListViewParticipants);
            ParticipationPanel.Location = new Point(35, 60);
            ParticipationPanel.Name = "ParticipationPanel";
            ParticipationPanel.Size = new Size(834, 330);
            ParticipationPanel.TabIndex = 1;
            // 
            // DeleteParticipantbtn
            // 
            DeleteParticipantbtn.BackColor = Color.Red;
            DeleteParticipantbtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteParticipantbtn.ForeColor = SystemColors.Control;
            DeleteParticipantbtn.Location = new Point(464, 224);
            DeleteParticipantbtn.Name = "DeleteParticipantbtn";
            DeleteParticipantbtn.Size = new Size(214, 78);
            DeleteParticipantbtn.TabIndex = 8;
            DeleteParticipantbtn.Text = "Delete participant";
            DeleteParticipantbtn.UseVisualStyleBackColor = false;
            DeleteParticipantbtn.Click += DeleteParticipantbtn_Click;
            // 
            // AddParticipantbtn
            // 
            AddParticipantbtn.BackColor = Color.FromArgb(0, 192, 0);
            AddParticipantbtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            AddParticipantbtn.ForeColor = SystemColors.Control;
            AddParticipantbtn.Location = new Point(88, 224);
            AddParticipantbtn.Name = "AddParticipantbtn";
            AddParticipantbtn.Size = new Size(214, 78);
            AddParticipantbtn.TabIndex = 7;
            AddParticipantbtn.Text = "Add Participant";
            AddParticipantbtn.UseVisualStyleBackColor = false;
            AddParticipantbtn.Click += AddParticipantbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(423, 8);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 6;
            label2.Text = "Non participants";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 8);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 5;
            label1.Text = "Participants";
            // 
            // ListViewNonParticipants
            // 
            ListViewNonParticipants.Activation = ItemActivation.OneClick;
            ListViewNonParticipants.BackColor = SystemColors.GradientActiveCaption;
            ListViewNonParticipants.Columns.AddRange(new ColumnHeader[] { name, last, columnHeader3, columnHeader1 });
            ListViewNonParticipants.FullRowSelect = true;
            ListViewNonParticipants.GridLines = true;
            ListViewNonParticipants.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewNonParticipants.Location = new Point(423, 31);
            ListViewNonParticipants.Name = "ListViewNonParticipants";
            ListViewNonParticipants.Size = new Size(336, 171);
            ListViewNonParticipants.TabIndex = 4;
            ListViewNonParticipants.UseCompatibleStateImageBehavior = false;
            ListViewNonParticipants.View = View.Details;
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
            columnHeader3.Text = "Class";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Phone No.";
            columnHeader1.Width = 100;
            // 
            // ListViewParticipants
            // 
            ListViewParticipants.Activation = ItemActivation.OneClick;
            ListViewParticipants.BackColor = SystemColors.GradientActiveCaption;
            ListViewParticipants.Columns.AddRange(new ColumnHeader[] { FirstName, LastName, Class, PhoneNumber });
            ListViewParticipants.FullRowSelect = true;
            ListViewParticipants.GridLines = true;
            ListViewParticipants.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ListViewParticipants.Location = new Point(16, 31);
            ListViewParticipants.Name = "ListViewParticipants";
            ListViewParticipants.Size = new Size(336, 171);
            ListViewParticipants.TabIndex = 3;
            ListViewParticipants.UseCompatibleStateImageBehavior = false;
            ListViewParticipants.View = View.Details;
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
            // Class
            // 
            Class.Text = "Class";
            // 
            // PhoneNumber
            // 
            PhoneNumber.Text = "Phone No.";
            PhoneNumber.Width = 100;
            // 
            // ParticipantsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 450);
            Controls.Add(ParticipationPanel);
            Name = "ParticipantsForm";
            Text = "ParticipantsForm";
            ParticipationPanel.ResumeLayout(false);
            ParticipationPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ParticipationPanel;
        private Button DeleteParticipantbtn;
        private Button AddParticipantbtn;
        private Label label2;
        private Label label1;
        private ListView ListViewNonParticipants;
        private ColumnHeader name;
        private ColumnHeader last;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader1;
        private ListView ListViewParticipants;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private ColumnHeader Class;
        private ColumnHeader PhoneNumber;
    }
}