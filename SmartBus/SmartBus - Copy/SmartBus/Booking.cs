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

namespace SmartBus
{
    public partial class Booking : Form
    {
        private string _userID;
        private string _busID;
        private string _startCity;
        private string _endCity;
        public Booking(string userID,string busID, string startCity, string endCity)
        {
            InitializeComponent();
            _userID = userID;
            _busID = busID;
            _startCity = startCity;
            _endCity = endCity;
        }

        private void BUsDetails()
        {

            var db = new DBconnection();
            if (db.connect_db())
            {

                string query = "SELECT * FROM busdetails WHERE BusID = @busID";

                try
                {

                    MySqlCommand cmd = new MySqlCommand(query, db.mysqlconnection);
                    cmd.Parameters.AddWithValue("@busID", _busID);
                    
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtDriver.Text = reader["Driver"].ToString();
                            txtDriver.ReadOnly = true;
                            txtConductor.Text = reader["Conductor"].ToString();
                            txtConductor.ReadOnly = true;
                            txtRoute.Text = reader["Route"].ToString();
                            txtRoute.ReadOnly = true;
                            txtPrice.Text = reader["Price"].ToString();
                            txtPrice.ReadOnly = true;
                            txttime.Text = reader["DepatureTime"].ToString();
                            txttime.ReadOnly = true;

                            string busNumber = reader["BusNumber"].ToString();


                            // display bus number
                            lblBus.Text = $"{busNumber}";
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching bus details: {ex.Message}");
                }

            }

            else
            {
                MessageBox.Show("Failed to connect to the database.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            BUsDetails();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            var db = new DBconnection();
            if (db.connect_db())
            {
                try
                {
                    string passengers = txtPassenger.Text.Trim();
                    int half = int.TryParse(txtHalf.Text.Trim(), out int h) ? h : 0;
                    int full = int.TryParse(txtFull.Text.Trim(), out int f) ? f : 0;
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    string seat = string.Join(", ", checkedListBox1.CheckedItems.Cast<string>());

                    // Get price
                    double price = double.TryParse(txtPrice.Text, out double p) ? p : 0;

                    // Calculate full amount
                    double fullAmount = (price / 2 * half) + (price * full);

                    string query = "INSERT INTO booking (UserID, Passengers, Half, Full, Date, Seat, StartPoint, EndPoint, Price) " +
                                   "VALUES (@userID, @passengers, @half, @full, @date, @seat, @startCity, @endCity, @fullAmount)";

                    MySqlCommand cmd = new MySqlCommand(query, db.mysqlconnection);
                    cmd.Parameters.AddWithValue("@userID", _userID);
                    cmd.Parameters.AddWithValue("@passengers", passengers);
                    cmd.Parameters.AddWithValue("@half", half);
                    cmd.Parameters.AddWithValue("@full", full);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@seat", seat);
                    cmd.Parameters.AddWithValue("@startCity", _startCity);
                    cmd.Parameters.AddWithValue("@endCity", _endCity);
                    cmd.Parameters.AddWithValue("@fullAmount", fullAmount);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Booking successful — show summary
                        string start = string.IsNullOrEmpty(_startCity) ? "Unknown" : _startCity;
                        string end = string.IsNullOrEmpty(_endCity) ? "Unknown" : _endCity;

                        string summary = $"Booking Successful!\n\n" +
                                         $"Route: {start} → {end}\n" +
                                         $"Date: {date}\n" +
                                         $"Full Tickets: {full}, Half Tickets: {half}\n" +
                                         $"Total Price: Rs. {fullAmount:0.00}\n" +
                                         $"Seats: {seat}";

                        MessageBox.Show(summary, "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        // Reset textboxes
                        txtPassenger.Clear();
                        txtHalf.Clear();
                        txtFull.Clear();
                        checkedListBox1.ClearSelected();
                    }
                    else
                    {
                        MessageBox.Show("Booking failed. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error recording details: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Failed to connect to the database.");
            }
        }


    }
}
