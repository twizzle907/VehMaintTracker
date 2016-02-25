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
    public partial class frmServiceSelection : Form
    {
        public frmServiceSelection()
        {
            InitializeComponent();
        }

        private void btnFuel_Click(object sender, EventArgs e)
        {
            frmFuelEntry frm = new frmFuelEntry();
            frm.Show();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            frmServiceEntry frm = new frmServiceEntry();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
