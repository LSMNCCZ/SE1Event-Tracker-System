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
    public partial class Invoice : Form
    {
        private string eventID;
        private string payID;
        public Invoice(string eventID, string payID)
        {
            this.eventID = eventID;
            this.payID = payID;

            InitializeComponent();
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                MySqlCommand clientbalance = new MySqlCommand("SELECT * FROM event_management_system.invoice WHERE paymentID = @pID AND eventID = @eID;", con);
                clientbalance.Parameters.AddWithValue("@eID", this.eventID);
                clientbalance.Parameters.AddWithValue("@pID", this.payID);

                using (MySqlDataReader balancereader = clientbalance.ExecuteReader())
                {
                    if (balancereader.Read())  // Check if there are rows to read
                    {
                        string pStatus = balancereader["paymentStatus"].ToString();
                        string balance = balancereader["paymentBal"].ToString();
                        string pType = balancereader["paymentType"].ToString();
                        string pAmount = balancereader["totalAmount"].ToString();
                        string pDP = balancereader["downpayment"].ToString();

                        EventID.Text = this.eventID;
                        PaymentID.Text = this.payID;
                        PStatus.Text = pStatus;
                        PType.Text = pType;
                        pTotal.Text = pAmount;
                        DP.Text = pDP;
                        pBalance.Text = balance;


                    }
                }
            }
            

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
