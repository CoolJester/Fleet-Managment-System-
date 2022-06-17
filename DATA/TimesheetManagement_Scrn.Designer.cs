namespace FLEET_SYSTEM1._0
{
    partial class TimesheetManagement_Scrn
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnEmpSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.myGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtQuick = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timesheet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // btnEmpSearch
            // 
            this.btnEmpSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpSearch.FlatAppearance.BorderSize = 0;
            this.btnEmpSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpSearch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEmpSearch.Location = new System.Drawing.Point(677, 149);
            this.btnEmpSearch.Name = "btnEmpSearch";
            this.btnEmpSearch.Size = new System.Drawing.Size(66, 20);
            this.btnEmpSearch.TabIndex = 2;
            this.btnEmpSearch.Text = "Search";
            this.btnEmpSearch.UseVisualStyleBackColor = true;
            this.btnEmpSearch.Click += new System.EventHandler(this.btnEmpSearch_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(243, 149);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 20);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(401, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(519, 149);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(152, 20);
            this.txtSurname.TabIndex = 5;
            // 
            // myGrid
            // 
            this.myGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myGrid.Location = new System.Drawing.Point(108, 185);
            this.myGrid.Name = "myGrid";
            this.myGrid.Size = new System.Drawing.Size(677, 353);
            this.myGrid.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter Employee ID or Timesheet ID for quick search";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(534, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "RESET DATA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtQuick
            // 
            this.txtQuick.Location = new System.Drawing.Point(322, 86);
            this.txtQuick.Name = "txtQuick";
            this.txtQuick.Size = new System.Drawing.Size(206, 20);
            this.txtQuick.TabIndex = 10;
            this.txtQuick.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TimesheetManagement_Scrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.txtQuick);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.myGrid);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnEmpSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TimesheetManagement_Scrn";
            this.Size = new System.Drawing.Size(959, 587);
            this.Load += new System.EventHandler(this.TimesheetManagement_Scrn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEmpSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.DataGridView myGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtQuick;
    }
}
