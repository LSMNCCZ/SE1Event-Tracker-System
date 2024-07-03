using MySql.Data.MySqlClient;
using Mysqlx.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADET_sample
{
    public partial class Equipments_tab : Form
    {
        private int repeat;
        public Equipments_tab()
        {
            InitializeComponent();
            FillEquipmentsDataGrid();
            EquipmentDataGrid.ReadOnly = true;
        }
        public void FillEquipmentsDataGrid()
        {
            repeat = repeat + 1;

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter Equipment = new MySqlDataAdapter("SELECT * FROM event_management_system.equipment", conn);
                    DataTable EquipTable = new DataTable();
                    Equipment.Fill(EquipTable);
                    EquipmentDataGrid.DataSource = EquipTable;

                    EquipmentDataGrid.ReadOnly = true;

                    // Adjusting column headers and visibility
                    EquipmentDataGrid.Columns["equipID"].HeaderText = "Equipment ID";
                    EquipmentDataGrid.Columns["equipName"].HeaderText = "Name";
                    EquipmentDataGrid.Columns["equipType"].HeaderText = "Type";
                    EquipmentDataGrid.Columns["equipCondition"].HeaderText = "Condition";
                    EquipmentDataGrid.Columns["equipStatus"].HeaderText = "Status";

                    if (repeat == 1)
                    {
                        // Add an image column for checkout
                        DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                        imgColumn.HeaderText = "";
                        imgColumn.Image = Properties.Resources.deploy; // Use the image from resources
                        imgColumn.Name = "Deploy";
                        EquipmentDataGrid.Columns.Add(imgColumn);

                        // Set the width of the image column
                        EquipmentDataGrid.Columns["Deploy"].Width = 50;
                        EquipmentDataGrid.Columns["Deploy"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    }
                    if (repeat == 1)
                    {
                        // Add an image column for checkout
                        DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                        imgColumn.HeaderText = "";
                        imgColumn.Image = Properties.Resources._return; //liit masyado
                        imgColumn.Name = "Return";
                        EquipmentDataGrid.Columns.Add(imgColumn);

                        // Set the width of the image column
                        EquipmentDataGrid.Columns["Return"].Width = 50;
                        EquipmentDataGrid.Columns["Return"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
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
        private void EquipmentDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.ColumnIndex == EquipmentDataGrid.Columns["Deploy"].Index)
            {
                // Get the add-on ID of the clicked row
                DataGridViewRow selectedRow = EquipmentDataGrid.Rows[e.RowIndex];
                string equipID = selectedRow.Cells["equipID"].Value.ToString();
                string equipStatus = selectedRow.Cells["equipStatus"].Value.ToString();
                string column = "Deploy";

                UpdateStatus(equipID, equipStatus, column);
            }

            else if (e.RowIndex >= 0 && e.ColumnIndex == EquipmentDataGrid.Columns["Return"].Index)
            {
                // Get the add-on ID of the clicked row
                DataGridViewRow selectedRow = EquipmentDataGrid.Rows[e.RowIndex];
                string equipID = selectedRow.Cells["equipID"].Value.ToString();
                string equipStatus = selectedRow.Cells["equipStatus"].Value.ToString();
                string column = "Return";

                UpdateStatus(equipID, equipStatus, column);
            }
            else
            {
                DataGridViewRow selectedRow = EquipmentDataGrid.Rows[e.RowIndex];
                string equipID = selectedRow.Cells["equipID"].Value.ToString();
                string equipStat = selectedRow.Cells["equipStatus"].Value.ToString();
                string equipType = selectedRow.Cells["equipType"].Value.ToString();
                string equipCon = selectedRow.Cells["equipCondition"].Value.ToString();
                string equipName = selectedRow.Cells["equipName"].Value.ToString();

                AddEquipment packagesForm = new AddEquipment(this, equipID, equipStat, equipType, equipCon, equipName);
                packagesForm.Show();
            }
        }
        private void UpdateStatus(string equipID, string equipStatus, string column)
        {
            if (equipStatus == "Deployed" && column == "Return")
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand command = new MySqlCommand("UPDATE event_management_system.equipment SET equipStatus = 'In-Studio' WHERE equipID = @equipID", conn);
                        command.Parameters.AddWithValue("@equipID", equipID);
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
            else if (equipStatus == "In-Studio" && column == "Deploy")
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand command = new MySqlCommand("UPDATE event_management_system.equipment SET equipStatus = 'Deployed' WHERE equipID = @equipID", conn);
                        command.Parameters.AddWithValue("@equipID", equipID);
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

            FillEquipmentsDataGrid();
        }

        private void NewEquipmentBTN_Click(object sender, EventArgs e)
        {
            AddEquipment packagesForm = new AddEquipment(this,null, null, null, null, null);
            packagesForm.Show();

        }
    }
}
