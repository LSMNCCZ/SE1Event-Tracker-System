using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Ocsp;
using System.Globalization;
using System.IO.Packaging;
using System.Reflection;
using System.Security.Cryptography;

namespace ADET_sample
{
    public partial class Events_Info : Form
    {
        //initial values
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
        private string initialpType;
        private string initialpAmount;
        private string initialpDP;
        private string eventID;
        private string payID;
        private string balance;
        private Dictionary<string, int> packagePrices;
        private Dictionary<string, int> addOnPrices;
        private Dictionary<string, int> empPay;

        public Events_Info(Events_tab eventsTab, string eventName, string eventType, string venue, string time, string clientName,
            string eventDate, string package, string addOns, string paymentStatus, string staff1, string staff2,
            string staff3, string staff4, string contact, string request, string equipments, string eventID, string payID)
        {
            InitializeComponent();
            // Store the initial values of the text boxes and comboboxes
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
            this.payID = payID;
            this.eventID = eventID;

            this.packagePrices = new Dictionary<string, int>();
            this.addOnPrices = new Dictionary<string, int>();
            this.empPay = new Dictionary<string, int>();

            // Convert 24-hour time format into 12
            var timeParts = time.Split(':');
            this.hour = int.Parse(timeParts[0]);
            this.min = int.Parse(timeParts[1]);

            if (hour > 12)
            {
                hour -= 12;
                this.dayTime = "PM";
            }
            else
            {
                this.dayTime = "AM";
            }
            this.initialdayTime = dayTime;
            this.initialHour = hour.ToString();
            this.initialMin = min.ToString();

            // Connecting to DB for drop down options and getting balance
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                MySqlCommand packageOptions = new MySqlCommand("SELECT packageType FROM event_management_system.package;", con);
                MySqlCommand addOnsOptions = new MySqlCommand("SELECT addOnID FROM event_management_system.addon;", con);
                MySqlCommand staffOptions = new MySqlCommand("SELECT employeeName FROM event_management_system.employee;", con);

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

                // Getting balance
                MySqlCommand clientbalance = new MySqlCommand("SELECT * FROM event_management_system.invoice WHERE paymentID = @pID AND eventID = @eID;", con);
                clientbalance.Parameters.AddWithValue("@eID", this.eventID);
                clientbalance.Parameters.AddWithValue("@pID", this.payID);

                using (MySqlDataReader balancereader = clientbalance.ExecuteReader())
                {
                    if (balancereader.Read())
                    {
                        this.balance = balancereader["paymentBal"].ToString();
                        this.initialpType = balancereader["paymentType"].ToString();
                        this.initialpAmount = balancereader["totalAmount"].ToString();
                        this.initialpDP = balancereader["downpayment"].ToString();
                    }
                }

                // Getting prices
                MySqlCommand packageCommand = new MySqlCommand("SELECT packageType, packagePrice FROM event_management_system.package", con);
                using (MySqlDataReader packageReader = packageCommand.ExecuteReader())
                {
                    while (packageReader.Read())
                    {
                        string pType = packageReader.GetString("packageType");
                        int pPrice = packageReader.GetInt32("packagePrice");
                        this.packagePrices.Add(pType, pPrice);
                    }
                }

                MySqlCommand addOnCommand = new MySqlCommand("SELECT addOnID, addOnPrice FROM event_management_system.addon", con);
                using (MySqlDataReader addOnReader = addOnCommand.ExecuteReader())
                {
                    while (addOnReader.Read())
                    {
                        string AOID = addOnReader.GetString("addOnID");
                        int AOPrice = addOnReader.GetInt32("addOnPrice");
                        this.addOnPrices.Add(AOID, AOPrice);
                    }
                }

                MySqlCommand payCommand = new MySqlCommand("SELECT packageType, employeeRate FROM event_management_system.package", con);
                using (MySqlDataReader payReader = payCommand.ExecuteReader())
                {
                    while (payReader.Read())
                    {
                        string pType = payReader.GetString("packageType");
                        int empPay = payReader.GetInt32("employeeRate");
                        this.empPay.Add(pType, empPay);
                    }
                }
            }

            // Check if the event date is in the past
            DateTime eventDateTime;
            if (DateTime.TryParse(this.initialEventDate, out eventDateTime))
            {
                peReportBTN.Visible = eventDateTime < DateTime.Now;
            }

            // If Event Name is null (means adding a new Event)
            if (string.IsNullOrEmpty(eventName) && string.IsNullOrEmpty(eventType))
            {
                Edit_EventInfo.Text = "Add Event";
                Delete_EventInfo.Text = "Clear";
                ExitButton.Text = "Done";
                Down_BalLabel.Text = "Down Payment";

                EventNameTB.Visible = true;
                EventTypeTB.Visible = true;
                EventNameLabel.Visible = false;

                VenueTB.ReadOnly = false;
                ClientTB.ReadOnly = false;
                DateTB.ReadOnly = true;
                DateTB.Text = this.initialEventDate;
                ContactTB.ReadOnly = false;
                RequestTB.ReadOnly = false;
                EquipmentsTB.ReadOnly = false;

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

                Staff1DB.Visible = true;
                Staff2DB.Visible = true;
                Staff3DB.Visible = true;
                Staff4DB.Visible = true;
                AddOnsDB.Visible = true;

                RequestTB.BorderStyle = BorderStyle.FixedSingle;
                EquipmentsTB.BorderStyle = BorderStyle.FixedSingle;
                PickDateBT.Visible = true;

                UnderlineClient.Visible = true;
                UnderlineDate.Visible = true;
                UnderlinedContact.Visible = true;
                UnderlinedVenue.Visible = true;
                UnderlineEventName.Visible = true;
                UnderlineEventType.Visible = true;
                UNDownPayment.Visible = true;
            }
            else // for displaying selected date event and editing event details
            {
                MODlabel.Visible = false;
                MODCB.Visible = false;
                Down_BalLabel.Text = "Balance";
                DownPaymentTB.Text = this.balance;
                DownPaymentTB.ReadOnly = true;
                EventNameTB.Visible = false;
                EventTypeTB.Visible = false;
                EventNameLabel.Text = $"{eventName} - {eventType}";

                VenueTB.ReadOnly = true;
                VenueTB.Text = venue;

                HourCB.Enabled = false;
                MinCB.Enabled = false;
                AMPMCB.Enabled = false;
                HourCB.Text = this.initialHour;
                MinCB.Text = this.initialMin;
                AMPMCB.Text = this.initialdayTime;

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

                PackageDB.Enabled = false;
                PaymentStatusDB.Enabled = false;
                Staff1DB.Enabled = false;
                Staff2DB.Enabled = false;
                Staff3DB.Enabled = false;
                Staff4DB.Enabled = false;
                AddOnsDB.Enabled = false;

                UnderlineClient.Visible = false;
                UnderlineDate.Visible = false;
                UnderlinedContact.Visible = false;
                UnderlinedVenue.Visible = false;
                UnderlineEventName.Visible = false;
                UnderlineEventType.Visible = false;
                UNDownPayment.Visible = false;
                PickDateBT.Visible = false;

                PackageDB.Text = package;
                AddOnsDB.Text = string.IsNullOrEmpty(addOns) ? "None" : addOns;
                PaymentStatusDB.Text = paymentStatus;
                Staff1DB.Text = staff1;
                Staff2DB.Text = staff2;
                Staff3DB.Text = staff3;
                Staff4DB.Text = staff4;
            }

            if (GlobalVariables.UserRole != "Admin")
            {
                Delete_EventInfo.Enabled = false;
                Edit_EventInfo.Enabled = false;
            }

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
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

            Staff1DB.Visible = true;
            Staff2DB.Visible = true;
            Staff3DB.Visible = true;
            Staff4DB.Visible = true;
            AddOnsDB.Visible = true;
            RequestTB.BorderStyle = BorderStyle.FixedSingle;
            EquipmentsTB.BorderStyle = BorderStyle.FixedSingle;

            UnderlineClient.Visible = true;
            UnderlineDate.Visible = true;
            UnderlinedContact.Visible = true;
            UnderlinedVenue.Visible = true;

            PickDateBT.Visible = true;

            if (Edit_EventInfo.Text == "Save")
            {
                if (!IsFormValid())
                {
                    MessageBox.Show("All fields are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DownPaymentTB.ReadOnly = false;
                UNDownPayment.Visible = true;
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

                    string staff1 = Staff1DB.SelectedItem?.ToString() ?? "";
                    string staff2 = Staff2DB.SelectedItem?.ToString() ?? "";
                    string staff3 = Staff3DB.SelectedItem?.ToString() ?? "";
                    string staff4 = Staff4DB.SelectedItem?.ToString() ?? "";
                    string addOns = AddOnsDB.SelectedItem?.ToString() ?? "";
                    string equipments = EquipmentsTB.Text;

                    string hh = HourCB.Text;
                    string mm = MinCB.Text;
                    if (AMPMCB.Text == "PM")
                    {
                        int hour = int.Parse(hh);
                        hour += 12;
                        hh = hour.ToString();
                    }
                    string time = $"{hh}:{mm}:00";

                    string pbalance = paymentStatus == "FULL" ? "0" : this.balance;

                    UpdatingEventDataBase(eventName, eventType, venue, time, clientName, eventDate,
                            package, addOns, paymentStatus, staff1, staff2, staff3, staff4, contact, request, equipments, this.eventID, this.payID);

                    UpdateInvoice(this.eventID, this.payID, paymentStatus, this.initialpAmount, pbalance, this.initialpDP, this.initialpType);

                    Invoice Invoice = new Invoice(this.eventID, this.payID);
                    Invoice.Show();

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

                    UnderlineClient.Visible = false;
                    UnderlineDate.Visible = false;
                    UnderlinedContact.Visible = false;
                    UnderlinedVenue.Visible = false;

                    PackageDB.Text = package;
                    AddOnsDB.Text = string.IsNullOrEmpty(addOns) ? "None" : addOns;
                    PaymentStatusDB.Text = paymentStatus;

                    Staff1DB.Text = staff1;
                    Staff2DB.Text = staff2;
                    Staff3DB.Text = staff3;
                    Staff4DB.Text = staff4;

                    RefreshDataGridView();
                }
                else
                {
                    RevertValues();
                }
            }
            else if (Edit_EventInfo.Text == "Add Event")
            {
                if (!IsFormValid())
                {
                    MessageBox.Show("All fields are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
                    string staff1 = Staff1DB.SelectedItem?.ToString() ?? "";
                    string staff2 = Staff2DB.SelectedItem?.ToString() ?? "";
                    string staff3 = Staff3DB.SelectedItem?.ToString() ?? "";
                    string staff4 = Staff4DB.SelectedItem?.ToString() ?? "";
                    string addOns = AddOnsDB.SelectedItem?.ToString() ?? "";
                    string equipments = EquipmentsTB.Text;
                    string paymentType = MODCB.SelectedItem.ToString();

                    string hh = HourCB.Text;
                    string mm = MinCB.Text;
                    if (AMPMCB.Text == "PM")
                    {
                        int hour = int.Parse(hh);
                        hour += 12;
                        hh = hour.ToString();
                    }
                    string time = $"{hh}:{mm}:00";

                    string flEName = eventName.Substring(0, 1);
                    string flEType = eventType.Substring(0, 1);
                    string day = eventDate.Substring(8, 2);
                    string month = eventDate.Substring(5, 2);
                    string year = eventDate.Substring(2, 2);
                    string eID = flEName + flEType + day + month + year;
                    string pID = flEType + flEName + month + year;

                    int inttotalAmount = this.packagePrices[package];
                    if (!string.IsNullOrEmpty(addOns))
                    {
                        inttotalAmount += this.addOnPrices[addOns];
                    }

                    int dp = Convert.ToInt32(DownPaymentTB.Text);
                    int intbalance = inttotalAmount - dp;
                    string totalAmount = inttotalAmount.ToString();
                    string pbalance = paymentStatus == "FULL" ? "0" : intbalance.ToString();

                    UpdatingEventDataBase(eventName, eventType, venue, time, clientName, eventDate,
                            package, addOns, paymentStatus, staff1, staff2, staff3, staff4, contact, request, equipments, eID, pID);

                    UpdateInvoice(eID, pID, paymentStatus, totalAmount, pbalance, dp.ToString(), paymentType);

                    AddStaffPayout(staff1, eID, package, eventDate);
                    AddStaffPayout(staff2, eID, package, eventDate);
                    AddStaffPayout(staff3, eID, package, eventDate);
                    AddStaffPayout(staff4, eID, package, eventDate);

                    Invoice Invoice = new Invoice(eID, pID);
                    Invoice.Show();

                    EventNameLabel.Visible = true;
                    EventNameTB.Visible = false;
                    EventTypeTB.Visible = false;
                    EventNameLabel.Text = $"{eventName} - {eventType}";

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

                    UnderlineClient.Visible = false;
                    UnderlineDate.Visible = false;
                    UnderlinedContact.Visible = false;
                    UnderlinedVenue.Visible = false;

                    PackageDB.Text = package;
                    AddOnsDB.Text = string.IsNullOrEmpty(addOns) ? "None" : addOns;
                    PaymentStatusDB.Text = paymentStatus;

                    Staff1DB.Text = staff1;
                    Staff2DB.Text = staff2;
                    Staff3DB.Text = staff3;
                    Staff4DB.Text = staff4;

                    Delete_EventInfo.Enabled = false;

                    RefreshDataGridView();
                }
                else
                {
                    ClearFormFields();
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
                        MySqlCommand command = new MySqlCommand("DELETE FROM event_management_system.event WHERE eventName = @EventName AND eventDate = @EventDate", con);
                        command.Parameters.AddWithValue("@EventName", this.initialEventName);
                        command.Parameters.AddWithValue("@EventDate", this.initialEventDate);
                        command.ExecuteNonQuery();

                        MySqlCommand command2 = new MySqlCommand("DELETE FROM event_management_system.invoice WHERE eventID = @eID AND paymentID = @pID", con);
                        command2.Parameters.AddWithValue("@eID", this.eventID);
                        command2.Parameters.AddWithValue("@pID", this.payID);
                        command2.ExecuteNonQuery();

                        MySqlCommand command3 = new MySqlCommand("DELETE FROM event_management_system.payout WHERE eventID = @eID", con);
                        command3.Parameters.AddWithValue("@eID", this.eventID);
                        command3.ExecuteNonQuery();

                        RefreshDataGridView();
                        this.Close();
                    }
                }
                else
                {
                    ClearFormFields();
                }
            }
            else if (Delete_EventInfo.Text == "Clear")
            {
                ClearFormFields();
            }
        }

        private void ClearFormFields()
        {
            EventNameTB.Visible = true;
            EventTypeTB.Visible = true;
            EventNameLabel.Visible = false;

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

            VenueTB.ReadOnly = false;
            HourCB.Enabled = true;
            MinCB.Enabled = true;
            AMPMCB.Enabled = true;
            ClientTB.ReadOnly = false;
            DateTB.ReadOnly = true;
            ContactTB.ReadOnly = false;
            RequestTB.ReadOnly = false;
            DateTB.ReadOnly = true;

            PackageDB.Enabled = true;
            PaymentStatusDB.Enabled = true;
            Staff1DB.Enabled = true;
            Staff2DB.Enabled = true;
            Staff3DB.Enabled = true;
            Staff4DB.Enabled = true;
            AddOnsDB.Enabled = true;

            Staff1DB.Visible = true;
            Staff2DB.Visible = true;
            Staff3DB.Visible = true;
            Staff4DB.Visible = true;
            AddOnsDB.Visible = true;

            RequestTB.BorderStyle = BorderStyle.FixedSingle;
            EquipmentsTB.BorderStyle = BorderStyle.FixedSingle;

            PickDateBT.Visible = true;
        }

        private void peReportBTN_Click(object sender, EventArgs e)
        {
            string reportID = this.eventID.Substring(2, 6) + this.eventID.Substring(0, 2);
            bool eventin = IsEventReportPosted(this.eventID);
            PostReport report = new PostReport(this.initialdayTime, this.eventID, reportID, eventin);
            report.Show();
        }

        private void AddStaffPayout(string staffName, string eventID, string packageType, string eventDate)
        {
            if (!string.IsNullOrEmpty(staffName))
            {
                using (MySqlConnection con = DatabaseConnection.GetConnection())
                {
                    con.Open();
                    MySqlCommand empCommand = new MySqlCommand("SELECT employeeID FROM event_management_system.employee WHERE employeeName = @empName", con);
                    empCommand.Parameters.AddWithValue("@empName", staffName);
                    using (MySqlDataReader empReader = empCommand.ExecuteReader())
                    {
                        if (empReader.Read())
                        {
                            string empID = empReader.GetString("employeeID");
                            int pAmount = this.empPay[packageType];
                            UpdatePayout(empID, eventID, packageType, eventDate, pAmount);
                        }
                    }
                }
            }
        }

        private bool IsFormValid()
        {
            return !string.IsNullOrEmpty(VenueTB.Text) && !string.IsNullOrEmpty(ClientTB.Text) && !string.IsNullOrEmpty(DateTB.Text) &&
                   !string.IsNullOrEmpty(ContactTB.Text) && PackageDB.SelectedItem != null && PaymentStatusDB.SelectedItem != null && HourCB.SelectedItem != null &&
                   MinCB.SelectedItem != null && AMPMCB.SelectedItem != null;
        }

        private void RevertValues()
        {
            EventNameLabel.Text = $"{this.initialEventName} - {this.initialEventType}";
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

        private void UpdatingEventDataBase(string eventName, string eventType, string venue, string time, string clientName,
            string eventDate, string package, string addOns, string paymentStatus, string staff1, string staff2,
            string staff3, string staff4, string contact, string request, string equipments, string eventID, string paymentID)
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
                    command.ExecuteNonQuery();

                    Edit_EventInfo.Enabled = false;
                    Delete_EventInfo.Enabled = false;
                }
                else if (Edit_EventInfo.Text == "Add Event")
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO event_management_system.event(eventID, paymentID, eventName, eventType, eventVenue, " +
                        "eventTime, clientName, eventDate, packageType, addOn, paymentStatus, staff1, staff2, " +
                        "staff3, staff4, clientNum, additionalReq, equipNeeded) VALUES (@EventID, @PaymentID, @EventName, @EventType, @Venue, @Time, " +
                        "@Client, @Date, @Package, @AddOns, @PaymentStatus, @Staff1, @Staff2, @Staff3, @Staff4, " +
                        "@Contact, @Request,@Equipments)", con);
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
                    command.ExecuteNonQuery();

                    Edit_EventInfo.Enabled = false;
                    Delete_EventInfo.Enabled = false;
                }
            }
        }

        private void UpdateInvoice(string eID, string payID, string paymentStatus, string totalAmount, string balance, string downpayment, string paymentType)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                if (Edit_EventInfo.Text == "Save")
                {
                    MySqlCommand command = new MySqlCommand("UPDATE event_management_system.invoice SET paymentStatus = @pStatus, paymentBal = @pBal " +
                        "WHERE eventID = @eID AND paymentID =@payID", con);
                    command.Parameters.AddWithValue("@eID", eID);
                    command.Parameters.AddWithValue("@payID", payID);
                    command.Parameters.AddWithValue("@pStatus", paymentStatus);
                    command.Parameters.AddWithValue("@pBal", balance);
                    command.ExecuteNonQuery();

                    DownPaymentTB.Text = balance;
                }
                else if (Edit_EventInfo.Text == "Add Event")
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO event_management_system.invoice(paymentID, eventID, paymentStatus, paymentType, totalAmount, paymentBal, downpayment) " +
                        "VALUES (@payID, @eID, @pStatus, @pType, @tAmount, @pbal, @dp)", con);
                    command.Parameters.AddWithValue("@eID", eID);
                    command.Parameters.AddWithValue("@payID", payID);
                    command.Parameters.AddWithValue("@pStatus", paymentStatus);
                    command.Parameters.AddWithValue("@tAmount", totalAmount);
                    command.Parameters.AddWithValue("@pType", paymentType);
                    command.Parameters.AddWithValue("@pbal", balance);
                    command.Parameters.AddWithValue("@dp", downpayment);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void UpdatePayout(string empID, string eventID, string packageType, string pMonth, int pAmount)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO event_management_system.payout(employeeID, eventID, packageType, payoutMonth, payoutAmount, payoutStatus) " +
                    "VALUES (@empID, @eventID, @pType, @pMonth, @pAmount, @pStatus)", con);
                command.Parameters.AddWithValue("@empID", empID);
                command.Parameters.AddWithValue("@eventID", eventID);
                command.Parameters.AddWithValue("@pType", packageType);
                command.Parameters.AddWithValue("@pMonth", pMonth);
                command.Parameters.AddWithValue("@pAmount", pAmount);
                command.Parameters.AddWithValue("@pStatus", "Pending");
                command.ExecuteNonQuery();
            }
        }

        public void RefreshDataGridView()
        {
            DateTime selectedDate = DateTime.ParseExact(this.initialEventDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            eventsTab.FillEventsDataGridView(selectedDate);
        }

        private void PickDateBT_Click(object sender, EventArgs e)
        {
            PickDateBT.Visible = true;
            EventInfoDatePicker.Visible = true;
        }

        private void EventInfoDatePicker_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTB.Text = EventInfoDatePicker.SelectionStart.ToString("yyyy-MM-dd");
            EventInfoDatePicker.Visible = false;
        }

        private void AMPMCB_SelectedIndexChanged(object sender, EventArgs e) { }

        private bool IsEventReportPosted(string eventID)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM event_management_system.posteventreport WHERE eventID = @eventID", con);
                cmd.Parameters.AddWithValue("@eventID", eventID);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


