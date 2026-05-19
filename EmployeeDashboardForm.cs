using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMProject
{
    public partial class EmployeeDashboardForm : Form
    {
        public EmployeeDashboardForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            EmployeeLoginForm emp = new EmployeeLoginForm();
            emp.Show();
            this.Hide();
        }
        

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            ViewCustomersForm frm = new ViewCustomersForm();
            frm.Show();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            ViewCustomersForm frm = new ViewCustomersForm();
            frm.Show();
        }

        private void btnVerifyAccount_Click(object sender, EventArgs e)
        {
            ViewCustomersForm frm = new ViewCustomersForm();
            frm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomerSupport_Click(object sender, EventArgs e)
        {
            CustomerSupportForm frm = new CustomerSupportForm();
            frm.Show();
        }

        private void btnViewLoginHistory_Click(object sender, EventArgs e)
        {
            EmployeeTransactionsForm frm = new EmployeeTransactionsForm();
            frm.Show();
        }

        private void btnViewTransactions_Click(object sender, EventArgs e)
        {
            EmployeeViewTransactionsForm frm = new EmployeeViewTransactionsForm();
            frm.Show();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            EmployeeProfileForm frm = new EmployeeProfileForm();
            frm.Show();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            EmployeeProfileForm frm = new EmployeeProfileForm();
            frm.Show();
        }
    }
}
