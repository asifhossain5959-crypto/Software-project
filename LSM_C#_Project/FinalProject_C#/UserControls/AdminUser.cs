using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_C_.UserControls
{
    public partial class AdminUser : UserControl
    {
        public AdminUser()
        {
            InitializeComponent();
            this.load_UserTable();
            load_ServiceCategoryCommand();

            this.txtUserID.Text = GenerateNextUserId();
        }

        internal static string GenerateNextUserId()
        {
            var Query = $"Select MAX(UserID) from Users";
            String UserID = "U-0001";
            try
            {
                var DT = MainWindow.dataAccess.ExecuteQueryTable(Query);
                
                if (DT.Rows.Count<1) return UserID;

                string lastUserId = DT.Rows[0][0].ToString();

                string numericPart = lastUserId.Substring(2);
                int number = int.Parse(numericPart);
                number++;
                string newUserId = $"U-{number:D4}";
                return newUserId;

            }
            catch (Exception ex) { MessageBox.Show($"ERROR {ex.Message}"); }

            return UserID;
        }


        private void load_ServiceCategoryCommand()
        {
            var query = "select * from UserType where UserTypeID != 2";
            try
            {
                var DT = MainWindow.dataAccess.ExecuteQueryTable(query);
                this.cmbServiceType.DataSource = DT;
                this.cmbServiceType.DisplayMember = "TypeName";
                this.cmbServiceType.ValueMember = "UserTypeID";
            }
            catch (Exception ex) { MessageBox.Show($"ERROR {ex.Message}"); }
        }

        private void clear() 
        {
            this.txtUserID.Text = GenerateNextUserId();

            this.dgvUserTable.ClearSelection();
            this.txtSearchUser.Clear();
            this.txtFullName.Clear();
            this.rbFemale.Checked = false;
            this.rbMale.Checked = false;
            this.dtpDate.Value=DateTime.Now;
            this.txtEmail.Clear();
            this.txtPhoneNo.Clear();
            this.txtPassword.Clear();
            this.cmbUserType.SelectedItem=null;
            this.cmbServiceType.SelectedItem =null;
        }
        private void load_UserTable(string query = "select U.UserID,U.FullName,U.Gender,U.DOB,U.Email,U.PhoneNo,U.Password,U.UserDescription,UT.TypeName from Users as U,UserType as UT where U.UserTypeID=UT.UserTypeID")
        {
            try
            {
                var DT = MainWindow.dataAccess.ExecuteQueryTable(query);
                this.dgvUserTable.AutoGenerateColumns = false;
                this.dgvUserTable.DataSource = DT;
            }
            catch (Exception ex) { MessageBox.Show($"ERROR {ex.Message}"); }
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbUserType.Text == "EMPLOYEE")
            {
                this.cmbServiceType.Visible = true;
                this.txtUserDescription.Visible = true;
            }
            else { this.cmbServiceType.Visible = false; this.txtUserDescription.Visible = false; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.txtUserID.Text == "U-0001")
            {
                MessageBox.Show("This user can not be updated");
                return;
            }

            string UserID = txtUserID.Text;
            string FullName = txtFullName.Text;
            string Gender = rbMale.Checked ? rbMale.Text : rbFemale.Checked ? rbFemale.Text : "";
            string Email = txtEmail.Text;
            string PhoneNo = txtPhoneNo.Text;
            string Password = txtPassword.Text;
            string UserType = cmbUserType.SelectedItem == null ? string.Empty : cmbUserType.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(UserID) ||
               string.IsNullOrWhiteSpace(FullName) ||
               string.IsNullOrWhiteSpace(Gender) ||
               string.IsNullOrWhiteSpace(Email) ||
               string.IsNullOrWhiteSpace(PhoneNo) ||
               string.IsNullOrWhiteSpace(Password) ||
               string.IsNullOrWhiteSpace(UserType))
            {
                MessageBox.Show("Fill All the Field First");
                return;
            }

            if (this.cmbUserType.Text == "EMPLOYEE" && this.cmbServiceType.Text == "")
            {
                MessageBox.Show("Fill All the Field First");
                return;
            }
            string ServiceTypeID = "";
            if (this.cmbUserType.Text == "EMPLOYEE")
            {
                ServiceTypeID = this.cmbServiceType.SelectedValue.ToString();
            }

            if (this.cmbUserType.Text == "USER") { ServiceTypeID = "02"; }

            try
            {
                var UserCheck = MainWindow.dataAccess.ExecuteQueryTable($"select * from Users where UserID='{this.txtUserID.Text}'");

                string query ="";

                if( UserCheck.Rows.Count==1)
                {
                    query = $@"Update Users set FullName = '{this.txtFullName.Text}',Gender = '{Gender}',Email = '{this.txtEmail.Text}',DOB = '{this.dtpDate.Text}',PhoneNo = '{this.txtPhoneNo.Text}',Password = '{this.txtPassword.Text}',UserDescription = '{this.txtUserDescription.Text}', UserTypeID = '{ServiceTypeID}' where UserID = '{this.txtUserID.Text}'";
                }
                else
                {
                    query = $@"Insert into Users values ('{this.txtUserID.Text}','{this.txtFullName.Text}','{Gender}','{this.dtpDate.Text}','{this.txtEmail.Text}','{this.txtPhoneNo.Text}','{this.txtPassword.Text}','{this.txtUserDescription.Text}','{ServiceTypeID}','');";
                }

                var validate = MainWindow.dataAccess.ExecuteDMLQuery(query);
                if (validate == 1)
                {
                    MessageBox.Show("User Information Save Successful");
                    this.load_UserTable();
                    this.clear();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"ERROR {ex.Message}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void dgvUserTable_DoubleClick(object sender, EventArgs e)
        {
            this.clear();
            this.txtUserID.Text = this.dgvUserTable.CurrentRow.Cells["UserId"].Value.ToString();
            this.txtFullName.Text = this.dgvUserTable.CurrentRow.Cells["FullName"].Value.ToString();
            string gender = this.dgvUserTable.CurrentRow.Cells["Gender"].Value.ToString();
            if (gender == "Male")
            {
                this.rbMale.Checked = true;
                this.rbFemale.Checked = false;
            }
            else if (gender == "Female")
            {
                this.rbFemale.Checked = true;
                this.rbMale.Checked = false;
            }

            string UserType = this.dgvUserTable.CurrentRow.Cells["UserType"].Value.ToString();
            if(UserType=="User")
            {
                this.cmbUserType.Text = "USER";
            }
            else { this.cmbUserType.Text = "EMPLOYEE";
                this.cmbServiceType.Visible = true;
                this.txtUserDescription.Visible = true;
            }

            this.txtEmail.Text = this.dgvUserTable.CurrentRow.Cells["Email"].Value.ToString();
            this.dtpDate.Text = this.dgvUserTable.CurrentRow.Cells["DOB"].Value.ToString();
            this.txtPhoneNo.Text = this.dgvUserTable.CurrentRow.Cells["PhoneNo"].Value.ToString();
            this.txtPassword.Text = this.dgvUserTable.CurrentRow.Cells["Password"].Value.ToString();
            this.cmbServiceType.Text = this.dgvUserTable.CurrentRow.Cells["UserType"].Value.ToString();
            this.txtUserDescription.Text = this.dgvUserTable.CurrentRow.Cells["UserDescription"].Value.ToString();
        }

        private void ButRemove_Click(object sender, EventArgs e)
        {
            if (this.dgvUserTable.CurrentRow.Cells["UserID"].Value.ToString() == "U-0001")
            {
                MessageBox.Show("This user can not be updated");
                return;
            }

            if (this.dgvUserTable.SelectedRows.Count<1)
            {
                MessageBox.Show("Please Select A Row First To Delete");
                return;
            }
            DialogResult sure=MessageBox.Show("Are you sure to remove this person?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (sure == DialogResult.No)
            {
                this.clear();
                return;
            }

            var UserID = this.dgvUserTable.CurrentRow.Cells["UserID"].Value.ToString();
            try
            {
                var query = $@"Delete from Users Where UserID='{UserID}'";
                var validate = MainWindow.dataAccess.ExecuteDMLQuery(query);
                if (validate == 1)
                {
                    MessageBox.Show("User Delete Successful");
                    this.load_UserTable();
                    this.clear();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"ERROR {ex.Message}");
            }
        
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            string query =$@"select U.UserID,U.FullName,U.Gender,U.DOB,U.Email,U.PhoneNo,U.Password,U.UserDescription,UT.TypeName from Users as U,UserType as UT where U.UserTypeID=UT.UserTypeID and (U.UserID like '{this.txtSearchUser.Text}%' or U.FullName like '{this.txtSearchUser.Text}%')";
            this.load_UserTable(query);
            this.dgvUserTable.ClearSelection();
        }
    }
}
