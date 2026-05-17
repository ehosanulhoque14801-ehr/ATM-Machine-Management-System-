using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMProject
{
    public partial class ATMForm : Form
    {

       

        public string LoggedInAccountNumber { get; set; }
       



        public ATMForm()
        {
            InitializeComponent();
        }

        private void ATMForm_Load(object sender, EventArgs e)
        {
           
            lblWelcome.Text = $"Welcome, Account#: {LoggedInAccountNumber}";



            ATMPinEntryControl pinControl = new ATMPinEntryControl();
           
            LoadATMControl(pinControl);
        }
        private void LoadATMControl(UserControl uc)
        {
            panelCenter.Controls.Clear();   
            uc.Dock = DockStyle.Fill;       
            panelCenter.Controls.Add(uc);   
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawControl withdraw = new WithdrawControl();
            withdraw.AccountNumber = LoggedInAccountNumber;
            LoadATMControl(withdraw);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
           DepositControl deposit = new DepositControl();
            deposit.AccountNumber = LoggedInAccountNumber;
            LoadATMControl(deposit);
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            BalanceControl balance = new BalanceControl();
            balance.AccountNumber = LoggedInAccountNumber;
            LoadATMControl(balance);

            
            balance.LoadBalance();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            ReceiptControl rc = new ReceiptControl();
            rc.AccountNumber = LoggedInAccountNumber;
            LoadATMControl(rc);
        }

        private void btnMiniStmt_Click(object sender, EventArgs e)
        {
            MiniStatementControl ms = new MiniStatementControl();
            ms.AccountNumber = LoggedInAccountNumber;
            LoadATMControl(ms);
        }

        private void btnChangePin_Click(object sender, EventArgs e)
        {
            ChangePinControl cp = new ChangePinControl();
            cp.AccountNumber = LoggedInAccountNumber;
            LoadATMControl(cp);
        }

        private void btnFastCash_Click(object sender, EventArgs e)
        {

            FastCashControl fc = new FastCashControl();
            fc.AccountNumber = LoggedInAccountNumber;
            LoadATMControl(fc);
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            LanguageOptionsControl languageOptions = new LanguageOptionsControl();
            languageOptions.AccountNumber = LoggedInAccountNumber;
            LoadATMControl(languageOptions);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogLogout();

            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void LogLogout()
        {
            try
            {
                string conStr = @"Data Source=localhost\SQLEXPRESS01;Initial Catalog=ATMSystem;Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO LoginHistory (AccountNumber, LogoutTime) VALUES (@acc, 'LogoutTime')", con);
                    cmd.Parameters.AddWithValue("@acc", LoggedInAccountNumber);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception )
            {
                
            }
        }


        private void btnQuit_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to quit the ATM?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void panelCenter_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dash = new DashboardForm();
            dash.LoggedInAccountNumber = this.LoggedInAccountNumber; 
            dash.Show();
        }
    }
}
