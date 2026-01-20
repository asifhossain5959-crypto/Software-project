namespace FinalProject_C_.UserControls
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.pnlMainPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnlSUBPN = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblCD = new System.Windows.Forms.Label();
            this.lblLGS = new System.Windows.Forms.Label();
            this.gpbPIC = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlFM = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cmbServiceType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUserType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtUserDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhoneNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlMainPanel.SuspendLayout();
            this.pnlSUBPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpbPIC)).BeginInit();
            this.pnlFM.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainPanel
            // 
            this.pnlMainPanel.Controls.Add(this.pnlSUBPN);
            this.pnlMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(75)))), ((int)(((byte)(55)))));
            this.pnlMainPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.pnlMainPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlMainPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPanel.Name = "pnlMainPanel";
            this.pnlMainPanel.Size = new System.Drawing.Size(1100, 713);
            this.pnlMainPanel.TabIndex = 4;
            // 
            // pnlSUBPN
            // 
            this.pnlSUBPN.Controls.Add(this.lblCD);
            this.pnlSUBPN.Controls.Add(this.lblLGS);
            this.pnlSUBPN.Controls.Add(this.gpbPIC);
            this.pnlSUBPN.Controls.Add(this.pnlFM);
            this.pnlSUBPN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.pnlSUBPN.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.pnlSUBPN.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlSUBPN.Location = new System.Drawing.Point(50, 66);
            this.pnlSUBPN.Name = "pnlSUBPN";
            this.pnlSUBPN.Size = new System.Drawing.Size(1000, 600);
            this.pnlSUBPN.TabIndex = 0;
            // 
            // lblCD
            // 
            this.lblCD.AutoSize = true;
            this.lblCD.BackColor = System.Drawing.Color.Transparent;
            this.lblCD.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCD.Location = new System.Drawing.Point(85, 80);
            this.lblCD.Name = "lblCD";
            this.lblCD.Size = new System.Drawing.Size(429, 23);
            this.lblCD.TabIndex = 12;
            this.lblCD.Text = "Complete the sign up to create your dashboard.";
            // 
            // lblLGS
            // 
            this.lblLGS.AutoSize = true;
            this.lblLGS.BackColor = System.Drawing.Color.Transparent;
            this.lblLGS.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblLGS.Location = new System.Drawing.Point(82, 37);
            this.lblLGS.Name = "lblLGS";
            this.lblLGS.Size = new System.Drawing.Size(295, 41);
            this.lblLGS.TabIndex = 11;
            this.lblLGS.Text = "Let\'s Get Started";
            // 
            // gpbPIC
            // 
            this.gpbPIC.BackColor = System.Drawing.Color.Transparent;
            this.gpbPIC.Image = ((System.Drawing.Image)(resources.GetObject("gpbPIC.Image")));
            this.gpbPIC.ImageRotate = 0F;
            this.gpbPIC.Location = new System.Drawing.Point(65, 123);
            this.gpbPIC.Name = "gpbPIC";
            this.gpbPIC.Size = new System.Drawing.Size(449, 420);
            this.gpbPIC.TabIndex = 10;
            this.gpbPIC.TabStop = false;
            // 
            // pnlFM
            // 
            this.pnlFM.BackColor = System.Drawing.Color.Transparent;
            this.pnlFM.Controls.Add(this.btnBack);
            this.pnlFM.Controls.Add(this.cmbServiceType);
            this.pnlFM.Controls.Add(this.panel1);
            this.pnlFM.Controls.Add(this.label1);
            this.pnlFM.Controls.Add(this.cmbUserType);
            this.pnlFM.Controls.Add(this.dtpDate);
            this.pnlFM.Controls.Add(this.btnSignUp);
            this.pnlFM.Controls.Add(this.txtUserDescription);
            this.pnlFM.Controls.Add(this.txtCPassword);
            this.pnlFM.Controls.Add(this.txtPassword);
            this.pnlFM.Controls.Add(this.txtPhoneNo);
            this.pnlFM.Controls.Add(this.txtEmail);
            this.pnlFM.Controls.Add(this.txtFullName);
            this.pnlFM.Controls.Add(this.txtUserID);
            this.pnlFM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(71)))), ((int)(((byte)(63)))));
            this.pnlFM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFM.Location = new System.Drawing.Point(560, 23);
            this.pnlFM.Name = "pnlFM";
            this.pnlFM.Size = new System.Drawing.Size(414, 562);
            this.pnlFM.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 8;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(54)))));
            this.btnBack.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(77)))), ((int)(((byte)(32)))));
            this.btnBack.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(49, 507);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 36);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbServiceType
            // 
            this.cmbServiceType.BackColor = System.Drawing.Color.Transparent;
            this.cmbServiceType.BorderRadius = 5;
            this.cmbServiceType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiceType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbServiceType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbServiceType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbServiceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbServiceType.ItemHeight = 30;
            this.cmbServiceType.Items.AddRange(new object[] {
            "Cleaning",
            "Plumbing",
            "Gardening",
            "Electrician"});
            this.cmbServiceType.Location = new System.Drawing.Point(19, 402);
            this.cmbServiceType.Name = "cmbServiceType";
            this.cmbServiceType.Size = new System.Drawing.Size(380, 36);
            this.cmbServiceType.TabIndex = 27;
            this.cmbServiceType.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Location = new System.Drawing.Point(120, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 33);
            this.panel1.TabIndex = 26;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.rbFemale.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbFemale.Location = new System.Drawing.Point(174, 5);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(77, 22);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.rbMale.ForeColor = System.Drawing.Color.White;
            this.rbMale.Location = new System.Drawing.Point(32, 5);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(60, 22);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Gender:";
            // 
            // cmbUserType
            // 
            this.cmbUserType.BackColor = System.Drawing.Color.Transparent;
            this.cmbUserType.BorderRadius = 5;
            this.cmbUserType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUserType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbUserType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbUserType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbUserType.ItemHeight = 30;
            this.cmbUserType.Items.AddRange(new object[] {
            "USER",
            "EMPLOYEE"});
            this.cmbUserType.Location = new System.Drawing.Point(19, 360);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(380, 36);
            this.cmbUserType.TabIndex = 23;
            this.cmbUserType.SelectedIndexChanged += new System.EventHandler(this.cmbUserType_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.BorderRadius = 5;
            this.dtpDate.BorderThickness = 1;
            this.dtpDate.Checked = true;
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.FillColor = System.Drawing.Color.LightGray;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(19, 189);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(380, 36);
            this.dtpDate.TabIndex = 22;
            this.dtpDate.Value = new System.DateTime(2025, 10, 3, 2, 41, 25, 580);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BorderRadius = 8;
            this.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignUp.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(54)))));
            this.btnSignUp.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(77)))), ((int)(((byte)(32)))));
            this.btnSignUp.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(236, 507);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(135, 36);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtUserDescription
            // 
            this.txtUserDescription.BorderRadius = 5;
            this.txtUserDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserDescription.DefaultText = "";
            this.txtUserDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserDescription.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserDescription.ForeColor = System.Drawing.Color.Black;
            this.txtUserDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserDescription.Location = new System.Drawing.Point(19, 445);
            this.txtUserDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserDescription.Name = "txtUserDescription";
            this.txtUserDescription.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUserDescription.PlaceholderText = "User Description(Optional)";
            this.txtUserDescription.SelectedText = "";
            this.txtUserDescription.Size = new System.Drawing.Size(380, 35);
            this.txtUserDescription.TabIndex = 14;
            this.txtUserDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserDescription.Visible = false;
            // 
            // txtCPassword
            // 
            this.txtCPassword.BorderRadius = 5;
            this.txtCPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCPassword.DefaultText = "";
            this.txtCPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCPassword.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCPassword.ForeColor = System.Drawing.Color.Black;
            this.txtCPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCPassword.Location = new System.Drawing.Point(19, 318);
            this.txtCPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCPassword.PlaceholderText = "Confirm Password";
            this.txtCPassword.SelectedText = "";
            this.txtCPassword.Size = new System.Drawing.Size(380, 35);
            this.txtCPassword.TabIndex = 12;
            this.txtCPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 5;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(19, 275);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(380, 35);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.BorderRadius = 5;
            this.txtPhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNo.DefaultText = "";
            this.txtPhoneNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhoneNo.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNo.Location = new System.Drawing.Point(19, 232);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPhoneNo.PlaceholderText = "Phone Number";
            this.txtPhoneNo.SelectedText = "";
            this.txtPhoneNo.Size = new System.Drawing.Size(380, 35);
            this.txtPhoneNo.TabIndex = 10;
            this.txtPhoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 5;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(19, 147);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(380, 35);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFullName
            // 
            this.txtFullName.BorderRadius = 5;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFullName.ForeColor = System.Drawing.Color.Black;
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Location = new System.Drawing.Point(19, 57);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFullName.PlaceholderText = "Full Name";
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(380, 35);
            this.txtFullName.TabIndex = 7;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserID
            // 
            this.txtUserID.BorderRadius = 5;
            this.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserID.DefaultText = "";
            this.txtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserID.ForeColor = System.Drawing.Color.Black;
            this.txtUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.Location = new System.Drawing.Point(19, 14);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUserID.PlaceholderText = "UserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.SelectedText = "";
            this.txtUserID.Size = new System.Drawing.Size(380, 35);
            this.txtUserID.TabIndex = 6;
            this.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.pnlMainPanel);
            this.Name = "SignUp";
            this.Size = new System.Drawing.Size(1100, 713);
            this.pnlMainPanel.ResumeLayout(false);
            this.pnlSUBPN.ResumeLayout(false);
            this.pnlSUBPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gpbPIC)).EndInit();
            this.pnlFM.ResumeLayout(false);
            this.pnlFM.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlMainPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlSUBPN;
        private Guna.UI2.WinForms.Guna2GradientButton btnSignUp;
        private Guna.UI2.WinForms.Guna2Panel pnlFM;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private Guna.UI2.WinForms.Guna2TextBox txtUserDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtCPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblLGS;
        private Guna.UI2.WinForms.Guna2PictureBox gpbPIC;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUserType;
        private System.Windows.Forms.Label lblCD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbServiceType;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
    }
}
