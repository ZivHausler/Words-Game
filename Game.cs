using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Words_Game
{
    public partial class Game : Form
    {
        // ---- Data: ----
        private SoundPlayer soundplayer1;
        private SoundPlayer soundplayer2;
        private SoundPlayer soundplayer3;
        private SoundPlayer soundplayer4;
        private SoundPlayer soundplayer5;
        private SoundPlayer soundplayer6;
        private SoundPlayer soundplayer7;
        private SoundPlayer soundplayer8;

        static Random random = new Random();
        int i = 0;
        int ticks = 0;
        int click = 0;
        int hint = 0;
        Button[] btnLettersArray;
        Button[] btnCorrectArray;
        string[] words;
        char[] tmp2;
        public Game()
        {

            InitializeComponent();
            pb.Image = il.Images[i];
            //Comic Sans MS, 11.25pt, style = Bold, Italic
            btnLVL.Text = "LEVEL 1";
            btnLVL.Font = new Font("Comic Sans MS", 11, FontStyle.Bold);
            soundplayer1 = new SoundPlayer(@"..\..\Resources\MixSound.wav");
            soundplayer2 = new SoundPlayer(@"..\..\Resources\btnhover.wav");
            soundplayer3 = new SoundPlayer(@"..\..\Resources\letterhover.wav");
            soundplayer4 = new SoundPlayer(@"..\..\Resources\QuestionMarkSound.wav");
            soundplayer5 = new SoundPlayer(@"..\..\Resources\click.wav");
            soundplayer6 = new SoundPlayer(@"..\..\Resources\Sad Violin.wav");
            soundplayer7 = new SoundPlayer(@"..\..\Resources\duck quack.wav");
            soundplayer8 = new SoundPlayer(@"..\..\Resources\claps and cheers.wav");
            btnLVL.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnHint.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnMix.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            words = new string[] { "APPLE", "BOX", "CHAIR", "DOG", "DOOR", "ICE", "PUPPET", "TOWER", "WATERMELON" };
            tmp2 = new char[words[i].Length];
            btnCorrectArray = new Button[] { btnCorrenct1, btnCorrenct2, btnCorrenct3, btnCorrenct4, btnCorrenct5, btnCorrenct6, btnCorrenct7, btnCorrenct8, btnCorrenct9, btnCorrenct10
};
            btnLettersArray = new Button[] { btnLetter1, btnLetter2, btnLetter3, btnLetter4, btnLetter5, btnLetter6, btnLetter7, btnLetter8, btnLetter9, btnLetter10, btnLetter11, btnLetter12 };
            for (int k = 0; k < 10; k++)
            {
                btnCorrectArray[k].BackColor = Color.Transparent;
                btnCorrectArray[k].FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            } // CorrectButtons transparancy
            for (int k = 0; k < 12; k++)
            {
                btnLettersArray[k].FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            } // LettersButtons transparancy
            int len = words[i].Length;
            for (int k = 0; k < words[i].Length; k++)
            {
                btnCorrectArray[k].Location = new Point(186 + (57 * k), 393);
                btnCorrectArray[k].Visible = true;
            }
            GenerateRandomButtons();
        }
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Guess openGuess = new Guess();
            openGuess.Show();
            this.Hide();
        }

        // ---- Methods: ----
        public int[] GetRandomNumbersArray()
        {
            int[] numArr = new int[words[i].Length];
            for (int t = 0; t < words[i].Length; t++)
            {
                numArr[t] = -1;
            }
            for (int t = 0; t < words[i].Length; t++)
            {
                bool good = true;
                int number = GetRandomNumber(11); // 0-11
                for (int k = 0; k <= t; k++)
                {
                    if (number == numArr[k])
                    {
                        good = false;
                        t--;
                        break;
                    }
                }
                if (good == true)
                    numArr[t] = number;
            }
            return numArr;
        }
        public int GetRandomNumber(int length)
        {
            return random.Next(length + 1);
        }
        public char GetLetter()
        {
            int num = GetRandomNumber(25); // A-Z
            char letter = (char)('A' + num);
            return letter;
        }
        public void GenerateRandomButtons()
        {
            char[] letters = new char[words[i].Length];
            letters = words[i].ToCharArray();
            int[] numWordArr = GetRandomNumbersArray();
            int[] numRandArr = new int[12 - numWordArr.Length];
            for (int t = 0, j = 0; (t < 12); t++)
            {
                if (j >= numRandArr.Length) break;
                int good = 1;
                for (int k = 0; k < numWordArr.Length; k++)
                {
                    if (numWordArr[k] == t)
                    {
                        good = 0;
                        break;
                    }
                }
                if (good == 1)
                {
                    numRandArr[j] = t;
                    j++;
                }
            } // creating second random numbers
            for (int t = 0; t < numWordArr.Length; t++)
            {
                btnLettersArray[numWordArr[t]].Text = letters[t].ToString();
            }
            for (int t = 0; t < numRandArr.Length; t++)
            {
                btnLettersArray[numRandArr[t]].Text = GetLetter().ToString();
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            for (int i = 0; i < btnCorrectArray.Length; i++)
            {
                if (btnCorrectArray[i] == null)
                {
                    soundplayer7.Play();
                    DialogResult result4 = MessageBox.Show("You didn't complete the whole word. Please keep trying or use the 'HINT' button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (isEqual())
            {
                ClearAllButtons();
                GoNext();
                tmp2 = new char[words[i].Length];
                btnLVL.Text = ShowLVL();
                return;
            }
            if (!(click == words[i].Length))
            {
                soundplayer7.Play();
                DialogResult result0 = MessageBox.Show("You didn't complete the whole word. Please keep trying or use the 'HINT' button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result0 == DialogResult.OK) timer1.Start();
                return;
            }
            soundplayer7.Play();
            DialogResult result1 = MessageBox.Show("You didn't guess the correct word. Please try again!", "Error", MessageBoxButtons.OK);
        }
        private void DisableAllButtons()
        {
            btnHint.Enabled = false;
            btnMix.Enabled = false;
            btnReset.Enabled = false;
            btnLetter1.Enabled = false;
            btnLetter2.Enabled = false;
            btnLetter3.Enabled = false;
            btnLetter4.Enabled = false;
            btnLetter5.Enabled = false;
            btnLetter6.Enabled = false;
            btnLetter7.Enabled = false;
            btnLetter8.Enabled = false;
            btnLetter9.Enabled = false;
            btnLetter10.Enabled = false;
            btnLetter11.Enabled = false;
            btnLetter12.Enabled = false;
        }
        private void EnableAllButtons()
        {
            btnHint.Enabled = true;
            btnMix.Enabled = true;
            btnReset.Enabled = true;
            btnLetter1.Enabled = true;
            btnLetter2.Enabled = true;
            btnLetter3.Enabled = true;
            btnLetter4.Enabled = true;
            btnLetter5.Enabled = true;
            btnLetter6.Enabled = true;
            btnLetter7.Enabled = true;
            btnLetter8.Enabled = true;
            btnLetter9.Enabled = true;
            btnLetter10.Enabled = true;
            btnLetter11.Enabled = true;
            btnLetter12.Enabled = true;
        }
        private void ButtonsLocation()
        {
            int len = words[i].Length;
            switch (len)
            {
                case 3:
                    for (int k = 0; k < words[i].Length; k++)
                    {
                        btnCorrectArray[k].Visible = true;
                        btnCorrectArray[k].Location = new Point(239 + (57 * k), 393);
                    }
                    break;
                case 4:
                    for (int k = 0; k < words[i].Length; k++)
                    {
                        btnCorrectArray[k].Visible = true;
                        btnCorrectArray[k].Location = new Point(211 + (57 * k), 393);
                    }
                    break;
                case 5:
                    for (int k = 0; k < words[i].Length; k++)
                    {
                        btnCorrectArray[k].Visible = true;
                        btnCorrectArray[k].Location = new Point(183 + (57 * k), 393);
                    }
                    break;
                case 6:
                    for (int k = 0; k < words[i].Length; k++)
                    {
                        btnCorrectArray[k].Visible = true;
                        btnCorrectArray[k].Location = new Point(155 + (57 * k), 393);
                    }
                    break;
                case 7:
                    for (int k = 0; k < words[i].Length; k++)
                    {
                        btnCorrectArray[k].Visible = true;
                        btnCorrectArray[k].Location = new Point(127 + (57 * k), 393);
                    }
                    break;
                case 8:
                    for (int k = 0; k < words[i].Length; k++)
                    {
                        btnCorrectArray[k].Visible = true;
                        btnCorrectArray[k].Location = new Point(99 + (57 * k), 393);
                    }
                    break;
                case 9:
                    for (int k = 0; k < words[i].Length; k++)
                    {
                        btnCorrectArray[k].Visible = true;
                        btnCorrectArray[k].Location = new Point(71 + (57 * k), 393);
                    }
                    break;
                case 10:
                    for (int k = 0; k < words[i].Length; k++)
                    {
                        btnCorrectArray[k].Visible = true;
                        btnCorrectArray[k].Location = new Point(43 + (57 * k), 393);
                    }
                    break;
            }
        }
        private void GoNext()
        {
            for (int k = 0; k < 10; k++)
            {
                btnCorrectArray[k].Visible = false;
            }
            if (i < 8)
            {
                for (int k = 0; k < words[i].Length; k++)
                {
                    btnCorrectArray[k].Visible = false;
                }
                i++;
                pb.Image = il.Images[i];
                GenerateRandomButtons();
                ButtonsLocation();
                return;
            }
            if (i == 8)
            {
                soundplayer8.Play();
                DialogResult result2 = MessageBox.Show("You've successfully completed the game! Would you like to play again?", "Congratulations!", MessageBoxButtons.YesNo);
                if (result2 == DialogResult.No)
                    this.Close();
                soundplayer8.Stop();
                if (result2 == DialogResult.Yes)
                    soundplayer8.Stop();
                {
                    //for (int k = 0; k < words[i].Length; k++)
                    //{
                    //    btnCorrectArray[k].Visible = false;
                    //}
                    i = 0;
                    ButtonsLocation();
                    pb.Image = il.Images[0];
                    EnableAllButtons();
                    GenerateRandomButtons();
                    return;
                }
            }
        }
        private void ClearAllButtons()
        {
            for (int k = 0; k < words[i].Length; k++)
            {
                btnCorrectArray[k].Text = null;
            }
            for (int k = 0; k < btnLettersArray.Length; k++)
            {
                btnLettersArray[k].Visible = true;
            }
            hint = 0;
            click = 0;
            for (int k = 0; k < tmp2.Length; k++)
            {
                tmp2[k] = '\0';
            }
            btnHint.Enabled = true;
            btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HINTnormal));
            for (int k = 0; k < words[i].Length; k++)
            {
                btnCorrectArray[k].ForeColor = Color.Black;
            }
        }
        private char[] ButtonsToArray()
        {
            char[] letters = new char[words[i].Length];
            for (int k = 0; k < words[i].Length; k++)
            {
                if (btnCorrectArray[k].Text == "")
                    return null;
                letters[k] = char.Parse(btnCorrectArray[k].Text);
            }
            return letters;
        }
        private bool isEqual()
        {
            char[] check1 = ButtonsToArray();
            if (check1 == null) return false;
            char[] check2 = words[i].ToCharArray();
            return Enumerable.SequenceEqual(check1, check2);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAllButtons();
            soundplayer5.Play();
        }
        private void btnHint_Click(object sender, EventArgs e)
        {
            int flag = 0;
            soundplayer5.Play();
            if (hint < words[i].Length)
            {
                char[] tmp1 = words[i].ToCharArray();
                int num = GetRandomNumber(words[i].Length - 1);
                while (tmp2[num] != '\0' && tmp2[num] == tmp1[num])
                {
                    if (isEqual()) return;
                    num = GetRandomNumber(words[i].Length - 1);
                }
                char letterhint = tmp1[num];
                tmp2[num] = tmp1[num];
                for (int k = 0; k < btnCorrectArray.Length; k++)
                {
                    if (btnCorrectArray[k].Text == letterhint.ToString())
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 1)
                {
                    flag = 0;
                    for (int k = 0; k < btnLettersArray.Length; k++)
                    {
                        if ((btnLettersArray[k].Text == letterhint.ToString()) && (btnLettersArray[k].Visible == true))
                        {
                            btnLettersArray[k].Visible = false;
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                        for (int k = 0; k < btnCorrectArray.Length; k++)
                        {
                            if (k != num)
                            {
                                if (btnCorrectArray[k].Text == letterhint.ToString())
                                {
                                    btnCorrectArray[k].Text = "";
                                    tmp2[k] = '\0';
                                    click--;
                                }
                            }
                        }
                }
                if (((btnCorrectArray[num].Text) != null) && (btnCorrectArray[num].Text != letterhint.ToString()))
                {
                    for (int k = 0; k < btnLettersArray.Length; k++)
                    {
                        if ((btnLettersArray[k].Text == btnCorrectArray[num].Text) && (btnLettersArray[k].Visible == false))
                        {
                            btnLettersArray[k].Visible = true;
                            break;
                        }
                    } // renews a button with the specific letter
                    btnCorrectArray[num].Text = letterhint.ToString();
                    btnCorrectArray[num].ForeColor = Color.Blue;
                }
                if (flag != 1)
                    for (int k = 0; k < btnLettersArray.Length; k++)
                    {
                        if ((btnLettersArray[k].Text == letterhint.ToString()) && (btnLettersArray[k].Visible == true))
                        {
                            btnLettersArray[k].Visible = false;
                            break;
                        }
                    } // deletes a button with the randomized letter
                hint++;

                if (isEqual())
                {
                    this.btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HintUnavailable));
                    btnHint.Enabled = false;
                }

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks % 2 == 0) this.btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HINTlight));
            if (ticks % 2 != 0) this.btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HINTnormal));
            if (ticks == 11)
            {
                timer1.Stop();
                ticks = 0;
            }
        }
        private void btnMix_Click(object sender, EventArgs e)
        {
            soundplayer1.Play();
            int counter = 0;
            int t = 0;
            for (int k = 0; k < btnLettersArray.Length; k++)
            {
                if (btnLettersArray[k].Visible != false)
                    counter++;
            }
            char[] tmp1 = new char[counter];
            char[] tmp3 = new char[counter];
            for (int j = 0, k = 0; k < btnLettersArray.Length || j < counter; k++)
            {
                if (btnLettersArray[k].Visible == true)
                {
                    tmp3[j] = char.Parse(btnLettersArray[k].Text);
                    j++;
                }
            }
            while (t < counter)
            {
                int num = GetRandomNumber(counter - 1);
                if (tmp3[num] != '\0')
                {
                    tmp1[t] = tmp3[num];
                    tmp3[num] = '\0';
                    t++;
                }
            }
            for (int j = 0, k = 0; k < btnLettersArray.Length; k++)
            {
                if (btnLettersArray[k].Visible == true)
                {
                    btnLettersArray[k].Text = tmp1[j].ToString();
                    j++;
                }
            }
        }
        private string ShowLVL()
        {
            string txt = null;
            switch (i)
            {
                case 0:
                    txt = "LEVEL 1";
                    break;
                case 1:
                    txt = "LEVEL 2";
                    break;
                case 2:
                    txt = "LEVEL 3";
                    break;
                case 3:
                    txt = "LEVEL 4";
                    break;
                case 4:
                    txt = "LEVEL 5";
                    break;
                case 5:
                    txt = "LEVEL 6";
                    break;
                case 6:
                    txt = "LEVEL 7";
                    break;
                case 7:
                    txt = "LEVEL 8";
                    break;
                case 8:
                    txt = "LEVEL 9";
                    break;
                case 9:
                    txt = "LEVEL 10";
                    break;
            }
            return txt;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            soundplayer6.Play();
            DialogResult result5 = MessageBox.Show("Are you sure you want to go to the lobby?", "Second chance", MessageBoxButtons.YesNo);
            if (result5 == DialogResult.Yes)
            {
                Guess openGuess = new Guess();
                openGuess.Show();
                this.Hide();
                soundplayer6.Stop();
            }
            else soundplayer6.Stop();
        }
        private bool isFull()
        {
            for (int k = 0; k < words[i].Length; k++)
            {
                if (tmp2[k] == '\0') return false;
            }
            return true;
        }

        // ---- Highlight Buttons: ----
        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HomeLight));
            soundplayer4.Play();
        }
        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HomeNormal));
        }
        private void btnHint_MouseEnter(object sender, EventArgs e)
        {
            this.btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HINTlight));
            soundplayer2.Play();
        }
        private void btnHint_MouseLeave(object sender, EventArgs e)
        {
            if (hint == words[i].Length)
            {
                this.btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HintUnavailable));
                return;
            }
            this.btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HINTnormal));
        }
        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.RESETlight));
            soundplayer2.Play();
        }
        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.RESETnormal));
        }
        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.NEXTlight));
            soundplayer2.Play();
        }
        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.NEXTnormal));
        }
        private void btnMix_MouseEnter(object sender, EventArgs e)
        {
            this.btnMix.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MixLight));
            soundplayer2.Play();
        }
        private void btnMix_MouseLeave(object sender, EventArgs e)
        {
            this.btnMix.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.MixNormal));
        }
        private void btnCorrenct1_MouseEnter(object sender, EventArgs e)
        {
            this.btnCorrenct1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnCorrenct2_MouseEnter(object sender, EventArgs e)
        {
            this.btnCorrenct2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnCorrenct3_MouseEnter(object sender, EventArgs e)
        {
            this.btnCorrenct3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnCorrenct4_MouseEnter(object sender, EventArgs e)
        {
            this.btnCorrenct4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnCorrenct5_MouseEnter(object sender, EventArgs e)
        {
            this.btnCorrenct5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnCorrenct6_MouseEnter(object sender, EventArgs e)
        {
            this.btnCorrenct6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnCorrenct7_MouseEnter(object sender, EventArgs e)
        {
            this.btnCorrenct7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnCorrenct8_MouseEnter(object sender, EventArgs e)
        {
            this.btnCorrenct8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnCorrenct9_MouseEnter(object sender, EventArgs e)
        {
            this.btnCorrenct9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnCorrenct10_MouseEnter(object sender, EventArgs e)
        {
            this.btnCorrenct10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnCorrenct1_MouseLeave(object sender, EventArgs e)
        {
            this.btnCorrenct1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnCorrenct2_MouseLeave(object sender, EventArgs e)
        {
            this.btnCorrenct2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnCorrenct3_MouseLeave(object sender, EventArgs e)
        {
            this.btnCorrenct3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnCorrenct4_MouseLeave(object sender, EventArgs e)
        {
            this.btnCorrenct4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnCorrenct5_MouseLeave(object sender, EventArgs e)
        {
            this.btnCorrenct5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnCorrenct6_MouseLeave(object sender, EventArgs e)
        {
            this.btnCorrenct6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnCorrenct7_MouseLeave(object sender, EventArgs e)
        {
            this.btnCorrenct7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnCorrenct8_MouseLeave(object sender, EventArgs e)
        {
            this.btnCorrenct8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnCorrenct9_MouseLeave(object sender, EventArgs e)
        {
            this.btnCorrenct9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnCorrenct10_MouseLeave(object sender, EventArgs e)
        {
            this.btnCorrenct10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnLetter1_MouseEnter(object sender, EventArgs e)
        {
            this.btnLetter1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnLetter2_MouseEnter(object sender, EventArgs e)
        {
            this.btnLetter2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnLetter3_MouseEnter(object sender, EventArgs e)
        {
            this.btnLetter3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnLetter4_MouseEnter(object sender, EventArgs e)
        {
            this.btnLetter4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnLetter5_MouseEnter(object sender, EventArgs e)
        {
            this.btnLetter5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnLetter6_MouseEnter(object sender, EventArgs e)
        {
            this.btnLetter6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnLetter7_MouseEnter(object sender, EventArgs e)
        {
            this.btnLetter7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnLetter8_MouseEnter(object sender, EventArgs e)
        {
            this.btnLetter8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnLetter9_MouseEnter(object sender, EventArgs e)
        {
            this.btnLetter9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnLetter10_MouseEnter(object sender, EventArgs e)
        {
            this.btnLetter10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnLetter11_MouseEnter(object sender, EventArgs e)
        {
            this.btnLetter11.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnLetter12_MouseEnter(object sender, EventArgs e)
        {
            this.btnLetter12.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxLight));
            soundplayer3.Play();
        }
        private void btnLetter1_MouseLeave(object sender, EventArgs e)
        {
            this.btnLetter1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnLetter2_MouseLeave(object sender, EventArgs e)
        {
            this.btnLetter2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnLetter3_MouseLeave(object sender, EventArgs e)
        {
            this.btnLetter3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnLetter4_MouseLeave(object sender, EventArgs e)
        {
            this.btnLetter4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnLetter5_MouseLeave(object sender, EventArgs e)
        {
            this.btnLetter5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnLetter6_MouseLeave(object sender, EventArgs e)
        {
            this.btnLetter6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnLetter7_MouseLeave(object sender, EventArgs e)
        {
            this.btnLetter7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnLetter8_MouseLeave(object sender, EventArgs e)
        {
            this.btnLetter8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnLetter9_MouseLeave(object sender, EventArgs e)
        {
            this.btnLetter9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnLetter10_MouseLeave(object sender, EventArgs e)
        {
            this.btnLetter10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnLetter11_MouseLeave(object sender, EventArgs e)
        {
            this.btnLetter11.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }
        private void btnLetter12_MouseLeave(object sender, EventArgs e)
        {
            this.btnLetter12.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BoxNormal));
        }

        // ---- Add To Correct Array: ----
        private void btnLetter1_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            if (isFull()) return;
            int j = 0;
            if (click < words[i].Length)
            {
                while (tmp2[j] != '\0')
                {
                    j++;
                    if (click >= words[i].Length) return;
                }
                tmp2[j] = char.Parse(btnLetter1.Text);
                btnCorrectArray[j].Text = btnLetter1.Text;
                btnLetter1.Visible = false;
                if (isEqual())
                {
                    btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HintUnavailable));
                    btnHint.Enabled = false;
                }
            }
        }
        private void btnLetter2_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            if (isFull()) return;
            int j = 0;
            if (click < words[i].Length)
            {
                while (tmp2[j] != '\0')
                {
                    j++;
                    if (click >= words[i].Length) return;
                    if (j == words[i].Length) return;
                }
                tmp2[j] = char.Parse(btnLetter2.Text);
                btnCorrectArray[j].Text = btnLetter2.Text;
                click++;
                btnLetter2.Visible = false;
                if (isEqual())
                {
                    btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HintUnavailable));
                    btnHint.Enabled = false;
                }
            }
        }
        private void btnLetter3_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            if (isFull()) return;
            int j = 0;
            if (click < words[i].Length)
            {
                while (tmp2[j] != '\0')
                {
                    j++;
                    if (click >= words[i].Length) return;
                    if (j == words[i].Length) return;

                }
                tmp2[j] = char.Parse(btnLetter3.Text);
                btnCorrectArray[j].Text = btnLetter3.Text;
                click++;
                btnLetter3.Visible = false;
                if (isEqual())
                {
                    btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HintUnavailable));
                    btnHint.Enabled = false;
                }
            }
        }
        private void btnLetter4_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            if (isFull()) return;
            int j = 0;
            if (click < words[i].Length)
            {
                while (tmp2[j] != '\0')
                {
                    j++;
                    if (click >= words[i].Length) return;
                    if (j == words[i].Length) return;
                }
                tmp2[j] = char.Parse(btnLetter4.Text);
                btnCorrectArray[j].Text = btnLetter4.Text;
                click++;
                btnLetter4.Visible = false;
                if (isEqual())
                {
                    btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HintUnavailable));
                    btnHint.Enabled = false;
                }
            }
        }
        private void btnLetter5_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            if (isFull()) return;
            int j = 0;
            if (click < words[i].Length)
            {
                while (tmp2[j] != '\0')
                {
                    j++;
                    if (click >= words[i].Length) return;
                    if (j == words[i].Length) return;

                }
                tmp2[j] = char.Parse(btnLetter5.Text);
                btnCorrectArray[j].Text = btnLetter5.Text;
                click++;
                btnLetter5.Visible = false;
                if (isEqual())
                {
                    btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HintUnavailable));
                    btnHint.Enabled = false;
                }
            }
        }
        private void btnLetter6_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            if (isFull()) return;
            int j = 0;
            if (click < words[i].Length)
            {
                while (tmp2[j] != '\0')
                {
                    j++;
                    if (click >= words[i].Length) return;
                    if (j == words[i].Length) return;

                }
                tmp2[j] = char.Parse(btnLetter6.Text);
                btnCorrectArray[j].Text = btnLetter6.Text;
                click++;
                btnLetter6.Visible = false;
                if (isEqual())
                {
                    btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HintUnavailable));
                    btnHint.Enabled = false;
                }
            }
        }
        private void btnLetter7_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            if (isFull()) return;
            int j = 0;
            if (click < words[i].Length)
            {
                while (tmp2[j] != '\0')
                {
                    j++;
                    if (click >= words[i].Length) return;
                    if (j == words[i].Length) return;

                }
                tmp2[j] = char.Parse(btnLetter7.Text);
                btnCorrectArray[j].Text = btnLetter7.Text;
                click++;
                btnLetter7.Visible = false;
                if (isEqual())
                {
                    btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HintUnavailable));
                    btnHint.Enabled = false;
                }
            }
        }
        private void btnLetter8_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            if (isFull()) return;
            int j = 0;
            if (click < words[i].Length)
            {
                while (tmp2[j] != '\0')
                {
                    j++;
                    if (click >= words[i].Length) return;
                    if (j == words[i].Length) return;

                }
                tmp2[j] = char.Parse(btnLetter8.Text);
                btnCorrectArray[j].Text = btnLetter8.Text;
                click++;
                btnLetter8.Visible = false;
                if (isEqual())
                {
                    btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HintUnavailable));
                    btnHint.Enabled = false;
                }
            }
        }
        private void btnLetter9_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            if (isFull()) return;
            int j = 0;
            if (click < words[i].Length)
            {
                while (tmp2[j] != '\0')
                {
                    j++;
                    if (click >= words[i].Length) return;
                    if (j == words[i].Length) return;

                }
                tmp2[j] = char.Parse(btnLetter9.Text);
                btnCorrectArray[j].Text = btnLetter9.Text;
                click++;
                btnLetter9.Visible = false;
                if (isEqual())
                {
                    btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HintUnavailable));
                    btnHint.Enabled = false;
                }
            }
        }
        private void btnLetter10_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            if (isFull()) return;
            int j = 0;
            if (click < words[i].Length)
            {
                while (tmp2[j] != '\0')
                {
                    j++;
                    if (click >= words[i].Length) return;
                    if (j == words[i].Length) return;

                }
                tmp2[j] = char.Parse(btnLetter10.Text);
                btnCorrectArray[j].Text = btnLetter10.Text;
                click++;
                btnLetter10.Visible = false;
                if (isEqual())
                {
                    btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HintUnavailable));
                    btnHint.Enabled = false;
                }
            }
        }
        private void btnLetter11_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            if (isFull()) return;
            int j = 0;
            if (click < words[i].Length)
            {
                while (tmp2[j] != '\0')
                {
                    j++;
                    if (click >= words[i].Length) return;
                    if (j == words[i].Length) return;

                }
                tmp2[j] = char.Parse(btnLetter11.Text);
                btnCorrectArray[j].Text = btnLetter11.Text;
                click++;
                btnLetter11.Visible = false;
                if (isEqual())
                {
                    btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HintUnavailable));
                    btnHint.Enabled = false;
                }
            }
        }
        private void btnLetter12_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            if (isFull()) return;
            int j = 0;
            if (click < words[i].Length)
            {
                while (tmp2[j] != '\0')
                {
                    j++;
                    if (click >= words[i].Length) return;
                    if (j == words[i].Length) return;
                }
                tmp2[j] = char.Parse(btnLetter12.Text);
                btnCorrectArray[j].Text = btnLetter12.Text;
                click++;
                btnLetter12.Visible = false;
                if (isEqual())
                {
                    btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HintUnavailable));
                    btnHint.Enabled = false;
                }
            }
        }

        // ---- Remove From Correct Array: ----
        private void btnCorrenct1_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            for (int k = 0; k < btnLettersArray.Length; k++)
            {
                if ((btnCorrenct1.Text == btnLettersArray[k].Text) && (btnLettersArray[k].Visible == false))
                {
                    btnLettersArray[k].Visible = true;
                    break;
                }
            }
            tmp2[0] = '\0';
            click--;
            btnCorrenct1.Text = "";
            if (btnCorrenct1.ForeColor == Color.Blue)
                hint--;
            btnCorrenct1.ForeColor = Color.Black;
            btnHint.Enabled = true;
            this.btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HINTnormal));
        }
        private void btnCorrenct2_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            for (int k = 0; k < btnLettersArray.Length; k++)
            {
                if ((btnCorrenct2.Text == btnLettersArray[k].Text) && (btnLettersArray[k].Visible == false))
                {
                    btnLettersArray[k].Visible = true;
                    break;
                }
            }
            tmp2[1] = '\0';
            click--;
            btnCorrenct2.Text = "";
            if (btnCorrenct2.ForeColor == Color.Blue)
                hint--;
            btnCorrenct2.ForeColor = Color.Black;
            btnHint.Enabled = true;
            this.btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HINTnormal));
        }
        private void btnCorrenct3_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            for (int k = 0; k < btnLettersArray.Length; k++)
            {
                if ((btnCorrenct3.Text == btnLettersArray[k].Text) && (btnLettersArray[k].Visible == false))
                {
                    btnLettersArray[k].Visible = true;
                    break;
                }
            }
            tmp2[2] = '\0';
            click--;
            btnCorrenct3.Text = "";
            if (btnCorrenct3.ForeColor == Color.Blue)
                hint--;
            btnCorrenct3.ForeColor = Color.Black;
            btnHint.Enabled = true;
            this.btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HINTnormal));
        }
        private void btnCorrenct4_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            for (int k = 0; k < btnLettersArray.Length; k++)
            {
                if ((btnCorrenct4.Text == btnLettersArray[k].Text) && (btnLettersArray[k].Visible == false))
                {
                    btnLettersArray[k].Visible = true;
                    break;
                }
            }
            tmp2[3] = '\0';
            click--;
            btnCorrenct4.Text = "";
            if (btnCorrenct4.ForeColor == Color.Blue)
                hint--;
            btnCorrenct4.ForeColor = Color.Black;
            btnHint.Enabled = true;
            this.btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HINTnormal));
        }
        private void btnCorrenct5_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            for (int k = 0; k < btnLettersArray.Length; k++)
            {
                if ((btnCorrenct5.Text == btnLettersArray[k].Text) && (btnLettersArray[k].Visible == false))
                {
                    btnLettersArray[k].Visible = true;
                    break;
                }
            }
            tmp2[4] = '\0';
            click--;
            btnCorrenct5.Text = "";
            if (btnCorrenct5.ForeColor == Color.Blue)
                hint--;
            btnCorrenct5.ForeColor = Color.Black;
            btnHint.Enabled = true;
            this.btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HINTnormal));
        }
        private void btnCorrenct6_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            for (int k = 0; k < btnLettersArray.Length; k++)
            {
                if ((btnCorrenct6.Text == btnLettersArray[k].Text) && (btnLettersArray[k].Visible == false))
                {
                    btnLettersArray[k].Visible = true;
                    break;
                }
            }
            tmp2[5] = '\0';
            click--;
            btnCorrenct6.Text = "";
            if (btnCorrenct6.ForeColor == Color.Blue)
                hint--;
            btnCorrenct6.ForeColor = Color.Black;
            btnHint.Enabled = true;
            this.btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HINTnormal));
        }
        private void btnCorrenct7_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            for (int k = 0; k < btnLettersArray.Length; k++)
            {
                if ((btnCorrenct7.Text == btnLettersArray[k].Text) && (btnLettersArray[k].Visible == false))
                {
                    btnLettersArray[k].Visible = true;
                    break;
                }
            }
            tmp2[6] = '\0';
            click--;
            btnCorrenct7.Text = "";
            if (btnCorrenct7.ForeColor == Color.Blue)
                hint--;
            btnCorrenct7.ForeColor = Color.Black;
            btnHint.Enabled = true;
            this.btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HINTnormal));
        }
        private void btnCorrenct8_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            for (int k = 0; k < btnLettersArray.Length; k++)
            {
                if ((btnCorrenct8.Text == btnLettersArray[k].Text) && (btnLettersArray[k].Visible == false))
                {
                    btnLettersArray[k].Visible = true;
                    break;
                }
            }
            tmp2[7] = '\0';
            click--;
            btnCorrenct8.Text = "";
            if (btnCorrenct8.ForeColor == Color.Blue)
                hint--;
            btnCorrenct8.ForeColor = Color.Black;
            btnHint.Enabled = true;
            this.btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HINTnormal));
        }
        private void btnCorrenct9_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            for (int k = 0; k < btnLettersArray.Length; k++)
            {
                if ((btnCorrenct9.Text == btnLettersArray[k].Text) && (btnLettersArray[k].Visible == false))
                {
                    btnLettersArray[k].Visible = true;
                    break;
                }
            }
            tmp2[8] = '\0';
            click--;
            btnCorrenct9.Text = "";
            if (btnCorrenct9.ForeColor == Color.Blue)
                hint--;
            btnCorrenct9.ForeColor = Color.Black;
            btnHint.Enabled = true;
            this.btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HINTnormal));
        }
        private void btnCorrenct10_Click(object sender, EventArgs e)
        {
            soundplayer5.Play();
            for (int k = 0; k < btnLettersArray.Length; k++)
            {
                if ((btnCorrenct10.Text == btnLettersArray[k].Text) && (btnLettersArray[k].Visible == false))
                {
                    btnLettersArray[k].Visible = true;
                    break;
                }
            }
            tmp2[9] = '\0';
            click--;
            btnCorrenct10.Text = "";
            if (btnCorrenct10.ForeColor == Color.Blue)
                hint--;
            btnCorrenct10.ForeColor = Color.Black;
            btnHint.Enabled = true;
            this.btnHint.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.HINTnormal));
        }
    }
}
