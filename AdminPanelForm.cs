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
    public partial class AdminPanelForm : Form
    {
        string conStr = @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True;TrustServerCertificate=True;";

        public AdminPanelForm()
        {
            InitializeComponent();
            dataGridUsers.DataError += (s, ev) => { ev.ThrowException = false; };
            dataGridLoans.DataError += (s, ev) => { ev.ThrowException = false; };
            LoadUsers();
            LoadLoanRequests();

            dataGridUsers.SelectionChanged += dataGridUsers_SelectionChanged;
        }

        private void LoadUsers()
        {
            SqlConnection con = new SqlConnection(conStr);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, FullName, Email, Phone, AccountNumber, IsAdmin FROM Users", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridUsers.DataSource = dt;
        }

        private void LoadLoanRequests()
        {
            SqlConnection con = new SqlConnection(conStr);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LoanRequests", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridLoans.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) { }

        private void AdminPanelForm_Load(object sender, EventArgs e) { }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string acc = txtSearch.Text.Trim();
            if (acc == "")
            {
                MessageBox.Show("Enter account number to search.");
                return;
            }

            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Users WHERE AccountNumber = '{acc}'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridUsers.DataSource = dt;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a user to delete.");
                return;
            }

            string accNum = dataGridUsers.SelectedRows[0].Cells["AccountNumber"].Value.ToString();

            DialogResult confirm = MessageBox.Show($"Are you sure to delete user {accNum}?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand($"DELETE FROM Users WHERE AccountNumber = '{accNum}'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("User deleted successfully.");
            LoadUsers();
        }

        private void btnRefreshUsers_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnApproveLoan_Click(object sender, EventArgs e)
        {
            if (dataGridLoans.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a loan request.");
                return;
            }

            int id = Convert.ToInt32(dataGridLoans.SelectedRows[0].Cells["Id"].Value);
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand($"UPDATE LoanRequests SET Status = 'Accepted' WHERE Id = {id}", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Loan request approved.");
            LoadLoanRequests();
        }

        private void btnRejectLoan_Click(object sender, EventArgs e)
        {
            if (dataGridLoans.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a loan request.");
                return;
            }

            int id = Convert.ToInt32(dataGridLoans.SelectedRows[0].Cells["Id"].Value);
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand($"UPDATE LoanRequests SET Status = 'Rejected' WHERE Id = {id}", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Loan request rejected.");
            LoadLoanRequests();
        }

        private void btnRefreshLoans_Click(object sender, EventArgs e)
        {
            LoadLoanRequests();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        
        private void dataGridUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridUsers.SelectedRows.Count > 0)
            {
                var row = dataGridUsers.SelectedRows[0];
                txtFullNameEdit.Text = row.Cells["FullName"].Value.ToString();
                txtEmailEdit.Text = row.Cells["Email"].Value.ToString();
                txtPhoneEdit.Text = row.Cells["Phone"].Value.ToString();
                txtIsAdminEdit.Text = row.Cells["IsAdmin"].Value.ToString();
            }
        }



        private void btnUpdateUser_Click_1(object sender, EventArgs e)
        {
            if (dataGridUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a user to update.");
                return;
            }

            string accNum = dataGridUsers.SelectedRows[0].Cells["AccountNumber"].Value.ToString();
            string newName = txtFullNameEdit.Text.Trim();
            string newEmail = txtEmailEdit.Text.Trim();
            string newPhone = txtPhoneEdit.Text.Trim();
            bool isAdmin = txtIsAdminEdit.Text.Trim().ToLower() == "true";

            if (newName == "" || newEmail == "" || newPhone == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(@"UPDATE Users 
                                               SET FullName = @name, Email = @email, Phone = @phone, IsAdmin = @isAdmin 
                                               WHERE AccountNumber = @accNum", con);

            cmd.Parameters.AddWithValue("@name", newName);
            cmd.Parameters.AddWithValue("@email", newEmail);
            cmd.Parameters.AddWithValue("@phone", newPhone);
            cmd.Parameters.AddWithValue("@isAdmin", isAdmin);
            cmd.Parameters.AddWithValue("@accNum", accNum);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("User info updated successfully.");
            LoadUsers();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLoginForm loginForm = new AdminLoginForm();
            loginForm.Show();
        }

        private void btnLogout1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
