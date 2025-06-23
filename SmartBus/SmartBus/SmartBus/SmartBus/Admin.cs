using Google.Protobuf.WellKnownTypes;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            this.Load += new EventHandler(Admin_Load);
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            loaddata();
            LoadDashboard();
        }
        // admin label
        private void label2_Click(object sender, EventArgs e)
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
        //logout
        private void btnBook_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        // bus details
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            loaddata();
        }

        private void linklblAddBus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddBus addbus = new AddBus();
            addbus.Show();
        }

        // edit delete bus details
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the bus ID from the 3rd column (index 2)
                object thirdCellValue = dataGridView1.Rows[e.RowIndex].Cells[2].Value;

                if (thirdCellValue != null && int.TryParse(thirdCellValue.ToString(), out int busIdCellValue))
                {
                    if (e.ColumnIndex == 0)
                    {
                        // Edit button clicked
                        EditBus edit = new EditBus(busIdCellValue);
                        edit.Show();
                    }
                    else if (e.ColumnIndex == 1)
                    {
                        // Delete button clicked
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                                                              "Confirm Delete",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            var db = new DBconnection();
                            if (db.connect_db())
                            {
                                string query = "DELETE FROM busdetails WHERE BusID = @BusID";
                                MySqlCommand cmd = new MySqlCommand(query, db.mysqlconnection);
                                cmd.Parameters.AddWithValue("@BusID", busIdCellValue);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Record deleted successfully.");
                                    // reload the DataGridView
                                    loaddata();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to delete record.");
                                }

                                db.close_db();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No valid data! Please select a bus");
                }
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
           // loaddata();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();

        }


        // count tickets and revenue
        private int GetCount(string query)
        {
            int count = 0;
            var db = new DBconnection();
            if (db.connect_db())
            {
                MySqlCommand cmd = new MySqlCommand(query, db.mysqlconnection);
                count = Convert.ToInt32(cmd.ExecuteScalar());
                db.close_db();
            }
            return count;
        }

        // get revenue
        private decimal GetRevenue(string query)
        {
            decimal revenue = 0;
            var db = new DBconnection();
            if (db.connect_db())
            {
                MySqlCommand cmd = new MySqlCommand(query, db.mysqlconnection);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    revenue = Convert.ToDecimal(result);
                }
                db.close_db();
            }
            return revenue;
        }

        // table
        private Panel CreateMetricPanel(string title, string value, Color backColor)
        {
            Panel panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = backColor,
                Margin = new Padding(10)
            };

            Label lblTitle = new Label
            {
                Text = title,
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 30
            };

            Label lblValue = new Label
            {
                Text = value,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.DarkBlue
            };

            panel.Controls.Add(lblValue);
            panel.Controls.Add(lblTitle);
            return panel;
        }

        // load dashboard
        private void LoadDashboard()
        {
            int todayBookings = GetCount("SELECT COUNT(*) FROM booking WHERE Date = CURDATE()");
            int weekBookings = GetCount("SELECT COUNT(*) FROM booking WHERE WEEK(Date, 1) = WEEK(CURDATE(), 1) AND YEAR(Date) = YEAR(CURDATE())");
            int monthBookings = GetCount("SELECT COUNT(*) FROM booking WHERE MONTH(Date) = MONTH(CURDATE()) AND YEAR(Date) = YEAR(CURDATE())");

            decimal todayRevenue = GetRevenue("SELECT SUM(Price) FROM booking WHERE Date = CURDATE()");
            decimal weekRevenue = GetRevenue("SELECT SUM(Price) FROM booking WHERE WEEK(Date, 1) = WEEK(CURDATE(), 1) AND YEAR(Date) = YEAR(CURDATE())");
            decimal monthRevenue = GetRevenue("SELECT SUM(Price) FROM booking WHERE MONTH(Date) = MONTH(CURDATE()) AND YEAR(Date) = YEAR(CURDATE())");

            tableLayoutPanel1.Controls.Clear();

            // Row 0: Ticket Counts
            tableLayoutPanel1.Controls.Add(CreateMetricPanel("Tickets Today", todayBookings.ToString(), Color.LightBlue), 0, 0);
            tableLayoutPanel1.Controls.Add(CreateMetricPanel("Tickets This Week", weekBookings.ToString(), Color.LightGreen), 1, 0);
            tableLayoutPanel1.Controls.Add(CreateMetricPanel("Tickets This Month", monthBookings.ToString(), Color.LightYellow), 2, 0);

            // Row 1: Revenues
            tableLayoutPanel1.Controls.Add(CreateMetricPanel("Revenue Today", $"Rs. {todayRevenue:N2}", Color.MistyRose), 0, 1);
            tableLayoutPanel1.Controls.Add(CreateMetricPanel("Revenue This Week", $"Rs. {weekRevenue:N2}", Color.LightSkyBlue), 1, 1);
            tableLayoutPanel1.Controls.Add(CreateMetricPanel("Revenue This Month", $"Rs. {monthRevenue:N2}", Color.LightSalmon), 2, 1);
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           // LoadDashboard();
        }
    }
}
