using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ATMProject
{
    public partial class BalanceControl : UserControl
    {
        public string AccountNumber { get; set; }

        string conStr = @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True;TrustServerCertificate=True;";

        public BalanceControl()
        {
            InitializeComponent();
            this.Load += BalanceControl_Load;
            dataGridViewBalance.CellFormatting += dataGridViewBalance_CellFormatting;
        }

        private void BalanceControl_Load(object sender, EventArgs e)
        {
            LoadBalance();
        }

        public void LoadBalance()
        {
            lblMessage.Visible = false;
            dataGridViewBalance.DataSource = null;

            if (string.IsNullOrEmpty(AccountNumber))
            {
                lblMessage.Text = "Account number not set.";
                lblMessage.ForeColor = Color.Red;
                lblMessage.Visible = true;
                return;
            }

            using (SqlConnection con = new SqlConnection(conStr))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT TOP 1 BalanceAfter AS [Available Balance] FROM Transactions WHERE AccountNumber = @acc ORDER BY DateTime DESC", con);
                    cmd.Parameters.AddWithValue("@acc", AccountNumber);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridViewBalance.DataSource = dt;

                        foreach (DataGridViewColumn col in dataGridViewBalance.Columns)
                        {
                            col.SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                    }
                    else
                    {
                        lblMessage.Text = "No transaction found.";
                        lblMessage.ForeColor = Color.Red;
                        lblMessage.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Error: " + ex.Message;
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Visible = true;
                }
            }
        }

        private void dataGridViewBalance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewBalance.Columns[e.ColumnIndex].Name == "Available Balance" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal val))
                {
                    e.Value = "৳ " + val.ToString("N2"); 
                    e.FormattingApplied = true;
                }
            }
        }

        private void dataGridViewBalance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}