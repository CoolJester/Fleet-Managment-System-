namespace FLEET_SYSTEM1._0
{
    partial class TripsAndUsage_Scrn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnTrips_Daily = new System.Windows.Forms.Button();
            this.btnTrips_Weekly = new System.Windows.Forms.Button();
            this.btnTrips_Monthly = new System.Windows.Forms.Button();
            this.tripGrid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtTimesheetID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tripGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trips ";
            // 
            // btnTrips_Daily
            // 
            this.btnTrips_Daily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrips_Daily.FlatAppearance.BorderSize = 0;
            this.btnTrips_Daily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrips_Daily.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTrips_Daily.Location = new System.Drawing.Point(49, 79);
            this.btnTrips_Daily.Name = "btnTrips_Daily";
            this.btnTrips_Daily.Size = new System.Drawing.Size(75, 23);
            this.btnTrips_Daily.TabIndex = 1;
            this.btnTrips_Daily.Text = "Daily";
            this.btnTrips_Daily.UseVisualStyleBackColor = true;
            this.btnTrips_Daily.Click += new System.EventHandler(this.btnTrips_Daily_Click);
            // 
            // btnTrips_Weekly
            // 
            this.btnTrips_Weekly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrips_Weekly.FlatAppearance.BorderSize = 0;
            this.btnTrips_Weekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrips_Weekly.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTrips_Weekly.Location = new System.Drawing.Point(130, 79);
            this.btnTrips_Weekly.Name = "btnTrips_Weekly";
            this.btnTrips_Weekly.Size = new System.Drawing.Size(75, 23);
            this.btnTrips_Weekly.TabIndex = 2;
            this.btnTrips_Weekly.Text = "Weekly";
            this.btnTrips_Weekly.UseVisualStyleBackColor = true;
            // 
            // btnTrips_Monthly
            // 
            this.btnTrips_Monthly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrips_Monthly.FlatAppearance.BorderSize = 0;
            this.btnTrips_Monthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrips_Monthly.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTrips_Monthly.Location = new System.Drawing.Point(211, 79);
            this.btnTrips_Monthly.Name = "btnTrips_Monthly";
            this.btnTrips_Monthly.Size = new System.Drawing.Size(75, 23);
            this.btnTrips_Monthly.TabIndex = 3;
            this.btnTrips_Monthly.Text = "Monthly";
            this.btnTrips_Monthly.UseVisualStyleBackColor = true;
            // 
            // tripGrid
            // 
            this.tripGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tripGrid.Location = new System.Drawing.Point(49, 118);
            this.tripGrid.Name = "tripGrid";
            this.tripGrid.Size = new System.Drawing.Size(548, 398);
            this.tripGrid.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete Record";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.txtEmployeeID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.txtTimesheetID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(603, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 168);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(9, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Search by Employee";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(9, 108);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(305, 20);
            this.txtEmployeeID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter the employee number";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Search by Timesheet";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtTimesheetID
            // 
            this.txtTimesheetID.Location = new System.Drawing.Point(9, 35);
            this.txtTimesheetID.Name = "txtTimesheetID";
            this.txtTimesheetID.Size = new System.Drawing.Size(305, 20);
            this.txtTimesheetID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter the timesheet number";
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(613, 292);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(304, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "RESET";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // TripsAndUsage_Scrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tripGrid);
            this.Controls.Add(this.btnTrips_Monthly);
            this.Controls.Add(this.btnTrips_Weekly);
            this.Controls.Add(this.btnTrips_Daily);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TripsAndUsage_Scrn";
            this.Size = new System.Drawing.Size(959, 587);
            this.Load += new System.EventHandler(this.TripsAndUsage_Scrn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tripGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrips_Daily;
        private System.Windows.Forms.Button btnTrips_Weekly;
        private System.Windows.Forms.Button btnTrips_Monthly;
        private System.Windows.Forms.DataGridView tripGrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtTimesheetID;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button7;
    }
}
