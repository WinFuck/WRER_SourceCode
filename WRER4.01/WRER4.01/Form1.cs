using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;

namespace WRER4._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var NewForm = new Premium();
            NewForm.ShowDialog();
        }

        private void informacjeOProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To jest juz czwarta wersja programu Windows Registry Entries Reseter !", "WRER v4.01", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void informacjeOWersjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wersja: 4.01", "WRER v4.01", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            reg.SetValue("EnableLUA", "1", RegistryValueKind.String);

            MessageBox.Show("Ustawienia zostaly zresetowane.", "WRER v4.01", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistryKey mk = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
            mk.SetValue("Shell", "explorer", RegistryValueKind.String);
            MessageBox.Show("Ustawienia zostaly zresetowane.", "WRER v4.01", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegistryKey mk = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Policies\\Winlogon");
            mk.SetValue("WallPaper", "C:\\Windows\\Web\\Wallpaper\\Windows\\img0.jpg", RegistryValueKind.String);
            MessageBox.Show("Ustawienia zostaly zresetowane.", "WRER v4.01", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DaVinci, ogólnie dziękuje za testowanie mojego WRERa wersję 4.01! Pozdrawia Windows_Locker :) - (A i pozdrawiam rederka jeśli to oglada za pseudonim Zpizgany 'Pizduś' Jerry XD - A i pozdrawiam widzow :)", "WRER v4.01", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistryKey mk1 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Policies\\Winlogon");
            mk1.SetValue("Userinit", "C:\\Windows\\system32\\userinit.exe,", RegistryValueKind.String);
            MessageBox.Show("Ustawienia zostaly zresetowane.", "WRER v4.01", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RegistryKey regrest3 = Registry.CurrentUser.CreateSubKey("Control Panel\\Mouse");
            regrest3.SetValue("SwapMouseButtons", "0", RegistryValueKind.String);
            MessageBox.Show("Ustawienia zostaly zresetowane.", "WRER v4.01", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RegistryKey regrest = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Policies\\Winlogon");
            regrest.SetValue("DisableCAD", "1", RegistryValueKind.String);
            MessageBox.Show("Ustawienia zostaly zresetowane.", "WRER v4.01", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RegistryKey regrest1 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Policies\\Winlogon");
            regrest1.SetValue("AutoAdminLogon", "1", RegistryValueKind.String);
            MessageBox.Show("Ustawienia zostaly zresetowane.", "WRER v4.01", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RegistryKey wrer = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
            wrer.SetValue("DisableCMD", "", RegistryValueKind.String);
            MessageBox.Show("Ustawienia zostaly zresetowane.", "WRER v4.01", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            rk.SetValue("DisableRegistryTools", "", RegistryValueKind.String);
            MessageBox.Show("Ustawienia zostaly zresetowane.", "WRER v4.01", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
