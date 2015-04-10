using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrcTester
{
    public partial class SimpleCrcGenerator : Form
    {
        public SimpleCrcGenerator()
        {
            InitializeComponent();
            lblElapsedTime.Text = "";
        }

        private void btnComputeCrc_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            txtOutput.Text = Arinc702Crc.AppendCrcToMessage(txtInput.Text);
            sw.Stop();
            lblElapsedTime.Text = "Elapsed time: " + sw.Elapsed.ToString();
        }
    }
}
