using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_C_.UserControls.Cards
{
    public partial class ReviewCard : UserControl
    {
        public ReviewCard()
        {
            InitializeComponent();
        }
        public ReviewCard(string name, string rating, string comment) :this()
        {
            this.lblUserName.Text += name;
            this.lblComment.Text += comment;

            if (rating == "1")
            {
                this.pnlRating1.Visible = true;
            }
            else if (rating == "2")
            {
                this.pnlRating1.Visible = true;
                this.pnlRating2.Visible = true;
            }
            else if (rating == "3")
            {
                this.pnlRating1.Visible = true;
                this.pnlRating2.Visible = true;
                this.pnlRating3.Visible = true;
            }
            else if (rating == "4")
            {
                this.pnlRating1.Visible = true;
                this.pnlRating2.Visible = true;
                this.pnlRating3.Visible = true;
                this.pnlRating4.Visible = true;
            }
            else if (rating == "5")
            {
                this.pnlRating1.Visible = true;
                this.pnlRating2.Visible = true;
                this.pnlRating3.Visible = true;
                this.pnlRating4.Visible = true;
                this.pnlRating5.Visible = true;
            }
        }
    }
}
