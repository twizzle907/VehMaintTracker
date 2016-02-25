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
    public partial class frmAddVeh : Form
    {
        public frmAddVeh()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vEHICLEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vEHICLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBtrackerDataSet);

        }

        private void frmAddVeh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBtrackerDataSet.VEHICLE' table. You can move, or remove it, as needed.
            this.vEHICLETableAdapter.Fill(this.dBtrackerDataSet.VEHICLE);

        }
    }
}
