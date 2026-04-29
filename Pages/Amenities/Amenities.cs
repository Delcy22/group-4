using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HOTEL_RESERVATION.Pages.Amenities
{
    public partial class Amenities : Form
    {
        public Amenities()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOTEL_RESERVATION.Pages.Dashboard.Dashboard dashboard = new HOTEL_RESERVATION.Pages.Dashboard.Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HOTEL_RESERVATION.Pages.Dining.Dining dining = new HOTEL_RESERVATION.Pages.Dining.Dining();
            dining.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
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
