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
    public partial class EmployeeViewTransactionsForm : Form
    {
        public EmployeeViewTransactionsForm()
        {
            InitializeComponent();
            LoadTransactions();
        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadTransactions()
        {
            string connectionString =
                @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Transactions";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvTransactions.DataSource = dt;
            }
        }

        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(
           dgvTransactions.SelectedRows[0].Cells["Id"].Value);

                string connectionString =
                    @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Transactions WHERE Id=@id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Transaction deleted successfully.");

                LoadTransactions();
            }
            else
            {
                MessageBox.Show("Please select a transaction.");
            }
        }
    }   
}
