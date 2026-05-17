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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        string conStr = @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True;TrustServerCertificate=True;";

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string accNumber = txtAccountNumber.Text.Trim();
            string pin = txtPin.Text.Trim();
            DateTime dob = dtpDOB.Value;

            if (fullName == "" || email == "" || phone == "" || accNumber == "" || pin == "")
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (pin.Length != 4 || !int.TryParse(pin, out _))
            {
                MessageBox.Show("PIN must be a 4-digit number.");
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True;TrustServerCertificate=True;";
                con.Open();



                SqlCommand checkAccCmd = new SqlCommand();
                checkAccCmd.Connection = con;
                checkAccCmd.CommandText = $"SELECT COUNT(*) FROM Users WHERE AccountNumber = '{accNumber}'";

                int accCount = (int)checkAccCmd.ExecuteScalar();
                if (accCount > 0)
                {
                    MessageBox.Show("Account Number already exists.");
                    con.Close();
                    return;
                }

               

                SqlCommand checkPhoneCmd = new SqlCommand();
                checkPhoneCmd.Connection = con;
                checkPhoneCmd.CommandText = $"SELECT COUNT(*) FROM Users WHERE Phone = '{phone}'";

                int phoneCount = (int)checkPhoneCmd.ExecuteScalar();
                if (phoneCount > 0)
                {
                    MessageBox.Show("Phone number already registered. Use a different phone number.");
                    con.Close();
                    return;
                }

               
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"INSERT INTO Users (FullName, Email, Phone, DOB, AccountNumber, PIN) " +
                                  $"VALUES ('{fullName}', '{email}', '{phone}', '{dob.ToString("yyyy-MM-dd")}', '{accNumber}', '{pin}')";

               // MessageBox.Show(cmd.CommandText); //no need now,if faculty asks then

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registered Successfully");

                con.Close();

                new LoginForm().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration failed: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }
    }
}
