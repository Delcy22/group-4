using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HOTEL_RESERVATION.Pages.Booking
{
    public partial class Booking : Form
    {

        string connString = DbConfig.ConnString;
        public string chosenPaymentMethod = "";

        private int bookindId = 0;
        private decimal bookingMoney = 0;
        private string bookingType = "Null";

        public Booking(int bookingId, decimal bookingMoney, string bookingType)
        {
            InitializeComponent();
            this.bookindId = bookingId;
            this.bookingMoney = bookingMoney;
            this.bookingType = bookingType;
        }


        public Booking()
        {
            InitializeComponent();


        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HOTEL_RESERVATION.Pages.Dining.Dining dining = new HOTEL_RESERVATION.Pages.Dining.Dining();
            dining.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ecocashpic_Click(object sender, EventArgs e)
        {
            chosenPaymentMethod = "EcoCash";
            ecocashpic.BorderStyle = BorderStyle.Fixed3D;
        }

        private void cabspic_Click(object sender, EventArgs e)
        {
            chosenPaymentMethod = "CABS";
            cabspic.BorderStyle = BorderStyle.Fixed3D;
        }

        private void completebtn_Click(object sender, EventArgs e)
        {
            string idcardnum = UserSession.CurrentIdcard;
            DateTime checkInDate = datetimepicker.Value.Date;
            string paymentMethod = chosenPaymentMethod;

            if (!int.TryParse(stayingdays.Text, out int StayingDays))
            {
                MessageBox.Show("Please enter a valid number for staying days.");
                return;
            }

            if (!int.TryParse(moneynight.Text, out int pricePerNight))
            {
                MessageBox.Show("Room price is missing or invalid.");
                return;
            }

            DateTime checkOutDate = checkInDate.AddDays(StayingDays);
            int totalMoney = pricePerNight * StayingDays;

            if (string.IsNullOrEmpty(paymentMethod))
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            if (string.IsNullOrEmpty(idcardnum))
            {
                MessageBox.Show("User session data is missing. Please log in again.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO BookingDetails (IDCardNumber, CheckInDate, DaysStayed, CheckOutDate, PaymentType, TotalAmount, RoomId) VALUES (@IDCardNumber, @CheckInDate, @DaysStayed, @CheckOutDate, @PaymentType, @TotalAmount, @roomidy)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDCardNumber", idcardnum);
                        cmd.Parameters.AddWithValue("@CheckInDate", checkInDate);
                        cmd.Parameters.AddWithValue("@DaysStayed", StayingDays);
                        cmd.Parameters.AddWithValue("@CheckOutDate", checkOutDate);
                        cmd.Parameters.AddWithValue("@PaymentType", paymentMethod);
                        cmd.Parameters.AddWithValue("@TotalAmount", totalMoney);
                        cmd.Parameters.AddWithValue("@roomidy", bookindId);
                        cmd.ExecuteNonQuery();

                        string updateQuery = "UPDATE Rooms SET Status = 'Booked' WHERE RoomID = @RoomID";
                        using (SqlCommand cmd1 = new SqlCommand(updateQuery, conn))
                        {
                            cmd1.Parameters.AddWithValue("@RoomID", bookindId);
                            cmd1.ExecuteNonQuery();
                        }

                        MessageBox.Show("Room Booked Successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while processing your booking: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HOTEL_RESERVATION.Pages.Amenities.Amenities amenities = new HOTEL_RESERVATION.Pages.Amenities.Amenities();
            amenities.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOTEL_RESERVATION.Pages.Dashboard.Dashboard dashboard = new HOTEL_RESERVATION.Pages.Dashboard.Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }

        private void roomID_Click(object sender, EventArgs e)
        {

        }

        private void Booking_Load(object sender, EventArgs e)
        {
            roomID.Text = bookindId.ToString();
            roomtype.Text = bookingType.ToString();
            moneynight.Text = bookingMoney.ToString();
            fullname.Text = UserSession.CurrentName + UserSession.CurrentSurname;
            idnum.Text = UserSession.CurrentIdcard;
            email.Text = UserSession.CurrentEmail;
            contact.Text = UserSession.CurrentContact;
            datetimepicker.MinDate = DateTime.Today;
        }
    }
}
