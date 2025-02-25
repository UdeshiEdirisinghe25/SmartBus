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

                }

            }
            catch (Exception ex)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
