using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace FinalProject_C_.UserControls
{
    public partial class AdminService : UserControl
    {
        internal static string destinationFilePath { get; set; }
        public AdminService()
        {
            InitializeComponent();
            this.load_ServiceTable();

            this.txtServiceID.Text = GenerateNextUserId();
        }

        internal static string GenerateNextUserId()
        {
            var Query = $"Select MAX(ServiceID) from Service";
            String ServiceID = "S-001";
            try
            {
                var DT = MainWindow.dataAccess.ExecuteQueryTable(Query);

                if (DT.Rows.Count < 1) return ServiceID;

                string lastServiceId = DT.Rows[0][0].ToString();

                string numericPart = lastServiceId.Substring(2);
                int number = int.Parse(numericPart);
                number++;
                string newServiceId = $"S-{number:D3}";
                return newServiceId;

            }
            catch (Exception ex) { MessageBox.Show($"ERROR {ex.Message}"); }

            return ServiceID;
        }

        private void Clear()
        {
            this.gdvServiceTable.ClearSelection();
            this.txtServiceID.Text = GenerateNextUserId();
            this.txtServiceN.Clear();
            this.cmbServiceCN.SelectedItem=null;
            this.cmbServiceSCN.SelectedIndex=-1; 
            this.txtServiceD.Clear();
            this.txtServiceP.Clear();
            this.txtServiceI.Clear();
        }
        private void load_ServiceCategoryCommand()
        {
            var query = "select  * from ServiceCategory";
            try
            {
                var DT = MainWindow.dataAccess.ExecuteQueryTable(query);
                this.cmbServiceCN.DataSource = DT;
                this.cmbServiceCN.DisplayMember = "CategoryName";
                this.cmbServiceCN.ValueMember = "CategoryID";
            }
            catch (Exception ex) { MessageBox.Show($"ERROR {ex.Message}"); }
        }
        private void load_SubCategory(string CategoryID)
        {
            var query = $"select * from SubCategory where CategoryID ='{CategoryID}'";
            try
            {
                var DT = MainWindow.dataAccess.ExecuteQueryTable(query);
                this.cmbServiceSCN.DataSource = DT;
                this.cmbServiceSCN.DisplayMember = "SubCategoryName";
                this.cmbServiceSCN.ValueMember = "SubCategoryID";
                this.cmbServiceSCN.SelectedItem = null;
            }
            catch (Exception ex) { MessageBox.Show($"ERROR {ex.Message}"); }
        
        }
        private void load_ServiceTable(string query = "select S.ServiceID,S.Name,C.CategoryName,SC.SubCategoryName,S.Description,S.Price, S.Image from Service as S, ServiceCategory as C, SubCategory as SC where S.SubCategoryID=SC.SubCategoryID and SC.CategoryID=C.CategoryID")
        {
            try
            {
                var DT = MainWindow.dataAccess.ExecuteQueryTable(query);
                this.gdvServiceTable.AutoGenerateColumns = false;
                this.gdvServiceTable.DataSource = DT;
            }
            catch (Exception ex) { MessageBox.Show($"ERROR {ex.Message}"); }
        }
        private void UDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void gdvServiceTable_DoubleClick(object sender, EventArgs e)
        {
            this.Clear();
            this.load_ServiceCategoryCommand();
            this.txtServiceID.Text = this.gdvServiceTable.CurrentRow.Cells["ServiceId"].Value.ToString();
            this.txtServiceN.Text = this.gdvServiceTable.CurrentRow.Cells["ServiceName"].Value.ToString();
            this.cmbServiceCN.Text = this.gdvServiceTable.CurrentRow.Cells["CategoryName"].Value.ToString();
            this.cmbServiceSCN.Text = this.gdvServiceTable.CurrentRow.Cells["SubCategoryName"].Value.ToString();
            this.txtServiceD.Text = this.gdvServiceTable.CurrentRow.Cells["Description"].Value.ToString();
            this.txtServiceP.Text = this.gdvServiceTable.CurrentRow.Cells["Price"].Value.ToString();
            this.txtServiceI.Text = this.gdvServiceTable.CurrentRow.Cells["ServiceImage"].Value.ToString();
        }

        private void cmbSeviceCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbServiceCN.SelectedItem==null) return;
            this.load_SubCategory(this.cmbServiceCN.SelectedValue.ToString());
        }

        private void cmbServiceCN_Click(object sender, EventArgs e)
        {
            this.load_ServiceCategoryCommand();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ServiceID = txtServiceID.Text;
            string Name = txtServiceN.Text;
            string Category = cmbServiceCN.SelectedItem == null ? string.Empty : cmbServiceCN.SelectedItem.ToString();
            string SubCategory = cmbServiceSCN.SelectedValue == null ? string.Empty : cmbServiceSCN.SelectedValue.ToString(); ;
            string Description = txtServiceD.Text;
            string Price = txtServiceP.Text;


            if (string.IsNullOrWhiteSpace(ServiceID) ||
               string.IsNullOrWhiteSpace(Name) ||
               string.IsNullOrWhiteSpace(Category) ||
               string.IsNullOrWhiteSpace(SubCategory) ||
               string.IsNullOrWhiteSpace(Description) ||
               string.IsNullOrWhiteSpace(Price))
            {
                MessageBox.Show("Fill All the Field First");
                return;
            }

            /*if (this.cmbServiceCN.Text == ("Cleaning" || "Gardening" || "Elecric") && this.cmbServiceSCN.Text == "")
            {
                MessageBox.Show("Fill All the Field First");
                return;
            }*/
            try
            {
                var ServiceCheck = MainWindow.dataAccess.ExecuteQueryTable($"select * from Service where ServiceID='{ServiceID}'");
                string query = "";
                this.CopyFIle();
                string Image = destinationFilePath;

                if (ServiceCheck.Rows.Count == 1)
                {
                    query = $@"Update Service set Name = '{Name}',Price = '{Price}',Description = '{Description}',Image = '{Image}',SubCategoryID='{SubCategory}' where ServiceID='{ServiceID}'";
                }
                else
                {
                    query = $@"Insert into Service values ('{ServiceID}','{Name}','{Price}','{Description}','{Image}','{SubCategory}')";
                }

                var validate = MainWindow.dataAccess.ExecuteDMLQuery(query);
                if (validate == 1)
                {
                    MessageBox.Show("User Information Save Successful");
                    this.load_ServiceTable();
                    this.Clear();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"ERROR {ex.Message}");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.gdvServiceTable.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please Select A Row First To Delete");
                return;
            }
            DialogResult sure = MessageBox.Show("Are you sure to remove this Service?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sure == DialogResult.No)
            {
                this.Clear();
                return;
            }

            var ServiceID = this.gdvServiceTable.CurrentRow.Cells["ServiceID"].Value.ToString();
            try
            {
                var query = $@"Delete from Service Where ServiceID='{ServiceID}'";
                var validate = MainWindow.dataAccess.ExecuteDMLQuery(query);
                if (validate == 1)
                {
                    MessageBox.Show("Service Delete Successful");
                    this.load_ServiceTable();
                    this.Clear();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"ERROR {ex.Message}");
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            String query =$"select S.ServiceID,S.Name,C.CategoryName,SC.SubCategoryName,S.Description,S.Price, S.Image from Service as S, ServiceCategory as C, SubCategory as SC where S.SubCategoryID=SC.SubCategoryID and SC.CategoryID=C.CategoryID and (S.ServiceID like '{this.txtSearchBox.Text}%' or S.Name like '{this.txtSearchBox.Text}%')";
            this.load_ServiceTable(query);
            this.gdvServiceTable.ClearSelection();
        }

        private void ofdChoseFile_FileOk(object sender, CancelEventArgs e)
        {
            this.txtServiceI.Text = this.ofdChoseFile.FileName;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.ofdChoseFile.ShowDialog();
        }


        private void CopyFIle()
        {
            string sourceFilePath = this.txtServiceI.Text;
            string fileName = $"{this.txtServiceID.Text}.png";
            destinationFilePath = Path.Combine(@"..\..\ServiceImage", fileName);

            string destinationDirectory = Path.GetDirectoryName(destinationFilePath);
            if (!Directory.Exists(destinationDirectory))
            {
                Directory.CreateDirectory(destinationDirectory);
            }

            try
            {
                File.Copy(sourceFilePath, destinationFilePath, true);
            }
            catch{ }
        }

    }
}
