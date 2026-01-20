using FinalProject_C_.UserControls.Cards;
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
    public partial class ServiceDetails : UserControl
    {
        internal string ServiceID {  get; set; }
        internal string SubCategoryID {  get; set; }
        internal string Price { get; set; }
        public ServiceDetails()
        {
            InitializeComponent();
            BookN.SDetailPage = this;
        }
        public ServiceDetails(string ServiceID, string Name, string CategoryName, string SubCategoryName, string Description, string price, string Image ,string SubCID) : this ()
        {
            this.lblServiceN.Text = Name;
            this.lblCategoryN.Text += CategoryName;
            this.lblSubCategoryN.Text += SubCategoryName;
            this.lblDescription.Text += Description;
            Price = price;
            this.lblPrice.Text += Price;
            this.ServiceID = ServiceID;
            this.SubCategoryID = SubCID;

            try
            {
                this.ptbServicePic.Image = System.Drawing.Image.FromFile(Image);
            }
            catch { }

            LoadReviews();
        }

        private void LoadReviews()
        {
            var query = $"select * from FeedBack where ServiceID = '{this.ServiceID}'";

            try
            {
                var data = MainWindow.dataAccess.ExecuteQueryTable(query);
                if (data.Rows.Count > 0) 
                {
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        ReviewCard r = new ReviewCard(data.Rows[0][4].ToString(), data.Rows[0][2].ToString(), data.Rows[0][1].ToString());
                        this.flpReviews.Controls.Add(r);
                    }
                }
                
            }
            catch { }

            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            BookN book = new BookN(this.ServiceID,this.SubCategoryID ,this.Price);
            book.TrackDetailP = true;
            book.Dock = DockStyle.Fill;
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(book);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainWindow.ucSevices = new MainServiceP();
            MainWindow.ucSevices.Dock = DockStyle.Fill;
            this.pnlMainPanel.Controls.Clear();
            this.pnlMainPanel.Controls.Add(MainWindow.ucSevices);
            MainWindow.ucSevices.Show();

            Sevices services = new Sevices();
            services.Dock = DockStyle.Fill;
            MainServiceP.ServicesPanel.Controls.Clear();
            MainServiceP.ServicesPanel.Controls.Add(services);
        }
    }
}
