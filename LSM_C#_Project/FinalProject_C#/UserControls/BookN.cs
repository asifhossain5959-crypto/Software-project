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
    public partial class BookN : UserControl
    {
        internal static string DateTime {  get; set; }
        internal static string Hours { get; set; }
        internal static string EmployeeID { get; set; }
        internal static string Address { get; set; }
        internal static string PhoneNo { get; set; }
        internal static string ServiceID { get; set; }
        internal static string Price { get; set; }
        internal static string TotalCost { get; set; }
        internal static string SubCategoryID { get; set; }
        internal static UserControl SDetailPage { get; set; }
        internal Boolean TrackDetailP { get; set; } = false;

        public BookN()
        {
            InitializeComponent();
        }

        public BookN(string serviceID , string SCategoryID , string price) : this()
        {
            this.lblServiceID.Text += serviceID;
            ServiceID = serviceID;
            SubCategoryID = SCategoryID;
            Price = price;
            loadEmployee();
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            if(this.txtHours.Text == "" || 
                this.cmbEmployee.Text == ""||
                this.txtAddress.Text == ""||
                this.txtPhoneNo.Text == "")
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }

            DateTime = this.dtpDateTime.Text;
            Hours = this.txtHours.Text;
            EmployeeID = this.cmbEmployee.SelectedValue.ToString();
            Address = this.txtAddress.Text;
            PhoneNo = this.txtPhoneNo.Text;


            Payment payment = new Payment();
            payment.Dock = DockStyle.Fill;
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(payment);
        }

        internal void loadEmployee()
        {
            

            try
            {
                int EmployeeTypeID = 0;
                if (SubCategoryID == "P-02")
                {
                    EmployeeTypeID = 4;
                }
                else if (SubCategoryID == "P-01")
                {
                    EmployeeTypeID = 3;
                }
                else if (SubCategoryID == "P-03" || SubCategoryID == "P-04")
                {
                    EmployeeTypeID = 5;
                }
                else if (SubCategoryID == "P-05" || SubCategoryID == "P-06")
                {
                    EmployeeTypeID = 6;
                }

                var query = $"select U.UserID, U.FullName, U.UserTypeID ,UT.TypeName from Users as U , UserType as UT where U.UserTypeID = {EmployeeTypeID} and u.UserTypeID = ut.UserTypeID";
                var DT = MainWindow.dataAccess.ExecuteQueryTable(query);

                this.cmbEmployee.DataSource = DT;
                this.cmbEmployee.DisplayMember = "FullName";
                this.cmbEmployee.ValueMember = "UserID";
            }
            catch(Exception e) { MessageBox.Show("Error : " + e.Message); }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainWindow.ucSevices = new MainServiceP();
            MainWindow.ucSevices.Dock = DockStyle.Fill;
            this.pnlMainPanel.Controls.Clear();
            this.pnlMainPanel.Controls.Add(MainWindow.ucSevices);
            MainWindow.ucSevices.Show();

            if (this.TrackDetailP)
            {
                SDetailPage.Dock = DockStyle.Fill;
                this.pnlMainPanel.Controls.Clear();
                this.pnlMainPanel.Controls.Add(SDetailPage);
                return;
            }
            MainServiceP.LoadServices();
        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {
            if(txtHours.Text != "")
            {
                TotalCost = (Convert.ToInt32(Price) * Convert.ToInt32(this.txtHours.Text)).ToString();
            }
            else { TotalCost = ""; }
            this.lblTotalCost.Text = "Your Total cost : " + TotalCost;
        }
    }
}
