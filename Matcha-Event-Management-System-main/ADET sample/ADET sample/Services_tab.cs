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
    public partial class Services_tab : Form
    {
        public Services_tab()
        {
            InitializeComponent();
        }

        private void Services_tab_Load(object sender, EventArgs e)
        {
            FillServiceTab();
        }

        public void FillServiceTab()
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM event_management_system.package", conn);
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    Packages_List_DataGrid.DataSource = dataTable;

                    command = new MySqlCommand("SELECT * FROM event_management_system.addon", conn);
                    dataTable = new DataTable();
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    Addons_List_DataGrid.DataSource = dataTable;
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

        private void label_Addons_Click(object sender, EventArgs e)
        {

        }
    }
}