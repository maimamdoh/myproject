using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHARMACY
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if ((TxtUsername.Text == "one" && TxtPassword.Text == "1" && ChkbAdmin.Checked && ChkbEmployee.Checked == false)
                || (TxtUsername.Text == "two" && TxtPassword.Text == "2" && ChkbEmployee.Checked && ChkbAdmin.Checked == false))
            {
                TxtUsername.Clear();
                TxtPassword.Clear();
                Main Dashboard = new Main();
                Dashboard.Show();
                
            }

            else if ((TxtUsername.Text != "one" && TxtPassword.Text != "1") || (TxtUsername.Text != "two" && TxtPassword.Text != "2"))
            {
                MessageBox.Show("please enter right username and password", "PHARMACY");
                TxtUsername.Clear();
                TxtPassword.Clear();
                TxtUsername.Focus();
            }
        }
    }
}
