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
    public partial class DepositControl : UserControl
    {
        public string AccountNumber { get; set; }

        string conStr = @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True;TrustServerCertificate=True;";

        public DepositControl()
        {
            InitializeComponent();
            this.Load += DepositControl_Load;
        }

        private void DepositControl_Load(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = false;

            if (txtAmount.Text == "")
            {
                MessageBox.Show("Please enter an amount.");
                return;
            }

            decimal amount;
            if (!decimal.TryParse(txtAmount.Text.Trim(), out amount) || amount <= 0)
            {
                MessageBox.Show("Enter a valid positive amount.");
                return;
            }

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

                decimal newBalance = currentBalance + amount;

                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"INSERT INTO Transactions (AccountNumber, TransactionType, Amount, BalanceAfter, DateTime) " +
                                  $"VALUES ('{AccountNumber}', 'Deposit', {amount}, {newBalance}, '{DateTime.Now}')";

              

                cmd.ExecuteNonQuery();

                MessageBox.Show("Deposit successful.");

                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = $"Deposited ৳{amount} successfully.\nNew Balance: ৳{newBalance}";
                lblMessage.Visible = true;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}