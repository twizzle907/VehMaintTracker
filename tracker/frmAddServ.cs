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
    public partial class frmAddServ : Form
    {
        public frmAddServ()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sERVICEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sERVICEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBtrackerDataSet);

        }

        private void frmAddServ_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBtrackerDataSet.SERVICE' table. You can move, or remove it, as needed.
            this.sERVICETableAdapter.Fill(this.dBtrackerDataSet.SERVICE);

        }
    }
}
