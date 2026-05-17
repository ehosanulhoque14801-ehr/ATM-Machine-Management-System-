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
    public partial class LogoutControl : UserControl
    {

        public string AccountNumber { get; set; }

        public LogoutControl()
        {
            InitializeComponent();
        }
    }
}
