using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADET_sample
{
    public partial class PostReport : Form
    {
        public PostReport(string date, string eventID, string reportID, bool eventin)
        {
            

            InitializeComponent();
            ReportID.Text = reportID;
            EventID.Text = eventID;

            if (eventin != false)
            {
                string equipmentCon = "";
                string photoPaperC = "";
                string outputQuality = "";
                string Comments = "";

                SumbitBTN.Text = "Done";
                using (MySqlConnection con = DatabaseConnection.GetConnection())
                {
                    con.Open();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM event_management_system.posteventreport WHERE eventID = @eventID", con);
                    command.Parameters.AddWithValue("@eventID", eventID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            equipmentCon = reader["equipmentCon"].ToString();
                            photoPaperC = reader["photoPaperC"].ToString();
                            outputQuality = reader["outputQuality"].ToString();
                            Comments =reader["Comments"].ToString();

                        }
                    }
                }

                
                EquipTB.Text = equipmentCon;
                PaperCountTB.Text = photoPaperC;
                equipConCB.SelectedItem = outputQuality;
                CommentsTB.Text = Comments;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SumbitBTN_Click(object sender, EventArgs e)
        {
            if(SumbitBTN.Text == "Done")
            {
                this.Close();
            }
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO event_management_system.posteventreport(reportID, eventID," +
                    "equipmentCon,photoPaperC, outputQuality, Comments) " +
                    "VALUES (@repID, @eventID, @equip, @PPC, @Quali)", con);
                // Set the parameters for the command
                command.Parameters.AddWithValue("@repID", ReportID.Text);
                command.Parameters.AddWithValue("@eventID", EventID.Text);
                command.Parameters.AddWithValue("@equip", EquipTB.Text);
                command.Parameters.AddWithValue("@PPC", PaperCountTB.Text);
                command.Parameters.AddWithValue("@Quali", equipConCB.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Quali", CommentsTB.Text);

                SumbitBTN.Text = "Done";

                // Execute the command to update the data in the database
                command.ExecuteNonQuery();
            }
        }

        private void SumbitBTN_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
