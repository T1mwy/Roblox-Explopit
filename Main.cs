using FastColoredTextBoxNS;
using Loader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using WeAreDevs_API;
using static Loader.Settings;

namespace KeyAuth
{
    public partial class Main : Form
    {
        private Point lastPoint;
        private readonly List<string> listScripts = new List<string>();
        ExploitAPI Exapi = new ExploitAPI();
        public Main()
        {
            InitializeComponent();
        }

        private void windowMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void windowDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void exploitListScriptBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScriptBox.Text = File.ReadAllText($"./Scripts/{ScriptList.SelectedItem}");
        }

        private void btnKillRoblox_Click(object sender, EventArgs e)
        {
            //Scripthub scripthub = new Scripthub();
            //scripthub.Show();
            MessageBox.Show("Comeing soon new update\nSorry", "OVERTIME GANG",
            System.Windows.Forms.MessageBoxButtons.OKCancel,
            System.Windows.Forms.MessageBoxIcon.Information
            );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ScriptBox.Text = "";
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = @"Txt Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua|All Files (*.*)|*.*";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            var s = sfd.OpenFile();
            var sw = new StreamWriter(s);
            sw.Write(ScriptBox.Text);
            sw.Close();
            ScriptBox.Clear();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"Txt Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                ScriptBox.Text = "";
                using (openFileDialog.OpenFile())
                    ScriptBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show(@"An unexpected error has occured", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRunFile_Click(object sender, EventArgs e)
        {
            Exapi.LaunchExploit();
        } 

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            ScriptList.Items.Clear();
            Functions.PopulateListBox(ScriptList, @".\Scripts", "*.txt");
            Functions.PopulateListBox(ScriptList, @".\Scripts", "*.lua");
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            Exapi.SendLuaScript(ScriptBox.Text);
        }

        private void exploitScriptBox_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchScript_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
        }

        private void Killrobllox_Click(object sender, EventArgs e)
        {
            try
            {
                var localByName = Process.GetProcessesByName("RobloxPlayerBeta");
                foreach (Process p in localByName)
                {
                    p.Kill();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Failed to kill Roblox");
            }
        }
    }
}
