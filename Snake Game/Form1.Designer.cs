namespace Snake_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblNameGame = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPause = new System.Windows.Forms.Label();
            this.lblNewGame = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNightmare = new System.Windows.Forms.Label();
            this.tbEasy = new System.Windows.Forms.Label();
            this.bntSwitch = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Mute = new System.Windows.Forms.PictureBox();
            this.Sound = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(900, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 53);
            this.label1.TabIndex = 5;
            this.label1.Text = "SCORE:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Mistral", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(1071, 377);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(83, 53);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "100";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            // 
            // lblNameGame
            // 
            this.lblNameGame.AutoSize = true;
            this.lblNameGame.Font = new System.Drawing.Font("Mistral", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameGame.ForeColor = System.Drawing.Color.Red;
            this.lblNameGame.Location = new System.Drawing.Point(955, 303);
            this.lblNameGame.Name = "lblNameGame";
            this.lblNameGame.Size = new System.Drawing.Size(288, 57);
            this.lblNameGame.TabIndex = 8;
            this.lblNameGame.Text = "Snake World !!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(910, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 53);
            this.label2.TabIndex = 10;
            this.label2.Text = "TIME:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Mistral", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(1053, 430);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(115, 53);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "00:01";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lblPause);
            this.panel1.Controls.Add(this.lblNewGame);
            this.panel1.Controls.Add(this.lblDashboard);
            this.panel1.Controls.Add(this.lblHelp);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 43);
            this.panel1.TabIndex = 1;
            // 
            // lblPause
            // 
            this.lblPause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPause.AutoSize = true;
            this.lblPause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPause.Font = new System.Drawing.Font("Minion Pro", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.Location = new System.Drawing.Point(164, 5);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(81, 32);
            this.lblPause.TabIndex = 5;
            this.lblPause.Text = "PAUSE";
            this.lblPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPause.Click += new System.EventHandler(this.lblPause_Click);
            // 
            // lblNewGame
            // 
            this.lblNewGame.AutoSize = true;
            this.lblNewGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNewGame.Font = new System.Drawing.Font("Minion Pro", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewGame.Location = new System.Drawing.Point(12, 5);
            this.lblNewGame.Name = "lblNewGame";
            this.lblNewGame.Size = new System.Drawing.Size(136, 32);
            this.lblNewGame.TabIndex = 4;
            this.lblNewGame.Text = "NEW GAME";
            this.lblNewGame.Click += new System.EventHandler(this.lblNewGame_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDashboard.Font = new System.Drawing.Font("Minion Pro", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(280, 5);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(186, 32);
            this.lblDashboard.TabIndex = 2;
            this.lblDashboard.Text = "HIGHEST SCORE";
            this.lblDashboard.Click += new System.EventHandler(this.lblDashboard_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHelp.Font = new System.Drawing.Font("Minion Pro", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.Location = new System.Drawing.Point(490, 5);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(70, 32);
            this.lblHelp.TabIndex = 1;
            this.lblHelp.Text = "HELP";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1071, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 53);
            this.label3.TabIndex = 14;
            this.label3.Text = "15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(900, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 53);
            this.label4.TabIndex = 15;
            this.label4.Text = "SPEED:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(900, 532);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 53);
            this.label5.TabIndex = 17;
            this.label5.Text = "MODE:";
            // 
            // tbNightmare
            // 
            this.tbNightmare.AutoSize = true;
            this.tbNightmare.Font = new System.Drawing.Font("Mistral", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNightmare.ForeColor = System.Drawing.Color.DarkViolet;
            this.tbNightmare.Location = new System.Drawing.Point(1056, 529);
            this.tbNightmare.Name = "tbNightmare";
            this.tbNightmare.Size = new System.Drawing.Size(159, 48);
            this.tbNightmare.TabIndex = 20;
            this.tbNightmare.Text = "NightMare";
            this.tbNightmare.Visible = false;
            // 
            // tbEasy
            // 
            this.tbEasy.AllowDrop = true;
            this.tbEasy.AutoSize = true;
            this.tbEasy.Font = new System.Drawing.Font("Mistral", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEasy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbEasy.Location = new System.Drawing.Point(1085, 529);
            this.tbEasy.Name = "tbEasy";
            this.tbEasy.Size = new System.Drawing.Size(85, 48);
            this.tbEasy.TabIndex = 19;
            this.tbEasy.Text = "Easy";
            // 
            // bntSwitch
            // 
            this.bntSwitch.AutoSize = true;
            this.bntSwitch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntSwitch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bntSwitch.Font = new System.Drawing.Font("Minion Pro", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSwitch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bntSwitch.Location = new System.Drawing.Point(974, 595);
            this.bntSwitch.Name = "bntSwitch";
            this.bntSwitch.Size = new System.Drawing.Size(194, 46);
            this.bntSwitch.TabIndex = 5;
            this.bntSwitch.Text = "Switch Mode";
            this.bntSwitch.Click += new System.EventHandler(this.bntSwitch_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Snake_Game.Properties.Resources.Swap;
            this.pictureBox2.Location = new System.Drawing.Point(900, 595);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // Mute
            // 
            this.Mute.Image = global::Snake_Game.Properties.Resources.Mute;
            this.Mute.Location = new System.Drawing.Point(1209, 608);
            this.Mute.Name = "Mute";
            this.Mute.Size = new System.Drawing.Size(59, 66);
            this.Mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mute.TabIndex = 13;
            this.Mute.TabStop = false;
            this.Mute.Visible = false;
            this.Mute.Click += new System.EventHandler(this.Mute_Click);
            // 
            // Sound
            // 
            this.Sound.BackColor = System.Drawing.Color.White;
            this.Sound.Image = global::Snake_Game.Properties.Resources.Sound;
            this.Sound.Location = new System.Drawing.Point(1181, 592);
            this.Sound.Name = "Sound";
            this.Sound.Size = new System.Drawing.Size(103, 98);
            this.Sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Sound.TabIndex = 12;
            this.Sound.TabStop = false;
            this.Sound.Click += new System.EventHandler(this.Sound_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Snake_Game.Properties.Resources.Snake;
            this.pictureBox1.Location = new System.Drawing.Point(900, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.DimGray;
            this.pbCanvas.Location = new System.Drawing.Point(0, 42);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(894, 666);
            this.pbCanvas.TabIndex = 4;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1287, 711);
            this.Controls.Add(this.bntSwitch);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbEasy);
            this.Controls.Add(this.tbNightmare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Mute);
            this.Controls.Add(this.Sound);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNameGame);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCanvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SnakeGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblNameGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblNewGame;
        private System.Windows.Forms.PictureBox Sound;
        private System.Windows.Forms.PictureBox Mute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tbNightmare;
        private System.Windows.Forms.Label tbEasy;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label bntSwitch;
        private System.Windows.Forms.Label lblPause;
    }
}

