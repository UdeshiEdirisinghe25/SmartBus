using iTextSharp.text.pdf;
using iTextSharp.text;
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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace SmartBus
{
    public partial class User : Form
    {
        private string _userName;
        private string _userID;
        public User(string userName, string userID)
        {
            InitializeComponent();
            _userName = userName;
            _userID = userID;
        }

        // booking history 
        private void LoadBookingHistory()
        {

            var db = new DBconnection();
            if (db.connect_db())
            {

                string query = "SELECT * FROM Booking WHERE UserID = @UserID AND Date < CURRENT_DATE()";

                try
                {
                    // Use the existing connection from DBconnection class
                    MySqlCommand cmd = new MySqlCommand(query, db.mysqlconnection);
                    cmd.Parameters.AddWithValue("@UserID", _userID);


                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);


                    dataGridView2.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching booking history: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Failed to connect to the database.");
            }
        }

        // ongoing booking
        private void LoadOnGoing()
        {

            var db = new DBconnection();
            if (db.connect_db())
            {

                string query = "SELECT BookingID, Date, Seat, Price FROM booking WHERE UserID = @UserID AND Date >= CURRENT_DATE() ";

                try
                {

                    MySqlCommand cmd = new MySqlCommand(query, db.mysqlconnection);
                    cmd.Parameters.AddWithValue("@UserID", _userID);


                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching booking history: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Failed to connect to the database.");
            }
        }

        public class RouteItem
        {
            public string RouteName { get; set; }
            public string BusID { get; set; }
            public string StartCity { get; set; }
            public string EndCity { get; set; }

            public RouteItem(string routeName, string busID, string startCity, string endCity)
            {
                RouteName = routeName;
                BusID = busID;
                StartCity = startCity;
                EndCity = endCity;
            }

            public override string ToString()
            {
                return $"{RouteName} ({StartCity} → {EndCity})";
            }
        }




        // SearchBus
        public void SearchBus()
        {
            string startCity = txtFrom.Text.Trim();
            string endCity = txtTo.Text.Trim();

            checkedListBox1.Items.Clear(); // clear old results

            var db = new DBconnection();
            if (!db.connect_db())
            {
                MessageBox.Show("Failed to connect to the database.");
                return;
            }

            try
            {
                //  Get CityIDs
                string cityQuery = "SELECT CityID FROM cities WHERE City = @city";
                MySqlCommand getStartIDCmd = new MySqlCommand(cityQuery, db.mysqlconnection);
                getStartIDCmd.Parameters.AddWithValue("@city", startCity);
                var startID = getStartIDCmd.ExecuteScalar()?.ToString();

                MySqlCommand getEndIDCmd = new MySqlCommand(cityQuery, db.mysqlconnection);
                getEndIDCmd.Parameters.AddWithValue("@city", endCity);
                var endID = getEndIDCmd.ExecuteScalar()?.ToString();

                if (startID == null || endID == null)
                {
                    MessageBox.Show("One or both cities were not found.");
                    return;
                }

                //  Search for bus routes
                string routeQuery = @"
                    SELECT BusID, RouteName 
                    FROM busroute 
                    WHERE JSON_CONTAINS(cities, JSON_QUOTE(@startID))
                      AND JSON_CONTAINS(cities, JSON_QUOTE(@endID))
                ";

                MySqlCommand searchCmd = new MySqlCommand(routeQuery, db.mysqlconnection);
                searchCmd.Parameters.AddWithValue("@startID", startID);
                searchCmd.Parameters.AddWithValue("@endID", endID);

                using (MySqlDataReader reader = searchCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string routeName = reader["RouteName"].ToString();
                        string busID = reader["BusID"].ToString();
                        RouteItem item = new RouteItem(routeName, busID, startCity, endCity);
                        checkedListBox1.Items.Add(item);


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching bus routes: {ex.Message}");
            }
        }




        private void User_Load(object sender, EventArgs e)
        {
            label2.Text = $"Hello {_userName}";
            LoadBookingHistory();
            LoadOnGoing();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBus();

            // resert textboxes
            txtFrom.Text = string.Empty;
            txtTo.Text = string.Empty;
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // download 

       private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
    if (e.RowIndex >= 0)
    {
        object bookingIdObj = dataGridView1.Rows[e.RowIndex].Cells[2].Value;

        if (bookingIdObj != null && int.TryParse(bookingIdObj.ToString(), out int bookingId))
        {
            if (e.ColumnIndex == 1) // Assuming download button is in column 1
            {
                var db = new DBconnection();
                if (db.connect_db())
                {
                    string query = "SELECT * FROM booking WHERE BookingID = @BookingID";
                    MySqlCommand cmd = new MySqlCommand(query, db.mysqlconnection);
                    cmd.Parameters.AddWithValue("@BookingID", bookingId);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string userId = reader["UserID"].ToString();
                        string date = reader["Date"].ToString();
                        string seat = reader["Seat"].ToString();
                        string from = reader["StartPoint"].ToString();
                        string to = reader["EndPoint"].ToString();
                        string price = reader["Price"].ToString();

                        reader.Close();
                        db.close_db();

                        SaveFileDialog saveFileDialog = new SaveFileDialog
                        {
                            Filter = "PDF File|*.pdf",
                            Title = "Save Ticket",
                            FileName = $"Ticket_{bookingId}.pdf"
                        };

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            GeneratePdfTicket(
                                saveFileDialog.FileName,
                                bookingId.ToString(),
                                userId,
                                from, to, date, seat, price
                            );

                            MessageBox.Show("Ticket downloaded successfully as PDF.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ticket not found.");
                        reader.Close();
                        db.close_db();
                    }
                }
                else
                {
                    MessageBox.Show("Database connection failed.");
                }
            }
        }
        else
        {
            MessageBox.Show("Invalid Booking ID.");
        }
    }
}

private void GeneratePdfTicket(string filePath, string bookingId, string userId, string from, string to, string date, string seat, string price)
{
    Document doc = new Document(PageSize.A4, 50, 50, 50, 50);

    using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
    {
        PdfWriter writer = PdfWriter.GetInstance(doc, fs);
        doc.Open();

        iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
        iTextSharp.text.Font bodyFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);

        doc.Add(new Paragraph("SMARTBUS TICKET", titleFont));
        doc.Add(new Paragraph(" "));
        doc.Add(new Paragraph($"Booking ID : {bookingId}", bodyFont));
        doc.Add(new Paragraph($"User ID    : {userId}", bodyFont));
        doc.Add(new Paragraph($"From       : {from}", bodyFont));
        doc.Add(new Paragraph($"To         : {to}", bodyFont));
        doc.Add(new Paragraph($"Date       : {date}", bodyFont));
        doc.Add(new Paragraph($"Seat No    : {seat}", bodyFont));
        doc.Add(new Paragraph($"Price      : {price}", bodyFont));
        doc.Add(new Paragraph(" "));
        doc.Add(new Paragraph("----------------------------", bodyFont));
        doc.Add(new Paragraph("Thank you for choosing SmartBus!", bodyFont));

        doc.Close();
        writer.Close();
    }
}



        private void btnBook_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                // Get the first checked item
                RouteItem selected = checkedListBox1.CheckedItems[0] as RouteItem;

                if (selected != null)
                {
                    string selectedBusID = selected.BusID;
                    string startCity = selected.StartCity;  // using RouteItem
                    string endCity = selected.EndCity;

                    // Fallback if RouteItem doesn't have StartCity/EndCity
                    if (string.IsNullOrWhiteSpace(startCity))
                        startCity = txtFrom.Text.Trim();
                    if (string.IsNullOrWhiteSpace(endCity))
                        endCity = txtTo.Text.Trim();

                    // Debug popup (optional)
                    MessageBox.Show($"Selected BusID: {selectedBusID}\nFrom: {startCity}\nTo: {endCity}",
                                    "Booking Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open Booking form
                    Booking booking = new Booking(_userID, selectedBusID, startCity, endCity);
                    booking.Show();

                    // Clear selection
                    checkedListBox1.ClearSelected();
                }
                else
                {
                    MessageBox.Show("Invalid bus selection.");
                }
            }
            else
            {
                MessageBox.Show("Please select a bus before booking.");
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOnGoing();
            LoadBookingHistory();
        }
    }
}

