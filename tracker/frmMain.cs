/*  Authors:  Rikki Swetzof & Carrie Fowler
 * November 2015*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace tracker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddVeh_Click(object sender, EventArgs e)
        {
            frmAddVeh frm = new frmAddVeh();
            frm.Show();
            
        }

        private void btnAddServiceType_Click(object sender, EventArgs e)
        {
            frmAddServ frm = new frmAddServ();
            frm.Show();
        }

        private void btnEnterTrans_Click(object sender, EventArgs e)
        {
            frmServiceSelection frm = new frmServiceSelection();
            //frmEnterTrans frm = new frmEnterTrans();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAvgMpg_Click(object sender, EventArgs e)
        {
            rptAvgMPG rpt = new rptAvgMPG();
            rpt.Show();
        }

        private void btnMaintCost_Click(object sender, EventArgs e)
        {
            rptTotalCost rpt = new rptTotalCost();
            rpt.Show();
        }

        private void btnFuelCost_Click(object sender, EventArgs e)
        {
           rptTotalFuel rpt = new rptTotalFuel();
            rpt.Show();
        }
    }
}
