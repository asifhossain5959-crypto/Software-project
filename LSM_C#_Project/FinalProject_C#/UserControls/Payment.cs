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
    public partial class Payment : UserControl
    {
        internal string BookingID { get; set; }
        internal string selectedPAYM { get; set; } = "0";
        public Payment()
        {
            InitializeComponent();
            this.lblTotalCost.Text += BookN.TotalCost;
        }

        internal void HidePayLaterB()
        {
            this.btnPayLater.Visible = false;
        }

        internal void InsertInDataBaseConfirmPay()
        {
            //Payment
            if (this.btnPayLater.Visible) 
            {
                InsertInDataBasePayLater();
            }

            try
            {
                var query1 = $@"INSERT INTO Payment (Amount, PaymentMethod, BookingID) VALUES
                                            ({BookN.TotalCost}, 
                                            '{this.selectedPAYM}', 
                                            '{BookingID}');";

                var InsertPaymenet = MainWindow.dataAccess.ExecuteDMLQuery(query1);

                var query2 = $@"Update Booking set StatusID = 2 where BookingID = '{this.BookingID}';";

                if (InsertPaymenet == 1)
                {
                    MainWindow.dataAccess.ExecuteDMLQuery(query2);
                    MessageBox.Show("Successfull Payment");
                }
            }
            catch (Exception ex) { MessageBox.Show("Error : " + ex.Message); }
        }

        internal void InsertInDataBasePayLater()
        {
            
            try
            {
                var query1 = $@"insert into Booking (BookedAt, StatusID) OUTPUT inserted.BookingID Values (GETDATE(),'1');";
                var InsertBooking = MainWindow.dataAccess.ExecuteQueryTable(query1);

                this.BookingID = InsertBooking.Rows[0][0].ToString();

                var query2 = $@"INSERT INTO Assigned (
                                WorkHours,
                                WorkStartTime,
                                WorkAddress,
                                PhoneNo,
                                BookingID,
                                ClientID,
                                EmployeeID,
                                ServiceID
                            )
                            VALUES (
                                {BookN.Hours},
                                '{BookN.DateTime}',
                                '{BookN.Address}',
                                '{BookN.PhoneNo}',
                                {this.BookingID},
                                '{MainWindow.loginUser.Rows[0][0].ToString()}',
                                '{BookN.EmployeeID}',
                                '{BookN.ServiceID}'
                            );";
                var InsertAssigned = MainWindow.dataAccess.ExecuteDMLQuery(query2);
                
            }
            catch (Exception ex) { MessageBox.Show("Error : " + ex.Message); }

        }

        private void btnPayLater_Click(object sender, EventArgs e)
        {
            InsertInDataBasePayLater();
            MessageBox.Show("Successfull Booking as pay later");
            ChangeWindow();
        }

        void ClickBorderChange ()
        {
            this.pnlSelectBkash.BorderThickness = 0;
            this.pnlSelectNagad.BorderThickness = 0;
            this.pnlSelectCard.BorderThickness = 0;
        }

        private void pnlSelectBkash_Click(object sender, EventArgs e)
        {
            ClickBorderChange();
            this.pnlSelectBkash.BorderThickness = 6;
            this.selectedPAYM = "Bkash";
        }

        private void pnlSelectNagad_Click(object sender, EventArgs e)
        {
            ClickBorderChange();
            this.pnlSelectNagad.BorderThickness = 6;
            this.selectedPAYM = "Nagad";
        }

        private void pnlSelectCard_Click(object sender, EventArgs e)
        {
            ClickBorderChange();
            this.pnlSelectCard.BorderThickness = 6;
            this.selectedPAYM = "Card";
        }

        private void ChangeWindow()
        {
            MainWindow.ucSevices = new MainServiceP();
            MainWindow.ucSevices.Dock = DockStyle.Fill;
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(MainWindow.ucSevices);
            MainWindow.ucSevices.Show();
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {

            //Validate
            if(this.txtPNorCN.Text==""||this.txtEmail.Text==""||this.txtPassword.Text=="")
            {
                MessageBox.Show("Fill All The Field First");
                return;
            }
            if(this.txtPassword.Text != MainWindow.loginUser.Rows[0][6].ToString())
            {
                MessageBox.Show("Password Did not match");
                return;
            }
            if (selectedPAYM == "0")
            {
                MessageBox.Show("Please Select a Payment Method");
                return;
            }

            InsertInDataBaseConfirmPay();
            ChangeWindow();
        }
    }
}
