

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace HOTEL_RESERVATION.Pages.Dashboard
{
    public partial class Dashboard : Form
    {

        string connString = DbConfig.ConnString;

        public Dashboard()
        {
            InitializeComponent();
        }


        private bool IsRoomAvailable(int roomId)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT Status FROM Rooms WHERE RoomID = @RoomID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomID", roomId);
                    object status = cmd.ExecuteScalar();

                    if (status != null && status.ToString() == "Available")
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        private void UpdateRoomStatusUI()
        {

            Label[] statusLabels = { labelAvailable1, labelAvailable2, labelAvailable3, labelAvailable4, labelAvailable5, labelAvailable6 };
            Button[] roomButtons = { Room1btn, Room2btn, Room3btn, Room4btn, Room5btn, Room6btn };

            for (int i = 0; i < 6; i++)
            {
                int currentRoomId = i + 1;

                if (IsRoomAvailable(currentRoomId))
                {
                    statusLabels[i].Text = "Available";
                    statusLabels[i].ForeColor = Color.Green;
                    roomButtons[i].Enabled = true;
                }
                else
                {
                    statusLabels[i].Text = "Fully Booked";
                    statusLabels[i].ForeColor = Color.Red;
                    roomButtons[i].Enabled = false;
                }
            }
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            UpdateRoomStatusUI();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnbooking_Click(object sender, EventArgs e)
        {
            HOTEL_RESERVATION.Pages.Booking.Booking booking = new HOTEL_RESERVATION.Pages.Booking.Booking();
            booking.Show();
            this.Hide();
        }

        private void anemitiesbtn_Click(object sender, EventArgs e)
        {

            HOTEL_RESERVATION.Pages.Amenities.Amenities amenities = new HOTEL_RESERVATION.Pages.Amenities.Amenities();
            amenities.Show();
            this.Hide();

        }

        private void continueToBooking(int id, decimal moneynight, string bookingType)
        {
            if (UserSession.IsLoggedIn)
            {

                HOTEL_RESERVATION.Pages.Booking.Booking myBooking = new HOTEL_RESERVATION.Pages.Booking.Booking(id, moneynight, bookingType);
                myBooking.Show();
                this.Hide();
            }
            else
            {

                DialogResult result = MessageBox.Show(
                    "You must be logged in to book a room. Would you like to log in now?",
                    "Login Required",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );


                if (result == DialogResult.Yes)
                {

                    HOTEL_RESERVATION.Pages.Login.Login login = new HOTEL_RESERVATION.Pages.Login.Login();
                    login.Show();
                    this.Hide();

                }
            }
        }

        private void Room1btn_Click(object sender, EventArgs e)
        {
            int roomId = 1;
            decimal moneynight = 100;
            string bookingType = "Standard";

            if (IsRoomAvailable(roomId))
            {
                continueToBooking(roomId, moneynight, bookingType);
            }
            else
            {
                MessageBox.Show("Sorry, this room is already booked by another user.");
            }
        }

        private void btndining_Click(object sender, EventArgs e)
        {
            HOTEL_RESERVATION.Pages.Dining.Dining dining = new HOTEL_RESERVATION.Pages.Dining.Dining();
            dining.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }

        private void Room2btn_Click(object sender, EventArgs e)
        {
            int roomId = 2;
            decimal moneynight = 150;
            string bookingType = "Standard";

            if (IsRoomAvailable(roomId))
            {
                continueToBooking(roomId, moneynight, bookingType);
            }
            else
            {
                MessageBox.Show("Sorry, this room is already booked by another user.");
            }
        }

        private void Room3btn_Click(object sender, EventArgs e)
        {
            int roomId = 3;
            decimal moneynight = 90;
            string bookingType = "Standard";

            if (IsRoomAvailable(roomId))
            {
                continueToBooking(roomId, moneynight, bookingType);
            }
            else
            {
                MessageBox.Show("Sorry, this room is already booked by another user.");
            }
        }

        private void Room4btn_Click(object sender, EventArgs e)
        {
            int roomId = 4;
            decimal moneynight = 300;
            string bookingType = "VIP";

            if (IsRoomAvailable(roomId))
            {
                continueToBooking(roomId, moneynight, bookingType);
            }
            else
            {
                MessageBox.Show("Sorry, this room is already booked by another user.");
            }
        }

        private void Room5btn_Click(object sender, EventArgs e)
        {
            int roomId = 5;
            decimal moneynight = 230;
            string bookingType = "VIP";

            if (IsRoomAvailable(roomId))
            {
                continueToBooking(roomId, moneynight, bookingType);
            }
            else
            {
                MessageBox.Show("Sorry, this room is already booked by another user.");
            }
        }

        private void Room6btn_Click(object sender, EventArgs e)
        {
            int roomId = 6;
            decimal moneynight = 400;
            string bookingType = "VIP";

            if (IsRoomAvailable(roomId))
            {
                continueToBooking(roomId, moneynight, bookingType);
            }
            else
            {
                MessageBox.Show("Sorry, this room is already booked by another user.");
            }
        }
    }
}
