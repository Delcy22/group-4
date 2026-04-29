using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HOTEL_RESERVATION.Pages.Login
{
    public partial class Login : Form
    {

       string connString = DbConfig.ConnString;

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string email = emaillogin.Text.Trim();
            string password = passwordlogin.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string passwordPattern = @"^[a-zA-Z0-9]+$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (!Regex.IsMatch(password, passwordPattern))
            {
                MessageBox.Show("Password must only contain letters and numbers.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM RegistrationDetails WHERE Email = @Email AND PasswordHash = @PasswordHash";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PasswordHash", password);
                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        string queryName = "SELECT IDCardNumber,FirstName,LastName,ContactNumber,Email FROM RegistrationDetails WHERE Email = @Email";
                        using (SqlCommand cmdName = new SqlCommand(queryName, conn))
                        {
                            cmdName.Parameters.AddWithValue("@Email", email);
                            using (SqlDataReader reader = cmdName.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    UserSession.CurrentIdcard = reader["IDCardNumber"].ToString();
                                    UserSession.CurrentName = reader["FirstName"].ToString();
                                    UserSession.CurrentSurname = reader["LastName"].ToString();
                                    UserSession.CurrentContact = reader["ContactNumber"].ToString();
                                    UserSession.CurrentEmail = reader["Email"].ToString();
                                }
                            }
                            UserSession.IsLoggedIn = true;
                        }

                        MessageBox.Show("Login successful!");

                        Homepage homepage = new Homepage();
                        homepage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.");
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HOTEL_RESERVATION.Pages.Registration.Registration registration = new HOTEL_RESERVATION.Pages.Registration.Registration();
            registration.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();

        }

        private void emaillogin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
