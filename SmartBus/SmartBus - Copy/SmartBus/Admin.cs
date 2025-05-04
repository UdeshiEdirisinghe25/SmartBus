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
            loaddata();
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
    }
}
