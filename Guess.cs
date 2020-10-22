using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Text;

namespace Words_Game
{
    public partial class Guess : Form
    {
        SoundPlayer soundplayer1;
        SoundPlayer soundplayer2;
        public Guess()
        {
            InitializeComponent();
            soundplayer1 = new SoundPlayer(@"C:\Users\zivho\source\repos\Words Game\Resources\zapsplat_technology_vr_headset_focus_slider_single_movement_19160 (online-audio-converter.com).wav");
            soundplayer2 = new SoundPlayer(@"C:\Users\zivho\source\repos\Words Game\Resources\The-Builder.wav");
            pbQuestionMark.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            this.btnStart.MouseEnter += new System.EventHandler(this.btnStart_MouseEnter);
            btnStart.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you sure you want to exit?", "Important Question!", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                soundplayer2.Stop();
                Environment.Exit(1);
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Game openGame = new Game();
            openGame.Show();
            soundplayer2.Stop();
            this.Hide();
        }
        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.StartLight));
            //soundplayer1.Play();
        }
        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.StartNormal));
        }
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ExitLightNew));
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ExitNormalNew));
        }
        private void Guess_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
