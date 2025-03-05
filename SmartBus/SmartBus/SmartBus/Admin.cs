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

        // edit bus details
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EditBus edit = new EditBus();
            edit.Show();

        }
    }
}
