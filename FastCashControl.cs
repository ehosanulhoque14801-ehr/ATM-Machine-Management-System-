using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ATMProject
{
    public partial class FastCashControl : UserControl
    {
        public string AccountNumber { get; set; }

        string conStr = @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True;TrustServerCertificate=True;";

        public FastCashControl()
        {
            InitializeComponent();
            this.Load += FastCashControl_Load;
        }

        private void FastCashControl_Load(object sender, EventArgs e)
        {
            
            btn500.Click += FastCash_Click;
            btn1000.Click += FastCash_Click;
            btn2000.Click += FastCash_Click;
            btn5000.Click += FastCash_Click;
        }

        private void FastCash_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            if (clicked == null)
            {
                MessageBox.Show("Invalid button.");
                return;
            }

            decimal amount = 0;
            if (!decimal.TryParse(clicked.Text.Replace("৳", ""), out amount))
            {
                MessageBox.Show("Invalid amount.");
                return;
            }

            WithdrawFastCash(amount);
        }

        private void WithdrawFastCash(decimal amount)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conStr;
                con.Open();

                SqlCommand balCmd = new SqlCommand();
                balCmd.Connection = con;
                balCmd.CommandText = $"SELECT TOP 1 BalanceAfter FROM Transactions WHERE AccountNumber = '{AccountNumber}' ORDER BY DateTime DESC";

               

                object result = balCmd.ExecuteScalar();
                decimal currentBalance = 0;

                if (result != null && result != DBNull.Value)
                {
                    currentBalance = Convert.ToDecimal(result);
                }

                if (amount > currentBalance)
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "Insufficient funds.";
                    lblMessage.Visible = true;
                    con.Close();
                    return;
                }

                decimal newBalance = currentBalance - amount;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"INSERT INTO Transactions (AccountNumber, TransactionType, Amount, BalanceAfter, DateTime) " +
                                  $"VALUES ('{AccountNumber}', 'FastCash', {amount}, {newBalance}, '{DateTime.Now}')";

               

                cmd.ExecuteNonQuery();

                MessageBox.Show("Withdrawn successfully");

                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = $"Withdrawn ৳{amount} successfully.\nNew Balance: ৳{newBalance}";
                lblMessage.Visible = true;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn500_Click(object sender, EventArgs e)
        {

        }
    }
}
