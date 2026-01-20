namespace FinalProject_C_.UserControls
{
    partial class MainServiceP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainServiceP));
            this.pnlMainPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnlServicesP = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlElectric = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlGardening = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlClening = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAllS = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMainPanel.SuspendLayout();
            this.pnlServicesP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainPanel
            // 
            this.pnlMainPanel.Controls.Add(this.btnAllS);
            this.pnlMainPanel.Controls.Add(this.pnlServicesP);
            this.pnlMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(75)))), ((int)(((byte)(55)))));
            this.pnlMainPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.pnlMainPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlMainPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPanel.Name = "pnlMainPanel";
            this.pnlMainPanel.ShadowDecoration.BorderRadius = 100;
            this.pnlMainPanel.ShadowDecoration.Depth = 1;
            this.pnlMainPanel.Size = new System.Drawing.Size(918, 713);
            this.pnlMainPanel.TabIndex = 5;
            // 
            // pnlServicesP
            // 
            this.pnlServicesP.BackColor = System.Drawing.Color.Transparent;
            this.pnlServicesP.Controls.Add(this.guna2PictureBox1);
            this.pnlServicesP.Controls.Add(this.pnlElectric);
            this.pnlServicesP.Controls.Add(this.pnlGardening);
            this.pnlServicesP.Controls.Add(this.pnlClening);
            this.pnlServicesP.Location = new System.Drawing.Point(16, 63);
            this.pnlServicesP.Name = "pnlServicesP";
            this.pnlServicesP.Size = new System.Drawing.Size(887, 635);
            this.pnlServicesP.TabIndex = 11;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(887, 165);
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pnlElectric
            // 
            this.pnlElectric.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlElectric.BackgroundImage")));
            this.pnlElectric.Location = new System.Drawing.Point(596, 183);
            this.pnlElectric.Name = "pnlElectric";
            this.pnlElectric.Size = new System.Drawing.Size(286, 449);
            this.pnlElectric.TabIndex = 2;
            this.pnlElectric.Click += new System.EventHandler(this.pnlElectric_Click);
            // 
            // pnlGardening
            // 
            this.pnlGardening.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGardening.BackgroundImage")));
            this.pnlGardening.Location = new System.Drawing.Point(300, 183);
            this.pnlGardening.Name = "pnlGardening";
            this.pnlGardening.Size = new System.Drawing.Size(286, 449);
            this.pnlGardening.TabIndex = 1;
            this.pnlGardening.Click += new System.EventHandler(this.pnlGardening_Click);
            // 
            // pnlClening
            // 
            this.pnlClening.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlClening.BackgroundImage")));
            this.pnlClening.Location = new System.Drawing.Point(5, 183);
            this.pnlClening.Name = "pnlClening";
            this.pnlClening.Size = new System.Drawing.Size(286, 449);
            this.pnlClening.TabIndex = 0;
            this.pnlClening.Click += new System.EventHandler(this.pnlClening_Click);
            // 
            // btnAllS
            // 
            this.btnAllS.BackColor = System.Drawing.Color.Transparent;
            this.btnAllS.BorderRadius = 8;
            this.btnAllS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAllS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAllS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAllS.FillColor = System.Drawing.Color.Green;
            this.btnAllS.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAllS.ForeColor = System.Drawing.Color.White;
            this.btnAllS.Location = new System.Drawing.Point(16, 12);
            this.btnAllS.Name = "btnAllS";
            this.btnAllS.Size = new System.Drawing.Size(180, 45);
            this.btnAllS.TabIndex = 12;
            this.btnAllS.Text = "All SERVICE";
            this.btnAllS.Click += new System.EventHandler(this.btnAllS_Click);
            // 
            // MainServiceP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainPanel);
            this.Name = "MainServiceP";
            this.Size = new System.Drawing.Size(918, 713);
            this.pnlMainPanel.ResumeLayout(false);
            this.pnlServicesP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlMainPanel;
        private Guna.UI2.WinForms.Guna2Panel pnlServicesP;
        private Guna.UI2.WinForms.Guna2Panel pnlElectric;
        private Guna.UI2.WinForms.Guna2Panel pnlGardening;
        private Guna.UI2.WinForms.Guna2Panel pnlClening;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnAllS;
    }
}
