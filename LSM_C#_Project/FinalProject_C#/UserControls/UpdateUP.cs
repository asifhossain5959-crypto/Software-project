using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace FinalProject_C_.UserControls
{
    public partial class UpdateUP : UserControl
    {
        internal static string destinationFilePath { get; set; }
        public UpdateUP()
        {
            InitializeComponent();
            this.txtFullName.Text = MainWindow.loginUser.Rows[0][1].ToString();
            this.lblFullName.Text = MainWindow.loginUser.Rows[0][1].ToString();
            this.lblUserType.Text = MainWindow.loginUser.Rows[0][8].ToString();
            this.txtEmail.Text = MainWindow.loginUser.Rows[0][4].ToString();
            this.txtPhoneNo.Text = MainWindow.loginUser.Rows[0][5].ToString();
            this.dtpDate.Text = MainWindow.loginUser.Rows[0][3].ToString();

            try
            {
                this.pbProfilePic.Image = System.Drawing.Image.FromFile(MainWindow.loginUser.Rows[0][9].ToString());
            }
            catch { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string FullName = txtFullName.Text;
            string Email = txtEmail.Text;
            string PhoneNo = txtPhoneNo.Text;
            string Password = txtPassword.Text;
            string UserID = MainWindow.loginUser.Rows[0][0].ToString();
            
            if (
               string.IsNullOrWhiteSpace(FullName) ||
               string.IsNullOrWhiteSpace(Email) ||
               string.IsNullOrWhiteSpace(PhoneNo) ||
               string.IsNullOrWhiteSpace(Password)
               )

            {
                MessageBox.Show("Fill All the Field First");
                return;
            }

            try
            {
                var UserCheck = MainWindow.dataAccess.ExecuteQueryTable($"select * from Users where Password='{this.txtPassword.Text}'");
                string query = "";
                CopyFIle();
                query = $@"Update Users set FullName = '{this.txtFullName.Text}',Email = '{this.txtEmail.Text}',DOB = '{this.dtpDate.Text}',PhoneNo = '{this.txtPhoneNo.Text}',ImagePath = '{destinationFilePath}' where Password = '{this.txtPassword.Text}' and UserID = '{MainWindow.loginUser.Rows[0][0].ToString()}'";


                var validate = MainWindow.dataAccess.ExecuteDMLQuery(query);
                if (validate == 1)
                {
                    var query1 = $@"select U.UserID,U.FullName,U.Gender,U.DOB,U.Email,U.PhoneNo,U.Password,U.UserDescription,UT.TypeName,U.ImagePath from Users as U,UserType as UT where U.UserTypeID=UT.UserTypeID and U.UserID='{MainWindow.loginUser.Rows[0][0].ToString()}'";
                    var DA = MainWindow.dataAccess.ExecuteQueryTable(query1);
                    MainWindow.loginUser = DA;
                    this.lblFullName.Text = MainWindow.loginUser.Rows[0][1].ToString();
                    try
                    {
                        this.pbProfilePic.Image = System.Drawing.Image.FromFile(destinationFilePath);
                    }
                    catch { }

                    MainWindow.ProfileButton.Text = MainWindow.loginUser.Rows[0][1].ToString();
                    MessageBox.Show("User Information Successfully Updated");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"ERROR {ex.Message}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Profile Back = new Profile();
            Back.Dock = DockStyle.Fill;
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(Back);
        }

        private void ofdChoseFile_FileOk(object sender, CancelEventArgs e)
        {
            this.txtUserImage.Text = this.ofdChoseFile.FileName;
        }

        private void btnChoseFile_Click(object sender, EventArgs e)
        {
            this.ofdChoseFile.ShowDialog();
        }

        private void CopyFIle()
        {
            string sourceFilePath = this.txtUserImage.Text;
            string fileName = $"{this.txtUserImage.Text}.png";
            destinationFilePath = Path.Combine(@"..\..\ProfileImage", fileName);

            string destinationDirectory = Path.GetDirectoryName(destinationFilePath);
            if (!Directory.Exists(destinationDirectory))
            {
                Directory.CreateDirectory(destinationDirectory);
            }

            try
            {
                File.Copy(sourceFilePath, destinationFilePath, true);
            }
            catch { }
        }
    }
}
