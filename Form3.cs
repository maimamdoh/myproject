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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource =localhost;port =3306;convert zero datetime=True;username=root;password=");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT *FROM smartpharmacy.products", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "products");
                dataGridView1.DataSource = ds.Tables["products"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
