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
    public partial class print : Form
    {
        int price;
        int quantity;
        int Total;
        public print()
        {
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            price = int.Parse( TxtPrice.Text);
            quantity = int.Parse(TxtQuantity.Text);
            

            e.Graphics.DrawString("Welcome", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(200, 10));
            e.Graphics.DrawString("Product :", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 60));
            e.Graphics.DrawString(TxtProduct.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(200, 60));
            e.Graphics.DrawString("Price :", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 120));
            e.Graphics.DrawString(TxtPrice.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(200, 120));
            e.Graphics.DrawString("Quantity :", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 180));
            e.Graphics.DrawString(TxtQuantity.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(200, 180));
            e.Graphics.DrawString("Total :", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 240));
            Total = price * quantity;
            e.Graphics.DrawString(Total.ToString(), new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(200, 240));
        }

        private void print_Load(object sender, EventArgs e)
        {

        }
    }
}
