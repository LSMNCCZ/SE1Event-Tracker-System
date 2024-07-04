using MySql.Data.MySqlClient;

namespace ADET_sample
{


    public partial class Packages : Form
    {
        private string inType;
        private string inName;
        private string inPrice;
        private string inInclusion;
        private string inRate;
        private Services_tab parentForm;
        public Packages(Services_tab servTab, string type, string name, string price, string inclusion, string rate)
        {
            InitializeComponent();
            //initial values
            this.parentForm = servTab;
            this.inType = type;
            this.inName = name;
            this.inPrice = price;
            this.inInclusion = inclusion;
            this.inRate = rate;

            //Display for add new Service 
            if (name == "" || name == null)
            {


                //Lines visible
                UNServID.Visible = true;
                UNServName.Visible = true;
                UNPrice.Visible = true;
                UNEmPay.Visible = true;
                InclusionTB.BorderStyle = BorderStyle.FixedSingle;


                // Make the text boxes editable
                ServiceNameTB.ReadOnly = false;
                ServIDTB.ReadOnly = false;
                ServPriceTB.ReadOnly = false;
                ServEmPayTB.ReadOnly = false;
                InclusionTB.ReadOnly = false;

                ServiceNameTB.Enabled = true;
                ServIDTB.Enabled = true;
                ServPriceTB.Enabled = true;
                ServEmPayTB.Enabled = true;
                InclusionTB.Enabled = true;

                //buttons
                EditPackageBTN.Text = "Add Service";
                RemovePackageBTN.Text = "Clear";
            }
            else if (name != "" || name != null) //display info or before edit info
            {

                //Lines disabled
                UNServID.Visible = false;
                UNServName.Visible = false;
                UNPrice.Visible = false;
                UNEmPay.Visible = false;
                UNEmPay.Visible = false;


                //ID IS TYPE HEHEHE
                ServiceNameTB.Text = name;
                ServIDTB.Text = type;
                ServPriceTB.Text = price;
                ServEmPayTB.Text = rate;
                InclusionTB.Text = inclusion;

                // Make the text boxes non-editable
                ServiceNameTB.ReadOnly = true;
                ServIDTB.ReadOnly = true;
                ServPriceTB.ReadOnly = true;
                ServEmPayTB.ReadOnly = true;
                InclusionTB.ReadOnly = true;

            }
            if (GlobalVariables.UserRole != "Admin")
            {
                EditPackageBTN.Enabled = false;
                RemovePackageBTN.Enabled = false;
            }
        }

        private void EditPackageBTN_Click(object sender, EventArgs e)
        {
            //Lines visible
            UNPrice.Visible = true;
            UNEmPay.Visible = true;
            InclusionTB.BorderStyle = BorderStyle.FixedSingle;

            //TextBoxesEnabled
            ServiceNameTB.ReadOnly = false;
            ServIDTB.ReadOnly = false;
            ServPriceTB.ReadOnly = false;
            ServEmPayTB.ReadOnly = false;
            InclusionTB.ReadOnly = false;

            if (EditPackageBTN.Text == "Save")//Updating lang ng Sevices
            {

                if (MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    UNServID.Visible = false;
                    UNServName.Visible = false;
                    //TYPE IS ID. BOBO MOMENTS
                    //For Updating the Database
                    string sName = this.inName;
                    string sID = this.inType;
                    string sPrice = ServPriceTB.Text;
                    string sPay = ServEmPayTB.Text;
                    string sInclusion = InclusionTB.Text;

                    //Update na
                    UpdatingServiceDataBase(sName, sID, sPrice, sPay, sInclusion);


                    //Making All Text Box initially display values according to Database's new record
                    // Make the text boxes non-editable
                    ServiceNameTB.ReadOnly = true;
                    ServIDTB.ReadOnly = true;
                    ServPriceTB.ReadOnly = true;
                    ServEmPayTB.ReadOnly = true;
                    InclusionTB.ReadOnly = true;

                    //Lines disabled
                    UNServID.Visible = false;
                    UNServName.Visible = false;
                    UNPrice.Visible = false;
                    UNEmPay.Visible = false;
                    UNEmPay.Visible = false;
                    this.Close();
                }
                else
                {
                    //RevertValues
                    ServIDTB.Text = this.inType;
                    ServiceNameTB.Text = this.inName;
                    ServPriceTB.Text = this.inPrice;
                    InclusionTB.Text = this.inInclusion;
                    ServEmPayTB.Text = this.inRate;
                }
            }
            //New Services
            else if (EditPackageBTN.Text == "Add Service")
            {
                if (MessageBox.Show("Do you want to add new Service?", "New Service ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    UNServID.Visible = true;
                    UNServName.Visible = true;
                    string sName = ServiceNameTB.Text;
                    string sID = ServIDTB.Text;
                    string sPrice = ServPriceTB.Text;
                    string sPay = ServEmPayTB.Text;
                    string sInclusion = InclusionTB.Text;

                    //Update na
                    UpdatingServiceDataBase(sName, sID, sPrice, sPay, sInclusion);

                    //Making All Text Box initially display values according to Database's new record
                    // Make the text boxes non-editable
                    ServiceNameTB.ReadOnly = true;
                    ServIDTB.ReadOnly = true;
                    ServPriceTB.ReadOnly = true;
                    ServEmPayTB.ReadOnly = true;
                    InclusionTB.ReadOnly = true;

                    //Lines disabled
                    UNServID.Visible = false;
                    UNServName.Visible = false;
                    UNPrice.Visible = false;
                    UNEmPay.Visible = false;
                    UNEmPay.Visible = false;
                    //clear button disabled
                    RemovePackageBTN.Enabled = false;
                }
                else
                {
                    //RevertValues
                    ServIDTB.Text = null;
                    ServiceNameTB.Text = null;
                    ServPriceTB.Text = null;
                    InclusionTB.Text = null;
                    ServEmPayTB.Text = null;
                }
            }
            EditPackageBTN.Text = "Save";
        }


        //updating Database


        private void RemovePackageBTN_Click(object sender, EventArgs e)
        {
            //Clearing Values sa entering new employee
            if (RemovePackageBTN.Text == "Clear")
            {
                //RevertValues
                ServIDTB.Text = null;
                ServiceNameTB.Text = null;
                ServPriceTB.Text = null;
                InclusionTB.Text = null;
                ServEmPayTB.Text = null;
            }
            //Removing Employee
            else if (RemovePackageBTN.Text == "Remove")
            {
                if (MessageBox.Show("Do you want to remove this Service?", "Remove Service", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (MySqlConnection con = DatabaseConnection.GetConnection())
                    {
                        con.Open();
                        MySqlCommand command = new MySqlCommand("DELETE FROM event_management_system.package WHERE " +
                            "packageType = @sID", con);
                        // Set the parameters for the command
                        command.Parameters.AddWithValue("@sID", this.inType);

                        // Execute the command to update the data in the database
                        command.ExecuteNonQuery();
                        parentForm.RefreshServList();
                        this.Close();
                    }
                }
            }
        }
        private void UpdatingServiceDataBase(string sName, string sID, string sPrice, string sPay, string sInclusion)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                if (EditPackageBTN.Text == "Save")//Update Services
                {
                    MySqlCommand command = new MySqlCommand("UPDATE event_management_system.package SET packagePrice = @sPrice," +
                        " packageInclusion = @sInclusion, employeeRate = @sPay " +
                        "WHERE packageType = @sID AND packageName = @sName", con);
                    // Set the parameters for the command
                    command.Parameters.AddWithValue("@sName", sName);
                    command.Parameters.AddWithValue("@sID", sID);
                    command.Parameters.AddWithValue("@sPrice", sPrice);
                    command.Parameters.AddWithValue("@sPay", sPay);
                    command.Parameters.AddWithValue("@sInclusion", sInclusion);

                    // Execute the command to update the data in the database
                    command.ExecuteNonQuery();
                }
                else if (EditPackageBTN.Text == "Add Service")//Add Service Item
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO event_management_system.package(packageType," +
                        "packageName,packagePrice, packageInclusion, employeeRate)" +
                        "VALUES (@sID, @sName, @sPrice, @sInclusion, @sPay)", con);
                    // Set the parameters for the command
                    command.Parameters.AddWithValue("@sName", sName);
                    command.Parameters.AddWithValue("@sID", sID);
                    command.Parameters.AddWithValue("@sPrice", sPrice);
                    command.Parameters.AddWithValue("@sPay", sPay);
                    command.Parameters.AddWithValue("@sInclusion", sInclusion);
                    //Make add add service unavail pag clicked once
                    EditPackageBTN.Enabled = false;
                    // Execute the command to update the data in the database
                    command.ExecuteNonQuery();

                }
                parentForm.RefreshServList();
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
