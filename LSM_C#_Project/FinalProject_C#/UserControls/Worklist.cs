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
    public partial class Worklist : UserControl
    {
        public Worklist()
        {
            InitializeComponent();
            this.LoadDataTable();
        }
        private void Clear()
        {
            this.lblBookingID.Text = "Booking ID : ";
            this.lblAssignedID.Text = "Assigned ID : ";
            this.lblServiceName.Text = "Service Name : ";
            this.lblCategory.Text = "Category Name : ";
            this.lblClientName.Text = "Client Name : ";
            this.lblClientPhone.Text = "Client Phone : ";
            this.lblAddress.Text = "Address : ";
            this.lblDT.Text = "Date and Time : ";
            this.lblWorkHour.Text = "Work Hours : ";
            this.lblEarnings.Text = "Earnings : ";
            this.lblServiceStatus.Text = "Service Status : ";
            this.btnComplete.Visible = false;
        }

        internal void LoadDataTable()
        {
            var Query = $@"select  B.BookingID,
                            A.AssignedID, 
                            S.Name,
                            SC.SubCategoryName,
                            U.FullName,
                            U.PhoneNo,
                            A.WorkAddress,
                            A.WorkStartTime,
                            A.WorkHours,
                            (S.Price*A.WorkHours) as Cost,
                            BS.StatusName
                    from Service as S,
                            Assigned as A,
                            Users as U ,
                            SubCategory as SC,
                            Booking as B,
                            BookingStatus as BS
                    where S.ServiceID = A.ServiceID and
                            A.ClientID = U.UserID and
                            SC.SubCategoryID = S.SubCategoryID and
                            A.BookingID = B.BookingID and
                            B.StatusID = BS.StatusID and
                            A.EmployeeID ='{MainWindow.loginUser.Rows[0][0]}';";
            try
            {
                var DT = MainWindow.dataAccess.ExecuteQueryTable(Query);
                this.dgvDataTable.DataSource = DT;
            }
            catch (Exception ex) { MessageBox.Show("Error : " + ex.Message); }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void dgvDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clear();
            this.lblBookingID.Text += this.dgvDataTable.CurrentRow.Cells[0].Value.ToString();
            this.lblAssignedID.Text += this.dgvDataTable.CurrentRow.Cells[1].Value.ToString();
            this.lblServiceName.Text += this.dgvDataTable.CurrentRow.Cells[2].Value.ToString(); 
            this.lblCategory.Text += this.dgvDataTable.CurrentRow.Cells[3].Value.ToString();
            this.lblClientName.Text += this.dgvDataTable.CurrentRow.Cells[4].Value.ToString();
            this.lblClientPhone.Text += this.dgvDataTable.CurrentRow.Cells[5].Value.ToString();
            this.lblAddress.Text += this.dgvDataTable.CurrentRow.Cells[6].Value.ToString();
            this.lblDT.Text += this.dgvDataTable.CurrentRow.Cells[7].Value.ToString();
            this.lblWorkHour.Text += this.dgvDataTable.CurrentRow.Cells[8].Value.ToString();
            this.lblEarnings.Text += this.dgvDataTable.CurrentRow.Cells[9].Value.ToString();
            this.lblServiceStatus.Text += this.dgvDataTable.CurrentRow.Cells[10].Value.ToString();

            if (this.dgvDataTable.CurrentRow.Cells[10].Value.ToString() == "Confirm")
            {
                this.btnComplete.Visible = true;
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            var query = $"Update Booking set StatusID = 3 where BookingID = {this.dgvDataTable.CurrentRow.Cells[0].Value.ToString()};";

            DialogResult sure = MessageBox.Show("Are you sure This service is complete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sure == DialogResult.No)
            {
                return;
            }


            try
            {
                MainWindow.dataAccess.ExecuteDMLQuery(query);
                this.LoadDataTable();
                this.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
