using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMProject
{
    public partial class ChangePinControl : UserControl
    {
        public string AccountNumber { get; set; }

        string conStr = @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True;";

        public ChangePinControl()
        {
            InitializeComponent();
        }

        private void ChangePinControl_Load(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = false;

            string currentPIN = txtCurrent.Text.Trim();
            string newPIN = txtNew.Text.Trim();
            string confirmPIN = txtConfirm.Text.Trim();

            if (currentPIN == "" || newPIN == "" || confirmPIN == "")
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (newPIN != confirmPIN)
            {
                MessageBox.Show("New PIN and Confirm PIN do not match.");
                return;
            }

            if (newPIN.Length < 4)
            {
                MessageBox.Show("PIN must be at least 4 digits.");
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conStr;
                con.Open();

                SqlCommand checkCmd = new SqlCommand();
                checkCmd.Connection = con;
                checkCmd.CommandText = $"SELECT COUNT(*) FROM Users WHERE AccountNumber = '{AccountNumber}' AND PIN = '{currentPIN}'";

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count == 0)
                {
                    MessageBox.Show("Current PIN is incorrect.");
                    con.Close();
                    return;
                }

                SqlCommand updateCmd = new SqlCommand();
                updateCmd.Connection = con;
                updateCmd.CommandText = $"UPDATE Users SET PIN = '{newPIN}' WHERE AccountNumber = '{AccountNumber}'";

                updateCmd.ExecuteNonQuery();

                MessageBox.Show("PIN changed successfully.");

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}