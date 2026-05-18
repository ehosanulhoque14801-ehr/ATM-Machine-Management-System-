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
    public partial class ViewCustomersForm : Form
    {
        public ViewCustomersForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearchCustomer.Text.Trim();

            if (searchValue == "")
            {
                MessageBox.Show("Please enter customer name or account number.");
                return;
            }
            string connectionString =
                    @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT Id, FullName, AccountNumber, Balance 
                         FROM Users 
                         WHERE FullName LIKE @search 
                         OR AccountNumber LIKE @search";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + searchValue + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCustomers.DataSource = dt;
            }

        }

        private void btnVerifyAccount_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.Rows.Count > 0)
            {
                MessageBox.Show("Account verified successfully.");
            }
            else
            {
                MessageBox.Show("Please search and select a customer first.");
            }

        }
    }
}
