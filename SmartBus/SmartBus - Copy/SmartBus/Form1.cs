using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace SmartBus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }  

        private void btnLogin_Click(object sender, EventArgs e)
        {

            // Get username and password from textboxes
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Basic validation 
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password cannot be empty!");

                return;

            }
            else if (password.Length < 8 || password.Length > 12)
            {
                MessageBox.Show($"Password must be at least {8} characters long.", "Short Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                MessageBox.Show("Please wait a moment!", "Login In ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // database
            // database
            try
            {
                var db = new DBconnection();
                if (db.connect_db())
                {
                    string query = "SELECT * FROM users WHERE UserName = @username AND Password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, db.mysqlconnection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string userID = reader["UserID"]?.ToString() ?? "";
                            string userName = reader["UserName"]?.ToString() ?? "";
                            string userType = reader["UserType"]?.ToString() ?? "";

                            MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            if (userType == "Admin")
                            {
                                Admin admin = new Admin();
                                admin.Show();
                                this.Hide();
                            }
                            else if (userType == "User")
                            {
                                User user = new User(userName,userID);
                                user.Show();
                                this.Hide();
                            }


                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            
        }
    }
}
