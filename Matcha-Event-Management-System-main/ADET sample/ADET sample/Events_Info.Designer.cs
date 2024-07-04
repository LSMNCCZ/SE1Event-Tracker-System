using Org.BouncyCastle.Tls;
using System.Windows.Forms;

namespace ADET_sample
{
    partial class Events_Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events_Info));
            process1 = new System.Diagnostics.Process();
            panel3 = new Panel();
            MODCB = new ComboBox();
            EventInfoDatePicker = new MonthCalendar();
            MODlabel = new Label();
            DownPaymentTB = new TextBox();
            UNDownPayment = new TextBox();
            Down_BalLabel = new Label();
            PickDateBT = new ADETADET_sample.RBButton();
            MinCB = new ComboBox();
            HourCB = new ComboBox();
            AMPMCB = new ComboBox();
            EquipmentsTB = new TextBox();
            EquipmentsLabel = new Label();
            EventTypeTB = new TextBox();
            EventNameTB = new TextBox();
            PackageDB = new ComboBox();
            Staff4DB = new ComboBox();
            Staff3DB = new ComboBox();
            Staff2DB = new ComboBox();
            Staff1DB = new ComboBox();
            AddOnsDB = new ComboBox();
            PaymentStatusDB = new ComboBox();
            AddOnsLabel = new Label();
            RequestTB = new TextBox();
            VenueTB = new TextBox();
            ContactTB = new TextBox();
            DateTB = new TextBox();
            ClientTB = new TextBox();
            TimeLabel = new Label();
            RequestLabel = new Label();
            PaymentStatusLabel = new Label();
            VenueLabel = new Label();
            PackageLabel = new Label();
            StaffsLabel = new Label();
            ContactLabel = new Label();
            DateLabel = new Label();
            ClientLabel = new Label();
            EventNameLabel = new Label();
            Delete_EventInfo = new ADETADET_sample.RBButton();
            Edit_EventInfo = new ADETADET_sample.RBButton();
            UnderlineClient = new TextBox();
            UnderlinedContact = new TextBox();
            UnderlinedVenue = new TextBox();
            UnderlineEventName = new TextBox();
            UnderlineEventType = new TextBox();
            UnderlineDate = new TextBox();
            TimedotLabel = new Label();
            EventInfoLabel = new Label();
            ExitButton = new ADETADET_sample.RBButton();
            peReportBTN = new ADETADET_sample.RBButton();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(MODCB);
            panel3.Controls.Add(EventInfoDatePicker);
            panel3.Controls.Add(MODlabel);
            panel3.Controls.Add(DownPaymentTB);
            panel3.Controls.Add(UNDownPayment);
            panel3.Controls.Add(Down_BalLabel);
            panel3.Controls.Add(PickDateBT);
            panel3.Controls.Add(MinCB);
            panel3.Controls.Add(HourCB);
            panel3.Controls.Add(AMPMCB);
            panel3.Controls.Add(EquipmentsTB);
            panel3.Controls.Add(EquipmentsLabel);
            panel3.Controls.Add(EventTypeTB);
            panel3.Controls.Add(EventNameTB);
            panel3.Controls.Add(PackageDB);
            panel3.Controls.Add(Staff4DB);
            panel3.Controls.Add(Staff3DB);
            panel3.Controls.Add(Staff2DB);
            panel3.Controls.Add(Staff1DB);
            panel3.Controls.Add(AddOnsDB);
            panel3.Controls.Add(PaymentStatusDB);
            panel3.Controls.Add(AddOnsLabel);
            panel3.Controls.Add(RequestTB);
            panel3.Controls.Add(VenueTB);
            panel3.Controls.Add(ContactTB);
            panel3.Controls.Add(DateTB);
            panel3.Controls.Add(ClientTB);
            panel3.Controls.Add(TimeLabel);
            panel3.Controls.Add(RequestLabel);
            panel3.Controls.Add(PaymentStatusLabel);
            panel3.Controls.Add(VenueLabel);
            panel3.Controls.Add(PackageLabel);
            panel3.Controls.Add(StaffsLabel);
            panel3.Controls.Add(ContactLabel);
            panel3.Controls.Add(DateLabel);
            panel3.Controls.Add(ClientLabel);
            panel3.Controls.Add(EventNameLabel);
            panel3.Controls.Add(Delete_EventInfo);
            panel3.Controls.Add(Edit_EventInfo);
            panel3.Controls.Add(UnderlineClient);
            panel3.Controls.Add(UnderlinedContact);
            panel3.Controls.Add(UnderlinedVenue);
            panel3.Controls.Add(UnderlineEventName);
            panel3.Controls.Add(UnderlineEventType);
            panel3.Controls.Add(UnderlineDate);
            panel3.Controls.Add(TimedotLabel);
            panel3.Location = new Point(8, 54);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(810, 545);
            panel3.TabIndex = 5;
            // 
            // MODCB
            // 
            MODCB.BackColor = Color.FromArgb(223, 232, 215);
            MODCB.DropDownStyle = ComboBoxStyle.DropDownList;
            MODCB.FormattingEnabled = true;
            MODCB.Items.AddRange(new object[] { "Bank Transfer", "Cash", "G-Cash", "PayMaya" });
            MODCB.Location = new Point(553, 327);
            MODCB.Margin = new Padding(2, 3, 2, 3);
            MODCB.Name = "MODCB";
            MODCB.Size = new Size(140, 33);
            MODCB.Sorted = true;
            MODCB.TabIndex = 62;
            // 
            // EventInfoDatePicker
            // 
            EventInfoDatePicker.Location = new Point(471, 24);
            EventInfoDatePicker.Name = "EventInfoDatePicker";
            EventInfoDatePicker.TabIndex = 39;
            EventInfoDatePicker.Visible = false;
            EventInfoDatePicker.DateChanged += EventInfoDatePicker_DateChanged;
            // 
            // MODlabel
            // 
            MODlabel.AutoSize = true;
            MODlabel.Location = new Point(547, 299);
            MODlabel.Margin = new Padding(2, 0, 2, 0);
            MODlabel.Name = "MODlabel";
            MODlabel.Size = new Size(154, 25);
            MODlabel.TabIndex = 59;
            MODlabel.Text = "Mode of Payment";
            MODlabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DownPaymentTB
            // 
            DownPaymentTB.BackColor = Color.FromArgb(223, 232, 215);
            DownPaymentTB.BorderStyle = BorderStyle.None;
            DownPaymentTB.Location = new Point(554, 262);
            DownPaymentTB.Margin = new Padding(2, 3, 2, 3);
            DownPaymentTB.Name = "DownPaymentTB";
            DownPaymentTB.Size = new Size(194, 24);
            DownPaymentTB.TabIndex = 57;
            // 
            // UNDownPayment
            // 
            UNDownPayment.BackColor = Color.FromArgb(223, 232, 215);
            UNDownPayment.BorderStyle = BorderStyle.None;
            UNDownPayment.Location = new Point(554, 266);
            UNDownPayment.Margin = new Padding(2, 3, 2, 3);
            UNDownPayment.Name = "UNDownPayment";
            UNDownPayment.ReadOnly = true;
            UNDownPayment.Size = new Size(229, 24);
            UNDownPayment.TabIndex = 58;
            UNDownPayment.TabStop = false;
            UNDownPayment.Text = "_____________________________";
            // 
            // Down_BalLabel
            // 
            Down_BalLabel.AutoSize = true;
            Down_BalLabel.Location = new Point(547, 235);
            Down_BalLabel.Margin = new Padding(2, 0, 2, 0);
            Down_BalLabel.Name = "Down_BalLabel";
            Down_BalLabel.Size = new Size(136, 25);
            Down_BalLabel.TabIndex = 56;
            Down_BalLabel.Text = "Down Payment:";
            Down_BalLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PickDateBT
            // 
            PickDateBT.BackColor = Color.FromArgb(223, 232, 215);
            PickDateBT.BackgroundColor = Color.FromArgb(223, 232, 215);
            PickDateBT.BackgroundImage = (Image)resources.GetObject("PickDateBT.BackgroundImage");
            PickDateBT.BackgroundImageLayout = ImageLayout.Stretch;
            PickDateBT.BorderColor = Color.PaleVioletRed;
            PickDateBT.BorderRadius = 8;
            PickDateBT.BorderSize = 0;
            PickDateBT.FlatAppearance.BorderSize = 0;
            PickDateBT.FlatStyle = FlatStyle.Flat;
            PickDateBT.ForeColor = Color.Black;
            PickDateBT.Location = new Point(740, 25);
            PickDateBT.Margin = new Padding(2, 3, 2, 3);
            PickDateBT.Name = "PickDateBT";
            PickDateBT.Size = new Size(32, 33);
            PickDateBT.TabIndex = 40;
            PickDateBT.TextColor = Color.Black;
            PickDateBT.UseVisualStyleBackColor = false;
            PickDateBT.Visible = false;
            PickDateBT.Click += PickDateBT_Click;
            // 
            // MinCB
            // 
            MinCB.BackColor = Color.FromArgb(223, 232, 215);
            MinCB.DropDownStyle = ComboBoxStyle.DropDownList;
            MinCB.FormattingEnabled = true;
            MinCB.Items.AddRange(new object[] { "1", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "2", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "3", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "4", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "5", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "6", "7", "8", "9" });
            MinCB.Location = new Point(632, 119);
            MinCB.Margin = new Padding(2, 3, 2, 3);
            MinCB.Name = "MinCB";
            MinCB.Size = new Size(61, 33);
            MinCB.Sorted = true;
            MinCB.TabIndex = 54;
            // 
            // HourCB
            // 
            HourCB.BackColor = Color.FromArgb(223, 232, 215);
            HourCB.DropDownStyle = ComboBoxStyle.DropDownList;
            HourCB.FormattingEnabled = true;
            HourCB.Items.AddRange(new object[] { "1", "10", "11", "12", "2", "3", "4", "5", "6", "7", "8", "9" });
            HourCB.Location = new Point(566, 119);
            HourCB.Margin = new Padding(2, 3, 2, 3);
            HourCB.Name = "HourCB";
            HourCB.Size = new Size(60, 33);
            HourCB.Sorted = true;
            HourCB.TabIndex = 53;
            // 
            // AMPMCB
            // 
            AMPMCB.BackColor = Color.FromArgb(223, 232, 215);
            AMPMCB.DropDownStyle = ComboBoxStyle.DropDownList;
            AMPMCB.FormattingEnabled = true;
            AMPMCB.Items.AddRange(new object[] { "AM", "PM" });
            AMPMCB.Location = new Point(702, 119);
            AMPMCB.Margin = new Padding(2, 3, 2, 3);
            AMPMCB.Name = "AMPMCB";
            AMPMCB.Size = new Size(70, 33);
            AMPMCB.Sorted = true;
            AMPMCB.TabIndex = 52;
            AMPMCB.SelectedIndexChanged += AMPMCB_SelectedIndexChanged;
            // 
            // EquipmentsTB
            // 
            EquipmentsTB.BackColor = Color.FromArgb(223, 232, 215);
            EquipmentsTB.BorderStyle = BorderStyle.None;
            EquipmentsTB.Location = new Point(451, 404);
            EquipmentsTB.Margin = new Padding(2, 3, 2, 3);
            EquipmentsTB.Multiline = true;
            EquipmentsTB.Name = "EquipmentsTB";
            EquipmentsTB.PlaceholderText = "List of needed equipments...";
            EquipmentsTB.Size = new Size(305, 79);
            EquipmentsTB.TabIndex = 51;
            // 
            // EquipmentsLabel
            // 
            EquipmentsLabel.AutoSize = true;
            EquipmentsLabel.Location = new Point(451, 376);
            EquipmentsLabel.Margin = new Padding(2, 0, 2, 0);
            EquipmentsLabel.Name = "EquipmentsLabel";
            EquipmentsLabel.Size = new Size(173, 25);
            EquipmentsLabel.TabIndex = 50;
            EquipmentsLabel.Text = "Equipments Needed";
            EquipmentsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EventTypeTB
            // 
            EventTypeTB.BackColor = Color.FromArgb(223, 232, 215);
            EventTypeTB.BorderStyle = BorderStyle.None;
            EventTypeTB.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            EventTypeTB.Location = new Point(298, 18);
            EventTypeTB.Margin = new Padding(2, 3, 2, 3);
            EventTypeTB.Name = "EventTypeTB";
            EventTypeTB.PlaceholderText = "Event Type -";
            EventTypeTB.Size = new Size(229, 32);
            EventTypeTB.TabIndex = 42;
            // 
            // EventNameTB
            // 
            EventNameTB.BackColor = Color.FromArgb(223, 232, 215);
            EventNameTB.BorderStyle = BorderStyle.None;
            EventNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            EventNameTB.Location = new Point(36, 18);
            EventNameTB.Margin = new Padding(2, 3, 2, 3);
            EventNameTB.Name = "EventNameTB";
            EventNameTB.PlaceholderText = "Event Name -";
            EventNameTB.Size = new Size(229, 32);
            EventNameTB.TabIndex = 41;
            // 
            // PackageDB
            // 
            PackageDB.BackColor = Color.FromArgb(223, 232, 215);
            PackageDB.DropDownStyle = ComboBoxStyle.DropDownList;
            PackageDB.FormattingEnabled = true;
            PackageDB.Location = new Point(301, 196);
            PackageDB.Margin = new Padding(2, 3, 2, 3);
            PackageDB.Name = "PackageDB";
            PackageDB.Size = new Size(140, 33);
            PackageDB.Sorted = true;
            PackageDB.TabIndex = 38;
            // 
            // Staff4DB
            // 
            Staff4DB.BackColor = Color.FromArgb(223, 232, 215);
            Staff4DB.DropDownStyle = ComboBoxStyle.DropDownList;
            Staff4DB.FormattingEnabled = true;
            Staff4DB.Items.AddRange(new object[] { "None" });
            Staff4DB.Location = new Point(34, 313);
            Staff4DB.Margin = new Padding(2, 3, 2, 3);
            Staff4DB.Name = "Staff4DB";
            Staff4DB.Size = new Size(140, 33);
            Staff4DB.Sorted = true;
            Staff4DB.TabIndex = 37;
            // 
            // Staff3DB
            // 
            Staff3DB.BackColor = Color.FromArgb(223, 232, 215);
            Staff3DB.DropDownStyle = ComboBoxStyle.DropDownList;
            Staff3DB.FormattingEnabled = true;
            Staff3DB.Items.AddRange(new object[] { "None" });
            Staff3DB.Location = new Point(34, 274);
            Staff3DB.Margin = new Padding(2, 3, 2, 3);
            Staff3DB.Name = "Staff3DB";
            Staff3DB.Size = new Size(140, 33);
            Staff3DB.Sorted = true;
            Staff3DB.TabIndex = 36;
            // 
            // Staff2DB
            // 
            Staff2DB.BackColor = Color.FromArgb(223, 232, 215);
            Staff2DB.DropDownStyle = ComboBoxStyle.DropDownList;
            Staff2DB.FormattingEnabled = true;
            Staff2DB.Items.AddRange(new object[] { "None" });
            Staff2DB.Location = new Point(34, 235);
            Staff2DB.Margin = new Padding(2, 3, 2, 3);
            Staff2DB.Name = "Staff2DB";
            Staff2DB.Size = new Size(140, 33);
            Staff2DB.Sorted = true;
            Staff2DB.TabIndex = 35;
            // 
            // Staff1DB
            // 
            Staff1DB.BackColor = Color.FromArgb(223, 232, 215);
            Staff1DB.DropDownStyle = ComboBoxStyle.DropDownList;
            Staff1DB.FormattingEnabled = true;
            Staff1DB.Items.AddRange(new object[] { "None" });
            Staff1DB.Location = new Point(34, 196);
            Staff1DB.Margin = new Padding(2, 3, 2, 3);
            Staff1DB.Name = "Staff1DB";
            Staff1DB.Size = new Size(140, 33);
            Staff1DB.Sorted = true;
            Staff1DB.TabIndex = 34;
            // 
            // AddOnsDB
            // 
            AddOnsDB.BackColor = Color.FromArgb(223, 232, 215);
            AddOnsDB.DropDownStyle = ComboBoxStyle.DropDownList;
            AddOnsDB.FormattingEnabled = true;
            AddOnsDB.Items.AddRange(new object[] { "None" });
            AddOnsDB.Location = new Point(301, 262);
            AddOnsDB.Margin = new Padding(2, 3, 2, 3);
            AddOnsDB.Name = "AddOnsDB";
            AddOnsDB.Size = new Size(140, 33);
            AddOnsDB.Sorted = true;
            AddOnsDB.TabIndex = 33;
            // 
            // PaymentStatusDB
            // 
            PaymentStatusDB.BackColor = Color.FromArgb(223, 232, 215);
            PaymentStatusDB.DropDownStyle = ComboBoxStyle.DropDownList;
            PaymentStatusDB.FormattingEnabled = true;
            PaymentStatusDB.Items.AddRange(new object[] { "FULL", "PRTL" });
            PaymentStatusDB.Location = new Point(301, 327);
            PaymentStatusDB.Margin = new Padding(2, 3, 2, 3);
            PaymentStatusDB.Name = "PaymentStatusDB";
            PaymentStatusDB.Size = new Size(140, 33);
            PaymentStatusDB.Sorted = true;
            PaymentStatusDB.TabIndex = 32;
            // 
            // AddOnsLabel
            // 
            AddOnsLabel.AutoSize = true;
            AddOnsLabel.Location = new Point(298, 235);
            AddOnsLabel.Margin = new Padding(2, 0, 2, 0);
            AddOnsLabel.Name = "AddOnsLabel";
            AddOnsLabel.Size = new Size(83, 25);
            AddOnsLabel.TabIndex = 31;
            AddOnsLabel.Text = "Add Ons";
            AddOnsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RequestTB
            // 
            RequestTB.BackColor = Color.FromArgb(223, 232, 215);
            RequestTB.BorderStyle = BorderStyle.None;
            RequestTB.Location = new Point(36, 403);
            RequestTB.Margin = new Padding(2, 3, 2, 3);
            RequestTB.Multiline = true;
            RequestTB.Name = "RequestTB";
            RequestTB.PlaceholderText = "Client requests...";
            RequestTB.Size = new Size(393, 79);
            RequestTB.TabIndex = 0;
            // 
            // VenueTB
            // 
            VenueTB.BackColor = Color.FromArgb(223, 232, 215);
            VenueTB.BorderStyle = BorderStyle.None;
            VenueTB.Location = new Point(298, 124);
            VenueTB.Margin = new Padding(2, 3, 2, 3);
            VenueTB.Name = "VenueTB";
            VenueTB.PlaceholderText = "Place of Event..";
            VenueTB.Size = new Size(194, 24);
            VenueTB.TabIndex = 28;
            // 
            // ContactTB
            // 
            ContactTB.BackColor = Color.FromArgb(223, 232, 215);
            ContactTB.BorderStyle = BorderStyle.None;
            ContactTB.Location = new Point(36, 124);
            ContactTB.Margin = new Padding(2, 3, 2, 3);
            ContactTB.MaxLength = 11;
            ContactTB.Name = "ContactTB";
            ContactTB.PlaceholderText = "09XXXXXXXXX";
            ContactTB.Size = new Size(194, 24);
            ContactTB.TabIndex = 21;
            // 
            // DateTB
            // 
            DateTB.BackColor = Color.FromArgb(223, 232, 215);
            DateTB.BorderStyle = BorderStyle.None;
            DateTB.Location = new Point(635, 30);
            DateTB.Margin = new Padding(2, 3, 2, 3);
            DateTB.Name = "DateTB";
            DateTB.PlaceholderText = "YYYY-MM-DD";
            DateTB.Size = new Size(101, 24);
            DateTB.TabIndex = 20;
            // 
            // ClientTB
            // 
            ClientTB.BackColor = Color.FromArgb(223, 232, 215);
            ClientTB.BorderStyle = BorderStyle.None;
            ClientTB.Location = new Point(89, 55);
            ClientTB.Margin = new Padding(2, 3, 2, 3);
            ClientTB.Name = "ClientTB";
            ClientTB.PlaceholderText = "Client Name...";
            ClientTB.Size = new Size(229, 24);
            ClientTB.TabIndex = 19;
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(563, 93);
            TimeLabel.Margin = new Padding(2, 0, 2, 0);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(50, 25);
            TimeLabel.TabIndex = 18;
            TimeLabel.Text = "Time";
            TimeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RequestLabel
            // 
            RequestLabel.AutoSize = true;
            RequestLabel.Location = new Point(32, 376);
            RequestLabel.Margin = new Padding(2, 0, 2, 0);
            RequestLabel.Name = "RequestLabel";
            RequestLabel.Size = new Size(160, 25);
            RequestLabel.TabIndex = 17;
            RequestLabel.Text = "Specified Requests";
            RequestLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PaymentStatusLabel
            // 
            PaymentStatusLabel.AutoSize = true;
            PaymentStatusLabel.Location = new Point(295, 299);
            PaymentStatusLabel.Margin = new Padding(2, 0, 2, 0);
            PaymentStatusLabel.Name = "PaymentStatusLabel";
            PaymentStatusLabel.Size = new Size(133, 25);
            PaymentStatusLabel.TabIndex = 16;
            PaymentStatusLabel.Text = "Payment Status";
            PaymentStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // VenueLabel
            // 
            VenueLabel.AutoSize = true;
            VenueLabel.Location = new Point(295, 97);
            VenueLabel.Margin = new Padding(2, 0, 2, 0);
            VenueLabel.Name = "VenueLabel";
            VenueLabel.Size = new Size(64, 25);
            VenueLabel.TabIndex = 14;
            VenueLabel.Text = "Venue:";
            VenueLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PackageLabel
            // 
            PackageLabel.AutoSize = true;
            PackageLabel.Location = new Point(297, 167);
            PackageLabel.Margin = new Padding(2, 0, 2, 0);
            PackageLabel.Name = "PackageLabel";
            PackageLabel.Size = new Size(76, 25);
            PackageLabel.TabIndex = 13;
            PackageLabel.Text = "Package";
            PackageLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StaffsLabel
            // 
            StaffsLabel.AutoSize = true;
            StaffsLabel.Location = new Point(28, 167);
            StaffsLabel.Margin = new Padding(2, 0, 2, 0);
            StaffsLabel.Name = "StaffsLabel";
            StaffsLabel.Size = new Size(134, 25);
            StaffsLabel.TabIndex = 11;
            StaffsLabel.Text = "Staffs Assigned";
            StaffsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ContactLabel
            // 
            ContactLabel.AutoSize = true;
            ContactLabel.Location = new Point(31, 97);
            ContactLabel.Margin = new Padding(2, 0, 2, 0);
            ContactLabel.Name = "ContactLabel";
            ContactLabel.Size = new Size(147, 25);
            ContactLabel.TabIndex = 10;
            ContactLabel.Text = "Contact Number:";
            ContactLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DateLabel.Location = new Point(560, 24);
            DateLabel.Margin = new Padding(2, 0, 2, 0);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(74, 32);
            DateLabel.TabIndex = 9;
            DateLabel.Text = "Date:";
            DateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ClientLabel
            // 
            ClientLabel.AutoSize = true;
            ClientLabel.Location = new Point(32, 55);
            ClientLabel.Margin = new Padding(2, 0, 2, 0);
            ClientLabel.Name = "ClientLabel";
            ClientLabel.Size = new Size(60, 25);
            ClientLabel.TabIndex = 8;
            ClientLabel.Text = "Client:";
            ClientLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EventNameLabel
            // 
            EventNameLabel.AutoSize = true;
            EventNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            EventNameLabel.Location = new Point(31, 18);
            EventNameLabel.Margin = new Padding(2, 0, 2, 0);
            EventNameLabel.Name = "EventNameLabel";
            EventNameLabel.Size = new Size(0, 32);
            EventNameLabel.TabIndex = 7;
            EventNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Delete_EventInfo
            // 
            Delete_EventInfo.BackColor = Color.Firebrick;
            Delete_EventInfo.BackgroundColor = Color.Firebrick;
            Delete_EventInfo.BorderColor = Color.PaleVioletRed;
            Delete_EventInfo.BorderRadius = 8;
            Delete_EventInfo.BorderSize = 0;
            Delete_EventInfo.FlatAppearance.BorderSize = 0;
            Delete_EventInfo.FlatStyle = FlatStyle.Flat;
            Delete_EventInfo.ForeColor = Color.White;
            Delete_EventInfo.Location = new Point(408, 499);
            Delete_EventInfo.Margin = new Padding(2, 3, 2, 3);
            Delete_EventInfo.Name = "Delete_EventInfo";
            Delete_EventInfo.Size = new Size(398, 39);
            Delete_EventInfo.TabIndex = 6;
            Delete_EventInfo.Text = "Delete";
            Delete_EventInfo.TextColor = Color.White;
            Delete_EventInfo.UseVisualStyleBackColor = false;
            Delete_EventInfo.Click += Delete_EventInfo_Click;
            // 
            // Edit_EventInfo
            // 
            Edit_EventInfo.BackColor = Color.FromArgb(46, 60, 24);
            Edit_EventInfo.BackgroundColor = Color.FromArgb(46, 60, 24);
            Edit_EventInfo.BorderColor = Color.PaleVioletRed;
            Edit_EventInfo.BorderRadius = 8;
            Edit_EventInfo.BorderSize = 0;
            Edit_EventInfo.FlatAppearance.BorderSize = 0;
            Edit_EventInfo.FlatStyle = FlatStyle.Flat;
            Edit_EventInfo.ForeColor = Color.White;
            Edit_EventInfo.Location = new Point(2, 499);
            Edit_EventInfo.Margin = new Padding(2, 3, 2, 3);
            Edit_EventInfo.Name = "Edit_EventInfo";
            Edit_EventInfo.Size = new Size(398, 39);
            Edit_EventInfo.TabIndex = 5;
            Edit_EventInfo.Text = "Edit";
            Edit_EventInfo.TextColor = Color.White;
            Edit_EventInfo.UseVisualStyleBackColor = false;
            Edit_EventInfo.Click += Edit_EventInfo_Click;
            // 
            // UnderlineClient
            // 
            UnderlineClient.BackColor = Color.FromArgb(223, 232, 215);
            UnderlineClient.BorderStyle = BorderStyle.None;
            UnderlineClient.Location = new Point(88, 57);
            UnderlineClient.Margin = new Padding(2, 3, 2, 3);
            UnderlineClient.Name = "UnderlineClient";
            UnderlineClient.ReadOnly = true;
            UnderlineClient.ShortcutsEnabled = false;
            UnderlineClient.Size = new Size(229, 24);
            UnderlineClient.TabIndex = 43;
            UnderlineClient.TabStop = false;
            UnderlineClient.Text = "_____________________________";
            // 
            // UnderlinedContact
            // 
            UnderlinedContact.BackColor = Color.FromArgb(223, 232, 215);
            UnderlinedContact.BorderStyle = BorderStyle.None;
            UnderlinedContact.Location = new Point(36, 128);
            UnderlinedContact.Margin = new Padding(2, 3, 2, 3);
            UnderlinedContact.Name = "UnderlinedContact";
            UnderlinedContact.ReadOnly = true;
            UnderlinedContact.Size = new Size(229, 24);
            UnderlinedContact.TabIndex = 45;
            UnderlinedContact.TabStop = false;
            UnderlinedContact.Text = "_____________________________";
            // 
            // UnderlinedVenue
            // 
            UnderlinedVenue.BackColor = Color.FromArgb(223, 232, 215);
            UnderlinedVenue.BorderStyle = BorderStyle.None;
            UnderlinedVenue.Location = new Point(298, 128);
            UnderlinedVenue.Margin = new Padding(2, 3, 2, 3);
            UnderlinedVenue.Name = "UnderlinedVenue";
            UnderlinedVenue.ReadOnly = true;
            UnderlinedVenue.Size = new Size(229, 24);
            UnderlinedVenue.TabIndex = 47;
            UnderlinedVenue.TabStop = false;
            UnderlinedVenue.Text = "_____________________________";
            // 
            // UnderlineEventName
            // 
            UnderlineEventName.BackColor = Color.FromArgb(223, 232, 215);
            UnderlineEventName.BorderStyle = BorderStyle.None;
            UnderlineEventName.Location = new Point(36, 28);
            UnderlineEventName.Margin = new Padding(2, 3, 2, 3);
            UnderlineEventName.Name = "UnderlineEventName";
            UnderlineEventName.ReadOnly = true;
            UnderlineEventName.Size = new Size(229, 24);
            UnderlineEventName.TabIndex = 48;
            UnderlineEventName.TabStop = false;
            UnderlineEventName.Text = "_____________________________";
            // 
            // UnderlineEventType
            // 
            UnderlineEventType.BackColor = Color.FromArgb(223, 232, 215);
            UnderlineEventType.BorderStyle = BorderStyle.None;
            UnderlineEventType.Location = new Point(298, 28);
            UnderlineEventType.Margin = new Padding(2, 3, 2, 3);
            UnderlineEventType.Name = "UnderlineEventType";
            UnderlineEventType.ReadOnly = true;
            UnderlineEventType.Size = new Size(229, 24);
            UnderlineEventType.TabIndex = 49;
            UnderlineEventType.TabStop = false;
            UnderlineEventType.Text = "_____________________________";
            // 
            // UnderlineDate
            // 
            UnderlineDate.BackColor = Color.FromArgb(223, 232, 215);
            UnderlineDate.BorderStyle = BorderStyle.None;
            UnderlineDate.Location = new Point(620, 32);
            UnderlineDate.Margin = new Padding(2, 3, 2, 3);
            UnderlineDate.Name = "UnderlineDate";
            UnderlineDate.Size = new Size(116, 24);
            UnderlineDate.TabIndex = 44;
            UnderlineDate.Text = "_____________________________";
            // 
            // TimedotLabel
            // 
            TimedotLabel.AutoSize = true;
            TimedotLabel.Location = new Point(622, 123);
            TimedotLabel.Margin = new Padding(2, 0, 2, 0);
            TimedotLabel.Name = "TimedotLabel";
            TimedotLabel.Size = new Size(16, 25);
            TimedotLabel.TabIndex = 55;
            TimedotLabel.Text = ":";
            TimedotLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EventInfoLabel
            // 
            EventInfoLabel.AutoSize = true;
            EventInfoLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EventInfoLabel.ImageAlign = ContentAlignment.MiddleLeft;
            EventInfoLabel.Location = new Point(1, 9);
            EventInfoLabel.Margin = new Padding(2, 0, 2, 0);
            EventInfoLabel.Name = "EventInfoLabel";
            EventInfoLabel.Size = new Size(291, 45);
            EventInfoLabel.TabIndex = 8;
            EventInfoLabel.Text = "Event Information";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(46, 60, 24);
            ExitButton.BackgroundColor = Color.FromArgb(46, 60, 24);
            ExitButton.BorderColor = Color.PaleVioletRed;
            ExitButton.BorderRadius = 8;
            ExitButton.BorderSize = 0;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(9, 605);
            ExitButton.Margin = new Padding(2, 3, 2, 3);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(805, 39);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Done";
            ExitButton.TextColor = Color.White;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // peReportBTN
            // 
            peReportBTN.BackColor = Color.FromArgb(46, 60, 24);
            peReportBTN.BackgroundColor = Color.FromArgb(46, 60, 24);
            peReportBTN.BorderColor = Color.PaleVioletRed;
            peReportBTN.BorderRadius = 8;
            peReportBTN.BorderSize = 0;
            peReportBTN.FlatAppearance.BorderSize = 0;
            peReportBTN.FlatStyle = FlatStyle.Flat;
            peReportBTN.ForeColor = Color.White;
            peReportBTN.Location = new Point(638, 9);
            peReportBTN.Margin = new Padding(2, 3, 2, 3);
            peReportBTN.Name = "peReportBTN";
            peReportBTN.Size = new Size(176, 39);
            peReportBTN.TabIndex = 63;
            peReportBTN.Text = "Post-Event Report";
            peReportBTN.TextColor = Color.White;
            peReportBTN.UseVisualStyleBackColor = false;
            // 
            // Events_Info
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(829, 650);
            Controls.Add(peReportBTN);
            Controls.Add(EventInfoLabel);
            Controls.Add(ExitButton);
            Controls.Add(panel3);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Events_Info";
            Text = "Event Information";
            TopMost = true;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private System.Diagnostics.Process process1;
        private Panel panel3;
        private ADETADET_sample.RBButton Edit_EventInfo;
        private ADETADET_sample.RBButton ExitButton;
        private ADETADET_sample.RBButton Delete_EventInfo;
        private Label EventNameLabel;
        private Label EventInfoLabel;
        private Label ContactLabel;
        private Label DateLabel;
        private Label ClientLabel;
        private Label StaffsLabel;
        private Label VenueLabel;
        private Label PackageLabel;
        private Label TimeLabel;
        private Label RequestLabel;
        private Label PaymentStatusLabel;
        private TextBox ContactTB;
        private TextBox DateTB;
        private TextBox ClientTB;
        private TextBox RequestTB;
        private TextBox VenueTB;
        private TextBox TimeTB;
        private Label AddOnsLabel;
        private ComboBox PaymentStatusDB;
        private ComboBox Staff4DB;
        private ComboBox Staff3DB;
        private ComboBox Staff2DB;
        private ComboBox Staff1DB;
        private ComboBox AddOnsDB;
        private ComboBox PackageDB;
        private MonthCalendar EventInfoDatePicker;
        private ADETADET_sample.RBButton PickDateBT;
        private TextBox EventNameTB;
        private TextBox EventTypeTB;
        private TextBox UnderlineDate;
        private TextBox UnderlineClient;
        private TextBox UnderlinedContact;
        private TextBox UnderlinedTime;
        private TextBox UnderlinedVenue;
        private TextBox UnderlineEventName;
        private TextBox UnderlineEventType;
        private TextBox EquipmentsTB;
        private Label EquipmentsLabel;
        private ComboBox AMPMCB;
        private ComboBox MinCB;
        private ComboBox HourCB;
        private Label TimedotLabel;
        private TextBox DownPaymentTB;
        private TextBox UNDownPayment;
        private Label Down_BalLabel;
        private ComboBox MODCB;
        private Label MODlabel;
        private ADETADET_sample.RBButton rbButton1;
        private ADETADET_sample.RBButton peReportBTN;
    }
}