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
    public partial class RequestLoanControl : UserControl
    {

        public string AccountNumber { get; set; }

        string conStr = @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True;TrustServerCertificate=True;";
        public RequestLoanControl()
        {
            InitializeComponent();
            lblMessage.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = false;

         
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                ShowMessage("Please enter a loan amount.", Color.Red);
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                ShowMessage("Enter a valid positive number.", Color.Red);
                return;
            }

            if (string.IsNullOrEmpty(AccountNumber))
            {
                ShowMessage("Account number not set. Please login again.", Color.Red);
                return;
            }

            
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    string query = @"INSERT INTO LoanRequests (AccountNumber, RequestedAmount, Status,RequestDate)
                                     VALUES (@acc, @amt, 'Pending', @dt)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@acc", AccountNumber);
                        cmd.Parameters.AddWithValue("@amt", amount);
                        cmd.Parameters.AddWithValue("@dt", DateTime.Now);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            ShowMessage($"Loan request for ৳{amount} submitted successfully.", Color.Green);
                            txtAmount.Clear();
                        }
                        else
                        {
                            ShowMessage("Failed to submit loan request. Please try again.", Color.Red);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage("Error: " + ex.Message, Color.Red);
            }
        }

        private void ShowMessage(string message, Color color)
        {
            lblMessage.Text = message;
            lblMessage.ForeColor = color;
            lblMessage.Visible = true;
        }

        private void RequestLoanControl_Load(object sender, EventArgs e)
        {

        }
    }
}
