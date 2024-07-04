using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADET_sample
{

    public partial class Log_In : Form
    {

        public class Employee
        {
            public string EmployeeID { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }

            public Employee(string employeeID, string password, string role)
            {
                EmployeeID = employeeID;
                Password = password;
                Role = role;
            }
        }
        private Dictionary<string, Employee> Employees;
        public Log_In()
        {
            InitializeComponent();
            Employees = new Dictionary<string, Employee>();
            LoadEmployees();

        }

        private void LoadEmployees()
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT employeeID, password, role FROM event_management_system.employee";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string employeeID = reader["employeeID"].ToString();
                    string password = reader["password"].ToString();
                    string role = reader["role"].ToString();
                    Employee employee = new Employee(employeeID, password, role);
                    Employees[employeeID] = employee;
                }

                reader.Close();
            }
        }



        private void LoginBTN_Click(object sender, EventArgs e)
        {
            string enteredEmployeeID = EmpIDTB.Text;
            string enteredPassword = PasswordTB.Text;

            if (Employees.TryGetValue(enteredEmployeeID, out Employee employee))
            {
                if (employee.Password == enteredPassword)
                {
                    this.Hide();
                    Main_Page mainPage = new Main_Page();
                    mainPage.Show();
                    GlobalVariables.UserRole = employee.Role;

                }
                else
                {
                    MessageBox.Show("Wrong Password/Employee ID");
                }
            }
            else
            {
                MessageBox.Show("Wrong Password/Employee ID");
            }

        }

        private void EmpIDTB_Click(object sender, EventArgs e)
        {
            EmpIDTB.Text = "";
        }
        private void PasswordTB_Click(object sender, EventArgs e)
        {
            PasswordTB.Text = "";
        }
        
    }
}
