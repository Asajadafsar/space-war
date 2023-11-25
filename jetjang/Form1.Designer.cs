namespace jetjang
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            player = new PictureBox();
            main_Timer = new System.Windows.Forms.Timer(components);
            CreatNewEnemy = new System.Windows.Forms.Timer(components);
            scoreLabel = new Label();
            overLBL = new Label();
            restartBTN = new Button();
            label_Score = new Label();
            Blood1 = new PictureBox();
            Blood2 = new PictureBox();
            Blood3 = new PictureBox();
            label_Power = new Label();
            showPower = new Label();
            label_enemy = new Label();
            showEnemyBlood = new Label();
            label_Record = new Label();
            recordLB = new Label();
            Start_Game = new Button();
            jet1 = new PictureBox();
            jet2 = new PictureBox();
            Bullet2 = new PictureBox();
            Bullet1 = new PictureBox();
            ghost = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Blood1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Blood2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Blood3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jet1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jet2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bullet2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bullet1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ghost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.Anchor = AnchorStyles.None;
            player.BackColor = Color.Transparent;
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(368, 429);
            player.Name = "player";
            player.Size = new Size(110, 110);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 0;
            player.TabStop = false;
            player.Tag = "player";
            // 
            // main_Timer
            // 
            main_Timer.Interval = 50;
            main_Timer.Tick += Main_Timer_Tick;
            // 
            // CreatNewEnemy
            // 
            CreatNewEnemy.Interval = 5000;
            CreatNewEnemy.Tick += CreatEnemyTimer_click;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = Color.Transparent;
            scoreLabel.Font = new Font("Sina", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLabel.ForeColor = Color.White;
            scoreLabel.Location = new Point(97, 9);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(21, 29);
            scoreLabel.TabIndex = 2;
            scoreLabel.Text = "0";
            // 
            // overLBL
            // 
            overLBL.Anchor = AnchorStyles.None;
            overLBL.AutoSize = true;
            overLBL.BackColor = Color.Transparent;
            overLBL.Font = new Font("Showcard Gothic", 72F, FontStyle.Bold, GraphicsUnit.Point);
            overLBL.ForeColor = Color.Brown;
            overLBL.Location = new Point(107, 203);
            overLBL.Name = "overLBL";
            overLBL.Size = new Size(635, 119);
            overLBL.TabIndex = 3;
            overLBL.Text = "GameOver:)";
            overLBL.Visible = false;
            // 
            // restartBTN
            // 
            restartBTN.Anchor = AnchorStyles.None;
            restartBTN.BackColor = Color.Yellow;
            restartBTN.FlatStyle = FlatStyle.Flat;
            restartBTN.Font = new Font("Aldhabi", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            restartBTN.ForeColor = SystemColors.ActiveCaption;
            restartBTN.Image = Properties.Resources._3663007;
            restartBTN.Location = new Point(368, 146);
            restartBTN.Name = "restartBTN";
            restartBTN.Size = new Size(110, 64);
            restartBTN.TabIndex = 4;
            restartBTN.Tag = "";
            restartBTN.Text = "RESTART";
            restartBTN.UseVisualStyleBackColor = false;
            restartBTN.Visible = false;
            restartBTN.Click += restartBTN_Click;
            // 
            // label_Score
            // 
            label_Score.AutoSize = true;
            label_Score.BackColor = Color.Transparent;
            label_Score.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_Score.ForeColor = Color.White;
            label_Score.Location = new Point(5, 9);
            label_Score.Name = "label_Score";
            label_Score.Size = new Size(103, 29);
            label_Score.TabIndex = 7;
            label_Score.Text = "Score : ";
            // 
            // Blood1
            // 
            Blood1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Blood1.BackColor = Color.Transparent;
            Blood1.Image = (Image)resources.GetObject("Blood1.Image");
            Blood1.Location = new Point(847, 12);
            Blood1.Name = "Blood1";
            Blood1.Size = new Size(29, 35);
            Blood1.SizeMode = PictureBoxSizeMode.StretchImage;
            Blood1.TabIndex = 8;
            Blood1.TabStop = false;
            // 
            // Blood2
            // 
            Blood2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Blood2.BackColor = Color.Transparent;
            Blood2.Image = (Image)resources.GetObject("Blood2.Image");
            Blood2.Location = new Point(803, 12);
            Blood2.Name = "Blood2";
            Blood2.Size = new Size(29, 35);
            Blood2.SizeMode = PictureBoxSizeMode.StretchImage;
            Blood2.TabIndex = 9;
            Blood2.TabStop = false;
            // 
            // Blood3
            // 
            Blood3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Blood3.BackColor = Color.Transparent;
            Blood3.Image = (Image)resources.GetObject("Blood3.Image");
            Blood3.Location = new Point(803, 59);
            Blood3.Name = "Blood3";
            Blood3.Size = new Size(29, 35);
            Blood3.SizeMode = PictureBoxSizeMode.StretchImage;
            Blood3.TabIndex = 10;
            Blood3.TabStop = false;
            // 
            // label_Power
            // 
            label_Power.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_Power.AutoSize = true;
            label_Power.BackColor = Color.Transparent;
            label_Power.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_Power.ForeColor = Color.Transparent;
            label_Power.Location = new Point(13, 79);
            label_Power.Name = "label_Power";
            label_Power.Size = new Size(0, 13);
            label_Power.TabIndex = 12;
            label_Power.Visible = false;
            // 
            // showPower
            // 
            showPower.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            showPower.AutoSize = true;
            showPower.BackColor = Color.Transparent;
            showPower.ForeColor = Color.White;
            showPower.Location = new Point(87, 79);
            showPower.Name = "showPower";
            showPower.Size = new Size(0, 15);
            showPower.TabIndex = 13;
            showPower.Visible = false;
            // 
            // label_enemy
            // 
            label_enemy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_enemy.AutoSize = true;
            label_enemy.BackColor = Color.Transparent;
            label_enemy.ForeColor = Color.White;
            label_enemy.Location = new Point(13, 53);
            label_enemy.Name = "label_enemy";
            label_enemy.Size = new Size(0, 15);
            label_enemy.TabIndex = 14;
            label_enemy.Visible = false;
            // 
            // showEnemyBlood
            // 
            showEnemyBlood.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            showEnemyBlood.AutoSize = true;
            showEnemyBlood.BackColor = Color.Transparent;
            showEnemyBlood.ForeColor = Color.White;
            showEnemyBlood.Location = new Point(101, 53);
            showEnemyBlood.Name = "showEnemyBlood";
            showEnemyBlood.Size = new Size(0, 15);
            showEnemyBlood.TabIndex = 15;
            showEnemyBlood.Visible = false;
            // 
            // label_Record
            // 
            label_Record.AutoSize = true;
            label_Record.BackColor = Color.Transparent;
            label_Record.Font = new Font("B Sina", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Record.ForeColor = Color.White;
            label_Record.Location = new Point(134, 1);
            label_Record.Name = "label_Record";
            label_Record.Size = new Size(121, 41);
            label_Record.TabIndex = 18;
            label_Record.Text = "+socre:";
            // 
            // recordLB
            // 
            recordLB.AutoSize = true;
            recordLB.BackColor = Color.Transparent;
            recordLB.Font = new Font("B Kourosh", 18F, FontStyle.Bold, GraphicsUnit.Point);
            recordLB.ForeColor = Color.White;
            recordLB.Location = new Point(261, 2);
            recordLB.Name = "recordLB";
            recordLB.Size = new Size(23, 36);
            recordLB.TabIndex = 17;
            recordLB.Text = "0";
            // 
            // Start_Game
            // 
            Start_Game.Anchor = AnchorStyles.None;
            Start_Game.BackColor = Color.FromArgb(255, 128, 0);
            Start_Game.FlatStyle = FlatStyle.Flat;
            Start_Game.Font = new Font("Broadway", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Start_Game.ForeColor = SystemColors.ButtonHighlight;
            Start_Game.Image = Properties.Resources._3663007;
            Start_Game.Location = new Point(340, 325);
            Start_Game.Name = "Start_Game";
            Start_Game.Size = new Size(165, 41);
            Start_Game.TabIndex = 19;
            Start_Game.Text = "Starat";
            Start_Game.UseVisualStyleBackColor = false;
            Start_Game.Click += Start_Game_Click;
            // 
            // jet1
            // 
            jet1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            jet1.BackColor = Color.Transparent;
            jet1.Image = Properties.Resources.player_2;
            jet1.Location = new Point(799, 347);
            jet1.Name = "jet1";
            jet1.Size = new Size(73, 66);
            jet1.SizeMode = PictureBoxSizeMode.StretchImage;
            jet1.TabIndex = 20;
            jet1.TabStop = false;
            jet1.Tag = "Selected";
            jet1.Click += jets_click;
            // 
            // jet2
            // 
            jet2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            jet2.BackColor = Color.Transparent;
            jet2.Image = Properties.Resources.player;
            jet2.Location = new Point(803, 275);
            jet2.Name = "jet2";
            jet2.Size = new Size(73, 66);
            jet2.SizeMode = PictureBoxSizeMode.StretchImage;
            jet2.TabIndex = 21;
            jet2.TabStop = false;
            jet2.Click += jets_click;
            // 
            // Bullet2
            // 
            Bullet2.BackColor = Color.Transparent;
            Bullet2.Image = (Image)resources.GetObject("Bullet2.Image");
            Bullet2.Location = new Point(12, 108);
            Bullet2.Name = "Bullet2";
            Bullet2.Size = new Size(32, 32);
            Bullet2.SizeMode = PictureBoxSizeMode.StretchImage;
            Bullet2.TabIndex = 24;
            Bullet2.TabStop = false;
            Bullet2.Click += Bullets_click;
            // 
            // Bullet1
            // 
            Bullet1.BackColor = Color.Transparent;
            Bullet1.Image = (Image)resources.GetObject("Bullet1.Image");
            Bullet1.Location = new Point(12, 146);
            Bullet1.Name = "Bullet1";
            Bullet1.Size = new Size(32, 32);
            Bullet1.SizeMode = PictureBoxSizeMode.StretchImage;
            Bullet1.TabIndex = 25;
            Bullet1.TabStop = false;
            Bullet1.Tag = "Selected";
            Bullet1.Click += Bullets_click;
            // 
            // ghost
            // 
            ghost.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ghost.BackColor = Color.Transparent;
            ghost.Image = Properties.Resources.ghost;
            ghost.Location = new Point(839, 59);
            ghost.Name = "ghost";
            ghost.Size = new Size(37, 41);
            ghost.SizeMode = PictureBoxSizeMode.StretchImage;
            ghost.TabIndex = 26;
            ghost.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Image = Properties.Resources._3663007;
            label1.Location = new Point(339, 369);
            label1.Name = "label1";
            label1.Size = new Size(166, 50);
            label1.TabIndex = 27;
            label1.Text = "to game";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._5;
            pictureBox1.Location = new Point(451, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(290, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 104);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(608, 20);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(109, 104);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 561);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(ghost);
            Controls.Add(Bullet1);
            Controls.Add(Bullet2);
            Controls.Add(jet2);
            Controls.Add(jet1);
            Controls.Add(Start_Game);
            Controls.Add(recordLB);
            Controls.Add(label_Record);
            Controls.Add(showEnemyBlood);
            Controls.Add(label_enemy);
            Controls.Add(showPower);
            Controls.Add(label_Power);
            Controls.Add(Blood3);
            Controls.Add(Blood2);
            Controls.Add(Blood1);
            Controls.Add(scoreLabel);
            Controls.Add(label_Score);
            Controls.Add(restartBTN);
            Controls.Add(overLBL);
            Controls.Add(player);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            Text = "jet_afsar_jamkarani";
            WindowState = FormWindowState.Maximized;
            KeyDown += Form1_KeyDown;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Blood1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Blood2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Blood3).EndInit();
            ((System.ComponentModel.ISupportInitialize)jet1).EndInit();
            ((System.ComponentModel.ISupportInitialize)jet2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bullet2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bullet1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ghost).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player;
        private System.Windows.Forms.Timer main_Timer;
        private System.Windows.Forms.Timer CreatNewEnemy;
        private Label scoreLabel;
        private Label overLBL;
        private Button restartBTN;
        private Label label_Score;
        private PictureBox Blood1;
        private PictureBox Blood2;
        private PictureBox Blood3;
        private Label label_Power;
        private Label showPower;
        private Label label_enemy;
        private Label showEnemyBlood;
        private Label label_Record;
        private Label recordLB;
        private Button Start_Game;
        private PictureBox jet1;
        private PictureBox jet2;
        private PictureBox Bullet2;
        private PictureBox Bullet1;
        private PictureBox ghost;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}