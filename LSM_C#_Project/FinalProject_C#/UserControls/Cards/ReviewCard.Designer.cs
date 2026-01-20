namespace FinalProject_C_.UserControls.Cards
{
    partial class ReviewCard
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.pnlRating1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlRating2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlRating3 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlRating4 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlRating5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(71, 6);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(67, 13);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name : ";
            // 
            // lblComment
            // 
            this.lblComment.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblComment.ForeColor = System.Drawing.Color.White;
            this.lblComment.Location = new System.Drawing.Point(71, 39);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(203, 34);
            this.lblComment.TabIndex = 2;
            this.lblComment.Text = "Comment : ";
            // 
            // pnlRating1
            // 
            this.pnlRating1.BackColor = System.Drawing.Color.Olive;
            this.pnlRating1.Location = new System.Drawing.Point(74, 23);
            this.pnlRating1.Name = "pnlRating1";
            this.pnlRating1.Size = new System.Drawing.Size(13, 14);
            this.pnlRating1.TabIndex = 3;
            this.pnlRating1.Visible = false;
            // 
            // pnlRating2
            // 
            this.pnlRating2.BackColor = System.Drawing.Color.Olive;
            this.pnlRating2.Location = new System.Drawing.Point(93, 23);
            this.pnlRating2.Name = "pnlRating2";
            this.pnlRating2.Size = new System.Drawing.Size(13, 14);
            this.pnlRating2.TabIndex = 4;
            this.pnlRating2.Visible = false;
            // 
            // pnlRating3
            // 
            this.pnlRating3.BackColor = System.Drawing.Color.Olive;
            this.pnlRating3.Location = new System.Drawing.Point(112, 23);
            this.pnlRating3.Name = "pnlRating3";
            this.pnlRating3.Size = new System.Drawing.Size(13, 14);
            this.pnlRating3.TabIndex = 5;
            this.pnlRating3.Visible = false;
            // 
            // pnlRating4
            // 
            this.pnlRating4.BackColor = System.Drawing.Color.Olive;
            this.pnlRating4.Location = new System.Drawing.Point(131, 23);
            this.pnlRating4.Name = "pnlRating4";
            this.pnlRating4.Size = new System.Drawing.Size(13, 14);
            this.pnlRating4.TabIndex = 6;
            this.pnlRating4.Visible = false;
            // 
            // pnlRating5
            // 
            this.pnlRating5.BackColor = System.Drawing.Color.Olive;
            this.pnlRating5.Location = new System.Drawing.Point(150, 23);
            this.pnlRating5.Name = "pnlRating5";
            this.pnlRating5.Size = new System.Drawing.Size(13, 14);
            this.pnlRating5.TabIndex = 7;
            this.pnlRating5.Visible = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(7, 6);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(58, 67);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ReviewCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(71)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.pnlRating5);
            this.Controls.Add(this.pnlRating4);
            this.Controls.Add(this.pnlRating3);
            this.Controls.Add(this.pnlRating2);
            this.Controls.Add(this.pnlRating1);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "ReviewCard";
            this.Size = new System.Drawing.Size(287, 79);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblComment;
        private Guna.UI2.WinForms.Guna2Panel pnlRating1;
        private Guna.UI2.WinForms.Guna2Panel pnlRating2;
        private Guna.UI2.WinForms.Guna2Panel pnlRating3;
        private Guna.UI2.WinForms.Guna2Panel pnlRating4;
        private Guna.UI2.WinForms.Guna2Panel pnlRating5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
