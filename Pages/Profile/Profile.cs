using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HOTEL_RESERVATION.Pages.Profile
{
    public partial class Profile : Form
    {
        string connString = DbConfig.ConnString;

        public Profile()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (profileview.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = profileview.SelectedRows[0];
                string fname = selectedRow.Cells["FirstName"].Value.ToString();
                string lname = selectedRow.Cells["LastName"].Value.ToString();

                if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname))
                {
                    MessageBox.Show("First Name and (or) Last Name cannot be empty.");
                }
                else
                {
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();
                        string updateQuery = @"UPDATE RegistrationDetails
                                           SET FirstName = @FirstName, LastName = @LastName
                                           WHERE Email = @LoggedEmail";
                        SqlCommand cmd = new SqlCommand(updateQuery, conn);
                        cmd.Parameters.AddWithValue("@FirstName", fname);
                        cmd.Parameters.AddWithValue("@LastName", lname);
                        cmd.Parameters.AddWithValue("@LoggedEmail", UserSession.CurrentEmail);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Profile update failed. Please try again.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a full row first!");
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            LoadProfileData();
        }

        private void LoadProfileData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = @"SELECT
                    B.BookingID,
                    R.FirstName, 
                    R.LastName, 
                    B.CheckInDate, 
                    B.DaysStayed, 
                    B.TotalAmount,
                    B.PaymentType,
                    B.RoomId
                FROM RegistrationDetails R
                INNER JOIN BookingDetails B
                    ON R.IDCardNumber = B.IDCardNumber
                WHERE R.Email = @LoggedEmail";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LoggedEmail", UserSession.CurrentEmail);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                profileview.DataSource = dt;

                if (profileview.Columns.Contains("BookingID"))
                {
                    profileview.Columns["BookingID"].Visible = false;
                }
            }
        }


        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (profileview.SelectedRows.Count > 0)
            {
                string selectedRecordId = profileview.SelectedRows[0].Cells["BookingID"].Value.ToString();
                string selectedroom = profileview.SelectedRows[0].Cells["RoomId"].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this specific record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();
                        string deleteBookings = @"DELETE FROM BookingDetails WHERE BookingID = @RecordId";

                        using (SqlCommand cmd1 = new SqlCommand(deleteBookings, conn))
                        {
                            cmd1.Parameters.AddWithValue("@RecordId", selectedRecordId);
                            int rowsAffected = cmd1.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Logic: After booking is deleted, immediately free up the room in the Rooms table
                                string updateRoomQuery = @"UPDATE Rooms SET Status = 'Available' WHERE RoomID = @RoomId";

                                using (SqlCommand cmdUpdate = new SqlCommand(updateRoomQuery, conn))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@RoomId", selectedroom);
                                    cmdUpdate.ExecuteNonQuery();
                                }

                                MessageBox.Show("Record deleted successfully and Room is now Available.");
                                LoadProfileData();
                            }
                            else
                            {
                                MessageBox.Show("Deletion failed. Record might not exist.");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }


    }
}