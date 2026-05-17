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
    public partial class ReceiptControl : UserControl
    {

        public string AccountNumber { get; set; }

        string conStr = @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True;TrustServerCertificate=True;";

        public ReceiptControl()
        {
            InitializeComponent();
        }

        private void ReceiptControl_Load(object sender, EventArgs e)
        {
            lblReceipt.Text = "";
            lblMessage.Visible = false;

            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT TOP 1 * FROM Transactions WHERE AccountNumber = @acc ORDER BY DateTime DESC", con);
                cmd.Parameters.AddWithValue("@acc", AccountNumber);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string type = dr["TransactionType"].ToString();
                    string amount = dr["Amount"].ToString();
                    string bal = dr["BalanceAfter"].ToString();
                    string datetime = Convert.ToDateTime(dr["DateTime"]).ToString("g");

                    lblReceipt.Text =
$@"---------------------------------------
        ATM TRANSACTION RECEIPT
---------------------------------------
Account Number : {AccountNumber}
Transaction    : {type}
Amount         : ৳ {amount}
Balance        : ৳ {bal}
Date/Time      : {datetime}
Machine        : {Environment.MachineName}
---------------------------------------
  Thank you for using RUPAM ATM!
---------------------------------------";
                }
                else
                {
                    ShowError("No transaction found.");
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                ShowError("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ShowError(string msg)
        {
            lblMessage.Text = msg;
            lblMessage.ForeColor = System.Drawing.Color.Red;
            lblMessage.Visible = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Receipt sent to printer (simulation).");
        }

        private void lblReceipt_Click(object sender, EventArgs e)
        {

        }
    }
}