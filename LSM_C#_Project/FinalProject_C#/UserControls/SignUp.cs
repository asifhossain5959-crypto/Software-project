using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_C_.UserControls
{
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
            load_ServiceCategoryCommand();
            this.txtUserID.Text = AdminUser.GenerateNextUserId();
        }

        private void load_ServiceCategoryCommand()
        {
            var query = "select * from UserType where UserTypeID > 2";
            try
            {
                var DT = MainWindow.dataAccess.ExecuteQueryTable(query);
                this.cmbServiceType.DataSource = DT;
                this.cmbServiceType.DisplayMember = "TypeName";
                this.cmbServiceType.ValueMember = "UserTypeID";
            }
            catch (Exception ex) { MessageBox.Show($"ERROR {ex.Message}"); }
        }

        private void btnSignUpBTOLogin_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Dock = DockStyle.Fill;
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(login);
        }
        
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (this.txtUserID.Text==""||this.txtFullName.Text == "" 
                || this.txtEmail.Text == "" 
                || this.txtPhoneNo.Text==""||this.txtPassword.Text==""
                ||this.txtCPassword.Text==""||this.cmbUserType.Text=="")
            {
                MessageBox.Show("Fill All the Field First");
                return;
            }

            string Gender = "";
            if (rbMale.Checked)
            {
                Gender = "Male";
                
            }
            else if(rbFemale.Checked)
            {
                Gender = "Female";

            }
            else
            {
                MessageBox.Show("Please Select Gender");
            }

            if(this.txtPassword.Text!=this.txtCPassword.Text)
            {
                MessageBox.Show("Password not Matched with Confirm Password");
                return;
            }

            if (this.cmbUserType.Text == "EMPLOYEE" && this.cmbServiceType.Text == "") 
            {
                MessageBox.Show("Fill All the Field First");
                return;
            }

            string ServiceTypeID = this.cmbServiceType.SelectedValue.ToString();

            if (this.cmbUserType.Text=="USER") { ServiceTypeID = "02"; }


            try
            {
                var query = $@"Insert into Users values ('{this.txtUserID.Text}','{this.txtFullName.Text}','{Gender}','{this.dtpDate.Value}','{this.txtEmail.Text}','{this.txtPhoneNo.Text}','{this.txtPassword.Text}','{this.txtUserDescription.Text}','{ServiceTypeID}','');";

                var validate = MainWindow.dataAccess.ExecuteDMLQuery(query);

                if(validate==1)
                {
                    MessageBox.Show("SignUP Successful");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"ERROR {ex.Message}");
            }

        }
        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cmbUserType.Text== "EMPLOYEE")
            {
                this.cmbServiceType.Visible =true;
                this.txtUserDescription.Visible =true;
            }
            else { this.cmbServiceType.Visible =false; this.txtUserDescription.Visible =false;}
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainWindow.ucLogIn = new LogIn();
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(MainWindow.ucLogIn);
            MainWindow.ucLogIn.Show();
        }
    }
}
