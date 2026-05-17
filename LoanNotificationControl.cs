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
    public partial class LoanNotificationControl : UserControl
    {
        public string AccountNumber { get; set; }

        string conStr = @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True;";

        public LoanNotificationControl()
        {
            InitializeComponent();
            this.Load += LoanNotificationControl_Load;
        }

        private void LoanNotificationControl_Load(object sender, EventArgs e)
        {
            LoadLoanStatus();
        }

        private void LoadLoanStatus()
        {
            if (string.IsNullOrEmpty(AccountNumber))
            {
                MessageBox.Show("Account number not set.");
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conStr;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT RequestedAmount AS [Amount], Status, RequestDate AS [Requested On] FROM LoanRequests WHERE AccountNumber = '{AccountNumber}'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DataTable dt = ds.Tables[0];
                dataGridViewLoanStatus.DataSource = dt;
                dataGridViewLoanStatus.Refresh();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading loan status: " + ex.Message);
            }
        }
    }
}

