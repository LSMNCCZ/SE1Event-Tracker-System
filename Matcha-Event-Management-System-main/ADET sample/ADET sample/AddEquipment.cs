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


    public partial class AddEquipment : Form
    {
        private Equipments_tab eTab;
        private string equipID;
        private string equipName;
        private string equipType;
        private string equipCon;
        private string equipStat;

        public AddEquipment(Equipments_tab parentForm, string equipID, string equipStat, string equipType, string equipCon, string equipName)
        {
            InitializeComponent();
            this.eTab = parentForm;
            this.equipType = equipType;
            this.equipCon = equipCon;
            this.equipStat = equipStat;
            this.equipID = equipID;
            this.equipName = equipName;


            //display initial values
            if (equipID != null)
            {
                SaveEquipBTN.Text = "Edit";
                ClearBTN.Text = "Remove";


                EquipIDTB.Text = equipID;
                equipNameTB.Text = equipName;
                equipTypeCB.Text = equipType;
                equipStatusCB.Text = equipStat;
                equipConCB.Text = equipCon;

                EquipIDTB.ReadOnly = true;
                equipNameTB.ReadOnly = true;
                equipTypeCB.Enabled = false;
                equipStatusCB.Enabled = false;
                equipConCB.Enabled = false;
            }
            else
            {
                EquipIDTB.ReadOnly = false;
                equipNameTB.ReadOnly = false;
            }
        }

        private void SaveEquipBTN_Click(object sender, EventArgs e)
        {
            if (SaveEquipBTN.Text == "Save")
            {
                string eID = EquipIDTB.Text;
                string eName = equipNameTB.Text;
                string eType = equipTypeCB.Text;
                string eStat = equipStatusCB.Text;
                string eCon = equipConCB.Text;

                UpdateEquipmentDataBase(eID, eName, eType, eStat, eCon);
            }
            else if (SaveEquipBTN.Text == "Edit")//admin edit condition ng equipment
            {
                equipConCB.Enabled = true;
                SaveEquipBTN.Text = "Save";
            }

        }
        private void UpdateEquipmentDataBase(string eID, string eName, string eType,
                string eStat, string eCon)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                if (ClearBTN.Text == "Clear")
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO event_management_system.equipment(equipID, equipName," +
                        "equipType, equipCondition, equipStatus) " +
                        "VALUES (@ID, @Name, @Type, @Con, @Stat)", con);
                    // Set the parameters for the command
                    command.Parameters.AddWithValue("@ID", eID);
                    command.Parameters.AddWithValue("@Name", eName);
                    command.Parameters.AddWithValue("@Type", eType);
                    command.Parameters.AddWithValue("@Stat", eStat);
                    command.Parameters.AddWithValue("@Con", eCon);

                    //Make add event button unavail pag clicked once
                    ClearBTN.Enabled = false;
                    SaveEquipBTN.Enabled = false;

                    // Execute the command to update the data in the database
                    command.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand command = new MySqlCommand("UPDATE event_management_system.equipment SET equipStatus = @Stat WHERE equipID = @ID", con);
                    // Set the parameters for the command
                    command.Parameters.AddWithValue("@ID", eID);
                    command.Parameters.AddWithValue("@Stat", eStat);

                    //Make add event button unavail pag clicked once
                    ClearBTN.Enabled = false;
                    SaveEquipBTN.Enabled = false;

                    // Execute the command to update the data in the database
                    command.ExecuteNonQuery();
                }
            }
            eTab.FillEquipmentsDataGrid();
        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {

            if (ClearBTN.Text == "Remove")
            {
                if (MessageBox.Show("Do you want to Remove Equipment?", "Remove Equipment", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string eID = EquipIDTB.Text;
                    using (MySqlConnection conn = DatabaseConnection.GetConnection())
                    {
                        try
                        {
                            conn.Open();
                            MySqlCommand command = new MySqlCommand("DELETE FROM event_management_system.equipment WHERE equipID = @eID", conn);
                            command.Parameters.AddWithValue("@eID", eID);
                            command.ExecuteNonQuery();
                            eTab.FillEquipmentsDataGrid();

                            this.Close();
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
                }            }
            else
            {
                EquipIDTB.Text = "XXXXX";
                equipNameTB.Text = "--";
                equipTypeCB.Text = null;
                equipStatusCB.Text = null;
                equipConCB.Text = null;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

