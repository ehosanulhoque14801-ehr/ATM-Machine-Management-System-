using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ATMProject
{
    public partial class UserProfileControl : UserControl
    {

        public string AccountNumber { get; set; }
        public UserProfileControl()
        {
            InitializeComponent();
            this.Load += UserProfileControl_Load;

        }

        private void UserProfileControl_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }
        private void LoadUserData()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT FullName, Email, Phone, DOB, AccountNumber FROM Users WHERE AccountNumber = '{AccountNumber}'";

                

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                dgvUserInfo.DataSource = dt;
                dgvUserInfo.Refresh();

                dgvUserInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvUserInfo.AutoResizeColumns();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void dgvUserInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}