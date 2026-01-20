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
    public partial class AllBookingList : UserControl
    {
        public AllBookingList()
        {
            InitializeComponent();
            loadTable();
        }

        private void loadTable()
        {
            var Query = $@"select  B.BookingID,
                                A.AssignedID,
                                S.ServiceID,
                                S.Name,
                                SC.SubCategoryName,
                                U.UserID as userID,
                                EU.UserID as EmID,
                                A.WorkAddress,
                                A.WorkStartTime,
                                A.WorkHours,
                                BS.StatusName,
                                (S.Price*A.WorkHours) as Cost
                        from Service as S,
                                Assigned as A,
                                Users as EU ,
                                SubCategory as SC,
                                Booking as B,
                                BookingStatus as BS,
                                Users as U
                        where S.ServiceID = A.ServiceID and
                                A.EmployeeID = EU.UserID and
                                A.ClientID = U.UserID and
                                SC.SubCategoryID = S.SubCategoryID and
                                A.BookingID = B.BookingID and
                                B.StatusID = BS.StatusID;";
            try
            {
                var DT = MainWindow.dataAccess.ExecuteQueryTable(Query);
                this.gdvBookingsTable.DataSource = DT;
            }
            catch (Exception ex) { MessageBox.Show("Error : " + ex.Message); }
        }

        private void Clear()
        {
            this.lblBookingID.Text = "Booking ID : ";
            this.lblAssignedID.Text = "Assigned ID : ";
            this.lblServiceID.Text = "Service ID : ";
            this.lblServiceName.Text = "Service Name : ";
            this.lblCatagoryName.Text = "Category Name : ";
            this.lblClientID.Text = "Client ID : ";
            this.lblEmployeID.Text = "Employee ID : ";
            this.lblAddress.Text = "Work Address : ";
            this.lblDT.Text = "Date and Time : ";
            this.lblWorkHour.Text = "Work Hour : ";
            this.lblBookingStatus.Text = "Booking Status : ";
            this.lblTotalCost.Text = "Total Cose : ";
        }

        private void gdvBookingsTable_DoubleClick(object sender, EventArgs e)
        {
            Clear();
            this.lblBookingID.Text += this.gdvBookingsTable.CurrentRow.Cells[0].Value.ToString();
            this.lblAssignedID.Text += this.gdvBookingsTable.CurrentRow.Cells[1].Value.ToString();
            this.lblServiceID.Text += this.gdvBookingsTable.CurrentRow.Cells[2].Value.ToString();
            this.lblServiceName.Text += this.gdvBookingsTable.CurrentRow.Cells[3].Value.ToString();
            this.lblCatagoryName.Text += this.gdvBookingsTable.CurrentRow.Cells[4].Value.ToString();
            this.lblClientID.Text += this.gdvBookingsTable.CurrentRow.Cells[5].Value.ToString();
            this.lblEmployeID.Text += this.gdvBookingsTable.CurrentRow.Cells[6].Value.ToString();
            this.lblAddress.Text += this.gdvBookingsTable.CurrentRow.Cells[7].Value.ToString();
            this.lblDT.Text += this.gdvBookingsTable.CurrentRow.Cells[8].Value.ToString();
            this.lblWorkHour.Text += this.gdvBookingsTable.CurrentRow.Cells[9].Value.ToString();
            this.lblBookingStatus.Text += this.gdvBookingsTable.CurrentRow.Cells[10].Value.ToString();
            this.lblTotalCost.Text += this.gdvBookingsTable.CurrentRow.Cells[11].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }
    }
}
