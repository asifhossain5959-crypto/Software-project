using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProject_C_.UserControls.Cards
{
    public partial class ServiceCard : UserControl
    {
        string ServiceID { get; set; }
        string ServiceName { get; set; }
        string CategoryName { get; set; }
        string SubCategoryName { get; set; }
        string SubCID { get; set; }
        string Description { get; set; }
        string Price { get; set; }
        string Image { get; set; }
        public ServiceCard()
        {
            InitializeComponent();
        }

        public ServiceCard(string ServiceID, string Name, string CategoryName, string SubCategoryName, string Description, string Price, string Image ,string SubCID) : this ()
        {
            this.ServiceID= ServiceID;
            this.ServiceName= Name;
            this.CategoryName= CategoryName;
            this.SubCategoryName= SubCategoryName;
            this.Description= Description;
            this.Price = Price;
            this.Image = Image;
            this.SubCID = SubCID;
            this.lblServiceN.Text = Name;
            this.lblCategory.Text += CategoryName;
            this.lblPrice.Text += Price+" Tk";
            try
            {
                this.pbSeviceImage.Image = System.Drawing.Image.FromFile(this.Image);
            }
            catch { }
        }
        private void pnlCard_Click(object sender, EventArgs e)
        {
            goServicedetails();
        }

        private void goServicedetails()
        {
            ServiceDetails servicedetails = new ServiceDetails(this.ServiceID, this.ServiceName, this.CategoryName, this.SubCategoryName, this.Description, this.Price, this.Image, this.SubCID);
            servicedetails.Dock = DockStyle.Fill;
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(servicedetails);
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            BookN book = new BookN(this.ServiceID , this.SubCID , this.Price);
            book.Dock = DockStyle.Fill;
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(book);
        }
    }
}
