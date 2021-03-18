using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PHARMACY
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {

            Form3 Products = new Form3();
            Products.Show();
        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            DialogResult iWarn;
            iWarn = MessageBox.Show("Are you an Admin", "PHARMACY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iWarn == DialogResult.Yes)
            {
                stuffLogin st = new stuffLogin();
                st.Show();
            }
        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            print SaleProduct = new print();
            SaleProduct.Show();
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            Form6 OnlineRequest = new Form6();
            OnlineRequest.Show();
        }

        private void BtnMailbox_Click(object sender, EventArgs e)
        {
            Form7 MailBox = new Form7();
            MailBox.Show();
        }

        private void BtnSupplier_Click_1(object sender, EventArgs e)
        {
            Form8 Suppliers = new Form8();
            Suppliers.Show();
        }

        private void BtnMachine_Click(object sender, EventArgs e)
        {
            Machine get = new Machine();
            get.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            BtnProducts.Enabled = true;
            BtnStaff.Enabled = true;
            BtnPurchase.Enabled = true;
            BtnOrders.Enabled = true;
            BtnMailbox.Enabled = true;
            BtnSupplier.Enabled = true;
            BtnMachine.Enabled = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "PHARMACY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
