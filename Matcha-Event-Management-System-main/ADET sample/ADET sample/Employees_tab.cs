using MySql.Data.MySqlClient;
using System.Data;

namespace ADET_sample
{
    public partial class Employees_tab : Form
    {

        public Employees_tab()
        {
            InitializeComponent();
            FILL_EMP_LIST();
            EmployeeListDataGrid.ReadOnly = true;
        }

        private void Employees_tab_Load(object sender, EventArgs e)
        {
        }

        public void FILL_EMP_LIST()
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter Employee = new MySqlDataAdapter("SELECT * FROM event_management_system.employee", conn);
                    DataTable EmployeeTab = new DataTable();
                    Employee.Fill(EmployeeTab);
                    EmployeeListDataGrid.DataSource = EmployeeTab;

                    EmployeeListDataGrid.ReadOnly = true;

                    // Adjusting column headers and visibility
                    EmployeeListDataGrid.Columns["employeeID"].HeaderText = "Employee ID";
                    EmployeeListDataGrid.Columns["employeeName"].HeaderText = "Name";
                    EmployeeListDataGrid.Columns["employeeNum"].HeaderText = "Number";
                    EmployeeListDataGrid.Columns["employeeAddress"].Visible = false;
                    EmployeeListDataGrid.Columns["employeeFBName"].Visible = false;
                    EmployeeListDataGrid.Columns["password"].Visible = false;
                    EmployeeListDataGrid.Columns["role"].Visible = false;
                    EmployeeListDataGrid.Columns["employeeEmail"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void Add_New_Emp_Btn_Click(object sender, EventArgs e)
        {
            EmployeeDetails EmployeeDetailsForm = new EmployeeDetails(this, null, null, null, null, null, null, null, null);
            EmployeeDetailsForm.ShowDialog();
        }

        private void EmployeeListDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = EmployeeListDataGrid.Rows[e.RowIndex];
                string empID = selectedRow.Cells["employeeID"].Value.ToString();
                string empName = selectedRow.Cells["employeeName"].Value.ToString();
                string empEmail = selectedRow.Cells["employeeEmail"].Value.ToString();
                string empNum = selectedRow.Cells["employeeNum"].Value.ToString();
                string empAdd = selectedRow.Cells["employeeAddress"].Value.ToString();
                string empFB = selectedRow.Cells["employeeFBName"].Value.ToString();
                string empRole = selectedRow.Cells["role"].Value.ToString();
                string password = selectedRow.Cells["password"].Value.ToString();

                EmployeeDetails EmployeeDetailsForm = new EmployeeDetails(this, empID, empName, empEmail, empNum, empAdd, empFB, empRole, password);
                EmployeeDetailsForm.ShowDialog();
            }
        }

        public void RefreshEmployeeList()
        {
            FILL_EMP_LIST();
        }
    }
}

