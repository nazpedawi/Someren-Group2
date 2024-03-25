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
            dateTimePickerStartDate.Format = DateTimePickerFormat.Short;
            dateTimePickerStartDate.Location = new Point(560, 46);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(200, 23);
            dateTimePickerStartDate.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTotalNumberOfDrinks);
            groupBox1.Location = new Point(29, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Total Number Of Drinks";
            // 
            // lblTotalNumberOfDrinks
            // 
            lblTotalNumberOfDrinks.AutoSize = true;
            lblTotalNumberOfDrinks.Location = new Point(6, 39);
            lblTotalNumberOfDrinks.Name = "lblTotalNumberOfDrinks";
            lblTotalNumberOfDrinks.Size = new Size(36, 17);
            lblTotalNumberOfDrinks.TabIndex = 0;
            lblTotalNumberOfDrinks.Text = "label";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTotalTurnover);
            groupBox2.Location = new Point(29, 170);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Total Turnover";
            // 
            // lblTotalTurnover
            // 
            lblTotalTurnover.AutoSize = true;
            lblTotalTurnover.Location = new Point(6, 48);
            lblTotalTurnover.Name = "lblTotalTurnover";
            lblTotalTurnover.Size = new Size(36, 17);
            lblTotalTurnover.TabIndex = 0;
            lblTotalTurnover.Text = "label";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblNumberOfCustomers);
            groupBox3.Location = new Point(29, 290);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Number Of Customers";
            // 
            // lblNumberOfCustomers
            // 
            lblNumberOfCustomers.AutoSize = true;
            lblNumberOfCustomers.Location = new Point(6, 50);
            lblNumberOfCustomers.Name = "lblNumberOfCustomers";
            lblNumberOfCustomers.Size = new Size(36, 17);
            lblNumberOfCustomers.TabIndex = 0;
            lblNumberOfCustomers.Text = "label";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(466, 51);
            label1.Name = "label1";
            label1.Size = new Size(88, 17);
            label1.TabIndex = 3;
            label1.Text = "Starting Time:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 164);
            label2.Name = "label2";
            label2.Size = new Size(83, 17);
            label2.TabIndex = 4;
            label2.Text = "Ending Time:";
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Format = DateTimePickerFormat.Short;
            dateTimePickerEndDate.Location = new Point(560, 164);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(200, 23);
            dateTimePickerEndDate.TabIndex = 5;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(466, 247);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(294, 23);
            btnGenerateReport.TabIndex = 6;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click_1;
            // 
            // RevenueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenerateReport);
            Controls.Add(dateTimePickerEndDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePickerStartDate);
            Name = "RevenueForm";
            Text = "Form1";
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