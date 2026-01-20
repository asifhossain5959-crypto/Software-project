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
    public partial class LogIn : UserControl
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Dock = DockStyle.Fill;
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(signUp);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(this.txtEmail.Text==""||this.txtPassword.Text=="")
            {
                MessageBox.Show("Fill the email and password first");
                return;
            }
            try
            {
                var query =$@"select U.UserID,U.FullName,U.Gender,U.DOB,U.Email,U.PhoneNo,U.Password,U.UserDescription,UT.TypeName,U.ImagePath from Users as U,UserType as UT where U.UserTypeID=UT.UserTypeID and Email='{this.txtEmail.Text}' and Password='{this.txtPassword.Text}'";
                var DA = MainWindow.dataAccess.ExecuteQueryTable(query);
                if (DA.Rows.Count == 1)
                {
                    MainWindow.SideBar.Visible = true;
                    MainWindow.ucMainServiceP = new MainServiceP();
                    MainWindow.ucMainServiceP.Dock = DockStyle.Fill;
                    MainWindow.MainPanel.Controls.Clear();
                    MainWindow.MainPanel.Controls.Add(MainWindow.ucMainServiceP);
                    MainWindow.loginUser = DA;
                    MainWindow.ProfileButton.Text = DA.Rows[0][1].ToString();

                    this.ButtonVisible();
                }
                else { MessageBox.Show("Invalid User"); }
            }
            catch (Exception ex){ MessageBox.Show($"ERROR {ex.Message}"); }
           
        }

        internal void ButtonVisible()
        {
            if (MainWindow.loginUser.Rows[0][8].ToString() == "Admin")
            {
                MainWindow.BTNPANEL5.Visible = false;
            }
            else if (MainWindow.loginUser.Rows[0][8].ToString() == "User")
            {
                MainWindow.BTNPANEL2.Visible = false;
                MainWindow.BTNPANEL3.Visible = false;
                MainWindow.BTNPANEL4.Visible = false;
                MainWindow.BTNPANEL5.Visible = false;
            }
            else
            {
                MainWindow.BTNPANEL2.Visible = false;
                MainWindow.BTNPANEL3.Visible = false;
                MainWindow.BTNPANEL4.Visible = false;
            }
        }
        private void btnLabel_Click(object sender, EventArgs e)
        {
            ForgotPass forgot = new ForgotPass();
            forgot.Dock = DockStyle.Fill;
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(forgot);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var query = $"select UserID from Users where Email='{this.txtEmail.Text}'";
            var DA=MainWindow.dataAccess.ExecuteQueryTable(query);
            MessageBox.Show(DA.Rows[0][0].ToString());
        }
    }
}
