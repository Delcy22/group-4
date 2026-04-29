using HOTEL_RESERVATION.Pages.Dashboard;
using HOTEL_RESERVATION.Pages.Login;
using HOTEL_RESERVATION.Pages.Profile;
namespace HOTEL_RESERVATION
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            nameuser.Text = "Hi, " + UserSession.CurrentName;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gotoroom_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void nameuser_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            HOTEL_RESERVATION.Pages.Profile.Profile profile = new HOTEL_RESERVATION.Pages.Profile.Profile();
            profile.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        Application.Exit();
        }
    }
}
