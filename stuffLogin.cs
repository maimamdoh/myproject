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
    public partial class stuffLogin : Form
    {
        public stuffLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text=="one" && TxtPassword.Text == "1")
            {
                Form4 open = new Form4();
                open.Show();
            }
        }

        private void stuffLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
