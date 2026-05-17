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
    public partial class LoginForm : Form
    {
        string conStr = @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True;TrustServerCertificate=True;";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string accNumber = txtAccountNumber.Text.Trim();
            string pin = txtPIN.Text.Trim();

            if (accNumber == "" || pin == "")
            {
                MessageBox.Show("Please enter Account Number and PIN.");
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True;TrustServerCertificate=True;";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT * FROM Users WHERE AccountNumber = '{accNumber}' AND PIN = '{pin}'";

              

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    int userId = Convert.ToInt32(dr["ID"]);
                    bool isAdmin = Convert.ToBoolean(dr["IsAdmin"]);
                    dr.Close();


                    string machineName = Environment.MachineName;
                    string loginTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    SqlCommand loginCmd = new SqlCommand();
                    loginCmd.Connection = con;
                    loginCmd.CommandText = $"INSERT INTO LoginHistory (AccountNumber, LoginTime, MachineName) " +
                                           $"VALUES ('{accNumber}', '{loginTime}', '{machineName}')";



                    loginCmd.ExecuteNonQuery();

                    MessageBox.Show("Login successful.");

                    DashboardForm dash = new DashboardForm();
                    dash.LoggedInAccountNumber = accNumber;
                    dash.Show();
                    this.Hide();

                    if (isAdmin)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Invalid Account Number or PIN.");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            AdminLoginForm adminLogin = new AdminLoginForm();
            adminLogin.Show();
            this.Hide();
        }
    }
}
