using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_C_.UserControls
{
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
            string FullName = MainWindow.loginUser.Rows[0][1].ToString();
            string UserType = MainWindow.loginUser.Rows[0][8].ToString();
            string UserID = MainWindow.loginUser.Rows[0][0].ToString();
            string PhoneNo = MainWindow.loginUser.Rows[0][5].ToString();
            string Email = MainWindow.loginUser.Rows[0][4].ToString();
            string DOB = MainWindow.loginUser.Rows[0][3].ToString();
            string Gender = MainWindow.loginUser.Rows[0][2].ToString();
            string Description = MainWindow.loginUser.Rows[0][7].ToString();

            try
            {
                this.pbProfileImage.Image = System.Drawing.Image.FromFile(MainWindow.loginUser.Rows[0][9].ToString());
            }
            catch { }


            this.lblFullName.Text = FullName;
            this.lblUserType.Text = UserType;
            this.lblUserID.Text = UserID;
            this.lblPhoneNo.Text = PhoneNo;
            this.lblEmail.Text = Email;
            this.lblDOB.Text = DOB;
            this.lblGender.Text = Gender;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateUP update = new UpdateUP();
            update.Dock = DockStyle.Fill;
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(update);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
