using MySql.Data.MySqlClient;
using System.Data;

namespace ADET_sample
{
    public partial class Events_tab : Form
    {
        private DateTime inititalSelectedDate;
        public Events_tab()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            FillEventsDataGridView(today);
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            DateTime dateToConvert = this.inititalSelectedDate;
            string eventDate = dateToConvert.ToString("yyyy-MM-dd");

            string eventName = null;
            string eventType = null;
            string venue = null;
            string time = "00:00:00";
            string clientName = null;

            string package = null;
            string addOns = null;
            string paymentStatus = null;
            string staff1 = null;
            string staff2 = null;
            string staff3 = null;
            string staff4 = null;
            string contact = null;
            string request = null;
            string equipments = null;

            Events_Info events_Info = new Events_Info(this, eventName, eventType, venue, time, clientName, eventDate,
                    package, addOns, paymentStatus, staff1, staff2, staff3, staff4, contact, request, equipments, null, null);
            events_Info.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Events_tab_Load(object sender, EventArgs e)
        {
        }

        private void UpcomingEventsData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = UpcomingEventsData.Rows[e.RowIndex];

                string eventName = selectedRow.Cells["eventName"].Value.ToString();
                string eventType = selectedRow.Cells["eventType"].Value.ToString();
                string venue = selectedRow.Cells["eventVenue"].Value.ToString();
                string time = selectedRow.Cells["eventTime"].Value.ToString();
                string clientName = selectedRow.Cells["clientName"].Value.ToString();

                DateTime selectedEventDate = Convert.ToDateTime(selectedRow.Cells["eventDate"].Value);
                string eventDate = selectedEventDate.ToString("yyyy-MM-dd");

                string package = selectedRow.Cells["packageType"].Value.ToString();
                string addOns = selectedRow.Cells["addOn"].Value.ToString();
                string paymentStatus = selectedRow.Cells["paymentStatus"].Value.ToString();
                string staff1 = selectedRow.Cells["staff1"].Value.ToString();
                string staff2 = selectedRow.Cells["staff2"].Value.ToString();
                string staff3 = selectedRow.Cells["staff3"].Value.ToString();
                string staff4 = selectedRow.Cells["staff4"].Value.ToString();
                string contact = selectedRow.Cells["clientNum"].Value.ToString();
                string request = selectedRow.Cells["additionalReq"].Value.ToString();
                string equipments = selectedRow.Cells["equipNeeded"].Value.ToString();
                string payID = selectedRow.Cells["paymentID"].Value.ToString();
                string eventID = selectedRow.Cells["eventID"].Value.ToString();

                Events_Info eventsInfoForm = new Events_Info(this, eventName, eventType, venue, time, clientName, eventDate,
                    package, addOns, paymentStatus, staff1, staff2, staff3, staff4, contact, request, equipments, eventID, payID);
                eventsInfoForm.Show();
            }
        }

        //Filling the DataGrid View
        public void FillEventsDataGridView(DateTime selectedDate)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                this.inititalSelectedDate = selectedDate;
                con.Open();
                MySqlDataAdapter Events = new MySqlDataAdapter("SELECT * FROM event WHERE DATE_FORMAT(eventDate, '%Y/%m/%d') = @selectedDate  ", con);
                Events.SelectCommand.Parameters.AddWithValue("@selectedDate", selectedDate);
                DataTable EventTable = new DataTable();
                Events.Fill(EventTable);
                UpcomingEventsData.DataSource = EventTable;

                //static data events table
                UpcomingEventsData.ReadOnly = true;

                //Changing name to appear sa header
                UpcomingEventsData.Columns["eventName"].HeaderText = "Name";
                UpcomingEventsData.Columns["eventType"].HeaderText = "Type";
                UpcomingEventsData.Columns["eventVenue"].HeaderText = "Venue";
                UpcomingEventsData.Columns["eventTime"].HeaderText = "Time";


                // Hide columns na di pa need sa display
                UpcomingEventsData.Columns["eventID"].Visible = false;
                UpcomingEventsData.Columns["paymentID"].Visible = false;
                UpcomingEventsData.Columns["equipNeeded"].Visible = false;
                UpcomingEventsData.Columns["clientName"].Visible = false;
                UpcomingEventsData.Columns["eventDate"].Visible = false;
                UpcomingEventsData.Columns["packageType"].Visible = false;
                UpcomingEventsData.Columns["addOn"].Visible = false;
                UpcomingEventsData.Columns["paymentStatus"].Visible = false;
                UpcomingEventsData.Columns["staff1"].Visible = false;
                UpcomingEventsData.Columns["staff2"].Visible = false;
                UpcomingEventsData.Columns["staff3"].Visible = false;
                UpcomingEventsData.Columns["staff4"].Visible = false;
                UpcomingEventsData.Columns["additionalReq"].Visible = false;
                UpcomingEventsData.Columns["clientNum"].Visible = false;
            }
        }
    }
}

