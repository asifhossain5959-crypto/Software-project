using FinalProject_C_.UserControls.Cards;
using Guna.UI2.WinForms;
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
    public partial class Sevices : UserControl
    {
        internal DataTable SCdataTable { get; set; }
        public Sevices()
        {
            InitializeComponent();

            this.GetSubC($"select * from SubCategory where CategoryID = '{MainServiceP.TrackPage}'");

            if (SCdataTable.Rows.Count>0)
            {
                this.btnSubC1.Text = SCdataTable.Rows[0][1].ToString();
                this.btnSubC2.Text = SCdataTable.Rows[1][1].ToString();
            }
            else
            {
                this.btnSubC1.Visible = false;
                this.btnSubC2.Visible = false;
                this.btnClear.Visible = false;
            }
        }

        private void GetSubC(String Query = "select * from SubCategory")
        {
            try
            {
                SCdataTable = MainWindow.dataAccess.ExecuteQueryTable(Query);
            }
            catch(Exception ex) { MessageBox.Show("Error : "+ ex.Message); }
        }

        private void LoadServices()
        {
            this.flpServices.Controls.Clear();
            string ServiceID, Name, CategoryName, SubCategoryName, Description, Price, Image, SubCID;


            try
            {
                var DT = MainWindow.dataAccess.ExecuteQueryTable(MainServiceP.Query);
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    ServiceID = DT.Rows[i][0].ToString();
                    Name = DT.Rows[i][1].ToString();
                    CategoryName = DT.Rows[i][2].ToString();
                    SubCategoryName = DT.Rows[i][3].ToString();
                    Description = DT.Rows[i][4].ToString();
                    Price = DT.Rows[i][5].ToString();
                    Image = DT.Rows[i][6].ToString();

                    SubCID = DT.Rows[i][7].ToString();

                    ServiceCard serviceCard = new ServiceCard(ServiceID, Name, CategoryName, SubCategoryName, Description, Price, Image, SubCID);
                    this.flpServices.Controls.Add(serviceCard);
                }
            }
            catch (Exception ex) { MessageBox.Show($"ERROR {ex.Message}"); }
        } 

        private void Sevices_Load(object sender, EventArgs e)
        {
            LoadServices();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainServiceP.Query = "select S.ServiceID,S.Name,C.CategoryName,SC.SubCategoryName,S.Description,S.Price, S.Image ,SC.SubCategoryID from Service as S, ServiceCategory as C, SubCategory as SC where S.SubCategoryID=SC.SubCategoryID and SC.CategoryID=C.CategoryID";

            MainWindow.ucMainServiceP = new MainServiceP();
            MainWindow.ucMainServiceP.Dock = DockStyle.Fill;
            MainWindow.MainPanel.Controls.Clear();
            MainWindow.MainPanel.Controls.Add(MainWindow.ucMainServiceP);
        }

        private void btnSubC1_Click(object sender, EventArgs e)
        {
            MainServiceP.Query = $"select S.ServiceID,S.Name,C.CategoryName,SC.SubCategoryName,S.Description,S.Price, S.Image ,SC.SubCategoryID from Service as S, ServiceCategory as C, SubCategory as SC where S.SubCategoryID=SC.SubCategoryID and SC.CategoryID=C.CategoryID and SC.SubCategoryID = '{this.SCdataTable.Rows[0][0].ToString()}';";
            this.LoadServices();
        }

        private void btnSubC2_Click(object sender, EventArgs e)
        {
            MainServiceP.Query = $"select S.ServiceID,S.Name,C.CategoryName,SC.SubCategoryName,S.Description,S.Price, S.Image ,SC.SubCategoryID from Service as S, ServiceCategory as C, SubCategory as SC where S.SubCategoryID=SC.SubCategoryID and SC.CategoryID=C.CategoryID and SC.SubCategoryID = '{this.SCdataTable.Rows[1][0].ToString()}';";
            this.LoadServices();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MainServiceP.Query = $"select S.ServiceID,S.Name,C.CategoryName,SC.SubCategoryName,S.Description,S.Price, S.Image ,SC.SubCategoryID from Service as S, ServiceCategory as C, SubCategory as SC where S.SubCategoryID=SC.SubCategoryID and SC.CategoryID=C.CategoryID and C.CategoryID = '{MainServiceP.TrackPage}';";
            this.LoadServices();
        }
    }
}
