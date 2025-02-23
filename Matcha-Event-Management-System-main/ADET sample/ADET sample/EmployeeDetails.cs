﻿using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ADET_sample
{
    public partial class EmployeeDetails : Form
    {
        private Employees_tab parentForm;
        private string initialempID;
        private string initialempName;
        private string initialempEmail;
        private string initialempNum;
        private string initialempAdd;
        private string initialempFB;
        private string initialempRole;
        private string initialPassword;

        public EmployeeDetails(Employees_tab parentForm, string empID, string empName, string empEmail,
            string empNum, string empAdd, string empFB, string empRole, string password)
        {
            InitializeComponent();
            // Store the initial values of the text boxes and comboboxes
            this.parentForm = parentForm;
            this.initialempID = empID;
            this.initialempName = empName;
            this.initialempEmail = empEmail;
            this.initialempNum = empNum;
            this.initialempAdd = empAdd;
            this.initialempFB = empFB;
            this.initialempRole = empRole;
            this.initialPassword = password;

            // If EmpID is null (means adding a new Employee)
            if (string.IsNullOrEmpty(empID) && string.IsNullOrEmpty(empName))
            {
                Edit_EmployeeInfo.Text = "Save New Employee";
                Remove_EmployeeBTN.Text = "Clear";

                UNEmpAdd.Visible = true;
                UNEmpEmail.Visible = true;
                UNEmpFBName.Visible = true;
                UNEmpID.Visible = true;
                UNEmpName.Visible = true;
                UNEmpNum.Visible = true;
                PasswordLabel.Visible = true;
                PasswordTB.Visible = true;

                PasswordTB.ReadOnly = false;
                EmpNameTB.ReadOnly = false;
                EmpAddTB.ReadOnly = false;
                EmpFBTB.ReadOnly = false;
                EmpEmailTB.ReadOnly = false;
                EmpIDTB.ReadOnly = false;
                EmpNumTB.ReadOnly = false;
                EmpRoleTB.Enabled = true;
            }
            else // for displaying and editing employee 
            {
                UNEmpAdd.Visible = false;
                UNEmpEmail.Visible = false;
                UNEmpFBName.Visible = false;
                UNEmpID.Visible = false;
                UNEmpName.Visible = false;
                UNEmpNum.Visible = false;
                UNPassword.Visible = false;
                EmpRoleTB.Enabled = false;

                EmpNameTB.Text = empName;
                EmpIDTB.Text = empID;
                EmpFBTB.Text = empFB;
                EmpNumTB.Text = empNum;
                EmpEmailTB.Text = empEmail;
                EmpAddTB.Text = empAdd;
                EmpRoleTB.Text = empRole;
            }

            if (GlobalVariables.UserRole != "Admin")
            {
                Edit_EmployeeInfo.Enabled = false;
                Remove_EmployeeBTN.Enabled = false;
            }

            // Set form properties to stay on top and disable clicking away
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Remove_EmployeeBTN_Click(object sender, EventArgs e)
        {
            // Clearing values for entering new employee
            if (Remove_EmployeeBTN.Text == "Clear")
            {
                // Revert values
                EmpAddTB.Text = null;
                EmpEmailTB.Text = null;
                EmpNameTB.Text = null;
                EmpNumTB.Text = null;
                EmpRoleTB.Text = null;
                EmpFBTB.Text = null;
            }
            // Removing Employee
            else if (Remove_EmployeeBTN.Text == "Remove")
            {
                if (MessageBox.Show("Do you want to remove this employee?", "Remove Employee", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (MySqlConnection con = DatabaseConnection.GetConnection())
                    {
                        con.Open();
                        MySqlCommand command = new MySqlCommand("DELETE FROM event_management_system.employee WHERE employeeID = @ID", con);
                        // Set the parameters for the command
                        command.Parameters.AddWithValue("@ID", this.initialempID);

                        // Execute the command to update the data in the database
                        command.ExecuteNonQuery();
                        parentForm.RefreshEmployeeList();
                        this.Close();
                    }
                }
            }
        }

        private void Edit_EmployeeInfo_Click(object sender, EventArgs e)
        {
            // Make the text boxes editable
            EmpNameTB.ReadOnly = false;
            EmpAddTB.ReadOnly = false;
            EmpFBTB.ReadOnly = false;
            EmpEmailTB.ReadOnly = false;
            EmpNumTB.ReadOnly = false;
            EmpRoleTB.Enabled = true;

            UNEmpAdd.Visible = true;
            UNEmpEmail.Visible = true;
            UNEmpFBName.Visible = true;
            UNEmpName.Visible = true;
            UNEmpNum.Visible = true;

            if (Edit_EmployeeInfo.Text == "Save")
            {
                if (IsFormValid())
                {
                    if (MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string empName = EmpNameTB.Text;
                        string empEmail = EmpEmailTB.Text;
                        string empNum = EmpNumTB.Text;
                        string empAdd = EmpAddTB.Text;
                        string empFB = EmpFBTB.Text;
                        string empRole = EmpRoleTB.Text;

                        UpdateEmployeeDataBase(this.initialempID, empName, empEmail, empNum, empAdd, empFB, empRole, this.initialPassword);

                        // Making all text boxes initially display values according to the database's new record
                        EmpNameTB.ReadOnly = true;
                        EmpAddTB.ReadOnly = true;
                        EmpFBTB.ReadOnly = true;
                        EmpEmailTB.ReadOnly = true;
                        EmpNumTB.ReadOnly = true;
                        EmpRoleTB.Enabled = false;

                        // Visibility of underlines
                        UNEmpAdd.Visible = false;
                        UNEmpEmail.Visible = false;
                        UNEmpFBName.Visible = false;
                        UNEmpName.Visible = false;
                        UNEmpNum.Visible = false;

                        Edit_EmployeeInfo.Text = "Edit";
                    }
                    else
                    {
                        // Revert values
                        EmpAddTB.Text = this.initialempAdd;
                        EmpEmailTB.Text = this.initialempEmail;
                        EmpNameTB.Text = this.initialempName;
                        EmpNumTB.Text = this.initialempNum;
                        EmpRoleTB.Text = this.initialempRole;
                        EmpFBTB.Text = this.initialempFB;
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all the required fields.", "Missing Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (Edit_EmployeeInfo.Text == "Save New Employee")
            {
                if (IsFormValid())
                {
                    if (MessageBox.Show("Do you want to add this employee?", "Add Employee", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string empID = EmpIDTB.Text;
                        string empName = EmpNameTB.Text;
                        string empEmail = EmpEmailTB.Text;
                        string empNum = EmpNumTB.Text;
                        string empAdd = EmpAddTB.Text;
                        string empFB = EmpFBTB.Text;
                        string empRole = EmpRoleTB.Text;
                        string password = PasswordTB.Text;

                        UpdateEmployeeDataBase(empID, empName, empEmail, empNum, empAdd, empFB, empRole, password);

                        // Making all text boxes initially display values according to the database's new record
                        EmpNameTB.ReadOnly = true;
                        EmpAddTB.ReadOnly = true;
                        EmpFBTB.ReadOnly = true;
                        EmpEmailTB.ReadOnly = true;
                        EmpNumTB.ReadOnly = true;
                        EmpRoleTB.Enabled = false;

                        // Visibility of underlines
                        UNEmpAdd.Visible = false;
                        UNEmpEmail.Visible = false;
                        UNEmpFBName.Visible = false;
                        UNEmpName.Visible = false;
                        UNEmpNum.Visible = false;

                        // Clear button disabled
                        Remove_EmployeeBTN.Enabled = false;

                        Edit_EmployeeInfo.Text = "Edit";
                    }
                    else
                    {
                        // Revert values
                        EmpAddTB.Text = null;
                        EmpEmailTB.Text = null;
                        EmpNameTB.Text = null;
                        EmpNumTB.Text = null;
                        EmpRoleTB.Text = null;
                        EmpFBTB.Text = null;
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all the required fields.", "Missing Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            Edit_EmployeeInfo.Text = "Save";
        }

        private void UpdateEmployeeDataBase(string empID, string empName, string empEmail, string empNum, string empAdd, string empFB, string empRole, string password)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                if (Edit_EmployeeInfo.Text == "Save")
                {
                    MySqlCommand command = new MySqlCommand("UPDATE event_management_system.employee SET employeeName = @Name, employeeEmail = @Email, " +
                        "employeeNum = @Number, employeeAddress = @Address, employeeFBName = @FB, role = @Role WHERE employeeID = @ID", con);
                    // Set the parameters for the command
                    command.Parameters.AddWithValue("@ID", empID);
                    command.Parameters.AddWithValue("@Name", empName);
                    command.Parameters.AddWithValue("@Email", empEmail);
                    command.Parameters.AddWithValue("@Number", empNum);
                    command.Parameters.AddWithValue("@Address", empAdd);
                    command.Parameters.AddWithValue("@FB", empFB);
                    command.Parameters.AddWithValue("@Role", empRole);

                    // Execute the command to update the data in the database
                    command.ExecuteNonQuery();
                }
                else if (Edit_EmployeeInfo.Text == "Save New Employee")
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO event_management_system.employee(employeeID, employeeName, employeeEmail, " +
                        "employeeNum, employeeAddress, employeeFBName, role, password) VALUES (@ID, @Name, @Email, @Number, @Address, @FB, @Role, @Pass)", con);
                    // Set the parameters for the command
                    command.Parameters.AddWithValue("@ID", empID);
                    command.Parameters.AddWithValue("@Name", empName);
                    command.Parameters.AddWithValue("@Email", empEmail);
                    command.Parameters.AddWithValue("@Number", empNum);
                    command.Parameters.AddWithValue("@Address", empAdd);
                    command.Parameters.AddWithValue("@FB", empFB);
                    command.Parameters.AddWithValue("@Role", empRole);
                    command.Parameters.AddWithValue("@Pass", password);

                    // Execute the command to insert the data into the database
                    command.ExecuteNonQuery();

                    // Disable the Save button after adding
                    Edit_EmployeeInfo.Enabled = false;
                }

                parentForm.RefreshEmployeeList();
            }
        }

        private bool IsFormValid()
        {
            // Check if all required fields are filled
            return !string.IsNullOrEmpty(EmpIDTB.Text) &&
                   !string.IsNullOrEmpty(EmpNameTB.Text) &&
                   !string.IsNullOrEmpty(EmpEmailTB.Text) &&
                   !string.IsNullOrEmpty(EmpNumTB.Text) &&
                   !string.IsNullOrEmpty(EmpAddTB.Text) &&
                   !string.IsNullOrEmpty(EmpFBTB.Text) &&
                   !string.IsNullOrEmpty(EmpRoleTB.Text) &&
                   (Edit_EmployeeInfo.Text != "Save New Employee" || !string.IsNullOrEmpty(PasswordTB.Text));
        }
    }
}



