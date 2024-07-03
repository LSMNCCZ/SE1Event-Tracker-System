using MySql.Data.MySqlClient;

namespace ADET_sample
{
    public partial class NewAddOn : Form
    {
        private Services_tab parentForm;
        public NewAddOn(Services_tab servTab, string AOID, string AODesc, string AOPrice)
        {
            InitializeComponent();
            this.parentForm = servTab;
            // Make the text boxes editable
            AddOnIDTB.ReadOnly = false;
            AddOnDescTB.ReadOnly = false;
            AddOnPriceTB.ReadOnly = false;

            //visibility of underlines
            UNID.Visible = true;
            UNPrice.Visible = true;
            UNID.Visible = true;
        }

        private void SaveAddOnBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save New Employee?", "Add Employee ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string ID = AddOnIDTB.Text;
                string Desc = AddOnDescTB.Text;
                string Price = AddOnPriceTB.Text;

                UpdateAddOnDataBase(ID, Desc, Price);

                //Making All Text Box initially display values according to Database's new record
                // Make the text boxes editable
                AddOnIDTB.ReadOnly = true;
                AddOnDescTB.ReadOnly = true;
                AddOnPriceTB.ReadOnly = true;

                //visibility of underlines
                UNID.Visible = false;
                UNPrice.Visible = false;
                UNID.Visible = false;
                AddOnDescTB.BorderStyle = BorderStyle.None;

                //clear button disabled
                ClearBTN.Enabled = false;
            }
            else
            {
                //Making All Text Box initially display values according to Database's new record
                // Make the text boxes editable
                AddOnIDTB.ReadOnly = false;
                AddOnDescTB.ReadOnly = false;
                AddOnPriceTB.ReadOnly = false;

                //visibility of underlines
                UNID.Visible = true;
                UNPrice.Visible = true;
                UNID.Visible = true;

                //clear button disabled
                ClearBTN.Enabled = true;
            }
        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            //revert
            AddOnIDTB.Text = "XXXXX";
            AddOnDescTB.Text = null;
            AddOnPriceTB.Text = "00";
        }

        private void UpdateAddOnDataBase(string ID, string Desc, string Price)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO event_management_system.addon" +
                    "(addOnID, description, addOnPrice)" +
                        "VALUES (@aoID, @aoDesc, @aoPrice)", con);
                // Set the parameters for the command
                command.Parameters.AddWithValue("@aoID", ID);
                command.Parameters.AddWithValue("@aoDesc", Desc);
                command.Parameters.AddWithValue("@aoPrice", Price);

                // Execute the command to update the data in the database
                command.ExecuteNonQuery();

                ClearBTN.Enabled = false;
                SaveAddOnBTN.Enabled = false;

                parentForm.RefreshServList();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
