using MySql.Data.MySqlClient;

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
            // Store the initial values of the text boxes and comboboxes para accessible sa lahut
            this.parentForm = parentForm;
            this.initialempID = empID;
            this.initialempName = empName;
            this.initialempEmail = empEmail;
            this.initialempNum = empNum;
            this.initialempAdd = empAdd;
            this.initialempFB = empFB;
            this.initialempRole = empRole;
            this.initialPassword = password;

            //If EmpID is null(means adding a new Employee)
            if (empID == null && empName == null || empID == "" && empName == "")
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
            else //for displaying and editing employee 
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

        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Remove_EmployeeBTN_Click(object sender, EventArgs e)
        {   //Clearing Values sa entering new employee
            if (Remove_EmployeeBTN.Text == "Clear")
            {
                //RevertValues
                EmpAddTB.Text = null;
                EmpEmailTB.Text = null;
                EmpNameTB.Text = null;
                EmpNumTB.Text = null;
                EmpRoleTB.Text = null;
                EmpFBTB.Text = null;
            }
            //Removing Employee
            else if (Remove_EmployeeBTN.Text == "Remove")
            {
                if (MessageBox.Show("Do you want to Remove Employee?", "Remove Employee", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (MySqlConnection con = DatabaseConnection.GetConnection())
                    {
                        con.Open();
                        MySqlCommand command = new MySqlCommand("DELETE FROM event_management_system.employee WHERE " +
                            "employeeID = @ID AND employeeName = @Name", con);
                        // Set the parameters for the command
                        command.Parameters.AddWithValue("@ID", this.initialempID);
                        command.Parameters.AddWithValue("@Name", this.initialempName);

                        // Execute the command to update the data in the database
                        command.ExecuteNonQuery();
                        parentForm.RefreshEmployeeList();
                        this.Close();
                    }
                }
            }
        }
        private void EmpRoleTB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Edit_EmployeeInfo_Click(object sender, EventArgs e)
        {
            // Make the text boxes editable
            EmpNameTB.ReadOnly = false;
            EmpAddTB.ReadOnly = false;
            EmpFBTB.ReadOnly = false;
            EmpEmailTB.ReadOnly = false;
            //EmpIDTB.ReadOnly = false;
            EmpNumTB.ReadOnly = false;
            EmpRoleTB.Enabled = true;

            UNEmpAdd.Visible = true;
            UNEmpEmail.Visible = true;
            UNEmpFBName.Visible = true;
            UNEmpName.Visible = true;
            UNEmpNum.Visible = true;

            //Save Changes to existing employee
            if (Edit_EmployeeInfo.Text == "Save")
            {
                if (MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    string empName = EmpNameTB.Text;
                    string empEmail = EmpEmailTB.Text;
                    string empNum = EmpNumTB.Text;
                    string empAdd = EmpAddTB.Text;
                    string empFB = EmpFBTB.Text;
                    string empRole = EmpRoleTB.Text;


                    UpdatingEmployeeDataBase(this.initialempID, empName, empEmail,
                    empNum, empAdd, empFB, empRole, this.initialPassword);


                    //Making All Text Box initially display values according to Database's new record
                    // Make the text boxes editable
                    EmpNameTB.ReadOnly = true;
                    EmpAddTB.ReadOnly = true;
                    EmpFBTB.ReadOnly = true;
                    EmpEmailTB.ReadOnly = true;
                    EmpNumTB.ReadOnly = true;
                    EmpRoleTB.Enabled = true;

                    //visibility of underlines
                    UNEmpAdd.Visible = false;
                    UNEmpEmail.Visible = false;
                    UNEmpFBName.Visible = false;
                    UNEmpName.Visible = false;
                    UNEmpNum.Visible = false;
                }
                else
                {
                    //RevertValues
                    EmpAddTB.Text = this.initialempAdd;
                    EmpEmailTB.Text = this.initialempEmail;
                    EmpNameTB.Text = this.initialempName;
                    EmpNumTB.Text = this.initialempNum;
                    EmpRoleTB.Text = this.initialempRole;
                    EmpFBTB.Text = this.initialempFB;
                }
            }
            //Saving New employees
            else if (Edit_EmployeeInfo.Text == "Save New Employee")
            {
                if (MessageBox.Show("Do you want to save New Employee?", "Add Employee ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string empID = EmpIDTB.Text;
                    string empName = EmpNameTB.Text;
                    string empEmail = EmpEmailTB.Text;
                    string empNum = EmpNumTB.Text;
                    string empAdd = EmpAddTB.Text;
                    string empFB = EmpFBTB.Text;
                    string empRole = EmpRoleTB.Text;
                    string password = PasswordTB.Text;

                    UpdatingEmployeeDataBase(empID, empName, empEmail,
                        empNum, empAdd, empFB, empRole, password);

                    //Making All Text Box initially display values according to Database's new record
                    // Make the text boxes editable
                    EmpNameTB.ReadOnly = true;
                    EmpAddTB.ReadOnly = true;
                    EmpFBTB.ReadOnly = true;
                    EmpEmailTB.ReadOnly = true;
                    EmpNumTB.ReadOnly = true;
                    EmpRoleTB.Enabled = true;

                    //visibility of underlines
                    UNEmpAdd.Visible = false;
                    UNEmpEmail.Visible = false;
                    UNEmpFBName.Visible = false;
                    UNEmpName.Visible = false;
                    UNEmpNum.Visible = false;
                    //clear button disabled
                    Remove_EmployeeBTN.Enabled = false;
                }
                else
                {
                    //RevertValues
                    EmpAddTB.Text = null;
                    EmpEmailTB.Text = null;
                    EmpNameTB.Text = null;
                    EmpNumTB.Text = null;
                    EmpRoleTB.Text = null;
                    EmpFBTB.Text = null;
                }
            }
            Edit_EmployeeInfo.Text = "Save";
        }
        private void UpdatingEmployeeDataBase(string empID, string empName, string empEmail,
            string empNum, string empAdd, string empFB, string empRole, string password)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                if (Edit_EmployeeInfo.Text == "Save")
                {
                    MySqlCommand command = new MySqlCommand("UPDATE event_management_system.employee SET employeeName = @Name, employeeEmail = @Email, " +
                        "employeeNum = @Number, employeeAddress = @Address, employeeFBName = @FB, role = @Role" +
                        " WHERE employeeID = @ID AND employeeName = @Name", con);
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
                    MySqlCommand command = new MySqlCommand("INSERT INTO event_management_system.employee(employeeID, employeeName, employeeEmail," +
                        "employeeNum, employeeAddress, employeeFBName, role, password) " +
                        "VALUES (@ID, @Name, @Email, @Number, @Address, @FB, @Role, @Pass)", con);
                    // Set the parameters for the command
                    command.Parameters.AddWithValue("@ID", empID);
                    command.Parameters.AddWithValue("@Name", empName);
                    command.Parameters.AddWithValue("@Email", empEmail);
                    command.Parameters.AddWithValue("@Number", empNum);
                    command.Parameters.AddWithValue("@Address", empAdd);
                    command.Parameters.AddWithValue("@FB", empFB);
                    command.Parameters.AddWithValue("@Role", empRole);
                    command.Parameters.AddWithValue("@Pass", password);
                    //Make add event button unavail pag clicked once
                    Edit_EmployeeInfo.Enabled = false;
                    // Execute the command to update the data in the database
                    command.ExecuteNonQuery();

                }
                parentForm.RefreshEmployeeList();
            }

        }
    }
}


