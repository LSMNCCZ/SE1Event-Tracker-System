using MySql.Data.MySqlClient;
using System.Data;

namespace ADET_sample
{
    public partial class Services_tab : Form
    {
        private int repeat;
        public Services_tab()
        {
            InitializeComponent();
            if (GlobalVariables.UserRole != "Admin")
            {
                AddPackageBTN.Enabled = false;
                AddOnsBTN.Enabled = false;
            }
        }

        private void Services_tab_Load(object sender, EventArgs e)
        {
            FillServiceTab();
            Packages_List_DataGrid.ReadOnly = true;
            Addons_List_DataGrid.ReadOnly = true;

        }

        public void FillServiceTab()
        {
            repeat = repeat + 1;
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    // PACKAGES/SERVICES
                    MySqlCommand command = new MySqlCommand("SELECT * FROM event_management_system.package", conn);
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    Packages_List_DataGrid.DataSource = dataTable;

                    // Adjusting column headers and visibility
                    Packages_List_DataGrid.Columns["packageType"].HeaderText = "Service ID";
                    Packages_List_DataGrid.Columns["packageName"].HeaderText = "Package Name";
                    Packages_List_DataGrid.Columns["packagePrice"].HeaderText = "Package Price";
                    Packages_List_DataGrid.Columns["packageInclusion"].Visible = false;
                    Packages_List_DataGrid.Columns["employeeRate"].Visible = false;


                    // ADD ONS
                    command = new MySqlCommand("SELECT * FROM event_management_system.addon", conn);
                    dataTable = new DataTable();
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    Addons_List_DataGrid.DataSource = dataTable;
                    Addons_List_DataGrid.Columns["addOnID"].HeaderText = "Add-On";
                    Addons_List_DataGrid.Columns["description"].HeaderText = "Description";
                    Addons_List_DataGrid.Columns["addOnPrice"].HeaderText = "Price";

                    if (repeat == 1 && GlobalVariables.UserRole == "Admin")
                    {
                        // Add an image column for deletion
                        DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                        imgColumn.HeaderText = "";
                        imgColumn.Image = Properties.Resources.deletebtn; // Use the image from resources
                        imgColumn.Name = "";
                        Addons_List_DataGrid.Columns.Add(imgColumn);

                        // Set the width of the image column
                        Addons_List_DataGrid.Columns[""].Width = 50;
                        Addons_List_DataGrid.Columns[""].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    }
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

        private void AddPackageBTN_Click(object sender, EventArgs e)
        {
            //new package
            Packages packagesForm = new Packages(this, null, null, null, null, null);
            packagesForm.Show();
        }

        private void Packages_List_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //view details ng package
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = Packages_List_DataGrid.Rows[e.RowIndex];

                string type = selectedRow.Cells["packageType"].Value.ToString();
                string name = selectedRow.Cells["packageName"].Value.ToString();
                string price = selectedRow.Cells["packagePrice"].Value.ToString();
                string inclusion = selectedRow.Cells["packageInclusion"].Value.ToString();
                string rate = selectedRow.Cells["employeeRate"].Value.ToString();

                Packages packagesForm = new Packages(this, type, name, price, inclusion, rate);
                packagesForm.Show();
            }
        }
        public void RefreshServList()
        {
            FillServiceTab();
        }


        private void AddOnsBTN_Click(object sender, EventArgs e)
        {
            NewAddOn AddOnForm = new NewAddOn(this, null, null, null);
            AddOnForm.ShowDialog();
        }

        private void Addons_List_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == Addons_List_DataGrid.Columns[""].Index)
            {
                // Get the add-on ID of the clicked row
                DataGridViewRow selectedRow = Addons_List_DataGrid.Rows[e.RowIndex];
                string addOnID = selectedRow.Cells["addOnID"].Value.ToString();

                DeleteAddOnFromDatabase(addOnID);
                FillServiceTab();
            }
        }
        private void DeleteAddOnFromDatabase(string addOnID)
        {
            if (MessageBox.Show("Do you want to Remove Add-On?", "Remove Add-On", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand command = new MySqlCommand("DELETE FROM event_management_system.addon WHERE addOnID = @addOnID", conn);
                        command.Parameters.AddWithValue("@addOnID", addOnID);
                        command.ExecuteNonQuery();
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
        }

    }
}