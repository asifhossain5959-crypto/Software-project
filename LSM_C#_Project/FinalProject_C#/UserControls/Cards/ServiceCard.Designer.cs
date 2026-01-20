namespace FinalProject_C_.UserControls.Cards
{
    partial class ServiceCard
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
            this.pnlCard = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnBookNow = new Guna.UI2.WinForms.Guna2Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblServiceN = new System.Windows.Forms.Label();
            this.pbSeviceImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeviceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.Controls.Add(this.btnBookNow);
            this.pnlCard.Controls.Add(this.lblPrice);
            this.pnlCard.Controls.Add(this.lblCategory);
            this.pnlCard.Controls.Add(this.panel1);
            this.pnlCard.Controls.Add(this.lblServiceN);
            this.pnlCard.Controls.Add(this.pbSeviceImage);
            this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(75)))), ((int)(((byte)(55)))));
            this.pnlCard.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.pnlCard.Location = new System.Drawing.Point(0, 0);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(225, 125);
            this.pnlCard.TabIndex = 0;
            this.pnlCard.Click += new System.EventHandler(this.pnlCard_Click);
            // 
            // btnBookNow
            // 
            this.btnBookNow.BackColor = System.Drawing.Color.Transparent;
            this.btnBookNow.BorderRadius = 4;
            this.btnBookNow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBookNow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBookNow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBookNow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBookNow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(175)))), ((int)(((byte)(104)))));
            this.btnBookNow.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnBookNow.ForeColor = System.Drawing.Color.White;
            this.btnBookNow.Location = new System.Drawing.Point(134, 98);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(88, 21);
            this.btnBookNow.TabIndex = 7;
            this.btnBookNow.Text = "Book Now";
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(131, 79);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 15);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price : ";
            this.lblPrice.Click += new System.EventHandler(this.pnlCard_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCategory.Location = new System.Drawing.Point(3, 107);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 13);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category : ";
            this.lblCategory.Click += new System.EventHandler(this.pnlCard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.panel1.Location = new System.Drawing.Point(125, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 40);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.pnlCard_Click);
            // 
            // lblServiceN
            // 
            this.lblServiceN.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblServiceN.ForeColor = System.Drawing.Color.White;
            this.lblServiceN.Location = new System.Drawing.Point(3, 79);
            this.lblServiceN.Name = "lblServiceN";
            this.lblServiceN.Size = new System.Drawing.Size(119, 28);
            this.lblServiceN.TabIndex = 1;
            this.lblServiceN.Text = "Service Name";
            this.lblServiceN.Click += new System.EventHandler(this.pnlCard_Click);
            // 
            // pbSeviceImage
            // 
            this.pbSeviceImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbSeviceImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbSeviceImage.ImageRotate = 0F;
            this.pbSeviceImage.Location = new System.Drawing.Point(0, 0);
            this.pbSeviceImage.Name = "pbSeviceImage";
            this.pbSeviceImage.Size = new System.Drawing.Size(225, 72);
            this.pbSeviceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSeviceImage.TabIndex = 0;
            this.pbSeviceImage.TabStop = false;
            this.pbSeviceImage.Click += new System.EventHandler(this.pnlCard_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // ServiceCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCard);
            this.Margin = new System.Windows.Forms.Padding(20);
            this.Name = "ServiceCard";
            this.Size = new System.Drawing.Size(225, 125);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeviceImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlCard;
        private System.Windows.Forms.Label lblServiceN;
        private Guna.UI2.WinForms.Guna2PictureBox pbSeviceImage;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnBookNow;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}
