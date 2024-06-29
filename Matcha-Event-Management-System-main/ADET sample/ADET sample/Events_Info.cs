
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Windows.Input;

namespace ADET_sample
{
    public partial class Events_Info : Form
    {   //initial values
        private Events_tab eventsTab;
        private string initialEventName;
        private string initialEventType;
        private string initialVenue;
        private string initialTime;
        private string initialClientName;
        private string initialEventDate;
        private string initialContact;
        private string initialRequest;
        private string initialPaymentStatus;
        private string initialPackage;
        private string initialAddOns;
        private string initialStaff1;
        private string initialStaff2;
        private string initialStaff3;
        private string initialStaff4;
        private string initialEquipments;
        private int hour;
        private int min;
        private string dayTime;
        private string initialHour;
        private string initialMin;
        private string initialdayTime;

        public Events_Info(Events_tab eventsTab, string eventName, string eventType, string venue, string time, string clientName,
            string eventDate, string package, string addOns, string paymentStatus, string staff1, string staff2,
            string staff3, string staff4, string contact, string request, string equipments)
        {
            InitializeComponent();
            // Store the initial values of the text boxes and comboboxes para accessible sa lahut
            // Store the initial values of the text boxes and comboboxes para accessible sa lahut
            this.eventsTab = eventsTab;
            this.initialEventName = eventName;
            this.initialEventType = eventType;
            this.initialVenue = venue;
            this.initialTime = time;
            this.initialClientName = clientName;
            this.initialEventDate = eventDate;
            this.initialContact = contact;
            this.initialRequest = request;
            this.initialPaymentStatus = paymentStatus;
            this.initialPackage = package;
            this.initialAddOns = addOns;
            this.initialStaff1 = staff1;
            this.initialStaff2 = staff2;
            this.initialStaff3 = staff3;
            this.initialStaff4 = staff3;
            this.initialEquipments = equipments;

            //convert 24hours time format into 12
            var timeParts = time.Split(':');
            this.hour = int.Parse(timeParts[0]);
            this.min = int.Parse(timeParts[1]);

            if (hour > 12)
            {
                hour = hour - 12;
                this.dayTime = "PM";
            }
            else
            {
                this.dayTime = "AM";
            }
            this.initialdayTime = dayTime;
            string hourStr = hour.ToString();
            string minStr = min.ToString();
            this.initialHour = hourStr;
            this.initialMin = minStr;
            //
            //CONNECTING TO DB FOR DROP DOWN OPTIONS
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                MySqlCommand packageOptions = new MySqlCommand("SELECT packageType FROM event_management_system.package;", con);//package
                MySqlCommand addOnsOptions = new MySqlCommand("SELECT addOnID FROM event_management_system.addon;", con);//addons
                MySqlCommand staffOptions = new MySqlCommand("SELECT employeeName FROM event_management_system.employee;", con);//staff options

                using (MySqlDataReader packagereader = packageOptions.ExecuteReader())
                {
                    while (packagereader.Read())
                    {
                        string packageTypeOP = packagereader.GetString(0);
                        PackageDB.Items.Add(packageTypeOP);

                    }
                }

                using (MySqlDataReader addOnsreader = addOnsOptions.ExecuteReader())
                {
                    while (addOnsreader.Read())
                    {
                        string addOnsOP = addOnsreader.GetString(0);
                        AddOnsDB.Items.Add(addOnsOP);
                    }
                }

                using (MySqlDataReader staffreader = staffOptions.ExecuteReader())
                {
                    while (staffreader.Read())
                    {
                        string staffOP = staffreader.GetString(0);
                        Staff1DB.Items.Add(staffOP);
                        Staff2DB.Items.Add(staffOP);
                        Staff3DB.Items.Add(staffOP);
                        Staff4DB.Items.Add(staffOP);
                    }
                }

            }


            //If Event Name is null(means adding a new Event)
            if (eventName == null && eventType == null || eventName == "" && eventType == "")
            {
                Edit_EventInfo.Text = "Add Event";
                Delete_EventInfo.Text = "Clear";
                ExitButton.Text = "Done";

                EventNameTB.Visible = true;
                EventTypeTB.Visible = true;
                EventNameLabel.Visible = false;

                // Make the text boxes editable
                VenueTB.ReadOnly = false;
                ClientTB.ReadOnly = false;
                DateTB.ReadOnly = true;
                DateTB.Text = this.initialEventDate;
                ContactTB.ReadOnly = false;
                RequestTB.ReadOnly = false;
                EquipmentsTB.ReadOnly = false;

                // Make the combo boxes editable
                HourCB.Enabled = true;
                MinCB.Enabled = true;
                AMPMCB.Enabled = true;
                PackageDB.Enabled = true;
                PaymentStatusDB.Enabled = true;
                Staff1DB.Enabled = true;
                Staff2DB.Enabled = true;
                Staff3DB.Enabled = true;
                Staff4DB.Enabled = true;
                AddOnsDB.Enabled = true;

                //Visibility of additional staff
                Staff1DB.Visible = true;
                Staff2DB.Visible = true;
                Staff3DB.Visible = true;
                Staff4DB.Visible = true;
                AddOnsDB.Visible = true;


                RequestTB.BorderStyle = BorderStyle.FixedSingle;
                EquipmentsTB.BorderStyle = BorderStyle.FixedSingle;
                //new pick date should not be allowed
                PickDateBT.Visible = true;

                //visibility of underlines
                UnderlineClient.Visible = true;
                UnderlineDate.Visible = true;
                UnderlinedContact.Visible = true;
                UnderlinedVenue.Visible = true;
                UnderlineEventName.Visible = true;
                UnderlineEventType.Visible = true;

            }
            else//for displaying selected date event and editing event details.
            {
                EventNameTB.Visible = false;
                EventTypeTB.Visible = false;
                EventNameLabel.Text = eventName + " - " + eventType;
                //Making All Text Box initially display values according to Database's record
                VenueTB.ReadOnly = true;
                VenueTB.Text = venue;

                //Time
                HourCB.Enabled = false;
                MinCB.Enabled = false;
                AMPMCB.Enabled = false;
                HourCB.Text = hourStr;
                MinCB.Text = minStr;
                AMPMCB.Text = dayTime;

                ClientTB.ReadOnly = true;
                ClientTB.Text = clientName;

                DateTB.ReadOnly = true;
                DateTB.Text = eventDate;

                ContactTB.ReadOnly = true;
                ContactTB.Text = contact;

                RequestTB.ReadOnly = true;
                RequestTB.Text = request;

                EquipmentsTB.ReadOnly = true;
                EquipmentsTB.Text = equipments;

                //Making Drop Down options static
                PackageDB.Enabled = false;
                PaymentStatusDB.Enabled = false;
                Staff1DB.Enabled = false;
                Staff2DB.Enabled = false;
                Staff3DB.Enabled = false;
                Staff4DB.Enabled = false;
                AddOnsDB.Enabled = false;

                //visibility of underlines
                UnderlineClient.Visible = false;
                UnderlineDate.Visible = false;
                UnderlinedContact.Visible = false;
                UnderlinedVenue.Visible = false;
                UnderlineEventName.Visible = false;
                UnderlineEventType.Visible = false;

                PickDateBT.Visible = false;

                PackageDB.Text = package;

                if (addOns != "")
                {
                    AddOnsDB.Text = addOns;
                }
                else
                {
                    AddOnsDB.Text = "None";
                }



                PaymentStatusDB.Text = paymentStatus;


                if (staff1 != "")
                {
                    Staff1DB.Text = staff1;
                }
                else
                {
                    Staff1DB.Visible = false;
                }

                if (staff2 != "")
                {
                    Staff2DB.Text = staff2;
                }
                else
                {
                    Staff2DB.Visible = false;
                }
                if (staff3 != "")
                {
                    Staff3DB.Text = staff3;
                }
                else
                {
                    Staff3DB.Visible = false;
                }
                if (staff4 != "")
                {
                    Staff4DB.Text = staff4;
                }
                else
                {
                    Staff4DB.Visible = false;
                }
            }

        }


        private void EventNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void EventInfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void PackageLabel_Click(object sender, EventArgs e)
        {

        }

        private void TotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void ContactLabel_Click(object sender, EventArgs e)
        {

        }

        private void StaffsLabel_Click(object sender, EventArgs e)
        {

        }

        private void TimeLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void VenueLabel_Click(object sender, EventArgs e)
        {

        }

        private void PaymentStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void RequestLabel_Click(object sender, EventArgs e)
        {

        }

        private void DateTB_TextChanged(object sender, EventArgs e)
        {

        }


        private void ClientTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContactTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Staff1TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void VenueTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void PaymentStatusTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void RequestTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClientLabel_Click(object sender, EventArgs e)
        {

        }

        private void PaymentStatusDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddOnsLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddOnsTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit_EventInfo_Click(object sender, EventArgs e)
        {
            // Make the text boxes editable
            VenueTB.ReadOnly = false;
            ClientTB.ReadOnly = false;
            DateTB.ReadOnly = false;
            ContactTB.ReadOnly = false;
            RequestTB.ReadOnly = false;

            // Make the combo boxes editable
            HourCB.Enabled = true;
            MinCB.Enabled = true;
            AMPMCB.Enabled = true;
            PackageDB.Enabled = true;
            PaymentStatusDB.Enabled = true;
            Staff1DB.Enabled = true;
            Staff2DB.Enabled = true;
            Staff3DB.Enabled = true;
            Staff4DB.Enabled = true;
            AddOnsDB.Enabled = true;

            //Visibility of additional staff
            Staff1DB.Visible = true;
            Staff2DB.Visible = true;
            Staff3DB.Visible = true;
            Staff4DB.Visible = true;
            AddOnsDB.Visible = true;
            RequestTB.BorderStyle = BorderStyle.FixedSingle;
            EquipmentsTB.BorderStyle = BorderStyle.FixedSingle;

            //visibility of underlines
            UnderlineClient.Visible = true;
            UnderlineDate.Visible = true;
            UnderlinedContact.Visible = true;
            UnderlinedVenue.Visible = true;

            PickDateBT.Visible = true;

            if (Edit_EventInfo.Text == "Save")
            {
                if (MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string eventName = this.initialEventName;
                    string eventType = this.initialEventType;
                    string venue = VenueTB.Text;
                    
                    string clientName = ClientTB.Text;
                    string eventDate = DateTB.Text;
                    string contact = ContactTB.Text;
                    string request = RequestTB.Text;
                    string package = PackageDB.SelectedItem.ToString();
                    string paymentStatus = PaymentStatusDB.SelectedItem.ToString();

                    string staff1 = (Staff1DB.SelectedItem == null || Staff1DB.SelectedItem == "" || Staff1DB.SelectedItem == "None") ? "" : Staff1DB.SelectedItem.ToString();
                    string staff2 = (Staff2DB.SelectedItem == null || Staff2DB.SelectedItem == "" || Staff2DB.SelectedItem == "None") ? "" : Staff2DB.SelectedItem.ToString();
                    string staff3 = (Staff3DB.SelectedItem == null || Staff3DB.SelectedItem == "" || Staff3DB.SelectedItem == "None") ? "" : Staff3DB.SelectedItem.ToString();
                    string staff4 = (Staff4DB.SelectedItem == null || Staff4DB.SelectedItem == "" || Staff4DB.SelectedItem == "None") ? "" : Staff4DB.SelectedItem.ToString();

                    string addOns = AddOnsDB.SelectedItem.ToString();
                    string equipments = EquipmentsTB.Text;

                    //Time
                    string hh = HourCB.Text;
                    string mm = MinCB.Text;
                    if(AMPMCB.Text == "PM")
                    {
                        int  hour = int.Parse(hh);
                        hour = hour + 12;
                        hh = hour.ToString();
                    }
                    string concatTime = hh + ":" + mm + ":" + "00";
                    string time = concatTime;


                    UpdatingEventDataBase(eventName, eventType, venue, time, clientName, eventDate,
                            package, addOns, paymentStatus, staff1, staff2, staff3, staff4, contact, request, equipments);


                    //Making All Text Box initially display values according to Database's record
                    VenueTB.ReadOnly = true;
                    VenueTB.Text = venue;


                    ClientTB.ReadOnly = true;
                    ClientTB.Text = clientName;

                    DateTB.ReadOnly = true;
                    DateTB.Text = eventDate;

                    ContactTB.ReadOnly = true;
                    ContactTB.Text = contact;

                    RequestTB.ReadOnly = true;
                    RequestTB.Text = request;

                    EquipmentsTB.ReadOnly = true;
                    EquipmentsTB.Text = equipments;

                    //Making Drop Down options static
                    HourCB.Enabled = false;
                    MinCB.Enabled = false;
                    AMPMCB.Enabled = false;
                    PackageDB.Enabled = false;
                    PaymentStatusDB.Enabled = false;
                    Staff1DB.Enabled = false;
                    Staff2DB.Enabled = false;
                    Staff3DB.Enabled = false;
                    Staff4DB.Enabled = false;
                    AddOnsDB.Enabled = false;

                    //visibility of underlines
                    UnderlineClient.Visible = false;
                    UnderlineDate.Visible = false;
                    UnderlinedContact.Visible = false;
                    UnderlinedVenue.Visible = false;

                    PackageDB.Text = package;

                    if (addOns != "")
                    {
                        AddOnsDB.Text = addOns;
                    }
                    else
                    {
                        AddOnsDB.Text = "None";
                    }



                    PaymentStatusDB.Text = paymentStatus;


                    // Making the remaining Staff combo boxes static
                    Staff1DB.Enabled = false;
                    Staff2DB.Enabled = false;
                    Staff3DB.Enabled = false;
                    Staff4DB.Enabled = false;

                    // Visibility of remaining Staff combo boxes
                    Staff1DB.Visible = !string.IsNullOrEmpty(staff1);
                    Staff2DB.Visible = !string.IsNullOrEmpty(staff2);
                    Staff3DB.Visible = !string.IsNullOrEmpty(staff3);
                    Staff4DB.Visible = !string.IsNullOrEmpty(staff4);

                    // Set the text for the remaining Staff combo boxes
                    Staff1DB.Text = staff1;
                    Staff2DB.Text = staff2;
                    Staff3DB.Text = staff3;
                    Staff4DB.Text = staff4;

                    //refresh data grid
                    RefreshDataGridView();
                }
                else
                {
                    //RevertValues
                    EventNameLabel.Text = this.initialEventName + " - " + this.initialEventType;
                    VenueTB.Text = this.initialVenue;
                    HourCB.Text = this.initialHour;
                    MinCB.Text = this.initialMin;
                    AMPMCB.Text = this.initialdayTime;
                    ClientTB.Text = this.initialClientName;
                    DateTB.Text = this.initialEventDate;
                    ContactTB.Text = this.initialContact;
                    RequestTB.Text = this.initialRequest;
                    PaymentStatusDB.Text = this.initialPaymentStatus;
                    PackageDB.Text = this.initialPackage;
                    AddOnsDB.Text = this.initialAddOns;
                    Staff1DB.Text = this.initialStaff1;
                    Staff2DB.Text = this.initialStaff2;
                    Staff3DB.Text = this.initialStaff3;
                    Staff4DB.Text = this.initialStaff4;
                    EquipmentsTB.Text = this.initialEquipments;

                }

            }
            else if (Edit_EventInfo.Text == "Add Event")
            {
                Delete_EventInfo.Enabled = true;
                if (MessageBox.Show("Do you want to add event?", "Add Event", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string eventName = EventNameTB.Text;
                    string eventType = EventTypeTB.Text;
                    string venue = VenueTB.Text;
                    
                    string clientName = ClientTB.Text;
                    string eventDate = DateTB.Text;
                    string contact = ContactTB.Text;
                    string request = RequestTB.Text;
                    string package = PackageDB.SelectedItem.ToString();
                    string paymentStatus = PaymentStatusDB.SelectedItem.ToString();

                    string staff1 = (Staff1DB.SelectedItem == null || Staff1DB.SelectedItem == "" || Staff1DB.SelectedItem == "None") ? "" : Staff1DB.SelectedItem.ToString();
                    string staff2 = (Staff2DB.SelectedItem == null || Staff2DB.SelectedItem == "" || Staff2DB.SelectedItem == "None") ? "" : Staff2DB.SelectedItem.ToString();
                    string staff3 = (Staff3DB.SelectedItem == null || Staff3DB.SelectedItem == "" || Staff3DB.SelectedItem == "None") ? "" : Staff3DB.SelectedItem.ToString();
                    string staff4 = (Staff4DB.SelectedItem == null || Staff4DB.SelectedItem == "" || Staff4DB.SelectedItem == "None") ? "" : Staff4DB.SelectedItem.ToString();

                    string addOns = (AddOnsDB.SelectedItem == null || AddOnsDB.SelectedItem == "" || AddOnsDB.SelectedItem == "None") ? "" : AddOnsDB.SelectedItem.ToString();
                    string equipments = EquipmentsTB.Text;

                    //Time
                    string hh = HourCB.Text;
                    string mm = MinCB.Text;
                    if (AMPMCB.Text == "PM")
                    {
                        int hour = int.Parse(hh);
                        hour = hour + 12;
                        hh = hour.ToString();
                    }
                    string concatTime = hh + ":" + mm + ":" + "00";
                    string time = concatTime;

                    UpdatingEventDataBase(eventName, eventType, venue, time, clientName, eventDate,
                            package, addOns, paymentStatus, staff1, staff2, staff3, staff4, contact, request, equipments);

                    //Locking saved values from saving
                    EventNameLabel.Visible = true;
                    EventNameTB.Visible = false;
                    EventTypeTB.Visible = false;
                    EventNameLabel.Text = eventName + " - " + eventType;

                    //Making All Text Box initially display values according to Database's record
                    VenueTB.ReadOnly = true;
                    VenueTB.Text = venue;


                    ClientTB.ReadOnly = true;
                    ClientTB.Text = clientName;

                    DateTB.ReadOnly = true;
                    DateTB.Text = eventDate;

                    ContactTB.ReadOnly = true;
                    ContactTB.Text = contact;

                    RequestTB.ReadOnly = true;
                    RequestTB.Text = request;

                    EquipmentsTB.ReadOnly = true;
                    EquipmentsTB.Text = equipments;


                    //Making Drop Down options static
                    HourCB.Enabled = false;
                    MinCB.Enabled = false;
                    AMPMCB.Enabled = false;
                    PackageDB.Enabled = false;
                    PaymentStatusDB.Enabled = false;
                    Staff1DB.Enabled = false;
                    Staff2DB.Enabled = false;
                    Staff3DB.Enabled = false;
                    Staff4DB.Enabled = false;
                    AddOnsDB.Enabled = false;

                    //visibility of underlines
                    UnderlineClient.Visible = false;
                    UnderlineDate.Visible = false;
                    UnderlinedContact.Visible = false;
                    UnderlinedVenue.Visible = false;

                    PackageDB.Text = package;

                    if (addOns != "")
                    {
                        AddOnsDB.Text = addOns;
                    }
                    else
                    {
                        AddOnsDB.Text = "None";
                    }



                    PaymentStatusDB.Text = paymentStatus;


                    // Making the remaining Staff combo boxes static
                    Staff1DB.Enabled = false;
                    Staff2DB.Enabled = false;
                    Staff3DB.Enabled = false;
                    Staff4DB.Enabled = false;

                    // Visibility of remaining Staff combo boxes
                    Staff1DB.Visible = !string.IsNullOrEmpty(staff1);
                    Staff2DB.Visible = !string.IsNullOrEmpty(staff2);
                    Staff3DB.Visible = !string.IsNullOrEmpty(staff3);
                    Staff4DB.Visible = !string.IsNullOrEmpty(staff4);

                    // Set the text for the remaining Staff combo boxes
                    Staff1DB.Text = staff1;
                    Staff2DB.Text = staff2;
                    Staff3DB.Text = staff3;
                    Staff4DB.Text = staff4;

                    //clearbutton disabled upon adding event
                    Delete_EventInfo.Enabled = false;

                    //refresh data grid
                    RefreshDataGridView();

                }
                else
                {
                    //RevertValues
                    EventNameTB.Text = null;
                    EventTypeTB.Text = null;
                    VenueTB.Text = null;
                    ClientTB.Text = null;
                    DateTB.Text = null;
                    ContactTB.Text = null;
                    RequestTB.Text = null;
                    PaymentStatusDB.Text = null;
                    PackageDB.Text = null;
                    AddOnsDB.Text = null;
                    Staff1DB.Text = null;
                    Staff2DB.Text = null;
                    Staff3DB.Text = null;
                    Staff4DB.Text = null;
                    EquipmentsTB.Text = null;
                }
            }
            if (Edit_EventInfo.Text != "Add Event")
            {
                Edit_EventInfo.Text = "Save";
                PickDateBT.Visible = true;
            }

        }

        private void Delete_EventInfo_Click(object sender, EventArgs e)
        {
            if (Delete_EventInfo.Text == "Delete")
            {
                if (MessageBox.Show("Do you want to delete event?", "Delete Event", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (MySqlConnection con = DatabaseConnection.GetConnection())
                    {
                        con.Open();
                        MySqlCommand command = new MySqlCommand("DELETE FROM event_management_system.event WHERE " +
                            "eventName = @EventName AND eventDate = @EventDate", con);

                        string deleteEventName = this.initialEventName;
                        DateTime deleteDate = DateTime.ParseExact(this.initialEventDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                        // Set the parameters for the command
                        command.Parameters.AddWithValue("@EventName", deleteEventName);
                        command.Parameters.AddWithValue("@EventDate", deleteDate);

                        // Execute the command to update the data in the database
                        command.ExecuteNonQuery();
                        RefreshDataGridView();
                        this.Close();
                    }
                }
                else
                {
                    //RevertValues
                    EventNameTB.Visible = true;
                    EventTypeTB.Visible = true;
                    EventNameLabel.Visible = false;
                    //Making All textbox and Combo box empty
                    EventNameTB.Text = "Event Name -";
                    EventTypeTB.Text = "Event Type -";
                    VenueTB.Text = "";
                    HourCB.Text = "";
                    MinCB.Text = "";
                    AMPMCB.Text = "";
                    ClientTB.Text = "";
                    DateTB.Text = this.initialEventDate;
                    ContactTB.Text = "";
                    RequestTB.Text = "";
                    EquipmentsTB.Text = "";
                    PackageDB.SelectedIndex = -1;
                    PaymentStatusDB.SelectedIndex = -1;
                    Staff1DB.SelectedIndex = -1;
                    Staff2DB.SelectedIndex = -1;
                    Staff3DB.SelectedIndex = -1;
                    Staff4DB.SelectedIndex = -1;
                    AddOnsDB.SelectedIndex = -1;

                    // Make the text boxes editable
                    VenueTB.ReadOnly = false;
                    HourCB.Enabled = false;
                    MinCB.Enabled = false;
                    AMPMCB.Enabled = false;
                    ClientTB.ReadOnly = false;
                    DateTB.ReadOnly = true;
                    ContactTB.ReadOnly = false;
                    RequestTB.ReadOnly = false;
                    DateTB.ReadOnly = true;


                    // Make the combo boxes editable
                    PackageDB.Enabled = true;
                    PaymentStatusDB.Enabled = true;
                    Staff1DB.Enabled = true;
                    Staff2DB.Enabled = true;
                    Staff3DB.Enabled = true;
                    Staff4DB.Enabled = true;
                    AddOnsDB.Enabled = true;

                    //Visibility of additional staff
                    Staff1DB.Visible = true;
                    Staff2DB.Visible = true;
                    Staff3DB.Visible = true;
                    Staff4DB.Visible = true;
                    AddOnsDB.Visible = true;


                    RequestTB.BorderStyle = BorderStyle.FixedSingle;
                    EquipmentsTB.BorderStyle = BorderStyle.FixedSingle;
                    
                    PickDateBT.Visible = true;
                }
            }
            else if (Delete_EventInfo.Text == "Clear")
            {
                EventNameTB.Visible = true;
                EventTypeTB.Visible = true;
                EventNameLabel.Visible = false;
                //Making All textbox and Combo box empty
                EventNameTB.Text = "Event Name -";
                EventTypeTB.Text = "Event Type -";
                VenueTB.Text = "";
                HourCB.Text = "";
                MinCB.Text = "";
                AMPMCB.Text = "";
                ClientTB.Text = "";
                DateTB.Text = this.initialEventDate;
                ContactTB.Text = "";
                RequestTB.Text = "";
                EquipmentsTB.Text = "";
                PackageDB.SelectedIndex = -1;
                PaymentStatusDB.SelectedIndex = -1;
                Staff1DB.SelectedIndex = -1;
                Staff2DB.SelectedIndex = -1;
                Staff3DB.SelectedIndex = -1;
                Staff4DB.SelectedIndex = -1;
                AddOnsDB.SelectedIndex = -1;

                // Make the text boxes editable
                VenueTB.ReadOnly = false;
                HourCB.Enabled = false;
                MinCB.Enabled = false;
                AMPMCB.Enabled = false;
                ClientTB.ReadOnly = false;
                DateTB.ReadOnly = true;
                ContactTB.ReadOnly = false;
                RequestTB.ReadOnly = false;
                DateTB.ReadOnly = true;


                // Make the combo boxes editable
                PackageDB.Enabled = true;
                PaymentStatusDB.Enabled = true;
                Staff1DB.Enabled = true;
                Staff2DB.Enabled = true;
                Staff3DB.Enabled = true;
                Staff4DB.Enabled = true;
                AddOnsDB.Enabled = true;

                //Visibility of additional staff
                Staff1DB.Visible = true;
                Staff2DB.Visible = true;
                Staff3DB.Visible = true;
                Staff4DB.Visible = true;
                AddOnsDB.Visible = true;


                RequestTB.BorderStyle = BorderStyle.FixedSingle;
                EquipmentsTB.BorderStyle = BorderStyle.FixedSingle;
                
                PickDateBT.Visible = true;
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddOnsDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Staff1DB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Staff2DB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Staff3DB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Staff4DB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PackageDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void EventNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdatingEventDataBase(string eventName, string eventType, string venue, string time, string clientName,
            string eventDate, string package, string addOns, string paymentStatus, string staff1, string staff2,
            string staff3, string staff4, string contact, string request, string equipments)
        {   
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                if (Edit_EventInfo.Text == "Save")
                {
                    MySqlCommand command = new MySqlCommand("UPDATE event_management_system.event SET eventVenue = @Venue, eventTime = @Time, " +
                        "clientName = @Client, eventDate = @Date, clientNum = @Contact, packageType = @Package, paymentStatus = @PaymentStatus, " +
                        "staff1 = @Staff1, staff2 = @Staff2, staff3 = @Staff3, staff4 = @Staff4, addOn = @AddOns, " +
                        "additionalReq = @Request, equipNeeded =@Equipments WHERE eventName = @EventName AND eventType =@EventType", con);
                    // Set the parameters for the command
                    command.Parameters.AddWithValue("@EventName", eventName);
                    command.Parameters.AddWithValue("@EventType", eventType);
                    command.Parameters.AddWithValue("@Venue", venue);
                    command.Parameters.AddWithValue("@Time", time);
                    command.Parameters.AddWithValue("@Client", clientName);
                    command.Parameters.AddWithValue("@Date", eventDate);
                    command.Parameters.AddWithValue("@Contact", contact);
                    command.Parameters.AddWithValue("@Package", package);
                    command.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                    command.Parameters.AddWithValue("@Staff1", staff1);
                    command.Parameters.AddWithValue("@Staff2", staff2);
                    command.Parameters.AddWithValue("@Staff3", staff3);
                    command.Parameters.AddWithValue("@Staff4", staff4);
                    command.Parameters.AddWithValue("@AddOns", addOns);
                    command.Parameters.AddWithValue("@Request", request);
                    command.Parameters.AddWithValue("@Equipments", equipments);

                    // Execute the command to update the data in the database
                    command.ExecuteNonQuery();
                }
                else if (Edit_EventInfo.Text == "Add Event")
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO event_management_system.event(eventID, paymentID, eventName, eventType, eventVenue, " +
                        "eventTime, clientName, eventDate, packageType, addOn, paymentStatus, staff1, staff2, " +
                        "staff3, staff4, clientNum, additionalReq, equipNeeded) VALUES (@EventID, @PaymentID, @EventName, @EventType, @Venue, @Time, " +
                        "@Client, @Date, @Package, @AddOns, @PaymentStatus, @Staff1, @Staff2, @Staff3, @Staff4, " +
                        "@Contact, @Request,@Equipments)", con);

                    //Generate payment ID and eventID 
                    string flEName = eventName.Substring(0, 1);
                    string flEType = eventType.Substring(0, 1);
                    string day = eventDate.Substring(8, 2);
                    string month = eventDate.Substring(5, 2);
                    string year = eventDate.Substring(2, 2);
                    string eventID = flEName + flEType + day + month + year;
                    string paymentID = flEType + flEName + month + year;



                    // Set the parameters for the command
                    command.Parameters.AddWithValue("@EventID", eventID);
                    command.Parameters.AddWithValue("@PaymentID", paymentID);
                    command.Parameters.AddWithValue("@EventName", eventName);
                    command.Parameters.AddWithValue("@EventType", eventType);
                    command.Parameters.AddWithValue("@Venue", venue);
                    command.Parameters.AddWithValue("@Time", time);
                    command.Parameters.AddWithValue("@Client", clientName);
                    command.Parameters.AddWithValue("@Date", eventDate);
                    command.Parameters.AddWithValue("@Contact", contact);
                    command.Parameters.AddWithValue("@Package", package);
                    command.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                    command.Parameters.AddWithValue("@Staff1", staff1);
                    command.Parameters.AddWithValue("@Staff2", staff2);
                    command.Parameters.AddWithValue("@Staff3", staff3);
                    command.Parameters.AddWithValue("@Staff4", staff4);
                    command.Parameters.AddWithValue("@AddOns", addOns);
                    command.Parameters.AddWithValue("@Request", request);
                    command.Parameters.AddWithValue("@Equipments", equipments);
                    //Make add event button unavail pag clicked once
                    Edit_EventInfo.Enabled = false;
                    // Execute the command to update the data in the database
                    command.ExecuteNonQuery();
                }
            }
        }
        public void RefreshDataGridView()
        {
            DateTime selectedDate = DateTime.ParseExact(this.initialEventDate, "yyyy-MM-dd", CultureInfo.InvariantCulture); ;
            eventsTab.FillEventsDataGridView(selectedDate, eventsTab.GetUpcomingEventsData());

        }

        private void PickDateBT_Click(object sender, EventArgs e)
        {
            PickDateBT.Visible = true;
            EventInfoDatePicker.Visible = true;

        }
        private void EventInfoDatePicker_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Set the selected date to DateTB
            DateTB.Text = EventInfoDatePicker.SelectionStart.ToString("yyyy-MM-dd");

            // Hide the calendar after clicking date
            EventInfoDatePicker.Visible = false;


        }
    }

}

