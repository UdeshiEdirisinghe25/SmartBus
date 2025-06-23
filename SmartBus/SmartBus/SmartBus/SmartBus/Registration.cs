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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtUsename.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(Txtcontact.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtPassword.Text.Length < 8 || txtPassword.Text.Length > 12)
                {
                    MessageBox.Show("Password must be between 8 and 12 characters long.", "Invalid Password Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var db = new DBconnection();
                if (db.connect_db())
                {
                    string name = txtName.Text;
                    string email = txtEmail.Text;
                    string username = txtUsename.Text;
                    string password = txtPassword.Text;
                    string contact = Txtcontact.Text;

                    string query = "INSERT INTO users (Name, UserName, Password, ContactNo, Email, UserType) " +
                                   "VALUES (@Name, @UserName, @Password, @ContactNo, @Email, @UserType)";

                    MySqlCommand cmd = new MySqlCommand(query, db.mysqlconnection);

                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@ContactNo", contact);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@UserType", "User");

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record Added Successfully");

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
