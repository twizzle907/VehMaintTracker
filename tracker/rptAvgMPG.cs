using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace tracker
{
    public partial class rptAvgMPG : Form
    {
        SqlConnection connection;
        string connectionString;
        private BindingSource bindingSource1 = new BindingSource();

        public rptAvgMPG()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["tracker.Properties.Settings.DBtrackerConnectionString"].ConnectionString;
        }

        private void rptAvgMPG_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData();
        }

        private void GetData()
        {
            string query = "select * from [Avg MPG by Vehicle]";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);
                bindingSource1.DataSource = table;
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rptAvgMPG_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBtrackerDataSet3.Total_Maint_Cost_by_Vehicle' table. You can move, or remove it, as needed.
            //this.total_Maint_Cost_by_VehicleTableAdapter.Fill(this.dBtrackerDataSet2.Total_Maint_Cost_by_Vehicle);

        }
    }
}
