using FinalProject_C_.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Runtime.CompilerServices;

namespace FinalProject_C_
{
    public partial class MainWindow : Form
    {
        //LogIn User
        internal static DataTable loginUser {  get; set; }

        //Buttons
        internal static Guna2Button ProfileButton {  get; set; }

        //Panels
        internal static Panel MainPanel {  get; set; }
        internal static Panel SideBar {  get; set; }

        //SidePanelsButtons
        internal static Panel BTNPANEL1 { get; set; }
        internal static Panel BTNPANEL2 { get; set; }
        internal static Panel BTNPANEL3 { get; set; }
        internal static Panel BTNPANEL4 { get; set; }
        internal static Panel BTNPANEL5 { get; set; }
        internal static Panel BTNPANEL6 { get; set; }

        //UserControls Pages
        internal static UserControl ucLogIn {  get; set; }
        internal static UserControl ucProfile {  get; set; }
        internal static DataAccess dataAccess { get; set; }
        internal static UserControl ucUserTable { get; set; }
        internal static UserControl ucSevices { get; set; }
        internal static UserControl ucServiceTable { get; set; }
        internal static UserControl ucTransaction { get; set; }
        internal static UserControl ucWorkList { get; set; }
        internal static UserControl ucReview { get; set; }
        internal static UserControl ucMainServiceP { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();
            MainPanel = this.pnlMainPanel;
            SideBar = this.pnlSideBar;
            dataAccess = new DataAccess();
            ProfileButton = this.btnProfile;

            BTNPANEL1 = this.pnlBTN1;
            BTNPANEL2 = this.pnlBTN2;
            BTNPANEL3 = this.pnlBTN3;
            BTNPANEL4 = this.pnlBTN4;
            BTNPANEL5 = this.pnlBTN5;
            BTNPANEL6 = this.pnlBTN6;
        }

        private void ChangeWindow(UserControl NextPage)
        {
            NextPage.Dock = DockStyle.Fill;
            this.pnlMainPanel.Controls.Clear();
            this.pnlMainPanel.Controls.Add(NextPage);
            NextPage.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ucLogIn = new LogIn();
            this.ChangeWindow(ucLogIn);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MainWindow.SideBar.Visible = false;
            ucLogIn = new LogIn();
            this.ChangeWindow(ucLogIn);

            BTNPANEL1.Visible = true;
            BTNPANEL2.Visible = true;
            BTNPANEL3.Visible = true;
            BTNPANEL4.Visible = true;
            BTNPANEL5.Visible = true;
            BTNPANEL6.Visible = true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ucProfile = new Profile();
            this.ChangeWindow(ucProfile);
        }

        private void btnUserTable_Click(object sender, EventArgs e)
        {
            ucUserTable = new AdminUser();
            this.ChangeWindow(ucUserTable);
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            ucSevices = new MainServiceP();
            this.ChangeWindow(ucSevices);
        }

        private void btnServiceT_Click(object sender, EventArgs e)
        {
            ucServiceTable = new AdminService();
            this.ChangeWindow(ucServiceTable); 
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            ucTransaction= new AllBookingList();
            this.ChangeWindow(ucTransaction);
        }

        private void btnWorkList_Click(object sender, EventArgs e)
        {
            ucWorkList = new Worklist();
            this.ChangeWindow(ucWorkList);
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            ucReview= new MyBookings();
            this.ChangeWindow(ucReview);
        }
    }
}
