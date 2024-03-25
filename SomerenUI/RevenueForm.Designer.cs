namespace SomerenUI
{
    partial class RevenueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevenueForm));
            dateTimePickerStartDate = new DateTimePicker();
            groupBox1 = new GroupBox();
            lblTotalNumberOfDrinks = new Label();
            groupBox2 = new GroupBox();
            lblTotalTurnover = new Label();
            groupBox3 = new GroupBox();
            lblNumberOfCustomers = new Label();
            label1 = new Label();
            label2 = new Label();
            dateTimePickerEndDate = new DateTimePicker();
            btnGenerateReport = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.CalendarForeColor = Color.Coral;
            dateTimePickerStartDate.CalendarMonthBackground = SystemColors.InactiveBorder;
            dateTimePickerStartDate.Location = new Point(627, 69);
            dateTimePickerStartDate.Margin = new Padding(4);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(284, 31);
            dateTimePickerStartDate.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(lblTotalNumberOfDrinks);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(41, 69);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(286, 146);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Total Number Of Drinks";
            // 
            // lblTotalNumberOfDrinks
            // 
            lblTotalNumberOfDrinks.AutoSize = true;
            lblTotalNumberOfDrinks.Location = new Point(9, 69);
            lblTotalNumberOfDrinks.Margin = new Padding(4, 0, 4, 0);
            lblTotalNumberOfDrinks.Name = "lblTotalNumberOfDrinks";
            lblTotalNumberOfDrinks.Size = new Size(0, 30);
            lblTotalNumberOfDrinks.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.AppWorkspace;
            groupBox2.Controls.Add(lblTotalTurnover);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(41, 250);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(286, 147);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Total Turnover";
            // 
            // lblTotalTurnover
            // 
            lblTotalTurnover.AutoSize = true;
            lblTotalTurnover.Location = new Point(9, 71);
            lblTotalTurnover.Margin = new Padding(4, 0, 4, 0);
            lblTotalTurnover.Name = "lblTotalTurnover";
            lblTotalTurnover.Size = new Size(0, 30);
            lblTotalTurnover.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlDark;
            groupBox3.Controls.Add(lblNumberOfCustomers);
            groupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(41, 426);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(286, 147);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Number Of Customers";
            // 
            // lblNumberOfCustomers
            // 
            lblNumberOfCustomers.AutoSize = true;
            lblNumberOfCustomers.Location = new Point(9, 75);
            lblNumberOfCustomers.Margin = new Padding(4, 0, 4, 0);
            lblNumberOfCustomers.Name = "lblNumberOfCustomers";
            lblNumberOfCustomers.Size = new Size(0, 30);
            lblNumberOfCustomers.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(472, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 3;
            label1.Text = "Start Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(472, 165);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 4;
            label2.Text = "End Date:";
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Location = new Point(627, 164);
            dateTimePickerEndDate.Margin = new Padding(4);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(284, 31);
            dateTimePickerEndDate.TabIndex = 5;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.FromArgb(0, 192, 0);
            btnGenerateReport.Cursor = Cursors.Hand;
            btnGenerateReport.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerateReport.ForeColor = SystemColors.ButtonHighlight;
            btnGenerateReport.Image = (Image)resources.GetObject("btnGenerateReport.Image");
            btnGenerateReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerateReport.Location = new Point(540, 363);
            btnGenerateReport.Margin = new Padding(4);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(320, 97);
            btnGenerateReport.TabIndex = 6;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            // 
            // RevenueForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 662);
            Controls.Add(btnGenerateReport);
            Controls.Add(dateTimePickerEndDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePickerStartDate);
            Margin = new Padding(4);
            Name = "RevenueForm";
            Text = "Revenue Report Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerStartDate;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePickerEndDate;
        private Label lblTotalNumberOfDrinks;
        private Label lblTotalTurnover;
        private Label lblNumberOfCustomers;
        private Button btnGenerateReport;
    }
}