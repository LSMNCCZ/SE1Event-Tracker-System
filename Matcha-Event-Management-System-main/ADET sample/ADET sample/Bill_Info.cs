using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

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
            if (billID != null)//edit biller
            {
                SaveBTN.Text = "Edit";
                //keeping initital values
                this.billID = billID;
                this.billerName = billerName;
                this.billType = billType;
                this.billBudget = billBudget;
                this.billDDate = billDDate;

                //make underlines invisible
                UNBiller.Visible = false;
                UNBillType.Visible = false;
                UNID.Visible = false;
                UNBudget.Visible = false;
                UNdDate.Visible = false;

                //disable entry
                BillIDTB.ReadOnly = true;
                BillerNameTB.ReadOnly = true;
                BillTypeTB.ReadOnly = true;
                BillDueDateTB.ReadOnly = true;
                BillBudgetTB.ReadOnly = true;

                //display initital values
                BillIDTB.Text = billID;
                BillTypeTB.Text = billType;
                BillerNameTB.Text = billerName;
                BillDueDateTB.Text = billDDate;
                BillBudgetTB.Text = billBudget;

            }
            else if (billID == null) // add new billler
            {

                SaveBTN.Text = "Add Biller";
                DeleteBTN.Text = "Clear";
                //make underlines invisible
                UNBiller.Visible = true;
                UNBillType.Visible = true;
                UNID.Visible = true;
                UNBudget.Visible = true;
                UNdDate.Visible = true;

                //enable entry
                BillIDTB.ReadOnly = false;
                BillerNameTB.ReadOnly = false;
                BillTypeTB.ReadOnly = false;
                BillDueDateTB.ReadOnly = false;
                BillBudgetTB.ReadOnly = false;

                BillIDTB.Text = "XXXXXX";
                BillerNameTB.Text = "--";
                BillTypeTB.Text = "--";
                BillDueDateTB.Text = "YYYY-MM-DD";
                BillBudgetTB.Text = "00";
            }

        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            //make underlines visible
            UNID.Visible = true;
            UNBudget.Visible = true;
            UNdDate.Visible = true;

            //enable entry
            BillerNameTB.ReadOnly = false;
            BillDueDateTB.ReadOnly = false;
            BillBudgetTB.ReadOnly = false;

            if (SaveBTN.Text == "Save") //edit lang
            {
                if (MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string bID = this.billID;
                    string bName = BillerNameTB.Text;
                    string bType = BillTypeTB.Text;
                    string bDDate = BillDueDateTB.Text;
                    string bBudget = BillBudgetTB.Text;

                    UpdateBiller(bID, bName, bType, bDDate, bBudget);


                    //make underlines invisible
                    UNBiller.Visible = false;
                    UNBillType.Visible = false;
                    UNID.Visible = false;
                    UNBudget.Visible = false;
                    UNdDate.Visible = false;

                    //enable entry
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
                    //RevertValues
                    BillIDTB.Text = this.billID;
                    BillerNameTB.Text = this.billerName;
                    BillTypeTB.Text = this.billType;
                    BillDueDateTB.Text = this.billDDate;
                    BillBudgetTB.Text = this.billBudget;
                }

            }
            else if (SaveBTN.Text == "Add Biller")
            {
                string bID = BillIDTB.Text;
                string bName = BillerNameTB.Text;
                string bType = BillTypeTB.Text;
                string bDDate = BillDueDateTB.Text;
                string bBudget = BillBudgetTB.Text;

                UpdateBiller(bID, bName, bType, bDDate, bBudget);
            }

            if (SaveBTN.Text == "Edit")
            {
                SaveBTN.Text = "Save";
            }

        }

        public void UpdateBiller(string bID, string bName, string bType, string bDDate, string bBudget)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                if (DeleteBTN.Text == "Delete") //new biller
                {
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

                else if (DeleteBTN.Text == "Clear")//edit biller
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO event_management_system.biller" +
                        "(billerID, billerName, billType, dueDate, monthlyBudget, billStatus)" +
                            "VALUES (@billID, @billerName, @billType, @dueDate, @budget, @bStatus )", con);
                    // Set the parameters for the command
                    command.Parameters.AddWithValue("@billID", bID);
                    command.Parameters.AddWithValue("@billerName", bName);
                    command.Parameters.AddWithValue("@billType", bType);
                    command.Parameters.AddWithValue("@dueDate", bDDate);
                    command.Parameters.AddWithValue("@budget", bBudget);
                    command.Parameters.AddWithValue("@bStatus", "Unpaid");

                    // Execute the command to update the data in the database
                    command.ExecuteNonQuery();

                    DeleteBTN.Enabled = false;
                    SaveBTN.Enabled = false;
                }

                DateTime today = DateTime.Today;
                this.parentForm.FillBillsDataGridView(today);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (DeleteBTN.Text == "Delete")
            {
                if (MessageBox.Show("Do you want to Delete Biller?", "Delete Biller", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (MySqlConnection con = DatabaseConnection.GetConnection())
                    {
                        con.Open();
                        MySqlCommand command = new MySqlCommand("DELETE FROM event_management_system.biller WHERE billerID = @billID", con);
                        // Set the parameters for the command
                        command.Parameters.AddWithValue("@billID", this.billID);

                        command.ExecuteNonQuery();
                    }
                }
            }
            else if(DeleteBTN.Text == "Clear")
            {
                //RevertValues
                BillIDTB.Text = "XXXXXX";
                BillerNameTB.Text = "--";
                BillTypeTB.Text = "--";
                BillDueDateTB.Text = "YYYY-MM-DD";
                BillBudgetTB.Text = "00";
            }
        }
    }
}
