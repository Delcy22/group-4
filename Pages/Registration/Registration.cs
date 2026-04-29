using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HOTEL_RESERVATION.Pages.Registration
{
    public partial class Registration : Form
    {
        string connString = DbConfig.ConnString;

        public Registration()
        {
            InitializeComponent();
        }


        private void registerbtn_Click(object sender, EventArgs e)
        {
            string firstName = firstname.Text.Trim();
            string Surname = surname.Text.Trim();
            string Email = email.Text.Trim();
            string Password = password.Text.Trim();
            string Nationalid = nationalid.Text.Trim();
            string Contact = contact.Text.Trim();

            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(Surname) && !string.IsNullOrEmpty(Email) &&
                !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(Nationalid) && !string.IsNullOrEmpty(Contact))
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                string passwordPattern = @"^[a-zA-Z0-9]+$";
                string zimIdPattern = @"^\d{2}\d{6,8}[A-Z]\d{2}$";
                string zimContactPattern = @"^(071|073|077|078)\d{7}$";

                if (!Regex.IsMatch(Email, emailPattern))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }

                if (!Regex.IsMatch(Password, passwordPattern))
                {
                    MessageBox.Show("Password must only contain letters and numbers.");
                    return;
                }

                if (!Regex.IsMatch(Nationalid.Replace("-", ""), zimIdPattern))
                {
                    MessageBox.Show("Please enter a valid National ID.");
                    return;
                }

                if (!Regex.IsMatch(Contact, zimContactPattern))
                {
                    MessageBox.Show("Please enter a valid contact number.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // Check if either the Email OR the National ID already exists
                    string checkQuery = "SELECT COUNT(*) FROM RegistrationDetails WHERE Email = @Email OR IDCardNumber = @NationalId";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", Email);
                        checkCmd.Parameters.AddWithValue("@NationalId", Nationalid);
                        int userExists = (int)checkCmd.ExecuteScalar();

                        if (userExists > 0)
                        {
                            MessageBox.Show("A user with this Email or National ID is already registered.");
                            return;
                        }
                    }

                    string query = "INSERT INTO RegistrationDetails (IDCardNumber, FirstName, LastName, ContactNumber, Email, PasswordHash) VALUES (@NationalId, @FirstName, @LastName, @Contact, @Email, @Password)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", Surname);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@NationalId", Nationalid);
                        cmd.Parameters.AddWithValue("@Contact", Contact);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Registration successful!");
                            Homepage home = new Homepage();
                            home.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.");
            }
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }

        private void firstname_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
