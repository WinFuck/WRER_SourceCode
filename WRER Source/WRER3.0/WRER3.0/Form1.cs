using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WRER3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void windowsRegistryEntriesReseterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wersja tego programu to: 3.0", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void językProgramowaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Język programowania: C#", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            reg.SetValue("EnableLUA", "1", RegistryValueKind.String);
            MessageBox.Show(@"Zresetowano ustawienie: EnableLUA - lokalizacja w rejestrze: HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System\EnableLUA", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error: Wykryto błąd przez który to ustawienie nie moze byc zresetowane.", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            button2.Text = "ERROR 404";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            rk.SetValue("DisableRegistryTools", "", RegistryValueKind.String);
            MessageBox.Show(@"Ustawienie pomyślnie zresetowane: DisableRegistryTools - Lokalizacja w rejestrze windows: HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableRegistryTools", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegistryKey wrer = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
            wrer.SetValue("DisableCMD", "", RegistryValueKind.String);
            MessageBox.Show(@"Ustawienie pomyślnie zresetowane: DisableRegistryTools - Lokalizacja w rejestrze windows: HKCU\Software\Policies\Microsoft\Windows\System\DisableCMD", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegistryKey mk = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Policies\\Winlogon");
            mk.SetValue("Shell", "explorer.exe", RegistryValueKind.String);
            MessageBox.Show(@"Ustawienie pomyślnie zresetowane: Shell - Lokalizacja w rejestrze windows: HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Policies\Winlogon", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistryKey mk1 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Policies\\Winlogon");
            mk1.SetValue("Userinit", @"C:\Windows\system32\userinit.exe,", RegistryValueKind.String);
            MessageBox.Show(@"Ustawienie pomyślnie zresetowane: Userinit - Lokalizacja w rejestrze windows: HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Policies\Winlogon", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pliki do zresetowania ikon aplikacji .exe i .txt znajdziesz w folderze tam gdzie jest zainstalowany WRER! (Windows Registry Entries Reseter)" , "Windows Registry Reseter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RegistryKey regrest = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Policies\\Winlogon");
            regrest.SetValue("DisableCAD", "1", RegistryValueKind.String);
            RegistryKey regrest1 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Policies\\Winlogon");
            regrest1.SetValue("AutoAdminLogon", "1", RegistryValueKind.String);
            RegistryKey regrest2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Policies\\Winlogon");
            regrest2.SetValue("AutoAdminLogon", "1", RegistryValueKind.String);
            RegistryKey regrest3 = Registry.CurrentUser.CreateSubKey("Control Panel\\Mouse");
            regrest3.SetValue("SwapMouseButtons", "0", RegistryValueKind.String);
            MessageBox.Show(@"Krytyczne ustawienia zostaly usunięte i dodane na nowo. Jesli zresetowales wszystkie ustawienia musisz zrestartować komputer. Jesli chcesz zrestartowac komputer teraz, przejdz do menu glownego i bedzie przycisk: PC REBOOT - Lewy dolny róg", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            var NewForm = new PCReboot();
            NewForm.ShowDialog();
        }
    }
}
