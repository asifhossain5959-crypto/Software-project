namespace FinalProject_C_.UserControls
{
    partial class Worklist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClr = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.btnComplete = new Guna.UI2.WinForms.Guna2Button();
            this.lblServiceStatus = new System.Windows.Forms.Label();
            this.lblEarnings = new System.Windows.Forms.Label();
            this.lblWorkHour = new System.Windows.Forms.Label();
            this.lblDT = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblClientPhone = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblAssignedID = new System.Windows.Forms.Label();
            this.lblWorkDetails = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvDataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateandTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Earnings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTable)).BeginInit();
            this.guna2GradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClr
            // 
            this.btnClr.BackColor = System.Drawing.Color.Transparent;
            this.btnClr.BorderRadius = 8;
            this.btnClr.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClr.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClr.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(74)))));
            this.btnClr.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnClr.ForeColor = System.Drawing.Color.White;
            this.btnClr.Location = new System.Drawing.Point(594, 14);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(310, 37);
            this.btnClr.TabIndex = 4;
            this.btnClr.Text = "CLEAR";
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 8;
            this.guna2Panel2.Controls.Add(this.lblCategory);
            this.guna2Panel2.Controls.Add(this.lblServiceName);
            this.guna2Panel2.Controls.Add(this.lblBookingID);
            this.guna2Panel2.Controls.Add(this.btnComplete);
            this.guna2Panel2.Controls.Add(this.lblServiceStatus);
            this.guna2Panel2.Controls.Add(this.lblEarnings);
            this.guna2Panel2.Controls.Add(this.lblWorkHour);
            this.guna2Panel2.Controls.Add(this.lblDT);
            this.guna2Panel2.Controls.Add(this.lblAddress);
            this.guna2Panel2.Controls.Add(this.lblClientPhone);
            this.guna2Panel2.Controls.Add(this.lblClientName);
            this.guna2Panel2.Controls.Add(this.lblAssignedID);
            this.guna2Panel2.Controls.Add(this.lblWorkDetails);
            this.guna2Panel2.Controls.Add(this.panel1);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(71)))), ((int)(((byte)(63)))));
            this.guna2Panel2.Location = new System.Drawing.Point(599, 66);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(310, 635);
            this.guna2Panel2.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(20, 194);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(287, 42);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "Category : ";
            // 
            // lblServiceName
            // 
            this.lblServiceName.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblServiceName.ForeColor = System.Drawing.Color.White;
            this.lblServiceName.Location = new System.Drawing.Point(20, 152);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(290, 42);
            this.lblServiceName.TabIndex = 12;
            this.lblServiceName.Text = "Service Name : ";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblBookingID.ForeColor = System.Drawing.Color.White;
            this.lblBookingID.Location = new System.Drawing.Point(20, 68);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(105, 19);
            this.lblBookingID.TabIndex = 11;
            this.lblBookingID.Text = "Booking ID : ";
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.Transparent;
            this.btnComplete.BorderRadius = 8;
            this.btnComplete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComplete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComplete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComplete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComplete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(74)))));
            this.btnComplete.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnComplete.ForeColor = System.Drawing.Color.White;
            this.btnComplete.Location = new System.Drawing.Point(12, 575);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(284, 35);
            this.btnComplete.TabIndex = 10;
            this.btnComplete.Text = "COMPLETE";
            this.btnComplete.Visible = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // lblServiceStatus
            // 
            this.lblServiceStatus.AutoSize = true;
            this.lblServiceStatus.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblServiceStatus.ForeColor = System.Drawing.Color.White;
            this.lblServiceStatus.Location = new System.Drawing.Point(20, 488);
            this.lblServiceStatus.Name = "lblServiceStatus";
            this.lblServiceStatus.Size = new System.Drawing.Size(129, 19);
            this.lblServiceStatus.TabIndex = 9;
            this.lblServiceStatus.Text = "Service Status : ";
            // 
            // lblEarnings
            // 
            this.lblEarnings.AutoSize = true;
            this.lblEarnings.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblEarnings.ForeColor = System.Drawing.Color.White;
            this.lblEarnings.Location = new System.Drawing.Point(20, 446);
            this.lblEarnings.Name = "lblEarnings";
            this.lblEarnings.Size = new System.Drawing.Size(89, 19);
            this.lblEarnings.TabIndex = 8;
            this.lblEarnings.Text = "Earnings : ";
            // 
            // lblWorkHour
            // 
            this.lblWorkHour.AutoSize = true;
            this.lblWorkHour.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblWorkHour.ForeColor = System.Drawing.Color.White;
            this.lblWorkHour.Location = new System.Drawing.Point(20, 404);
            this.lblWorkHour.Name = "lblWorkHour";
            this.lblWorkHour.Size = new System.Drawing.Size(104, 19);
            this.lblWorkHour.TabIndex = 7;
            this.lblWorkHour.Text = "Work Hour : ";
            // 
            // lblDT
            // 
            this.lblDT.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblDT.ForeColor = System.Drawing.Color.White;
            this.lblDT.Location = new System.Drawing.Point(20, 362);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(290, 30);
            this.lblDT.TabIndex = 6;
            this.lblDT.Text = "Date and Time : ";
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(20, 320);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(290, 34);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address : ";
            // 
            // lblClientPhone
            // 
            this.lblClientPhone.AutoSize = true;
            this.lblClientPhone.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblClientPhone.ForeColor = System.Drawing.Color.White;
            this.lblClientPhone.Location = new System.Drawing.Point(20, 278);
            this.lblClientPhone.Name = "lblClientPhone";
            this.lblClientPhone.Size = new System.Drawing.Size(117, 19);
            this.lblClientPhone.TabIndex = 4;
            this.lblClientPhone.Text = "Client Phone : ";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblClientName.ForeColor = System.Drawing.Color.White;
            this.lblClientName.Location = new System.Drawing.Point(20, 236);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(112, 19);
            this.lblClientName.TabIndex = 3;
            this.lblClientName.Text = "Client Name : ";
            // 
            // lblAssignedID
            // 
            this.lblAssignedID.AutoSize = true;
            this.lblAssignedID.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblAssignedID.ForeColor = System.Drawing.Color.White;
            this.lblAssignedID.Location = new System.Drawing.Point(20, 110);
            this.lblAssignedID.Name = "lblAssignedID";
            this.lblAssignedID.Size = new System.Drawing.Size(113, 19);
            this.lblAssignedID.TabIndex = 2;
            this.lblAssignedID.Text = "Assigned ID : ";
            // 
            // lblWorkDetails
            // 
            this.lblWorkDetails.AutoSize = true;
            this.lblWorkDetails.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblWorkDetails.ForeColor = System.Drawing.Color.White;
            this.lblWorkDetails.Location = new System.Drawing.Point(91, 10);
            this.lblWorkDetails.Name = "lblWorkDetails";
            this.lblWorkDetails.Size = new System.Drawing.Size(136, 19);
            this.lblWorkDetails.TabIndex = 1;
            this.lblWorkDetails.Text = "WORK DETAILS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 2);
            this.panel1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.Controls.Add(this.dgvDataTable);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(71)))), ((int)(((byte)(63)))));
            this.guna2Panel1.Location = new System.Drawing.Point(13, 14);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(572, 686);
            this.guna2Panel1.TabIndex = 3;
            // 
            // dgvDataTable
            // 
            this.dgvDataTable.AllowUserToAddRows = false;
            this.dgvDataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(71)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDataTable.ColumnHeadersHeight = 41;
            this.dgvDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingID,
            this.AssignedID,
            this.ServiceName,
            this.SerCategory,
            this.ClientName,
            this.ClientPhone,
            this.Address,
            this.DateandTime,
            this.WorkHour,
            this.Earnings,
            this.ServiceStatus});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDataTable.Location = new System.Drawing.Point(0, 0);
            this.dgvDataTable.Name = "dgvDataTable";
            this.dgvDataTable.ReadOnly = true;
            this.dgvDataTable.RowHeadersVisible = false;
            this.dgvDataTable.Size = new System.Drawing.Size(572, 686);
            this.dgvDataTable.TabIndex = 0;
            this.dgvDataTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDataTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDataTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDataTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDataTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDataTable.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(71)))), ((int)(((byte)(63)))));
            this.dgvDataTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDataTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDataTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDataTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDataTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDataTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDataTable.ThemeStyle.HeaderStyle.Height = 41;
            this.dgvDataTable.ThemeStyle.ReadOnly = true;
            this.dgvDataTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDataTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDataTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDataTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDataTable.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDataTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDataTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataTable_CellDoubleClick);
            // 
            // BookingID
            // 
            this.BookingID.DataPropertyName = "BookingID";
            this.BookingID.HeaderText = "Booking ID";
            this.BookingID.Name = "BookingID";
            this.BookingID.ReadOnly = true;
            // 
            // AssignedID
            // 
            this.AssignedID.DataPropertyName = "AssignedID";
            this.AssignedID.HeaderText = "Assigned ID";
            this.AssignedID.Name = "AssignedID";
            this.AssignedID.ReadOnly = true;
            this.AssignedID.Visible = false;
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "Name";
            this.ServiceName.HeaderText = "ServiceName";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            this.ServiceName.Visible = false;
            // 
            // SerCategory
            // 
            this.SerCategory.DataPropertyName = "SubCategoryName";
            this.SerCategory.HeaderText = "ServiceCategory";
            this.SerCategory.Name = "SerCategory";
            this.SerCategory.ReadOnly = true;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "FullName";
            this.ClientName.HeaderText = "Client Name";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            this.ClientName.Visible = false;
            // 
            // ClientPhone
            // 
            this.ClientPhone.DataPropertyName = "PhoneNo";
            this.ClientPhone.HeaderText = "Client Phone";
            this.ClientPhone.Name = "ClientPhone";
            this.ClientPhone.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "WorkAddress";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Visible = false;
            // 
            // DateandTime
            // 
            this.DateandTime.DataPropertyName = "WorkStartTime";
            this.DateandTime.HeaderText = "Date And Time";
            this.DateandTime.Name = "DateandTime";
            this.DateandTime.ReadOnly = true;
            // 
            // WorkHour
            // 
            this.WorkHour.DataPropertyName = "WorkHours";
            this.WorkHour.HeaderText = "Work Hour";
            this.WorkHour.Name = "WorkHour";
            this.WorkHour.ReadOnly = true;
            this.WorkHour.Visible = false;
            // 
            // Earnings
            // 
            this.Earnings.DataPropertyName = "Cost";
            this.Earnings.HeaderText = "Earnings";
            this.Earnings.Name = "Earnings";
            this.Earnings.ReadOnly = true;
            // 
            // ServiceStatus
            // 
            this.ServiceStatus.DataPropertyName = "StatusName";
            this.ServiceStatus.HeaderText = "Service Status";
            this.ServiceStatus.Name = "ServiceStatus";
            this.ServiceStatus.ReadOnly = true;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.guna2Panel2);
            this.guna2GradientPanel2.Controls.Add(this.btnClr);
            this.guna2GradientPanel2.Controls.Add(this.guna2Panel1);
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(75)))), ((int)(((byte)(55)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.guna2GradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.BorderRadius = 100;
            this.guna2GradientPanel2.ShadowDecoration.Depth = 1;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(918, 713);
            this.guna2GradientPanel2.TabIndex = 16;
            // 
            // Worklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GradientPanel2);
            this.Name = "Worklist";
            this.Size = new System.Drawing.Size(918, 713);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTable)).EndInit();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClr;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblClientPhone;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblAssignedID;
        private System.Windows.Forms.Label lblWorkDetails;
        private Guna.UI2.WinForms.Guna2Button btnComplete;
        private System.Windows.Forms.Label lblServiceStatus;
        private System.Windows.Forms.Label lblEarnings;
        private System.Windows.Forms.Label lblWorkHour;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDataTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateandTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Earnings;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceStatus;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblBookingID;
    }
}
