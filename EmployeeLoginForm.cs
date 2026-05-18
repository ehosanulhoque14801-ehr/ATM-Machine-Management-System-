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
    public partial class EmployeeLoginForm : Form
    {
        public EmployeeLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string accountNo = txtAccountNo.Text.Trim();
            string pin = txtPin.Text.Trim();

            string connectionString =
       @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users WHERE AccountNumber=@acc AND PIN=@pin AND Role='Employee'";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@acc", accountNo);
                cmd.Parameters.AddWithValue("@pin", pin);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    EmployeeDashboardForm emp = new EmployeeDashboardForm();
                    emp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid employee credentials.");
                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
        }
    }
}
