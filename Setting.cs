﻿using KeyAuth;
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

namespace Loader
{
    public partial class Setting : Form
    {
        private Point lastPoint;
        private readonly List<string> listScripts = new List<string>();
        public Setting()
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
        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void btnKillRoblox_Click(object sender, EventArgs e)
        {
            if (btnKillRoblox.Enabled == true)
            {

                Process.Start(@".\Data\rbxfpsunlocker.exe");
            }
            else if (btnKillRoblox.Visible == false)
            {
                foreach (Process proc in Process.GetProcessesByName("rbxfpsunlocker"))
                {
                    proc.Kill();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkTopMost_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkTopMost.Checked;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (btnKillRoblox.Enabled == true)
            {

                Process.Start(@".\Data\Multiple_ROBLOX.exe");
            }
            else if (btnKillRoblox.Visible == false)
            {
                foreach (Process proc in Process.GetProcessesByName("Multiple_ROBLOX"))
                {
                    proc.Kill();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/@overtime8554/videos");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/GHBAGtwCZU");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/OverTime69");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Process.Start("https://cdn.vox-cdn.com/thumbor/lOcJy6rTwVIvons6E9l6fIH5ZjY=/0x0:2716x3528/1200x800/filters:focal(1736x1114:2170x1548)/cdn.vox-cdn.com/uploads/chorus_image/image/61662815/3046716.jpg.0.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("finj.exe");
            }
            catch
            {
                MessageBox.Show("Inject fix failed Try using the normal inject If that doesn't work report the bug at Support Channel", "OVERTIME GANG",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Exclamation
                );
            }
        }
    }
}
