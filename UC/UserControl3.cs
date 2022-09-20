using DiscordRPC;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xanax.config;

namespace Xanax.UC
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            switch (keyData)
            {
                case Keys.Home:
                    if (1 == 1)
                    {
                        Discord.rpctimestamp = Timestamps.Now;
                        Discord.InitializeRPC();
                        MessageBox.Show("Sucesso");
                    }
                    break;
                case Keys.F12:
                    selfdestruct();
                    break;


            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            selfdestruct();
        }

        private async void selfdestruct()
        {
            await Task.Delay(300);
            string location = Assembly.GetExecutingAssembly().Location;
            if (location == "" || location == null)
            {
                location = Assembly.GetEntryAssembly().Location;
            }
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/C ping 1.1.1.1 -n 1 -w 4000 > Nul & Del \"" + location + "\"",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            });
            Environment.Exit(0);
        }

        private void siticoneLabel8_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Btnyoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/c/PKDORX");
        }

        private void BtnInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/pkdorx/");
        }

        private void BtnDiscord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/Va7BP2fQw6");
        }
    }
}
