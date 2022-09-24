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

namespace chat
{
    public partial class rikotool : Form
    {
        public rikotool()
        {
            InitializeComponent();
        }

        private void rikotool_Load(object sender, EventArgs e)
        {

        }

        private void tool4_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void tool1_Click(object sender, EventArgs e)
        {
         /*   RikoEmote.Image = Image.FromFile(@"d:\Riko Chat Bot\chat\Rikoemote\rikoaim.png");
            DialogResult Getout = MessageBox.Show("Riko chan chúc bạn chơi vui vẻ", "bye bye", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);*/
            ProcessStartInfo sSMC = new ProcessStartInfo();
            sSMC.FileName = @"d:\\Steam\steamapps\common\Super Mecha Champions\launcher.exe";
            sSMC.Arguments = "header.h";
            Process startSMC = Process.Start(sSMC);
        }

        private void tool2_Click(object sender, EventArgs e)
        {

        }

        private void tool3_Click(object sender, EventArgs e)
        {
            this.Hide();
            rikocalc f2 = new rikocalc();
            f2.ShowDialog();
            this.Show();
        }
    }
}
