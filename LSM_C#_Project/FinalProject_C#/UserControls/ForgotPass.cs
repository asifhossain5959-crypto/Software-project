using System;
using System.CodeDom;
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
    public partial class ForgotPass : UserControl
    {
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void btlUpdate_Click(object sender, EventArgs e)
        {
            if(this.txtUserID.Text==""||this.txtEmail.Text==""||this.txtPassword.Text==""||this.txtCPassword.Text=="")
            {
                MessageBox.Show("Fill All The Field First");
                return;
            }
            try
            {
                var query = $"select * from Users  where UserID='{this.txtUserID.Text}' and Email='{this.txtEmail.Text}'";
                var validate = MainWindow.dataAccess.ExecuteQueryTable(query);
                if (validate.Rows.Count != 1)
                {
                    MessageBox.Show("Inavaild User");
                    return;
                }
                if (this.txtPassword.Text != this.txtCPassword.Text)
                {
                    MessageBox.Show("Password And Confirm Password Did Not Matched");
                    return;
                }
                var query1 = $"Update Users set Password = '{this.txtPassword.Text}' where UserID = '{this.txtUserID.Text}'";
                var validate1=MainWindow.dataAccess.ExecuteDMLQuery(query1);
                if(validate1==1)
                {
                    MessageBox.Show("Password Upadte Successfull");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error : " + ex.Message); }
        }

        private void btlBBBack_Click(object sender, EventArgs e)
        {
            MainWindow.ucLogIn = new LogIn();
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(MainWindow.ucLogIn);
            MainWindow.ucLogIn.Show();
        }
    }
}
