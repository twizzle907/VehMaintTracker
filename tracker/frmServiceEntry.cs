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
    public partial class frmServiceEntry : Form
    {
        string connectionString;
        SqlConnection connection;

        public frmServiceEntry()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["tracker.Properties.Settings.DBtrackerConnectionString"].ConnectionString;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sERVICEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.sERVICEBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.dBtrackerDataSet);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmServiceEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBtrackerDataSet.MAINTENANCE' table. You can move, or remove it, as needed.
            this.mAINTENANCETableAdapter.Fill(this.dBtrackerDataSet.MAINTENANCE);
            populateVehicles();
            populateServices();
        }
        
        private void populateVehicles()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("Select * from VEHICLE", connection))
            {
            DataTable vehicleTable = new DataTable();
                adapter.Fill(vehicleTable);

                lstVehicle.DisplayMember="LicensePlate";
                lstVehicle.ValueMember="LicensePlate";
                lstVehicle.DataSource=vehicleTable;
                populateState();

                lstState.DisplayMember = "State";
                lstState.ValueMember = "State";
                lstState.DataSource = vehicleTable;
            }
        }

        private void populateState()
        { 
            
        }

        private void populateServices()
        { 
        using (connection = new SqlConnection(connectionString))
        using (SqlDataAdapter adapter = new SqlDataAdapter("Select * from SERVICE where SID>1", connection))
        {
            DataTable serviceTable = new DataTable();
            adapter.Fill(serviceTable);

            lstServices.DisplayMember = "Type";
            lstServices.ValueMember = "SID";
            lstServices.DataSource = serviceTable;
            
        }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                string query = "INSERT into MAINTENANCE VALUES (@LicensePlate, @State, @Date, @SID, @Odometer, @Vendor, @Cost)";
               
                using (connection = new SqlConnection(connectionString))
                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@LicensePlate", lstVehicle.SelectedValue);
                    command.Parameters.AddWithValue("@State", lstState.SelectedValue);
                    command.Parameters.AddWithValue("@Date", txtDate.Value.ToString());
                    command.Parameters.AddWithValue("@SID", lstServices.SelectedIndex);
                    command.Parameters.AddWithValue("@Odometer", Convert.ToInt32(txtOdometer.Text));
                    command.Parameters.AddWithValue("@Vendor", txtVendor.Text);
                    command.Parameters.AddWithValue("@Cost", Convert.ToDecimal(txtCost.Text));

                    command.ExecuteNonQuery();

                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
        }

        private void mAINTENANCEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mAINTENANCEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBtrackerDataSet);

        }

        private void mAINTENANCEBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void lstVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateState();
        }

    }
}