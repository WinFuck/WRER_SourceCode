using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace WRER3._0
{
    public partial class PCReboot : Form
    {
        public PCReboot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "1")
            {
                MessageBox.Show("Polecenie zostało zrozumiane pomyślnie.", "PC Reboot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start("shutdown", "/r /t 60");
            }
            else if(textBox1.Text == "2")
            {
                MessageBox.Show("Polecenie zostało zrozumiane pomyślnie." , "PC Reboot", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
