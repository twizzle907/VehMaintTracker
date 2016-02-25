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
    public partial class frmFuelEntry : Form
    {
        string connectionString;
        SqlConnection connection;

        public frmFuelEntry()
        {
            InitializeComponent();
            //set connection string
            connectionString = ConfigurationManager.ConnectionStrings["tracker.Properties.Settings.DBtrackerConnectionString"].ConnectionString;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFuelEntry_Load(object sender, EventArgs e)
        {
            populateVehicles();
        }



        private void populateVehicles()
        {
            //set connection, adapter with select statement to fill the lstVehicle list box and lstState box
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("Select * from VEHICLE", connection))
            {
                DataTable vehicleTable = new DataTable();
                adapter.Fill(vehicleTable);

                lstVehicle.DisplayMember = "LicensePlate";
                lstVehicle.ValueMember = "LicensePlate";
                lstVehicle.DataSource = vehicleTable;
                populateState();

                lstState.DisplayMember = "State";
                lstState.ValueMember = "State";
                lstState.DataSource = vehicleTable;
            }
        }

        //unused stub
        private void populateState()
        {
            //unused stub
        }

        /*  Save information to database on click event btnSave*/
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Queries saved as strings
                string query1 = "INSERT into MAINTENANCE VALUES (@LicensePlate, @State, @Date, @SID, @Odometer, @Vendor, @Cost)SELECT SCOPE_IDENTITY()";
                string query2 = "INSERT into FUEL VALUES (@TripOdometer, @Gallons, @TID)";

                //set up connection and command to run query strings
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query1, connection))
                using (SqlCommand command2 = new SqlCommand (query2, connection))
                {
                    connection.Open();

                    //add values from scalar variables
                    command.Parameters.AddWithValue("@LicensePlate", lstVehicle.SelectedValue);
                    command.Parameters.AddWithValue("@State", lstState.SelectedValue);
                    command.Parameters.AddWithValue("@Date", txtDate.Value.ToString());
                    command.Parameters.AddWithValue("@SID", 1);
                    command.Parameters.AddWithValue("@Odometer", Convert.ToInt32(txtOdometer.Text));
                    command.Parameters.AddWithValue("@Vendor", txtVendor.Text);
                    command.Parameters.AddWithValue("@Cost", Convert.ToDecimal(txtCost.Text));
                    
                    int TID = Convert.ToInt32(command.ExecuteScalar());//get the TID from the parent MAINTENANCE
                    
                    command2.Parameters.AddWithValue("@TripOdometer", Convert.ToDecimal(txtTripOdometer.Text));
                    command2.Parameters.AddWithValue("@Gallons", Convert.ToDecimal(txtGallons.Text));
                    command2.Parameters.AddWithValue("@TID",TID);
           
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();

                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void lstVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            //empty
        }

        private void lstState_SelectedIndexChanged(object sender, EventArgs e)
        {
            //empty
        }
    }
}