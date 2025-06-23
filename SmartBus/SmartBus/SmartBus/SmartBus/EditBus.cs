using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBus
{
    public partial class EditBus : Form
    {
        int busIdReceived;

        public EditBus(int busId)
        {
            InitializeComponent();
            this.busIdReceived = busId;

            loadBusData(busId);
        }

        //load bus details
        public void loadBusData(int busId)
        {
            string busTxt = txtBus.Text;
            string routeTxt = txtRoute.Text;
            string driverTxt = txtDriver.Text;
            string depTimeTxt = txtTime.Text;
            string condutorTxt = txtConductor.Text;
            string priceTxt = txtPrice.Text;
            string driverNTCTxt = txtDriverNTC.Text;
            string travelTimeTxt = txtTraveltime.Text;
            string conductorNTCTxt = txtConductorNTC.Text;
            string distanceTxt = txtTraveldistance.Text;


            try
            {
                var DBconnection = new DBconnection();
                if (DBconnection.connect_db())
                {
                    string query = "select BusNumber, Route, DriverNTC, ConductorNTC, Price, TravelTime, TravelDistance, DepatureTime, Driver, Conductor from busdetails where BusID = " + busId.ToString();
                    MySqlCommand cmd = new MySqlCommand(query);
                    cmd.Connection = DBconnection.mysqlconnection;
                    //MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) // Read the first row
                    {
                        string busNumber = reader.GetString("BusNumber");
                        string route = reader.GetString("Route");
                        string driverNTC = reader.GetString("DriverNTC");
                        string conductorNTC = reader.GetString("ConductorNTC");
                        decimal price = reader.GetDecimal("Price");
                        TimeSpan travelTimeInTime = reader.GetTimeSpan("TravelTime");
                        string travelTime = travelTimeInTime.ToString();
                        string travelDistance = reader.GetString("TravelDistance");
                        TimeSpan departureTimeInTime = reader.GetTimeSpan("DepatureTime");
                        string departureTime = departureTimeInTime.ToString();
                        string driver = reader.GetString("Driver");
                        string conductor = reader.GetString("Conductor");


                        DBconnection.close_db();

                        txtBus.Text = busNumber;
                        txtRoute.Text = route;
                        txtDriver.Text = driver;
                        txtTime.Text = departureTime;
                        txtConductor.Text = conductor;
                        txtPrice.Text = price.ToString();
                        txtDriverNTC.Text = driverNTC;
                        txtTraveltime.Text = travelTime;
                        txtConductorNTC.Text = conductorNTC;
                        txtTraveldistance.Text = travelDistance;

                    }
                    else
                    {
                        MessageBox.Show("Database connection Failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                var dbconnection = new DBconnection();
                if (dbconnection.connect_db())
                {
                    string busTxt = txtBus.Text;
                    string routeTxt = txtRoute.Text;
                    string driverTxt = txtDriver.Text;
                    string condutorTxt = txtConductor.Text;
                    string priceTxt = txtPrice.Text;
                    string driverNTCTxt = txtDriverNTC.Text;
                    string travelTimeTxt = txtTraveltime.Text;
                    string conductorNTCTxt = txtConductorNTC.Text;
                    string distanceTxt = txtTraveldistance.Text;

                    //string query = "update busdetails set (BusNumber,Route, DepatureTime, Driver, DriverNTC, Conductor, ConductorNTC, TravelTime, TravelDistance,Price)" +
                    //               "values (@BusNumber, @Route, @DepatureTime, @Driver, @DriverNTC, @Conductor, @ConductorNTC, @TravelTime, @TravelDistance, @Price) where BusID = " + busIdReceived.ToString();

                    string query = "UPDATE busdetails " +
                                   "SET BusNumber = @BusNumber, Route = @Route, DepatureTime = @DepatureTime, Driver = @Driver, DriverNTC = @DriverNTC, " +
                                   "Conductor = @Conductor, ConductorNTC = @ConductorNTC, TravelTime = @TravelTime, TravelDistance = @TravelDistance, Price = @Price " +
                                   "WHERE BusID = @BusID";


                    MySqlCommand cmd = new MySqlCommand(query, dbconnection.mysqlconnection);


                    cmd.Parameters.AddWithValue("@BusID", busIdReceived);
                    cmd.Parameters.AddWithValue("@BusNumber", busTxt);
                    cmd.Parameters.AddWithValue("@Route", routeTxt);
                    cmd.Parameters.AddWithValue("@Driver", driverTxt);
                    cmd.Parameters.AddWithValue("@DriverNTC", driverNTCTxt);
                    cmd.Parameters.AddWithValue("@Conductor", condutorTxt);
                    cmd.Parameters.AddWithValue("@ConductorNTC", conductorNTCTxt);
                    cmd.Parameters.AddWithValue("@TravelTime", travelTimeTxt);
                    cmd.Parameters.AddWithValue("@TravelDistance", distanceTxt);
                    cmd.Parameters.AddWithValue("@Price", priceTxt);



                    // convert time to correct format
                    string time = txtTime.Text;
                    TimeSpan parsedTime;

                    if (TimeSpan.TryParse(time, out parsedTime))
                    {
                        string formattedTime = parsedTime.ToString(@"hh\:mm\:ss"); // Format for MySQL TIME column
                        cmd.Parameters.AddWithValue("@DepatureTime", formattedTime);
                    }
                    else
                    {
                        MessageBox.Show("Invalid time format! Please enter time in HH:mm:ss format.");
                        return; // Stop execution if time is invalid
                    }

                    // Execute the query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record Added Successfully");

                        // Clear input fields after successful insertion
                        txtBus.Text = "";
                        txtRoute.Text = "";
                        txtDriver.Text = "";
                        txtDriverNTC.Text = "";
                        txtConductor.Text = "";
                        txtConductorNTC.Text = "";
                        txtTraveltime.Text = "";
                        txtTraveldistance.Text = "";
                        txtPrice.Text = "";
                        txtTime.Text = "";


                    }
                    else
                    {
                        MessageBox.Show("Record Adding Failed");
                    }



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
    }
}
