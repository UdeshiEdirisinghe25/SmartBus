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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SmartBus
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
        // lable6 do not touch
        private void label6_Click(object sender, EventArgs e)
        {

        }
        // register
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new DBconnection();
                if (db.connect_db())
                {
                    string name = txtName.Text;
                    string email = txtEmail.Text;
                    string username = txtUsename.Text;
                    string password = txtPassword.Text;
                    string contact = Txtcontact.Text;
                  

                    string query = "INSERT INTO users (Name, UserName, Password, ContactNo, Email, UserType) " +
                                   "VALUES ( @Name, @UserName, @Password, @ContactNo, @Email, @UserType)";

                    MySqlCommand cmd = new MySqlCommand(query, db.mysqlconnection);

                    // Corrected parameter names
                    
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@ContactNo", contact);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@UserType", "User"); 



                    // Execute the query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record Added Successfully");

                        // Clear input fields after successful insertion
                        txtName.Text = "";
                        txtEmail.Text = "";
                        txtUsename.Text = "";
                        txtPassword.Text = "";
                        Txtcontact.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Record Adding Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Not Connected");
                }
                db.close_db();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

    }
}
