using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SmartBus
{
    public partial class AddBus : Form
    {
        public AddBus()
        {
            InitializeComponent();
        }
        // label
        private void label2_Click(object sender, EventArgs e)
        {

        }
        //panel
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            loaddata();
        }
        //lable
        private void label6_Click(object sender, EventArgs e)
        {

        }
        //addbus
        private void AddBus_Load(object sender, EventArgs e)
        {

        }
        //lable12
        private void label12_Click(object sender, EventArgs e)
        {

        }
        //panel
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // edit button
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //load bus details
        public void loaddata()
        {
            try
            {
                var DBconnection = new DBconnection();
                if (DBconnection.connect_db())
                {
                    string query = "select BusID, BusNumber, Route, DriverNTC, ConductorNTC, Price, TravelTime, TravelDistance, DepatureTime from busdetails";
                    MySqlCommand cmd = new MySqlCommand(query);
                    cmd.Connection = DBconnection.mysqlconnection;
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    BindingSource bsource = new BindingSource();
                    bsource.DataSource = dt;

                    dataGridView1.DataSource = bsource;

                    DBconnection.close_db();

                }
                else
                {
                    MessageBox.Show("Database connection Failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // add new bus
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var dbconnection = new DBconnection();
                if (dbconnection.connect_db())
                {
                    string bus = txtBus.Text;
                    string route = txtRoute.Text;
                    string driver = txtDriver.Text;
                    string condutor = txtConductor.Text;
                    string driverNTC = txtDriverNTC.Text;
                    string conductorNTC = txtConductorNTC.Text;
                    string travel = txtTraveltime.Text;
                    string distance = txtTraveldistance.Text;
                    string price = txtPrice.Text;

                    string query = "INSERT INTO busdetails (BusNumber,Route, DepatureTime, Driver, DriverNTC, Conductor, ConductorNTC, TravelTime, TravelDistance,Price)" +
                                   "VALUES(@BusNumber, @Route, @DepatureTime, @Driver, @DriverNTC, @Conductor, @ConductorNTC, @TravelTime, @TravelDistance, @Price)";

                    MySqlCommand cmd = new MySqlCommand(query, dbconnection.mysqlconnection);


                    cmd.Parameters.AddWithValue("@BusNumber", bus);
                    cmd.Parameters.AddWithValue("@Route", route);
                    cmd.Parameters.AddWithValue("@Driver", driver);
                    cmd.Parameters.AddWithValue("@DriverNTC", driverNTC);
                    cmd.Parameters.AddWithValue("@Conductor", condutor);
                    cmd.Parameters.AddWithValue("@ConductorNTC", conductorNTC);
                    cmd.Parameters.AddWithValue("@TravelTime", travel);
                    cmd.Parameters.AddWithValue("@TravelDistance", distance);
                    cmd.Parameters.AddWithValue("@Price", price);


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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
