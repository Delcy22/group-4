using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HOTEL_RESERVATION.Pages.Dining
{
    public partial class Dining : Form
    {
        public Dining()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            HOTEL_RESERVATION.Pages.Dashboard.Dashboard dashboard = new HOTEL_RESERVATION.Pages.Dashboard.Dashboard();
            dashboard.Show();
            this.Hide();

        }

        private void anemitiesbtn_Click(object sender, EventArgs e)
        {
            HOTEL_RESERVATION.Pages.Amenities.Amenities amenities = new HOTEL_RESERVATION.Pages.Amenities.Amenities();
            amenities.Show();
            this.Hide();
        }

        private void btnbooking_Click(object sender, EventArgs e)
        {
            HOTEL_RESERVATION.Pages.Booking.Booking booking = new HOTEL_RESERVATION.Pages.Booking.Booking();
            booking.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }
    }
}
