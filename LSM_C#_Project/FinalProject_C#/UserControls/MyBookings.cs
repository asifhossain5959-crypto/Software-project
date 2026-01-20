using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_C_.UserControls
{
    public partial class MyBookings : UserControl
    {
        public MyBookings()
        {
            InitializeComponent();
            LoadDataTable();
        }

        internal void LoadDataTable()
        {
            var Query = $@"select B.BookingID,
                                A.ServiceID, 
                                S.Name,
                                U.FullName,
                                A.AssignedID, 
                                SC.SubCategoryName,
                                U.PhoneNo,
                                A.WorkAddress,
                                A.WorkStartTime,
                                A.WorkHours,
                                BS.StatusName,
                                (S.Price*A.WorkHours) as Cost
                        from Service as S,
                                Assigned as A,
                                Users as U ,
                                SubCategory as SC,
                                Booking as B,
                                BookingStatus as BS
                        where S.ServiceID = A.ServiceID and
                                A.EmployeeID = U.UserID and
                                SC.SubCategoryID = S.SubCategoryID and
                                A.BookingID = B.BookingID and
                                B.StatusID = BS.StatusID and
                                A.ClientID ='{MainWindow.loginUser.Rows[0][0].ToString()}';";
            try
            {
                var DT = MainWindow.dataAccess.ExecuteQueryTable(Query);
                this.gdvBookingsTable.DataSource = DT;
            }
            catch (Exception ex) { MessageBox.Show("Error : "+ ex.Message); }
        }

        private void Clear()
        {
            this.lblBookingID.Text = "Booking ID : ";
            this.lblServiceName.Text = "Worker Name : ";
            this.lblAssignedID.Text = "Assigned ID : ";
            this.lblCategoryName.Text = "Category Name : ";
            this.lblWorkerPhone.Text = "Worker Phone : ";
            this.lblAddress.Text = "Address : ";
            this.lblDateandTime.Text = "Date and Time : ";
            this.lblWorkHours.Text = "Work Hours : ";
            this.lblPaymentStatus.Text = "Service Status : ";
            this.lblTotalCost.Text = "Total Cost : ";
            this.cmbRating.SelectedIndex = -1;
            this.txtCommentBox.Text = "";
            this.btnPayNow.Visible = false;
            this.btnAddReview.Visible = false;
        }

        private void gdvBookingsTable_DoubleClick(object sender, EventArgs e)
        {
            Clear();
            this.lblBookingID.Text += this.gdvBookingsTable.CurrentRow.Cells[0].Value.ToString();
            this.lblServiceName.Text += this.gdvBookingsTable.CurrentRow.Cells[3].Value.ToString();
            this.lblAssignedID.Text += this.gdvBookingsTable.CurrentRow.Cells[4].Value.ToString();
            this.lblCategoryName.Text += this.gdvBookingsTable.CurrentRow.Cells[5].Value.ToString();
            this.lblWorkerPhone.Text += this.gdvBookingsTable.CurrentRow.Cells[6].Value.ToString();
            this.lblAddress.Text += this.gdvBookingsTable.CurrentRow.Cells[7].Value.ToString();
            this.lblDateandTime.Text += this.gdvBookingsTable.CurrentRow.Cells[8].Value.ToString();
            this.lblWorkHours.Text += this.gdvBookingsTable.CurrentRow.Cells[9].Value.ToString();
            this.lblPaymentStatus.Text += this.gdvBookingsTable.CurrentRow.Cells[10].Value.ToString();
            this.lblTotalCost.Text += this.gdvBookingsTable.CurrentRow.Cells[11].Value.ToString();

            if (this.gdvBookingsTable.CurrentRow.Cells[10].Value.ToString() == "Pending")
            {
                this.btnPayNow.Visible = true;
            }
            if (this.gdvBookingsTable.CurrentRow.Cells[10].Value.ToString() == "Complete")
            {
                this.btnAddReview.Visible = true;
            }

            this.LoadReviewCombobox();
            this.cmbRating.SelectedIndex = -1;
            LoadReview();
        }

        private void LoadReview()
        {
            var query = $"select * from FeedBack where BookingID = '{this.gdvBookingsTable.CurrentRow.Cells[0].Value.ToString()}'";
            try
            {
                var data = MainWindow.dataAccess.ExecuteQueryTable(query);
                if (data.Rows.Count == 1)
                {
                    this.cmbRating.SelectedValue = data.Rows[0][2].ToString();
                    this.txtCommentBox.Text = data.Rows[0][1].ToString();
                    this.btnAddReview.Visible = false;
                }
            }
            catch { }
        }

        private void LoadReviewCombobox()
        {
            var Query = "Select * from Rating";
            try
            {
                var dt = MainWindow.dataAccess.ExecuteQueryTable(Query);
                this.cmbRating.DataSource = dt;
                this.cmbRating.DisplayMember = "RatingName";
                this.cmbRating.ValueMember = "RatingID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            BookN.TotalCost = this.gdvBookingsTable.CurrentRow.Cells[11].Value.ToString();


            Payment payment = new Payment();
            payment.Dock = DockStyle.Fill;
            payment.HidePayLaterB();
            payment.BookingID = this.gdvBookingsTable.CurrentRow.Cells[0].Value.ToString();
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(payment);
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            if (cmbRating.SelectedIndex == -1 || this.txtCommentBox.Text == "" )
            {
                MessageBox.Show("please add rating and write something in comment");
                return;
            }

            var query = $@"insert into FeedBack (Comment,Rating,BookingID,ReviewerName,ServiceID) 
                            Values('{this.txtCommentBox.Text}',
                            '{this.cmbRating.SelectedValue.ToString()}',
                            '{this.gdvBookingsTable.CurrentRow.Cells[0].Value.ToString()}',
                            '{MainWindow.loginUser.Rows[0][1].ToString()}',
                            '{this.gdvBookingsTable.CurrentRow.Cells[1].Value.ToString()}')";
            try
            {
                MainWindow.dataAccess.ExecuteDMLQuery(query);
                this.Clear();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
