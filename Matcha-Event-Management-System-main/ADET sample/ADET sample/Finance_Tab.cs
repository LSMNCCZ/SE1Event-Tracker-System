using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ADET_sample
{
    public partial class Finance_tab : Form
    {
        private Dictionary<string, int> employeePay;
        private Dictionary<string, string> employeeDetails;
        private Dictionary<string, int> packagePrices;
        private string packageType;
        private int repeat = 0;
        private int repeat2 = 0;

        public Finance_tab()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            string month = today.Month.ToString("D2");
            string year = Convert.ToString(today.Year);
            UpdateFinanceRep(month, year, today);
            FillFinanceRepDataGrid(today);
            FillPayOutDataGrid(today);
            FillBillsDataGridView(today);

            // Attach event handlers once
            PayOutDataGrid.CellValueChanged += PayOutDataGrid_CellValueChanged;
            PayOutDataGrid.CurrentCellDirtyStateChanged += PayOutDataGrid_CurrentCellDirtyStateChanged;

            BillsDataGridView.CellValueChanged += BillsDataGridView_CellValueChanged;
            BillsDataGridView.CurrentCellDirtyStateChanged += BillsDataGridView_CurrentCellDirtyStateChanged;

            if (GlobalVariables.UserRole != "Admin")
            {
                AddBillerBTN.Enabled = false;
                PayOutDataGrid.ReadOnly = true;
                BillsDataGridView.ReadOnly = true;
            }
        }

        public void FillPayOutDataGrid(DateTime today)
        {
            repeat++;
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                // Get the first and last day of the current month
                DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
                DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                MySqlDataAdapter payoutGrid = new MySqlDataAdapter("SELECT * FROM event_management_system.payout WHERE payoutMonth >= @firstDayOfMonth AND payoutMonth <= @lastDayOfMonth", con);
                payoutGrid.SelectCommand.Parameters.AddWithValue("@firstDayOfMonth", firstDayOfMonth);
                payoutGrid.SelectCommand.Parameters.AddWithValue("@lastDayOfMonth", lastDayOfMonth);

                DataTable payoutTable = new DataTable();
                payoutGrid.Fill(payoutTable);

                PayOutDataGrid.DataSource = payoutTable;

                // Changing name to appear on the header
                PayOutDataGrid.Columns["employeeID"].HeaderText = "Employee ID";
                PayOutDataGrid.Columns["eventID"].HeaderText = "Event ID";
                PayOutDataGrid.Columns["payoutAmount"].HeaderText = "Amount";
                PayOutDataGrid.Columns["payoutStatus"].HeaderText = "Status";

                PayOutDataGrid.Columns["employeeID"].ReadOnly = true;
                PayOutDataGrid.Columns["eventID"].ReadOnly = true;
                PayOutDataGrid.Columns["payoutAmount"].ReadOnly = true;
                PayOutDataGrid.Columns["payoutStatus"].ReadOnly = true;

                PayOutDataGrid.Columns["payoutAmount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                PayOutDataGrid.Columns["payoutAmount"].Width = 110;

                PayOutDataGrid.Columns["payoutStatus"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                PayOutDataGrid.Columns["payoutStatus"].Width = 110;

                // Hide columns not needed for display
                PayOutDataGrid.Columns["payoutMonth"].Visible = false;
                PayOutDataGrid.Columns["packageType"].Visible = false;

                if (repeat <= 1)
                {
                    //checkbox
                    DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                    checkBoxColumn.Name = "";
                    checkBoxColumn.HeaderText = "";
                    checkBoxColumn.Width = 25;
                    PayOutDataGrid.Columns.Insert(0, checkBoxColumn);
                    PayOutDataGrid.Columns[""].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }
                
            }
        }

        private void PayOutDataGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (PayOutDataGrid.IsCurrentCellDirty)
            {
                PayOutDataGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void PayOutDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                bool isChecked = Convert.ToBoolean(PayOutDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                string payoutStatus = isChecked ? "Released" : "Pending";
                string employeeID = PayOutDataGrid.Rows[e.RowIndex].Cells["employeeID"].Value.ToString();

                using (MySqlConnection con = DatabaseConnection.GetConnection())
                {
                    con.Open();
                    string query = "UPDATE event_management_system.payout SET payoutStatus = @payoutStatus WHERE employeeID = @employeeID";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@payoutStatus", payoutStatus);
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);
                    cmd.ExecuteNonQuery();
                }

                // Directly update the payoutStatus cell to reflect the change in the DataGridView
                PayOutDataGrid.Rows[e.RowIndex].Cells["payoutStatus"].Value = payoutStatus;
            }
        }

        public void FillBillsDataGridView(DateTime today)
        {
            repeat2++;
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                MySqlDataAdapter billsGrid = new MySqlDataAdapter("SELECT * FROM event_management_system.biller", con);
                DataTable billsTable = new DataTable();
                billsGrid.Fill(billsTable);

                BillsDataGridView.DataSource = billsTable;

                // Changing name to appear on the header
                BillsDataGridView.Columns["billerID"].HeaderText = "Bill";
                BillsDataGridView.Columns["billerID"].ReadOnly = true;
                BillsDataGridView.Columns["dueDate"].HeaderText = "Due Date";
                BillsDataGridView.Columns["dueDate"].ReadOnly = true;
                BillsDataGridView.Columns["monthlyBudget"].HeaderText = "Amount";
                BillsDataGridView.Columns["monthlyBudget"].ReadOnly = true;
                BillsDataGridView.Columns["billStatus"].HeaderText = "Status";
                BillsDataGridView.Columns["billStatus"].ReadOnly = true;

                // Hide columns not needed for display
                BillsDataGridView.Columns["billerName"].Visible = false;
                BillsDataGridView.Columns["billType"].Visible = false;

                if (repeat2 <= 1)
                {
                    // Add checkbox column if it does not already exist
                    DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                    checkBoxColumn.Name = "";
                    checkBoxColumn.HeaderText = "";
                    checkBoxColumn.Width = 25;
                    BillsDataGridView.Columns.Insert(0, checkBoxColumn);
                    BillsDataGridView.Columns[""].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }
               
            }
        }

        private void BillsDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (BillsDataGridView.IsCurrentCellDirty)
            {
                BillsDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void BillsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                bool isChecked = Convert.ToBoolean(BillsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                string billStatus = isChecked ? "Paid" : "Unpaid";
                string billerID = BillsDataGridView.Rows[e.RowIndex].Cells["billerID"].Value.ToString();

                using (MySqlConnection con = DatabaseConnection.GetConnection())
                {
                    con.Open();
                    string query = "UPDATE event_management_system.biller SET billStatus = @billStatus WHERE billerID = @billerID";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@billStatus", billStatus);
                    cmd.Parameters.AddWithValue("@billerID", billerID);
                    cmd.ExecuteNonQuery();
                }

                // Directly update the billStatus cell to reflect the change in the DataGridView
                BillsDataGridView.Rows[e.RowIndex].Cells["billStatus"].Value = billStatus;
            }
        }

        public void FillFinanceRepDataGrid(DateTime today)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                MySqlDataAdapter financeGrid = new MySqlDataAdapter("SELECT * FROM event_management_system.financereport", con);

                DataTable financeTable = new DataTable();
                financeGrid.Fill(financeTable);
                FinanceRepDataGrid.DataSource = financeTable;
                FinanceRepDataGrid.Columns["financeRepID"].HeaderText = "Report ID";
                FinanceRepDataGrid.Columns["month"].HeaderText = "Day of Report";
                FinanceRepDataGrid.Columns["totalPayouts"].HeaderText = "Payouts";
                FinanceRepDataGrid.Columns["totalBill"].HeaderText = "Total Bill";
                FinanceRepDataGrid.Columns["totalMonthlyIncome"].HeaderText = "Income";
            }
        }
        private void BillsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex != 0)
            {
                DataGridViewRow selectedRow = BillsDataGridView.Rows[e.RowIndex];

                string billID = selectedRow.Cells["billerID"].Value.ToString();
                string billerName = selectedRow.Cells["billerName"].Value.ToString();
                string billType = selectedRow.Cells["billType"].Value.ToString();

                DateTime billDDate = DateTime.Parse(selectedRow.Cells["dueDate"].Value.ToString()).Date;
                string formattedBillDDate = billDDate.ToString("yyyy-MM-dd");

                string billBudget = selectedRow.Cells["monthlyBudget"].Value.ToString();
                string billStatus = selectedRow.Cells["billStatus"].Value.ToString();

                Bill_Info billInfo = new Bill_Info(this, billID, billerName, billType, formattedBillDDate, billBudget, billStatus);
                billInfo.Show();
            }
        }

        private void AddBillerBTN_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            string formattedDate = today.ToString("yyyy-MM-dd");
            Bill_Info billInfo = new Bill_Info(this, null, null, null, formattedDate, null, null);
            billInfo.Show();
        }

        public void UpdateFinanceRep(string month, string year, DateTime today)
        {
            string financeID = month + year.Substring(year.Length - 2);
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                //get values of total of monthlybudget
                MySqlCommand budgetquery = new MySqlCommand("SELECT SUM(monthlyBudget) FROM event_management_system.biller", con);
                object bresult = budgetquery.ExecuteScalar();
                int totalBill = 0;
                if (bresult != DBNull.Value)
                {
                    totalBill = Convert.ToInt32(bresult);
                }

                MySqlCommand payoutquery = new MySqlCommand("SELECT SUM(payoutAmount) FROM event_management_system.payout WHERE MONTH(payoutMonth) = @month AND YEAR(payoutMonth) = @year", con);
                payoutquery.Parameters.AddWithValue("@month", month);
                payoutquery.Parameters.AddWithValue("@year", year);
                object presult = payoutquery.ExecuteScalar();
                int totalPayouts = 0;
                if (presult != DBNull.Value)
                {
                    totalPayouts = Convert.ToInt32(presult);
                    string ID = Convert.ToString(month) + Convert.ToString(year);
                }

                MySqlCommand invoicequery = new MySqlCommand("SELECT SUM(totalAmount) FROM event_management_system.invoice WHERE paymentID LIKE @monthPattern AND paymentID LIKE @yearPattern", con);
                invoicequery.Parameters.AddWithValue("@monthPattern", "%" + month + "%");
                invoicequery.Parameters.AddWithValue("@yearPattern", "%" + year.Substring(year.Length - 2) + "%");
                object inresult = invoicequery.ExecuteScalar();
                int totalEventPayments = 0;
                if (inresult != DBNull.Value)
                {
                    totalEventPayments = Convert.ToInt32(inresult);
                }

                //storing all finance ID
                List<string> financeRepIDs = new List<string>();
                MySqlCommand financequery = new MySqlCommand("SELECT financeRepID FROM event_management_system.financereport", con);
                MySqlDataReader freader = financequery.ExecuteReader();
                while (freader.Read())
                {
                    // Assuming financeRepID is a string, otherwise adjust the type accordingly
                    string financeRepID = freader["financeRepID"].ToString();
                    financeRepIDs.Add(financeRepID);
                }
                freader.Close();


                int totalMonthlyIncome = totalEventPayments - (totalPayouts + totalBill);

                string fmonth = year + "-" + month + "-30";

                if (financeRepIDs.Contains(financeID))
                {
                    MySqlCommand command = new MySqlCommand("UPDATE event_management_system.financereport " +
                        "SET month = @month, totalPayouts = @totalPayouts, totalEventPayments = @totalEventPayments, totalBill = @totalBill, totalMonthlyIncome = @totalMonthlyIncome  " +
                       "WHERE financeRepID = @financeID", con);
                    // Set the parameters for the command
                    command.Parameters.AddWithValue("@month", fmonth);
                    command.Parameters.AddWithValue("@totalPayouts", totalPayouts);
                    command.Parameters.AddWithValue("@totalEventPayments", totalEventPayments);
                    command.Parameters.AddWithValue("@totalBill", totalBill);
                    command.Parameters.AddWithValue("@totalMonthlyIncome", totalMonthlyIncome);
                    command.Parameters.AddWithValue("@financeID", financeID);

                    // Execute the command to update the data in the database
                    command.ExecuteNonQuery();
                }
                else
                {
                    //insert new report
                    MySqlCommand command = new MySqlCommand("INSERT INTO event_management_system.financereport" +
                       "(financeRepID, month, totalPayouts, totalEventPayments, totalBill, totalMonthlyIncome)" +
                           "VALUES (@financeID, @month, @totalPayouts, @totalEventPayments, @totalBill, @totalMonthlyIncome )", con);
                    // Set the parameters for the command
                    command.Parameters.AddWithValue("@month", fmonth);
                    command.Parameters.AddWithValue("@totalPayouts", totalPayouts);
                    command.Parameters.AddWithValue("@totalEventPayments", totalEventPayments);
                    command.Parameters.AddWithValue("@totalBill", totalBill);
                    command.Parameters.AddWithValue("@totalMonthlyIncome", totalMonthlyIncome);
                    command.Parameters.AddWithValue("@financeID", financeID);

                    // Execute the command to update the data in the database
                    command.ExecuteNonQuery();
                }

                

            }
        }
    }
}
