using System.Data;
using System.IO.Packaging;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ADET_sample
{
    public partial class Events_tab : Form
    {
        private DateTime inititalSelectedDate;
        public Events_tab()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            FillEventsDataGridView(today, GetUpcomingEventsData());
            UpcomingEventsData = new DataGridView();
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
                    package, addOns, paymentStatus, staff1, staff2, staff3, staff4, contact, request, equipments);
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

                Events_Info eventsInfoForm = new Events_Info(this, eventName, eventType, venue, time, clientName, eventDate,
                    package, addOns, paymentStatus, staff1, staff2, staff3, staff4, contact, request, equipments);
                eventsInfoForm.Show();
            }
        }

        public DataGridView GetUpcomingEventsData()
        {
            return UpcomingEventsData;
        }

        //Filling the DataGrid View
        public void FillEventsDataGridView(DateTime selectedDate, DataGridView upcomingEventsData)
        {this.inititalSelectedDate = selectedDate;
            // Create a connection using a connection string
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                try
                {con.Open();
                    using (MySqlDataAdapter comm = new MySqlDataAdapter("SELECT * FROM event_management_system.event WHERE DATE_FORMAT(eventDate, '%Y/%m/%d') = @selectedDate", con))
                    {
                        // Add the selectedDate parameter to the command
                        comm.SelectCommand.Parameters.AddWithValue("@selectedDate", selectedDate.ToString("yyyy/MM/dd"));

                        // Create a DataTable to hold the data
                        DataTable EventTable = new DataTable();

                        // Fill the DataTable with data from the database
                        comm.Fill(EventTable);

                        // Check if the DataTable has any rows
                        if (EventTable.Rows.Count > 0)
                        {
                            // Assign the DataTable as the data source for the DataGridView
                            UpcomingEventsData.DataSource = EventTable;
                            UpcomingEventsData.Columns["eventName"].HeaderText = "Name";
                            UpcomingEventsData.Columns["eventType"].HeaderText = "Type";
                            UpcomingEventsData.Columns["eventVenue"].HeaderText = "Venue";
                            UpcomingEventsData.Columns["eventTime"].HeaderText = "Time";

                            // Hide columns not needed for display
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
                        else
                        {
                            // Optionally handle the case where no data is available
                            MessageBox.Show("No events found for the selected date.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that occurred during database access
                    MessageBox.Show("An error occurred while retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
