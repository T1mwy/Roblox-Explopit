﻿using KeyAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WeAreDevs_API;

namespace Loader
{
    public partial class Scriptlist : Form
    {
        private Point lastPoint;
        private readonly List<string> listScripts = new List<string>();
        ExploitAPI Exapi = new ExploitAPI();
        public Scriptlist()
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel02_Paint(object sender, PaintEventArgs e)
        {

        }

        private void column_Click(object sender, EventArgs e)
        {
            Panel01.Visible = true;
            Panel01.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel02.Visible = true;
            Panel02.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel03.Visible = true;
            Panel03.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Panel04.Visible = true;
            Panel04.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Panel05.Visible = true;
            Panel05.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Panel06.Visible = true;
            Panel06.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Panel07.Visible = true;
            Panel07.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Panel08.Visible = true;
            Panel08.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Panel09.Visible = true;
            Panel09.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Panel100.Visible = true;
            Panel100.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Panel11.Visible = true;
            Panel11.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Panel12.Visible = true;
            Panel12.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string petsim = "";
            Exapi.SendLuaScript(petsim);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            string bf = "";
            Exapi.SendLuaScript(bf);
        }
    }
}
