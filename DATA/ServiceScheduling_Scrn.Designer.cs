namespace FLEET_SYSTEM1._0
{
    partial class ServiceScheduling_Scrn
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.txtVehicleNumber = new System.Windows.Forms.TextBox();
            this.vehicleServicingScheduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wILDatabaseDataSet2 = new FLEET_SYSTEM1._0.WILDatabaseDataSet2();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServices1 = new System.Windows.Forms.TextBox();
            this.dateAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServices2 = new System.Windows.Forms.TextBox();
            this.txtServices4 = new System.Windows.Forms.TextBox();
            this.txtServices3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProcedureCode = new System.Windows.Forms.TextBox();
            this.gridCallService = new System.Windows.Forms.DataGridView();
            this.vehicleScheduleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCompletedService = new System.Windows.Forms.DataGridView();
            this.vehicleScheduleIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDescriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSchedule_Daily = new System.Windows.Forms.Button();
            this.btnSchedule_Weekly = new System.Windows.Forms.Button();
            this.btnSchedule_Yearly = new System.Windows.Forms.Button();
            this.btnSchedule_Monthly = new System.Windows.Forms.Button();
            this.vehicleServicingScheduleTableAdapter1 = new FLEET_SYSTEM1._0.WILDatabaseDataSet2TableAdapters.VehicleServicingScheduleTableAdapter();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtProcedureCode2 = new System.Windows.Forms.TextBox();
            this.dateAppointmentDate2 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleServicingScheduleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wILDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCallService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompletedService)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedule a Servicing";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSchedule.Location = new System.Drawing.Point(363, 250);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(75, 23);
            this.btnSchedule.TabIndex = 2;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // txtVehicleNumber
            // 
            this.txtVehicleNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleServicingScheduleBindingSource1, "VehicleID", true));
            this.txtVehicleNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtVehicleNumber.Location = new System.Drawing.Point(152, 64);
            this.txtVehicleNumber.Name = "txtVehicleNumber";
            this.txtVehicleNumber.Size = new System.Drawing.Size(140, 20);
            this.txtVehicleNumber.TabIndex = 3;
            this.txtVehicleNumber.Text = "VEH_";
            this.txtVehicleNumber.TextChanged += new System.EventHandler(this.txtVehicleNumber_TextChanged);
            // 
            // vehicleServicingScheduleBindingSource1
            // 
            this.vehicleServicingScheduleBindingSource1.DataMember = "VehicleServicingSchedule";
            this.vehicleServicingScheduleBindingSource1.DataSource = this.wILDatabaseDataSet2;
            // 
            // wILDatabaseDataSet2
            // 
            this.wILDatabaseDataSet2.DataSetName = "WILDatabaseDataSet2";
            this.wILDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Appointment date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtServices1
            // 
            this.txtServices1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleServicingScheduleBindingSource1, "ServiceDescription", true));
            this.txtServices1.Location = new System.Drawing.Point(152, 169);
            this.txtServices1.Name = "txtServices1";
            this.txtServices1.Size = new System.Drawing.Size(140, 20);
            this.txtServices1.TabIndex = 5;
            this.txtServices1.TextChanged += new System.EventHandler(this.txtServices1_TextChanged);
            // 
            // dateAppointmentDate
            // 
            this.dateAppointmentDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vehicleServicingScheduleBindingSource1, "ScheduleDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.dateAppointmentDate.Location = new System.Drawing.Point(152, 117);
            this.dateAppointmentDate.Name = "dateAppointmentDate";
            this.dateAppointmentDate.Size = new System.Drawing.Size(140, 20);
            this.dateAppointmentDate.TabIndex = 6;
            this.dateAppointmentDate.ValueChanged += new System.EventHandler(this.dateAppointmentDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Service(s) to perform";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtServices2
            // 
            this.txtServices2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleServicingScheduleBindingSource1, "ServiceDescription", true));
            this.txtServices2.Location = new System.Drawing.Point(298, 169);
            this.txtServices2.Name = "txtServices2";
            this.txtServices2.Size = new System.Drawing.Size(140, 20);
            this.txtServices2.TabIndex = 8;
            this.txtServices2.TextChanged += new System.EventHandler(this.txtServices2_TextChanged);
            // 
            // txtServices4
            // 
            this.txtServices4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleServicingScheduleBindingSource1, "ServiceDescription", true));
            this.txtServices4.Location = new System.Drawing.Point(298, 195);
            this.txtServices4.Name = "txtServices4";
            this.txtServices4.Size = new System.Drawing.Size(140, 20);
            this.txtServices4.TabIndex = 10;
            this.txtServices4.TextChanged += new System.EventHandler(this.txtServices4_TextChanged);
            // 
            // txtServices3
            // 
            this.txtServices3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleServicingScheduleBindingSource1, "ServiceDescription", true));
            this.txtServices3.Location = new System.Drawing.Point(152, 195);
            this.txtServices3.Name = "txtServices3";
            this.txtServices3.Size = new System.Drawing.Size(140, 20);
            this.txtServices3.TabIndex = 9;
            this.txtServices3.TextChanged += new System.EventHandler(this.txtServices3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Procedure code";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtProcedureCode
            // 
            this.txtProcedureCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleServicingScheduleBindingSource1, "VehicleScheduleID", true));
            this.txtProcedureCode.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtProcedureCode.Location = new System.Drawing.Point(152, 247);
            this.txtProcedureCode.Name = "txtProcedureCode";
            this.txtProcedureCode.Size = new System.Drawing.Size(140, 20);
            this.txtProcedureCode.TabIndex = 12;
            this.txtProcedureCode.Text = "VS_";
            this.txtProcedureCode.TextChanged += new System.EventHandler(this.txtProcedureCode_TextChanged);
            // 
            // gridCallService
            // 
            this.gridCallService.AllowUserToAddRows = false;
            this.gridCallService.AllowUserToDeleteRows = false;
            this.gridCallService.AutoGenerateColumns = false;
            this.gridCallService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCallService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleScheduleIDDataGridViewTextBoxColumn,
            this.vehicleIDDataGridViewTextBoxColumn,
            this.serviceDescriptionDataGridViewTextBoxColumn,
            this.scheduleDateDataGridViewTextBoxColumn});
            this.gridCallService.DataSource = this.vehicleServicingScheduleBindingSource1;
            this.gridCallService.Location = new System.Drawing.Point(472, 40);
            this.gridCallService.Name = "gridCallService";
            this.gridCallService.ReadOnly = true;
            this.gridCallService.Size = new System.Drawing.Size(459, 173);
            this.gridCallService.TabIndex = 13;
            // 
            // vehicleScheduleIDDataGridViewTextBoxColumn
            // 
            this.vehicleScheduleIDDataGridViewTextBoxColumn.DataPropertyName = "VehicleScheduleID";
            this.vehicleScheduleIDDataGridViewTextBoxColumn.HeaderText = "VehicleScheduleID";
            this.vehicleScheduleIDDataGridViewTextBoxColumn.Name = "vehicleScheduleIDDataGridViewTextBoxColumn";
            this.vehicleScheduleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            this.vehicleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceDescriptionDataGridViewTextBoxColumn
            // 
            this.serviceDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ServiceDescription";
            this.serviceDescriptionDataGridViewTextBoxColumn.HeaderText = "ServiceDescription";
            this.serviceDescriptionDataGridViewTextBoxColumn.Name = "serviceDescriptionDataGridViewTextBoxColumn";
            this.serviceDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scheduleDateDataGridViewTextBoxColumn
            // 
            this.scheduleDateDataGridViewTextBoxColumn.DataPropertyName = "ScheduleDate";
            this.scheduleDateDataGridViewTextBoxColumn.HeaderText = "ScheduleDate";
            this.scheduleDateDataGridViewTextBoxColumn.Name = "scheduleDateDataGridViewTextBoxColumn";
            this.scheduleDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gridCompletedService
            // 
            this.gridCompletedService.AllowUserToAddRows = false;
            this.gridCompletedService.AllowUserToDeleteRows = false;
            this.gridCompletedService.AutoGenerateColumns = false;
            this.gridCompletedService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompletedService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleScheduleIDDataGridViewTextBoxColumn1,
            this.vehicleIDDataGridViewTextBoxColumn1,
            this.serviceDescriptionDataGridViewTextBoxColumn1,
            this.scheduleDateDataGridViewTextBoxColumn1});
            this.gridCompletedService.DataSource = this.vehicleServicingScheduleBindingSource1;
            this.gridCompletedService.Location = new System.Drawing.Point(472, 331);
            this.gridCompletedService.Name = "gridCompletedService";
            this.gridCompletedService.ReadOnly = true;
            this.gridCompletedService.Size = new System.Drawing.Size(459, 173);
            this.gridCompletedService.TabIndex = 14;
            // 
            // vehicleScheduleIDDataGridViewTextBoxColumn1
            // 
            this.vehicleScheduleIDDataGridViewTextBoxColumn1.DataPropertyName = "VehicleScheduleID";
            this.vehicleScheduleIDDataGridViewTextBoxColumn1.HeaderText = "VehicleScheduleID";
            this.vehicleScheduleIDDataGridViewTextBoxColumn1.Name = "vehicleScheduleIDDataGridViewTextBoxColumn1";
            this.vehicleScheduleIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // vehicleIDDataGridViewTextBoxColumn1
            // 
            this.vehicleIDDataGridViewTextBoxColumn1.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn1.HeaderText = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn1.Name = "vehicleIDDataGridViewTextBoxColumn1";
            this.vehicleIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // serviceDescriptionDataGridViewTextBoxColumn1
            // 
            this.serviceDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "ServiceDescription";
            this.serviceDescriptionDataGridViewTextBoxColumn1.HeaderText = "ServiceDescription";
            this.serviceDescriptionDataGridViewTextBoxColumn1.Name = "serviceDescriptionDataGridViewTextBoxColumn1";
            this.serviceDescriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // scheduleDateDataGridViewTextBoxColumn1
            // 
            this.scheduleDateDataGridViewTextBoxColumn1.DataPropertyName = "ScheduleDate";
            this.scheduleDateDataGridViewTextBoxColumn1.HeaderText = "ScheduleDate";
            this.scheduleDateDataGridViewTextBoxColumn1.Name = "scheduleDateDataGridViewTextBoxColumn1";
            this.scheduleDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(469, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Call Service (Work to be completed) ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(469, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Completed Services";
            // 
            // btnSchedule_Daily
            // 
            this.btnSchedule_Daily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedule_Daily.FlatAppearance.BorderSize = 0;
            this.btnSchedule_Daily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule_Daily.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSchedule_Daily.Location = new System.Drawing.Point(613, 288);
            this.btnSchedule_Daily.Name = "btnSchedule_Daily";
            this.btnSchedule_Daily.Size = new System.Drawing.Size(75, 23);
            this.btnSchedule_Daily.TabIndex = 17;
            this.btnSchedule_Daily.Text = "Daily";
            this.btnSchedule_Daily.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule_Daily.UseVisualStyleBackColor = true;
            // 
            // btnSchedule_Weekly
            // 
            this.btnSchedule_Weekly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedule_Weekly.FlatAppearance.BorderSize = 0;
            this.btnSchedule_Weekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule_Weekly.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSchedule_Weekly.Location = new System.Drawing.Point(694, 288);
            this.btnSchedule_Weekly.Name = "btnSchedule_Weekly";
            this.btnSchedule_Weekly.Size = new System.Drawing.Size(75, 23);
            this.btnSchedule_Weekly.TabIndex = 18;
            this.btnSchedule_Weekly.Text = "Weekly";
            this.btnSchedule_Weekly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule_Weekly.UseVisualStyleBackColor = true;
            // 
            // btnSchedule_Yearly
            // 
            this.btnSchedule_Yearly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedule_Yearly.FlatAppearance.BorderSize = 0;
            this.btnSchedule_Yearly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule_Yearly.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSchedule_Yearly.Location = new System.Drawing.Point(856, 288);
            this.btnSchedule_Yearly.Name = "btnSchedule_Yearly";
            this.btnSchedule_Yearly.Size = new System.Drawing.Size(75, 23);
            this.btnSchedule_Yearly.TabIndex = 20;
            this.btnSchedule_Yearly.Text = "Yearly";
            this.btnSchedule_Yearly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule_Yearly.UseVisualStyleBackColor = true;
            // 
            // btnSchedule_Monthly
            // 
            this.btnSchedule_Monthly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedule_Monthly.FlatAppearance.BorderSize = 0;
            this.btnSchedule_Monthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule_Monthly.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSchedule_Monthly.Location = new System.Drawing.Point(775, 288);
            this.btnSchedule_Monthly.Name = "btnSchedule_Monthly";
            this.btnSchedule_Monthly.Size = new System.Drawing.Size(75, 23);
            this.btnSchedule_Monthly.TabIndex = 19;
            this.btnSchedule_Monthly.Text = "Monthly";
            this.btnSchedule_Monthly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule_Monthly.UseVisualStyleBackColor = true;
            // 
            // vehicleServicingScheduleTableAdapter1
            // 
            this.vehicleServicingScheduleTableAdapter1.ClearBeforeFill = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRefresh.Location = new System.Drawing.Point(370, 40);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Remove a Servicing Schedule";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "Procedure Code";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.dateAppointmentDate2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtProcedureCode2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(12, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 260);
            this.panel1.TabIndex = 24;
            // 
            // btnRemove
            // 
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRemove.Location = new System.Drawing.Point(351, 221);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(72, 23);
            this.btnRemove.TabIndex = 25;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtProcedureCode2
            // 
            this.txtProcedureCode2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleServicingScheduleBindingSource1, "VehicleID", true));
            this.txtProcedureCode2.Location = new System.Drawing.Point(140, 61);
            this.txtProcedureCode2.Name = "txtProcedureCode2";
            this.txtProcedureCode2.Size = new System.Drawing.Size(140, 20);
            this.txtProcedureCode2.TabIndex = 25;
            this.txtProcedureCode2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateAppointmentDate2
            // 
            this.dateAppointmentDate2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vehicleServicingScheduleBindingSource1, "ScheduleDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.dateAppointmentDate2.Location = new System.Drawing.Point(140, 167);
            this.dateAppointmentDate2.Name = "dateAppointmentDate2";
            this.dateAppointmentDate2.Size = new System.Drawing.Size(140, 20);
            this.dateAppointmentDate2.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 12);
            this.label11.TabIndex = 25;
            this.label11.Text = "Appointment date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "By Date:";
            // 
            // ServiceScheduling_Scrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSchedule_Yearly);
            this.Controls.Add(this.btnSchedule_Monthly);
            this.Controls.Add(this.btnSchedule_Weekly);
            this.Controls.Add(this.btnSchedule_Daily);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridCompletedService);
            this.Controls.Add(this.gridCallService);
            this.Controls.Add(this.txtProcedureCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtServices4);
            this.Controls.Add(this.txtServices3);
            this.Controls.Add(this.txtServices2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateAppointmentDate);
            this.Controls.Add(this.txtServices1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVehicleNumber);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ServiceScheduling_Scrn";
            this.Size = new System.Drawing.Size(959, 587);
            this.Load += new System.EventHandler(this.ServiceScheduling_Scrn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleServicingScheduleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wILDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCallService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompletedService)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.TextBox txtVehicleNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServices1;
        private System.Windows.Forms.DateTimePicker dateAppointmentDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServices2;
        private System.Windows.Forms.TextBox txtServices4;
        private System.Windows.Forms.TextBox txtServices3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProcedureCode;
        private System.Windows.Forms.DataGridView gridCallService;
        private System.Windows.Forms.DataGridView gridCompletedService;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSchedule_Daily;
        private System.Windows.Forms.Button btnSchedule_Weekly;
        private System.Windows.Forms.Button btnSchedule_Yearly;
        private System.Windows.Forms.Button btnSchedule_Monthly;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleScheduleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vehicleServicingScheduleBindingSource1;
        private WILDatabaseDataSet2 wILDatabaseDataSet2;
        private WILDatabaseDataSet2TableAdapters.VehicleServicingScheduleTableAdapter vehicleServicingScheduleTableAdapter1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleScheduleIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDescriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtProcedureCode2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DateTimePicker dateAppointmentDate2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}
