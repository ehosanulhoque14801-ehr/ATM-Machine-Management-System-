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
    public partial class DashboardForm : Form
    {



        public string LoggedInAccountNumber { get; set; }
        public string AccountNumber { get; set; }
       

        public DashboardForm()
        {
            InitializeComponent();
        }


        private void panelContent_Click(object sender, PaintEventArgs e)
        {

        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            UserProfileControl profile = new UserProfileControl();
            LoadContent(profile); 
        }








        private void LoadContent(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }








        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + LoggedInAccountNumber;
            LoadWelcomeMessage();
        }
        private void LoadWelcomeMessage()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True;TrustServerCertificate=True;");
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT FullName FROM Users WHERE AccountNumber = @acc", con);
                cmd.Parameters.AddWithValue("@acc", LoggedInAccountNumber);

                object result = cmd.ExecuteScalar(); 

                if (result != null)
                {
                    string fullName = result.ToString();
                    lblWelcome.Text = $"Welcome, {fullName} (Acc#: {LoggedInAccountNumber})";
                }
                else
                {
                    lblWelcome.Text = $"Welcome, Unknown (Acc#: {LoggedInAccountNumber})";
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load user name: " + ex.Message);
            }
        }








        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditProfileControl edit = new EditProfileControl();
            edit.AccountNumber = LoggedInAccountNumber;
            LoadContent(edit); 
        }

        private void btnUserProfile_Click_1(object sender, EventArgs e)
        {
            UserProfileControl profile = new UserProfileControl();
            profile.AccountNumber = LoggedInAccountNumber;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(profile);

        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            TransactionsControl trans = new TransactionsControl();
            trans.AccountNumber = LoggedInAccountNumber;
            LoadContent(trans); 
        }

        private void btnLoginHistory_Click(object sender, EventArgs e)
        {
            LoginHistoryControl history = new LoginHistoryControl();
            history.AccountNumber = LoggedInAccountNumber;
            LoadContent(history);
        }

        private void btnATM_Click(object sender, EventArgs e)
        {
            ATMForm form = new ATMForm();
            form.LoggedInAccountNumber= LoggedInAccountNumber;
            form.Show();
            this.Hide();
            
        }

        private void btnRequestLoan_Click(object sender, EventArgs e)
        {
            RequestLoanControl loanControl = new RequestLoanControl();
            loanControl.AccountNumber = this.LoggedInAccountNumber;  
            panelContent.Controls.Clear();
            loanControl.Dock = DockStyle.Fill;
            panelContent.Controls.Add(loanControl);
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            LoanNotificationControl notify = new LoanNotificationControl();
            notify.AccountNumber = LoggedInAccountNumber;
            panelContent.Controls.Clear();
            notify.Dock = DockStyle.Fill;
            panelContent.Controls.Add(notify);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
