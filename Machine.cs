using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
namespace PHARMACY
{
    public partial class Machine : Form
    {
        public Machine()
        {
            InitializeComponent();
        }
        SerialPort port;
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            port = new SerialPort(TxtPort.Text, int.Parse(TxtRate.Text), Parity.None, 8, StopBits.One);
            port.Open();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            port.Write(TxtMessage.Text);
        }

        private void Machine_Load(object sender, EventArgs e)
        {

        }
    }
}
