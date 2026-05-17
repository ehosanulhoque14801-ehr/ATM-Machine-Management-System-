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
    public partial class EditProfileControl : UserControl
    {

        public string AccountNumber { get; set; } 

        string conStr = @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True;TrustServerCertificate=True;";



        public EditProfileControl()
        {
            InitializeComponent();
            this.Load += EditProfileControl_Load;
        }

        private void EditProfileControl_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }
        private void LoadUserInfo()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conStr;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT * FROM Users WHERE AccountNumber = '{AccountNumber}'";

              

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtFullName.Text = reader["FullName"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtPhone.Text = reader["Phone"].ToString();
                    txtPIN.Text = reader["PIN"].ToString();
                    dtpDOB.Value = Convert.ToDateTime(reader["DOB"]);
                    txtAccountNo.Text = reader["AccountNumber"].ToString();
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            
            if (txtFullName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || txtPIN.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string pin = txtPIN.Text.Trim();
            string dob = dtpDOB.Value.ToString("yyyy-MM-dd");
            string accNumber = txtAccountNo.Text.Trim();

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conStr;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"UPDATE Users SET " +
                                  $"FullName = '{fullName}', " +
                                  $"Email = '{email}', " +
                                  $"Phone = '{phone}', " +
                                  $"DOB = '{dob}', " +
                                  $"PIN = '{pin}' " +
                                  $"WHERE AccountNumber = '{accNumber}'";

               

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Profile updated successfully.");
                    LoadUserInfo(); 
                }
                else
                {
                    MessageBox.Show("No matching account found to update.");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message);
            }
        }
    }
}