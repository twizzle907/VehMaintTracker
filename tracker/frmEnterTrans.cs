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
    public partial class frmEnterTrans : Form
    {
        public frmEnterTrans()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mAINTENANCEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mAINTENANCEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBtrackerDataSet);

        }

        private void frmEnterTrans_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBtrackerDataSet.MAINTENANCE' table. You can move, or remove it, as needed.
            this.mAINTENANCETableAdapter.Fill(this.dBtrackerDataSet.MAINTENANCE);

        }
    }
}
