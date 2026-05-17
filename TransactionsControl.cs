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
    public partial class TransactionsControl : UserControl
    {
        public string AccountNumber { get; set; }

        public TransactionsControl()
        {
            InitializeComponent();
            this.Load += TransactionsControl_Load;
        }

        private void TransactionsControl_Load(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True;TrustServerCertificate=True;";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT TransactionType, Amount, DateTime FROM Transactions WHERE AccountNumber = '{AccountNumber}' ORDER BY DateTime DESC";

               

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                dgvTransactions.DataSource = dt;
                dgvTransactions.Refresh();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load transactions: " + ex.Message);
            }
        }
    }
}