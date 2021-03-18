using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PHARMACY
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource =localhost;port =3306;convert zero datetime=True;username=root;password=");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT *FROM smart_pharmacy.orders", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "orders");
                dataGridView1.DataSource = ds.Tables["orders"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
