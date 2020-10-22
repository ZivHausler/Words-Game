namespace Words_Game
{
    partial class Guess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guess));
            this.lblOpenTitle = new System.Windows.Forms.Label();
            this.ttGameInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pbQuestionMark = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionMark)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOpenTitle
            // 
            this.lblOpenTitle.AutoSize = true;
            this.lblOpenTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblOpenTitle.Font = new System.Drawing.Font("Ravie", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenTitle.ForeColor = System.Drawing.Color.BurlyWood;
            this.lblOpenTitle.Location = new System.Drawing.Point(61, 78);
            this.lblOpenTitle.Name = "lblOpenTitle";
            this.lblOpenTitle.Size = new System.Drawing.Size(433, 86);
            this.lblOpenTitle.TabIndex = 0;
            this.lblOpenTitle.Text = "Welcome!";
            this.lblOpenTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ttGameInfo
            // 
            this.ttGameInfo.AutoPopDelay = 5000;
            this.ttGameInfo.InitialDelay = 300;
            this.ttGameInfo.IsBalloon = true;
            this.ttGameInfo.ReshowDelay = 50;
            this.ttGameInfo.ToolTipTitle = "Information:";
            // 
            // pbQuestionMark
            // 
            this.pbQuestionMark.Image = ((System.Drawing.Image)(resources.GetObject("pbQuestionMark.Image")));
            this.pbQuestionMark.Location = new System.Drawing.Point(12, 444);
            this.pbQuestionMark.Name = "pbQuestionMark";
            this.pbQuestionMark.Size = new System.Drawing.Size(88, 84);
            this.pbQuestionMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQuestionMark.TabIndex = 2;
            this.pbQuestionMark.TabStop = false;
            this.ttGameInfo.SetToolTip(this.pbQuestionMark, "This is a guessing game. \r\nJust fill in the letters matching to the image descrip" +
        "tion.");
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Words_Game.Properties.Resources.ExitNormalNew;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(274, 269);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(223, 85);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = global::Words_Game.Properties.Resources.StartNormal;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(45, 269);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(223, 85);
            this.btnStart.TabIndex = 1;
            this.btnStart.TabStop = false;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.btnStart_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            // 
            // Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(539, 540);
            this.Controls.Add(this.pbQuestionMark);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblOpenTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Guess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess Welcome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Guess_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpenTitle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbQuestionMark;
        private System.Windows.Forms.ToolTip ttGameInfo;
    }
}

