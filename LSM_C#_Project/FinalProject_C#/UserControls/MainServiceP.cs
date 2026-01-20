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
    public partial class MainServiceP : UserControl
    {
        internal static string Query { get; set; }
        internal static Panel ServicesPanel {  get; set; }
        internal static string TrackPage { get; set; }

        public MainServiceP()
        {
            InitializeComponent();
            ServicesPanel = this.pnlServicesP;
        }

        internal static void LoadServices()
        {
            Sevices services = new Sevices();
            services.Dock = DockStyle.Fill;
            ServicesPanel.Controls.Clear();
            ServicesPanel.Controls.Add(services);
        }

        private void ChangeQuery()
        {
            Query = $"select S.ServiceID,S.Name,C.CategoryName,SC.SubCategoryName,S.Description,S.Price, S.Image ,SC.SubCategoryID from Service as S, ServiceCategory as C, SubCategory as SC where S.SubCategoryID=SC.SubCategoryID and SC.CategoryID=C.CategoryID and C.CategoryID = '{TrackPage}';";
            LoadServices();
        }

        private void pnlClening_Click(object sender, EventArgs e)
        {
            TrackPage = "C-01";
            ChangeQuery();
        }

        private void pnlGardening_Click(object sender, EventArgs e)
        {
            TrackPage = "C-02";
            ChangeQuery();
        }

        private void pnlElectric_Click(object sender, EventArgs e)
        {
            TrackPage = "C-03";
            ChangeQuery();
        }

        private void btnAllS_Click(object sender, EventArgs e)
        {
            TrackPage = "0";
            Query = "select S.ServiceID,S.Name,C.CategoryName,SC.SubCategoryName,S.Description,S.Price, S.Image ,SC.SubCategoryID from Service as S, ServiceCategory as C, SubCategory as SC where S.SubCategoryID=SC.SubCategoryID and SC.CategoryID=C.CategoryID";
            LoadServices();
        }
    }
}
