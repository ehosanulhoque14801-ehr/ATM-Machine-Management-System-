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
    public partial class MiniStatementControl : UserControl
    {
        public string AccountNumber { get; set; }

        string conStr = @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True;TrustServerCertificate=True;";

        public MiniStatementControl()
        {
            InitializeComponent();
        }

        private void MiniStatementControl_Load(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
            LoadMiniStatement();
        }

        private void LoadMiniStatement()
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(
                    @"SELECT TOP 10 
                        TransactionType AS [Type], 
                        Amount, 
                        BalanceAfter AS [Balance], 
                        DateTime AS [Date/Time] 
                      FROM Transactions 
                      WHERE AccountNumber = @acc 
                      ORDER BY DateTime DESC", con);

                cmd.Parameters.AddWithValue("@acc", AccountNumber);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgvStatement.DataSource = dt;
                }
                else
                {
                    dgvStatement.DataSource = null;
                    ShowError("No transactions found.");
                }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}