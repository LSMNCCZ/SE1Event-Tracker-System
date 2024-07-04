using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ADET_sample
{
    public partial class Bill_Info : Form
    {
        private string billID;
        private string billerName;
        private string billType;
        private string billBudget;
        private string billDDate;
        private Finance_tab parentForm;

        public Bill_Info(Finance_tab parentForm, string billID, string billerName, string billType, string billDDate, string billBudget, string billStatus)
        {
            this.parentForm = parentForm;
            InitializeComponent();

            if (billID != null) // edit biller
            {
                SaveBTN.Text = "Edit";

                // keeping initial values
                this.billID = billID;
                this.billerName = billerName;
                this.billType = billType;
                this.billBudget = billBudget;
                this.billDDate = billDDate;

                // make underlines invisible
                UNBiller.Visible = false;
                UNBillType.Visible = false;
                UNID.Visible = false;
                UNBudget.Visible = false;
                UNdDate.Visible = false;

                // disable entry
                BillIDTB.ReadOnly = true;
                BillerNameTB.ReadOnly = true;
                BillTypeTB.ReadOnly = true;
                BillDueDateTB.ReadOnly = true;
                BillBudgetTB.ReadOnly = true;

                // display initial values
                BillIDTB.Text = billID;
                BillTypeTB.Text = billType;
                BillerNameTB.Text = billerName;
                BillDueDateTB.Text = billDDate;
                BillBudgetTB.Text = billBudget;
            }
            else // add new biller
            {
                SaveBTN.Text = "Add Biller";
                DeleteBTN.Text = "Clear";

                // make underlines visible
                UNBiller.Visible = true;
                UNBillType.Visible = true;
                UNID.Visible = true;
                UNBudget.Visible = true;
                UNdDate.Visible = true;

                // enable entry
                BillIDTB.ReadOnly = false;
                BillerNameTB.ReadOnly = false;
                BillTypeTB.ReadOnly = false;
                BillDueDateTB.ReadOnly = false;
                BillBudgetTB.ReadOnly = false;

                // default values
                BillIDTB.Text = "XXXXXX";
                BillerNameTB.Text = "--";
                BillTypeTB.Text = "--";
                BillDueDateTB.Text = "YYYY-MM-DD";
                BillBudgetTB.Text = "00";
            }

            if (GlobalVariables.UserRole != "Admin")
            {
                SaveBTN.Enabled = false;
                DeleteBTN.Enabled = false;
            }

            // Set form properties to stay on top and disable clicking away
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                if (SaveBTN.Text == "Save") // edit existing biller
                {
                    if (MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string bID = this.billID;
                        string bName = BillerNameTB.Text;
                        string bType = BillTypeTB.Text;
                        string bDDate = BillDueDateTB.Text;
                        string bBudget = BillBudgetTB.Text;

                        UpdateBiller(bID, bName, bType, bDDate, bBudget);

                        // make underlines invisible
                        UNBiller.Visible = false;
                        UNBillType.Visible = false;
                        UNID.Visible = false;
                        UNBudget.Visible = false;
                        UNdDate.Visible = false;

                        // disable entry
                        BillIDTB.ReadOnly = true;
                        BillerNameTB.ReadOnly = true;
                        BillTypeTB.ReadOnly = true;
                        BillDueDateTB.ReadOnly = true;
                        BillBudgetTB.ReadOnly = true;

                        SaveBTN.Enabled = false;
                        DeleteBTN.Enabled = false;
                    }
                    else
                    {
                        // Revert values
                        BillIDTB.Text = this.billID;
                        BillerNameTB.Text = this.billerName;
                        BillTypeTB.Text = this.billType;
                        BillDueDateTB.Text = this.billDDate;
                        BillBudgetTB.Text = this.billBudget;
                    }
                }
                else if (SaveBTN.Text == "Add Biller") // add new biller
                {
                    if (MessageBox.Show("Do you want to add this biller?", "Add Biller", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string bID = BillIDTB.Text;
                        string bName = BillerNameTB.Text;
                        string bType = BillTypeTB.Text;
                        string bDDate = BillDueDateTB.Text;
                        string bBudget = BillBudgetTB.Text;

                        InsertBiller(bID, bName, bType, bDDate, bBudget);
                    }
                }

                if (SaveBTN.Text == "Edit")
                {
                    SaveBTN.Text = "Save";
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the required fields.", "Missing Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void UpdateBiller(string bID, string bName, string bType, string bDDate, string bBudget)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE event_management_system.biller SET billerName = @billerName, dueDate = @dueDate, monthlyBudget = @budget " +
                    "WHERE billerID = @billID AND billType = @billType", con);
                // Set the parameters for the command
                command.Parameters.AddWithValue("@billID", bID);
                command.Parameters.AddWithValue("@billerName", bName);
                command.Parameters.AddWithValue("@billType", bType);
                command.Parameters.AddWithValue("@dueDate", bDDate);
                command.Parameters.AddWithValue("@budget", bBudget);

                // Execute the command to update the data in the database
                command.ExecuteNonQuery();

                DeleteBTN.Enabled = false;
                SaveBTN.Enabled = false;
            }

            DateTime today = DateTime.Today;
            this.parentForm.FillBillsDataGridView(today);
        }

        public void InsertBiller(string bID, string bName, string bType, string bDDate, string bBudget)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO event_management_system.biller (billerID, billerName, billType, dueDate, monthlyBudget, billStatus) " +
                    "VALUES (@billID, @billerName, @billType, @dueDate, @budget, @bStatus)", con);
                // Set the parameters for the command
                command.Parameters.AddWithValue("@billID", bID);
                command.Parameters.AddWithValue("@billerName", bName);
                command.Parameters.AddWithValue("@billType", bType);
                command.Parameters.AddWithValue("@dueDate", bDDate);
                command.Parameters.AddWithValue("@budget", bBudget);
                command.Parameters.AddWithValue("@bStatus", "Unpaid");

                // Execute the command to insert the data into the database
                command.ExecuteNonQuery();

                DeleteBTN.Enabled = false;
                SaveBTN.Enabled = false;
            }

            DateTime today = DateTime.Today;
            this.parentForm.FillBillsDataGridView(today);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (DeleteBTN.Text == "Delete")
            {
                if (MessageBox.Show("Do you want to delete this biller?", "Delete Biller", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (MySqlConnection con = DatabaseConnection.GetConnection())
                    {
                        con.Open();
                        MySqlCommand command = new MySqlCommand("DELETE FROM event_management_system.biller WHERE billerID = @billID", con);
                        // Set the parameters for the command
                        command.Parameters.AddWithValue("@billID", this.billID);

                        command.ExecuteNonQuery();

                        DateTime today = DateTime.Today;
                        this.parentForm.FillBillsDataGridView(today);
                    }
                }
            }
            else if (DeleteBTN.Text == "Clear")
            {
                // Clear values
                BillIDTB.Text = "XXXXXX";
                BillerNameTB.Text = "--";
                BillTypeTB.Text = "--";
                BillDueDateTB.Text = "YYYY-MM-DD";
                BillBudgetTB.Text = "00";
            }
        }

        private bool IsFormValid()
        {
            // Check if all required fields are filled
            return !string.IsNullOrEmpty(BillIDTB.Text) &&
                   !string.IsNullOrEmpty(BillerNameTB.Text) &&
                   !string.IsNullOrEmpty(BillTypeTB.Text) &&
                   !string.IsNullOrEmpty(BillDueDateTB.Text) &&
                   !string.IsNullOrEmpty(BillBudgetTB.Text);
        }
    }
}