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
    public partial class EmployeeProfileForm : Form
    {
        public EmployeeProfileForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            string connectionString =
        @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Users
                         SET FullName=@name,
                             Email=@email,
                             Phone=@phone
                         WHERE AccountNumber=@acc";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", txtFullName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@acc", txtAccountNumber.Text);

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Profile updated successfully.");
            }

        }
    }
}
