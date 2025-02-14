using Loader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MessageBox;

namespace KeyAuth
{
    public partial class Login : Form
    {

        public static api KeyAuthApp = new api(
            name: "",
            ownerid: "",
            secret: "",
            version: "1.0"
        );

        public Login()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();

            if (KeyAuthApp.response.message == "invalidver")
            {
                if (!string.IsNullOrEmpty(KeyAuthApp.app_data.downloadLink))
                {
                    DialogResult dialogResult = MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            Process.Start(KeyAuthApp.app_data.downloadLink);
                            Environment.Exit(0);
                            break;
                        case DialogResult.No:
                            WebClient webClient = new WebClient();
                            string destFile = Application.ExecutablePath;

                            string rand = random_string();

                            destFile = destFile.Replace(".exe", $"-{rand}.exe");
                            webClient.DownloadFile(KeyAuthApp.app_data.downloadLink, destFile);

                            Process.Start(destFile);
                            Process.Start(new ProcessStartInfo()
                            {
                                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                                WindowStyle = ProcessWindowStyle.Hidden,
                                CreateNoWindow = true,
                                FileName = "cmd.exe"
                            });
                            Environment.Exit(0);

                            break;
                        default:
                            MessageBox.Show("Invalid option");
                            Environment.Exit(0);
                            break;
                    }
                }
                MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");
                Thread.Sleep(2500);
                Environment.Exit(0);
            }
            
            if (!KeyAuthApp.response.success)
            {
                MessageBox.Show(KeyAuthApp.response.message);
                Environment.Exit(0);
            }
            //if (KeyAuthApp.checkblack())
            //{
            //    MessageBox.Show("user is blacklisted");
            //}
            //else
            //{
            //    MessageBox.Show("user is not blacklisted");
            //}
            KeyAuthApp.check();
        }

        static string random_string()
        {
            string str = null;

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;

        }

        private void UpgradeBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.license(key.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check you key or Place you key", "OVERTIME GANG",
                System.Windows.Forms.MessageBoxButtons.OKCancel,
                System.Windows.Forms.MessageBoxIcon.Information
                );
            }
        }

        private void RgstrBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void LicBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.license(key.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        private void key_TextChanged(object sender, EventArgs e)
        {
            key.PasswordChar = '*';
        }

        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/3FvKm7aYst");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Why you click it", "Secret",
                System.Windows.Forms.MessageBoxButtons.OKCancel,
                System.Windows.Forms.MessageBoxIcon.Question
            );
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }
    }
}
