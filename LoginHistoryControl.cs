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
    public partial class LoginHistoryControl : UserControl
    {
        public string AccountNumber { get; set; }

        public LoginHistoryControl()
        {
            InitializeComponent();
        }

        private void LoginHistoryControl_Load(object sender, EventArgs e)
        {
            LoadLoginHistory();
        }

        private void LoadLoginHistory()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True;";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT LoginTime, LogoutTime, MachineName FROM LoginHistory WHERE AccountNumber = '{AccountNumber}' ORDER BY LoginTime DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                dgvLoginHistory.DataSource = dt;
                dgvLoginHistory.Refresh();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading login history: " + ex.Message);
            }
        }

        private void dgvLoginHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}