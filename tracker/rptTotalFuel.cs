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
    public partial class rptTotalFuel : Form
    {
        SqlConnection connection;
        string connectionString;
        private BindingSource bindingSource1 = new BindingSource();

        public rptTotalFuel()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["tracker.Properties.Settings.DBtrackerConnectionString"].ConnectionString;
        }

        private void rptTotalFuel_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bindingSource1;
            GetData();
        }

        private void GetData()
        {
            string query = "select * from [Total Fuel Cost by Vehicle]";
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
    }
}