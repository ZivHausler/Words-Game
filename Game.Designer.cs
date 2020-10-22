namespace Words_Game
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.lblGuessTheWord = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMix = new System.Windows.Forms.Button();
            this.btnLetter6 = new System.Windows.Forms.Button();
            this.btnLetter12 = new System.Windows.Forms.Button();
            this.btnLetter5 = new System.Windows.Forms.Button();
            this.btnLetter11 = new System.Windows.Forms.Button();
            this.btnLetter4 = new System.Windows.Forms.Button();
            this.btnLetter10 = new System.Windows.Forms.Button();
            this.btnLetter3 = new System.Windows.Forms.Button();
            this.btnLetter9 = new System.Windows.Forms.Button();
            this.btnLetter2 = new System.Windows.Forms.Button();
            this.btnLetter8 = new System.Windows.Forms.Button();
            this.btnLetter1 = new System.Windows.Forms.Button();
            this.btnLetter7 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            this.il = new System.Windows.Forms.ImageList(this.components);
            this.btnCorrenct1 = new System.Windows.Forms.Button();
            this.btnCorrenct2 = new System.Windows.Forms.Button();
            this.btnCorrenct3 = new System.Windows.Forms.Button();
            this.btnCorrenct4 = new System.Windows.Forms.Button();
            this.btnCorrenct5 = new System.Windows.Forms.Button();
            this.btnCorrenct6 = new System.Windows.Forms.Button();
            this.btnCorrenct7 = new System.Windows.Forms.Button();
            this.btnCorrenct8 = new System.Windows.Forms.Button();
            this.btnCorrenct9 = new System.Windows.Forms.Button();
            this.btnCorrenct10 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLVL = new System.Windows.Forms.Button();
            this.ttHomeBTN = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGuessTheWord
            // 
            this.lblGuessTheWord.AutoSize = true;
            this.lblGuessTheWord.BackColor = System.Drawing.Color.Transparent;
            this.lblGuessTheWord.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessTheWord.ForeColor = System.Drawing.Color.BurlyWood;
            this.lblGuessTheWord.Location = new System.Drawing.Point(94, 25);
            this.lblGuessTheWord.Name = "lblGuessTheWord";
            this.lblGuessTheWord.Size = new System.Drawing.Size(455, 48);
            this.lblGuessTheWord.TabIndex = 1;
            this.lblGuessTheWord.Text = "GUESS THE WORD!";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = global::Words_Game.Properties.Resources.RESETnormal;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(14, 580);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 56);
            this.btnReset.TabIndex = 2;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.btnReset_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnReset_MouseLeave);
            // 
            // btnMix
            // 
            this.btnMix.BackColor = System.Drawing.Color.Transparent;
            this.btnMix.BackgroundImage = global::Words_Game.Properties.Resources.MixNormal;
            this.btnMix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMix.FlatAppearance.BorderSize = 0;
            this.btnMix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMix.Location = new System.Drawing.Point(14, 522);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(122, 56);
            this.btnMix.TabIndex = 3;
            this.btnMix.UseVisualStyleBackColor = false;
            this.btnMix.Click += new System.EventHandler(this.btnMix_Click);
            this.btnMix.MouseEnter += new System.EventHandler(this.btnMix_MouseEnter);
            this.btnMix.MouseLeave += new System.EventHandler(this.btnMix_MouseLeave);
            // 
            // btnLetter6
            // 
            this.btnLetter6.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter6.BackgroundImage")));
            this.btnLetter6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter6.FlatAppearance.BorderSize = 0;
            this.btnLetter6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLetter6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetter6.Location = new System.Drawing.Point(438, 498);
            this.btnLetter6.Name = "btnLetter6";
            this.btnLetter6.Size = new System.Drawing.Size(51, 44);
            this.btnLetter6.TabIndex = 4;
            this.btnLetter6.Text = "6";
            this.btnLetter6.UseVisualStyleBackColor = false;
            this.btnLetter6.Click += new System.EventHandler(this.btnLetter6_Click);
            this.btnLetter6.MouseEnter += new System.EventHandler(this.btnLetter6_MouseEnter);
            this.btnLetter6.MouseLeave += new System.EventHandler(this.btnLetter6_MouseLeave);
            // 
            // btnLetter12
            // 
            this.btnLetter12.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter12.BackgroundImage")));
            this.btnLetter12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter12.FlatAppearance.BorderSize = 0;
            this.btnLetter12.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLetter12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter12.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetter12.Location = new System.Drawing.Point(438, 548);
            this.btnLetter12.Name = "btnLetter12";
            this.btnLetter12.Size = new System.Drawing.Size(51, 44);
            this.btnLetter12.TabIndex = 4;
            this.btnLetter12.Text = "12";
            this.btnLetter12.UseVisualStyleBackColor = false;
            this.btnLetter12.Click += new System.EventHandler(this.btnLetter12_Click);
            this.btnLetter12.MouseEnter += new System.EventHandler(this.btnLetter12_MouseEnter);
            this.btnLetter12.MouseLeave += new System.EventHandler(this.btnLetter12_MouseLeave);
            // 
            // btnLetter5
            // 
            this.btnLetter5.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter5.BackgroundImage")));
            this.btnLetter5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter5.FlatAppearance.BorderSize = 0;
            this.btnLetter5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLetter5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetter5.Location = new System.Drawing.Point(381, 498);
            this.btnLetter5.Name = "btnLetter5";
            this.btnLetter5.Size = new System.Drawing.Size(51, 44);
            this.btnLetter5.TabIndex = 4;
            this.btnLetter5.Text = "5";
            this.btnLetter5.UseVisualStyleBackColor = false;
            this.btnLetter5.Click += new System.EventHandler(this.btnLetter5_Click);
            this.btnLetter5.MouseEnter += new System.EventHandler(this.btnLetter5_MouseEnter);
            this.btnLetter5.MouseLeave += new System.EventHandler(this.btnLetter5_MouseLeave);
            // 
            // btnLetter11
            // 
            this.btnLetter11.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter11.BackgroundImage")));
            this.btnLetter11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter11.FlatAppearance.BorderSize = 0;
            this.btnLetter11.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLetter11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter11.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetter11.Location = new System.Drawing.Point(381, 548);
            this.btnLetter11.Name = "btnLetter11";
            this.btnLetter11.Size = new System.Drawing.Size(51, 44);
            this.btnLetter11.TabIndex = 4;
            this.btnLetter11.Text = "11";
            this.btnLetter11.UseVisualStyleBackColor = false;
            this.btnLetter11.Click += new System.EventHandler(this.btnLetter11_Click);
            this.btnLetter11.MouseEnter += new System.EventHandler(this.btnLetter11_MouseEnter);
            this.btnLetter11.MouseLeave += new System.EventHandler(this.btnLetter11_MouseLeave);
            // 
            // btnLetter4
            // 
            this.btnLetter4.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter4.BackgroundImage")));
            this.btnLetter4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter4.FlatAppearance.BorderSize = 0;
            this.btnLetter4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLetter4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetter4.Location = new System.Drawing.Point(324, 498);
            this.btnLetter4.Name = "btnLetter4";
            this.btnLetter4.Size = new System.Drawing.Size(51, 44);
            this.btnLetter4.TabIndex = 4;
            this.btnLetter4.Text = "4";
            this.btnLetter4.UseVisualStyleBackColor = false;
            this.btnLetter4.Click += new System.EventHandler(this.btnLetter4_Click);
            this.btnLetter4.MouseEnter += new System.EventHandler(this.btnLetter4_MouseEnter);
            this.btnLetter4.MouseLeave += new System.EventHandler(this.btnLetter4_MouseLeave);
            // 
            // btnLetter10
            // 
            this.btnLetter10.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter10.BackgroundImage")));
            this.btnLetter10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter10.FlatAppearance.BorderSize = 0;
            this.btnLetter10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLetter10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetter10.Location = new System.Drawing.Point(324, 548);
            this.btnLetter10.Name = "btnLetter10";
            this.btnLetter10.Size = new System.Drawing.Size(51, 44);
            this.btnLetter10.TabIndex = 4;
            this.btnLetter10.Text = "10";
            this.btnLetter10.UseVisualStyleBackColor = false;
            this.btnLetter10.Click += new System.EventHandler(this.btnLetter10_Click);
            this.btnLetter10.MouseEnter += new System.EventHandler(this.btnLetter10_MouseEnter);
            this.btnLetter10.MouseLeave += new System.EventHandler(this.btnLetter10_MouseLeave);
            // 
            // btnLetter3
            // 
            this.btnLetter3.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter3.BackgroundImage")));
            this.btnLetter3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter3.FlatAppearance.BorderSize = 0;
            this.btnLetter3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLetter3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetter3.Location = new System.Drawing.Point(267, 498);
            this.btnLetter3.Name = "btnLetter3";
            this.btnLetter3.Size = new System.Drawing.Size(51, 44);
            this.btnLetter3.TabIndex = 4;
            this.btnLetter3.Text = "3";
            this.btnLetter3.UseVisualStyleBackColor = false;
            this.btnLetter3.Click += new System.EventHandler(this.btnLetter3_Click);
            this.btnLetter3.MouseEnter += new System.EventHandler(this.btnLetter3_MouseEnter);
            this.btnLetter3.MouseLeave += new System.EventHandler(this.btnLetter3_MouseLeave);
            // 
            // btnLetter9
            // 
            this.btnLetter9.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter9.BackgroundImage")));
            this.btnLetter9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter9.FlatAppearance.BorderSize = 0;
            this.btnLetter9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLetter9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetter9.Location = new System.Drawing.Point(267, 548);
            this.btnLetter9.Name = "btnLetter9";
            this.btnLetter9.Size = new System.Drawing.Size(51, 44);
            this.btnLetter9.TabIndex = 4;
            this.btnLetter9.Text = "9";
            this.btnLetter9.UseVisualStyleBackColor = false;
            this.btnLetter9.Click += new System.EventHandler(this.btnLetter9_Click);
            this.btnLetter9.MouseEnter += new System.EventHandler(this.btnLetter9_MouseEnter);
            this.btnLetter9.MouseLeave += new System.EventHandler(this.btnLetter9_MouseLeave);
            // 
            // btnLetter2
            // 
            this.btnLetter2.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter2.BackgroundImage")));
            this.btnLetter2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter2.FlatAppearance.BorderSize = 0;
            this.btnLetter2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLetter2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetter2.Location = new System.Drawing.Point(210, 498);
            this.btnLetter2.Name = "btnLetter2";
            this.btnLetter2.Size = new System.Drawing.Size(51, 44);
            this.btnLetter2.TabIndex = 4;
            this.btnLetter2.Text = "2";
            this.btnLetter2.UseVisualStyleBackColor = false;
            this.btnLetter2.Click += new System.EventHandler(this.btnLetter2_Click);
            this.btnLetter2.MouseEnter += new System.EventHandler(this.btnLetter2_MouseEnter);
            this.btnLetter2.MouseLeave += new System.EventHandler(this.btnLetter2_MouseLeave);
            // 
            // btnLetter8
            // 
            this.btnLetter8.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter8.BackgroundImage")));
            this.btnLetter8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter8.FlatAppearance.BorderSize = 0;
            this.btnLetter8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLetter8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetter8.Location = new System.Drawing.Point(210, 548);
            this.btnLetter8.Name = "btnLetter8";
            this.btnLetter8.Size = new System.Drawing.Size(51, 44);
            this.btnLetter8.TabIndex = 4;
            this.btnLetter8.Text = "8";
            this.btnLetter8.UseVisualStyleBackColor = false;
            this.btnLetter8.Click += new System.EventHandler(this.btnLetter8_Click);
            this.btnLetter8.MouseEnter += new System.EventHandler(this.btnLetter8_MouseEnter);
            this.btnLetter8.MouseLeave += new System.EventHandler(this.btnLetter8_MouseLeave);
            // 
            // btnLetter1
            // 
            this.btnLetter1.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter1.BackgroundImage")));
            this.btnLetter1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter1.FlatAppearance.BorderSize = 0;
            this.btnLetter1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLetter1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetter1.Location = new System.Drawing.Point(153, 498);
            this.btnLetter1.Name = "btnLetter1";
            this.btnLetter1.Size = new System.Drawing.Size(51, 44);
            this.btnLetter1.TabIndex = 4;
            this.btnLetter1.Text = "1";
            this.btnLetter1.UseVisualStyleBackColor = false;
            this.btnLetter1.Click += new System.EventHandler(this.btnLetter1_Click);
            this.btnLetter1.MouseEnter += new System.EventHandler(this.btnLetter1_MouseEnter);
            this.btnLetter1.MouseLeave += new System.EventHandler(this.btnLetter1_MouseLeave);
            // 
            // btnLetter7
            // 
            this.btnLetter7.BackColor = System.Drawing.Color.Transparent;
            this.btnLetter7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLetter7.BackgroundImage")));
            this.btnLetter7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLetter7.FlatAppearance.BorderSize = 0;
            this.btnLetter7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLetter7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLetter7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetter7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetter7.Location = new System.Drawing.Point(153, 548);
            this.btnLetter7.Name = "btnLetter7";
            this.btnLetter7.Size = new System.Drawing.Size(51, 44);
            this.btnLetter7.TabIndex = 4;
            this.btnLetter7.Text = "7";
            this.btnLetter7.UseVisualStyleBackColor = false;
            this.btnLetter7.Click += new System.EventHandler(this.btnLetter7_Click);
            this.btnLetter7.MouseEnter += new System.EventHandler(this.btnLetter7_MouseEnter);
            this.btnLetter7.MouseLeave += new System.EventHandler(this.btnLetter7_MouseLeave);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::Words_Game.Properties.Resources.NEXTnormal;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(501, 515);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(138, 63);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnOK_Click);
            this.btnNext.MouseEnter += new System.EventHandler(this.btnNext_MouseEnter);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            // 
            // btnHint
            // 
            this.btnHint.BackColor = System.Drawing.Color.Transparent;
            this.btnHint.BackgroundImage = global::Words_Game.Properties.Resources.HINTnormal;
            this.btnHint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHint.FlatAppearance.BorderSize = 0;
            this.btnHint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHint.Location = new System.Drawing.Point(14, 463);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(122, 58);
            this.btnHint.TabIndex = 3;
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            this.btnHint.MouseEnter += new System.EventHandler(this.btnHint_MouseEnter);
            this.btnHint.MouseLeave += new System.EventHandler(this.btnHint_MouseLeave);
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.Transparent;
            this.pb.Location = new System.Drawing.Point(227, 129);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(190, 190);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // il
            // 
            this.il.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il.ImageStream")));
            this.il.TransparentColor = System.Drawing.Color.Transparent;
            this.il.Images.SetKeyName(0, "apple.png");
            this.il.Images.SetKeyName(1, "box.png");
            this.il.Images.SetKeyName(2, "chair.png");
            this.il.Images.SetKeyName(3, "dog.png");
            this.il.Images.SetKeyName(4, "door.png");
            this.il.Images.SetKeyName(5, "ice.png");
            this.il.Images.SetKeyName(6, "puppet.png");
            this.il.Images.SetKeyName(7, "tower.png");
            this.il.Images.SetKeyName(8, "watermelon.png");
            // 
            // btnCorrenct1
            // 
            this.btnCorrenct1.BackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCorrenct1.BackgroundImage")));
            this.btnCorrenct1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorrenct1.FlatAppearance.BorderSize = 0;
            this.btnCorrenct1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrenct1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrenct1.Location = new System.Drawing.Point(44, 393);
            this.btnCorrenct1.Name = "btnCorrenct1";
            this.btnCorrenct1.Size = new System.Drawing.Size(51, 44);
            this.btnCorrenct1.TabIndex = 4;
            this.btnCorrenct1.UseVisualStyleBackColor = false;
            this.btnCorrenct1.Visible = false;
            this.btnCorrenct1.Click += new System.EventHandler(this.btnCorrenct1_Click);
            this.btnCorrenct1.MouseEnter += new System.EventHandler(this.btnCorrenct1_MouseEnter);
            this.btnCorrenct1.MouseLeave += new System.EventHandler(this.btnCorrenct1_MouseLeave);
            // 
            // btnCorrenct2
            // 
            this.btnCorrenct2.BackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCorrenct2.BackgroundImage")));
            this.btnCorrenct2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorrenct2.FlatAppearance.BorderSize = 0;
            this.btnCorrenct2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrenct2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrenct2.Location = new System.Drawing.Point(101, 393);
            this.btnCorrenct2.Name = "btnCorrenct2";
            this.btnCorrenct2.Size = new System.Drawing.Size(51, 44);
            this.btnCorrenct2.TabIndex = 4;
            this.btnCorrenct2.UseVisualStyleBackColor = false;
            this.btnCorrenct2.Visible = false;
            this.btnCorrenct2.Click += new System.EventHandler(this.btnCorrenct2_Click);
            this.btnCorrenct2.MouseEnter += new System.EventHandler(this.btnCorrenct2_MouseEnter);
            this.btnCorrenct2.MouseLeave += new System.EventHandler(this.btnCorrenct2_MouseLeave);
            // 
            // btnCorrenct3
            // 
            this.btnCorrenct3.BackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCorrenct3.BackgroundImage")));
            this.btnCorrenct3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorrenct3.FlatAppearance.BorderSize = 0;
            this.btnCorrenct3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrenct3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrenct3.Location = new System.Drawing.Point(158, 393);
            this.btnCorrenct3.Name = "btnCorrenct3";
            this.btnCorrenct3.Size = new System.Drawing.Size(51, 44);
            this.btnCorrenct3.TabIndex = 4;
            this.btnCorrenct3.UseVisualStyleBackColor = false;
            this.btnCorrenct3.Visible = false;
            this.btnCorrenct3.Click += new System.EventHandler(this.btnCorrenct3_Click);
            this.btnCorrenct3.MouseEnter += new System.EventHandler(this.btnCorrenct3_MouseEnter);
            this.btnCorrenct3.MouseLeave += new System.EventHandler(this.btnCorrenct3_MouseLeave);
            // 
            // btnCorrenct4
            // 
            this.btnCorrenct4.BackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCorrenct4.BackgroundImage")));
            this.btnCorrenct4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorrenct4.FlatAppearance.BorderSize = 0;
            this.btnCorrenct4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrenct4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrenct4.Location = new System.Drawing.Point(215, 393);
            this.btnCorrenct4.Name = "btnCorrenct4";
            this.btnCorrenct4.Size = new System.Drawing.Size(51, 44);
            this.btnCorrenct4.TabIndex = 4;
            this.btnCorrenct4.UseVisualStyleBackColor = false;
            this.btnCorrenct4.Visible = false;
            this.btnCorrenct4.Click += new System.EventHandler(this.btnCorrenct4_Click);
            this.btnCorrenct4.MouseEnter += new System.EventHandler(this.btnCorrenct4_MouseEnter);
            this.btnCorrenct4.MouseLeave += new System.EventHandler(this.btnCorrenct4_MouseLeave);
            // 
            // btnCorrenct5
            // 
            this.btnCorrenct5.BackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCorrenct5.BackgroundImage")));
            this.btnCorrenct5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorrenct5.FlatAppearance.BorderSize = 0;
            this.btnCorrenct5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrenct5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrenct5.Location = new System.Drawing.Point(272, 393);
            this.btnCorrenct5.Name = "btnCorrenct5";
            this.btnCorrenct5.Size = new System.Drawing.Size(51, 44);
            this.btnCorrenct5.TabIndex = 4;
            this.btnCorrenct5.UseVisualStyleBackColor = false;
            this.btnCorrenct5.Visible = false;
            this.btnCorrenct5.Click += new System.EventHandler(this.btnCorrenct5_Click);
            this.btnCorrenct5.MouseEnter += new System.EventHandler(this.btnCorrenct5_MouseEnter);
            this.btnCorrenct5.MouseLeave += new System.EventHandler(this.btnCorrenct5_MouseLeave);
            // 
            // btnCorrenct6
            // 
            this.btnCorrenct6.BackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCorrenct6.BackgroundImage")));
            this.btnCorrenct6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorrenct6.FlatAppearance.BorderSize = 0;
            this.btnCorrenct6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrenct6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrenct6.Location = new System.Drawing.Point(330, 393);
            this.btnCorrenct6.Name = "btnCorrenct6";
            this.btnCorrenct6.Size = new System.Drawing.Size(51, 44);
            this.btnCorrenct6.TabIndex = 4;
            this.btnCorrenct6.UseVisualStyleBackColor = false;
            this.btnCorrenct6.Visible = false;
            this.btnCorrenct6.Click += new System.EventHandler(this.btnCorrenct6_Click);
            this.btnCorrenct6.MouseEnter += new System.EventHandler(this.btnCorrenct6_MouseEnter);
            this.btnCorrenct6.MouseLeave += new System.EventHandler(this.btnCorrenct6_MouseLeave);
            // 
            // btnCorrenct7
            // 
            this.btnCorrenct7.BackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCorrenct7.BackgroundImage")));
            this.btnCorrenct7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorrenct7.FlatAppearance.BorderSize = 0;
            this.btnCorrenct7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrenct7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrenct7.Location = new System.Drawing.Point(387, 393);
            this.btnCorrenct7.Name = "btnCorrenct7";
            this.btnCorrenct7.Size = new System.Drawing.Size(51, 44);
            this.btnCorrenct7.TabIndex = 4;
            this.btnCorrenct7.UseVisualStyleBackColor = false;
            this.btnCorrenct7.Visible = false;
            this.btnCorrenct7.Click += new System.EventHandler(this.btnCorrenct7_Click);
            this.btnCorrenct7.MouseEnter += new System.EventHandler(this.btnCorrenct7_MouseEnter);
            this.btnCorrenct7.MouseLeave += new System.EventHandler(this.btnCorrenct7_MouseLeave);
            // 
            // btnCorrenct8
            // 
            this.btnCorrenct8.BackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCorrenct8.BackgroundImage")));
            this.btnCorrenct8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorrenct8.FlatAppearance.BorderSize = 0;
            this.btnCorrenct8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrenct8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrenct8.Location = new System.Drawing.Point(444, 393);
            this.btnCorrenct8.Name = "btnCorrenct8";
            this.btnCorrenct8.Size = new System.Drawing.Size(51, 44);
            this.btnCorrenct8.TabIndex = 4;
            this.btnCorrenct8.UseVisualStyleBackColor = false;
            this.btnCorrenct8.Visible = false;
            this.btnCorrenct8.Click += new System.EventHandler(this.btnCorrenct8_Click);
            this.btnCorrenct8.MouseEnter += new System.EventHandler(this.btnCorrenct8_MouseEnter);
            this.btnCorrenct8.MouseLeave += new System.EventHandler(this.btnCorrenct8_MouseLeave);
            // 
            // btnCorrenct9
            // 
            this.btnCorrenct9.BackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCorrenct9.BackgroundImage")));
            this.btnCorrenct9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorrenct9.FlatAppearance.BorderSize = 0;
            this.btnCorrenct9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrenct9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrenct9.Location = new System.Drawing.Point(501, 393);
            this.btnCorrenct9.Name = "btnCorrenct9";
            this.btnCorrenct9.Size = new System.Drawing.Size(51, 44);
            this.btnCorrenct9.TabIndex = 4;
            this.btnCorrenct9.UseVisualStyleBackColor = false;
            this.btnCorrenct9.Visible = false;
            this.btnCorrenct9.Click += new System.EventHandler(this.btnCorrenct9_Click);
            this.btnCorrenct9.MouseEnter += new System.EventHandler(this.btnCorrenct9_MouseEnter);
            this.btnCorrenct9.MouseLeave += new System.EventHandler(this.btnCorrenct9_MouseLeave);
            // 
            // btnCorrenct10
            // 
            this.btnCorrenct10.BackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCorrenct10.BackgroundImage")));
            this.btnCorrenct10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorrenct10.FlatAppearance.BorderSize = 0;
            this.btnCorrenct10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCorrenct10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrenct10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrenct10.Location = new System.Drawing.Point(558, 393);
            this.btnCorrenct10.Name = "btnCorrenct10";
            this.btnCorrenct10.Size = new System.Drawing.Size(51, 44);
            this.btnCorrenct10.TabIndex = 4;
            this.btnCorrenct10.UseVisualStyleBackColor = false;
            this.btnCorrenct10.Visible = false;
            this.btnCorrenct10.Click += new System.EventHandler(this.btnCorrenct10_Click);
            this.btnCorrenct10.MouseEnter += new System.EventHandler(this.btnCorrenct10_MouseEnter);
            this.btnCorrenct10.MouseLeave += new System.EventHandler(this.btnCorrenct10_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::Words_Game.Properties.Resources.HomeNormal;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(569, 7);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 66);
            this.btnHome.TabIndex = 6;
            this.ttHomeBTN.SetToolTip(this.btnHome, "Home Button");
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.btnHome_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // btnLVL
            // 
            this.btnLVL.BackColor = System.Drawing.Color.Transparent;
            this.btnLVL.BackgroundImage = global::Words_Game.Properties.Resources.lvl;
            this.btnLVL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLVL.Enabled = false;
            this.btnLVL.FlatAppearance.BorderSize = 0;
            this.btnLVL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLVL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLVL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLVL.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLVL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLVL.Location = new System.Drawing.Point(6, 5);
            this.btnLVL.Name = "btnLVL";
            this.btnLVL.Size = new System.Drawing.Size(72, 71);
            this.btnLVL.TabIndex = 6;
            this.btnLVL.UseVisualStyleBackColor = false;
            // 
            // ttHomeBTN
            // 
            this.ttHomeBTN.AutoPopDelay = 1000;
            this.ttHomeBTN.InitialDelay = 100;
            this.ttHomeBTN.ReshowDelay = 500;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(651, 652);
            this.Controls.Add(this.btnLVL);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnLetter7);
            this.Controls.Add(this.btnLetter8);
            this.Controls.Add(this.btnLetter9);
            this.Controls.Add(this.btnLetter10);
            this.Controls.Add(this.btnLetter11);
            this.Controls.Add(this.btnLetter12);
            this.Controls.Add(this.btnCorrenct10);
            this.Controls.Add(this.btnCorrenct9);
            this.Controls.Add(this.btnCorrenct5);
            this.Controls.Add(this.btnCorrenct8);
            this.Controls.Add(this.btnCorrenct4);
            this.Controls.Add(this.btnCorrenct7);
            this.Controls.Add(this.btnCorrenct3);
            this.Controls.Add(this.btnCorrenct6);
            this.Controls.Add(this.btnCorrenct2);
            this.Controls.Add(this.btnCorrenct1);
            this.Controls.Add(this.btnLetter1);
            this.Controls.Add(this.btnLetter2);
            this.Controls.Add(this.btnLetter3);
            this.Controls.Add(this.btnLetter4);
            this.Controls.Add(this.btnLetter5);
            this.Controls.Add(this.btnLetter6);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnMix);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblGuessTheWord);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "League of Legends";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Label lblGuessTheWord;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMix;
        private System.Windows.Forms.Button btnLetter6;
        private System.Windows.Forms.Button btnLetter12;
        private System.Windows.Forms.Button btnLetter5;
        private System.Windows.Forms.Button btnLetter11;
        private System.Windows.Forms.Button btnLetter4;
        private System.Windows.Forms.Button btnLetter10;
        private System.Windows.Forms.Button btnLetter3;
        private System.Windows.Forms.Button btnLetter9;
        private System.Windows.Forms.Button btnLetter2;
        private System.Windows.Forms.Button btnLetter8;
        private System.Windows.Forms.Button btnLetter1;
        private System.Windows.Forms.Button btnLetter7;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.ImageList il;
        private System.Windows.Forms.Button btnCorrenct1;
        private System.Windows.Forms.Button btnCorrenct2;
        private System.Windows.Forms.Button btnCorrenct3;
        private System.Windows.Forms.Button btnCorrenct4;
        private System.Windows.Forms.Button btnCorrenct5;
        private System.Windows.Forms.Button btnCorrenct6;
        private System.Windows.Forms.Button btnCorrenct7;
        private System.Windows.Forms.Button btnCorrenct8;
        private System.Windows.Forms.Button btnCorrenct9;
        private System.Windows.Forms.Button btnCorrenct10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLVL;
        private System.Windows.Forms.ToolTip ttHomeBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}