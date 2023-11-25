using System;
using System.Diagnostics.Eventing.Reader;
//reading roydad
using System.IO;
//creat file txt
using System.Media;
using System.Windows.Forms;

namespace jetjang
{
    public partial class Form1 : Form
    {
        int score = 0;
        Random rnd = new Random();
        int enemySpeed = 5;
        int blood = 3;
        int shotIndex = 0;
        int ghostTime = 0;
        int enemyIndex = 0;
        bool gameStop = true;
        int nextScore = 20;
        int aslenemy = 2;
        bool isDay = true;
        int enemyBlood = 1;
        int hadaksarenemy = 5;
        int shotPower = 1;
        int scoreasli;
        PictureBox last_Bullet;
        PictureBox last_jet;

        public Form1()
        {
            InitializeComponent();
            //مقداردهی اولیه و تنظیم اجزای بصری فرم شما مانند دکمه ها، برچسب ها، کادرهای متن و غیره را بر عهده دارد

            this.KeyPreview = true;
            //همه چیز ترو است تا کلیک شود
            scoreasli = Convert.ToInt32(File.ReadAllText("SaveScore.txt"));
            recordLB.Text = scoreasli.ToString();
            last_Bullet = Bullet1;
            last_jet = jet1;
            scoreLabel.Focus();

        }

        private void GameOver()
        {
            if (score > scoreasli)
            //رکورد بیشتر از امتیاز اصلی بود
            {
                scoreasli = score;
                File.WriteAllText("SaveScore.txt", Convert.ToString(score));
                //یک فایلی ایجاد کن و بریز توش امتیاز رکورد را و به حالت رشته
                recordLB.Text = score.ToString();
            }
            change_blood();
            player.Image = Properties.Resources.explosion;
            //بازیکن را برابر با انفجار قرار میدهی
            main_Timer.Stop();
            CreatNewEnemy.Stop();
            overLBL.Visible = true;
            restartBTN.Visible = true;
            gameStop = true;


        }

        private bool checkCollision(PictureBox img1, string name)
        {
            PictureBox changeImg2;
            foreach (Control img2 in this.Controls)
            {
                if (img1.Bounds.IntersectsWith(img2.Bounds) && img2.Name.Contains(name))
                // آیا مرزهای یک کنترل با مرزهای یک کنترل دیگر تلاقی دارند یا خیر. این متد متعلق به کلاس Control است
                //توجه داشته باشید که ویژگی Bounds یک کنترل، اندازه و مکان کنترل را نسبت به ظرف اصلی آن نشان می دهد.
                //قطعی مرز
                //Contains =havi
                {
                    if (name != "player")
                    {
                        changeImg2 = (PictureBox)img2;
                        changeImg2.Image = Properties.Resources.explosion;
                        changeImg2.SizeMode = PictureBoxSizeMode.StretchImage;
                        changeImg2.Size = new Size(50, 50);
                        changeImg2.Name = "remove" + shotIndex;
                        changeImg2.BringToFront();
                        //آن را به جلوی مرتبه z بیاوریم.
                    }
                    return true;
                }
            }

            return false;
        }


        /* private void show_SelectScreen()
         //برای صفحه نمایش هواپیما ها
         {

             foreach (Control jets in this.Controls)
             {
                 if (jets is PictureBox && (jets.Name.Contains("jet") || jets.Name.Contains("Bullet")))
                 {

                     jets.Visible = false;

                 }
             }

         }*/


        private int getRandomInt(int s, int a)
        {

            int randomNumber = rnd.Next(s, a);
            return randomNumber;
        }


        private void createEnemy()
        {
            int numberenememy = getRandomInt(aslenemy, hadaksarenemy);
            for (int i = 0; i < numberenememy; i++)
            {
                PictureBox enemyImage = new PictureBox();
                int wenemy = getRandomInt(1, 4);
                if (wenemy == 1)
                {
                    enemyImage.Image = Properties.Resources.enemy1;
                    enemyImage.Size = new Size(107, 74);
                }
                else if (wenemy == 2)
                {
                    enemyImage.Image = Properties.Resources.enemy2;
                    enemyImage.Size = new Size(68, 88);

                }
                else
                {
                    enemyImage.Image = Properties.Resources.enemy3;
                    enemyImage.Size = new Size(84, 68);
                }

                int minX = (player.Location.X - 250 > 0) ? player.Location.X - 250 : 0;
                int maxX = (player.Location.X + 250 < this.Width) ? player.Location.X + 250 : this.Width;

                enemyImage.Location = new Point(getRandomInt(minX, maxX), getRandomInt(-1600, -100));
                enemyImage.SizeMode = PictureBoxSizeMode.StretchImage;

                enemyImage.BackColor = Color.Transparent;
                enemyImage.Name = "enemy " + enemyIndex;
                enemyImage.Tag = "" + enemyBlood;
                enemyIndex++;
                Controls.Add(enemyImage);
                //کنترل دکمه را به مجموعه کنترل های فرم اضافه می کرد
                //  باید مکان و ویژگی های اندازه کنترل را تنظیم کرد تا به درستی آن را در فرم قرار دهیم
            }
        }


        private void creatButifulShape()
        {
            PictureBox shape = new PictureBox();
            shape.Location = new Point(getRandomInt(100, this.Width - 100), getRandomInt(-300, -100));
            shape.BackColor = Color.Transparent;
            shape.SizeMode = PictureBoxSizeMode.StretchImage;
            int randomShape = getRandomInt(1, 6);
            shape.Image = Properties.Resources.star;
            shape.Size = new Size(20, 20);
            shape.Name = "shape " + enemyIndex;
            shape.Tag = "Minus";

            if (randomShape == 1)
            {
                shape.Tag = "Star";
            }
            else if (randomShape == 2)
            {
                shape.Image = Properties.Resources.space;
                shape.Size = new Size(100, 100);
            }
            else if (randomShape == 3)
            {
                shape.Image = Properties.Resources.shoot_powerFull;
                shape.Size = new Size(50, 50);
                shape.Tag = "Power";
            }
            else if (randomShape == 4)
            {
                shape.Image = Properties.Resources.mahware;
                shape.Size = new Size(200, 150);
            }
            else if (randomShape == 5 && blood < 3)
            {
                shape.Image = Properties.Resources.Blood;
                shape.Size = new Size(40, 50);
                shape.Tag = "Blood";
            }
            else
            {
                shape.Tag = "Star";
            }

            shape.BringToFront();
            this.Controls.Add(shape);
        }


        private void creat_Shot(int playerX, int playerY)
        {
            SoundPlayer playerSound = new SoundPlayer("laser.wav");
            playerSound.Play();
            PictureBox shotImg = new PictureBox();
            shotImg.Image = last_Bullet.Image;
            shotImg.Location = new Point(playerX + (player.Size.Width / 2), playerY);
            shotImg.SizeMode = PictureBoxSizeMode.StretchImage;
            shotImg.Size = new Size(20, 20);
            shotImg.BackColor = Color.Transparent;
            shotImg.Name = "shot" + shotIndex;
            shotImg.Tag = "" + shotPower;

            Controls.Add(shotImg);
        }


        private bool checkGameOver(Control ctrl)
        {
            if (player.Bounds.IntersectsWith(ctrl.Bounds) && ghostTime == 0)
            {

                blood--;
                if (blood == 0)
                {
                    GameOver();
                    return true;
                }
                else
                {
                    PictureBox thisPicture = (PictureBox)ctrl;
                    thisPicture.Image = Properties.Resources.explosion;
                    ghostTime = 60;
                    ghost.Visible = true;
                    change_blood();
                }
            }
            return false;
        }


        private void change_blood()
        {

            Blood1.Visible = false;
            Blood2.Visible = false;
            Blood3.Visible = false;

            if (blood >= 1)
            {
                Blood1.Visible = true;
            }
            if (blood >= 2)
            {
                Blood2.Visible = true;
            }
            if (blood >= 3)
            {
                Blood3.Visible = true;
            }

        }


        private void enemyFanc(int picturX, int picturY, Control picture)
        {

            PictureBox thisPicture = (PictureBox)picture;
            picture.Location = new Point(picturX, picturY + enemySpeed);

            //بررسی تصادف

            if (checkCollision((PictureBox)picture, "shot"))
            {
                int thisJetBlood = Convert.ToInt32(picture.Tag) - shotPower;

                if (thisJetBlood <= 0)
                {

                    thisPicture.Image = Properties.Resources.explosion;
                    thisPicture.Size = new Size(150, 150);
                    score_Func(score + 2);
                    thisPicture.Name = "fake" + enemyIndex;

                }
                else
                {
                    picture.Tag = Convert.ToString(thisJetBlood);
                }

            }


            if (picture.Location.Y > this.Height)
            {
                this.Controls.Remove(picture);
                score_Func(score + 1);
            }

        }


        private void shapeFunc(Control picture)
        {
            picture.Location = new Point(picture.Location.X, picture.Location.Y + 4);
            if (checkCollision((PictureBox)picture, "shot") || checkCollision((PictureBox)picture, "player"))
            {
                if (picture.Tag == "Star")
                {
                    score += 5;
                }
                else if (picture.Tag == "Blood")
                {
                    blood++;
                    change_blood();
                }
                else if (picture.Tag == "Power")
                {
                    shotPower++;
                    /*        showPower.Text = "" + shotPower;*/
                }
                else
                {
                    score--;
                }
                score_Func(score);
                this.Controls.Remove(picture);
            }

            if (picture.Location.Y > this.Height)
            {
                this.Controls.Remove(picture);
            }
        }


        private void change_Back()
        {
            isDay = !isDay;
            if (isDay)
            {
                this.BackgroundImage = Properties.Resources.Back_Night;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.Back_Day;
            }

        }


        private void score_Func(int num)
        {

            score = num;
            scoreLabel.Text = score + "";
            if (score >= nextScore)
            {
                change_Back();
                if (hadaksarenemy < 20)
                {
                    hadaksarenemy++;
                    hadaksarenemy++;
                    //دو بار حداکثر ش رو برای عوض کردن بک گراند پلاس پلاس میکنم
                }
                enemyBlood++;
                //hard enemy
                // showEnemyBlood.Text = enemyBlood + "";
                nextScore += 20;
            }
        }


        private void AiCiller()
        {
            /*  int XPlace;
              foreach (Control enemy in this.Controls)
              {
                  if (enemy.Name.Contains("enemy"))
                  {
                      XPlace = enemy.Location.X;
                      player.Location = new Point(XPlace, player.Location.Y);
                      creat_Shot(XPlace, player.Location.Y);
                  }
              }*/
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!gameStop)
            //یک بولین برای چک کردن بازی و فالس هستش که شرط اجرا میشه
            {
                int playerX = player.Location.X;
                int playerY = player.Location.Y;
                //گرفتن لوکیشن بازیکن که بر اساس محور ایکس و ایگری
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                {
                    if (e.KeyCode == Keys.Left && playerX >= 0)
                    //اگر علامت بزرگ مساوی به سمت محور ایکس نباشد بازیکن حرکت نمیکند
                    //برای عدم خارج شدن از کادر نوشته شده که بزرگتر از صفر باشد یا عددی دیگر
                    {
                        playerX -= 10;
                        player.Location = new Point(playerX, playerY);
                    }
                    else if (e.KeyCode == Keys.Right && playerX + 135 <= this.Width)
                    //از 125 به بالا برای بازیکن محور ایکس مشکلی ایجاد نمیکنه
                    {
                        playerX += 10;
                        player.Location = new Point(playerX, playerY);
                    }
                   /* else if (e.KeyCode == Keys.Left  playerX = -10 )
                    {
                        playerX = 135;
                        player.Location = new Point(playerX, playerY);
                    }
                    else if(e.KeyCode == Keys.Right && playerX = 145)
                    {
                        playerX = 0;
                        player.Location = new Point(playerX, playerY);
                    }*/
                }
                /*    if (e.KeyCode == Keys.Right)
                    {
                        // move right
                        playerX += 100;
                        player.Location = new Point(playerX, playerY);
                    }
                    else if (e.KeyCode == Keys.Left)
                    {
                        //move left
                        playerX -= 100;
                        player.Location = new Point(playerX, playerY);
                    }
    */
                else if (e.KeyCode == Keys.Space)
                {
                    creat_Shot(playerX, playerY);
                }
                else if (e.KeyCode == Keys.G)
                {
                    ghost.Visible = true;
                    ghostTime = 50;
                }
                else if (e.KeyCode == Keys.B)
                {
                    blood = 3;
                    change_blood();
                }
                /*else if (e.KeyCode == Keys.A)
                {
                    AiCiller();
                }*/
                /* else if (e.KeyCode == Keys.P)
                 {
                     shotPower++;
                     showPower.Text = shotPower.ToString();
                 }*/
            }

        }



        private void restartBTN_Click(object sender, EventArgs e)
        {
            Application.Restart();
            //دستور نیاز برای ریستارت
        }



        private void Main_Timer_Tick(object sender, EventArgs e)
        {
            int picturX = 0;
            int picturY = 0;

            foreach (Control picture in this.Controls)
            {
                if (picture is PictureBox)
                {
                    picturX = picture.Location.X;
                    picturY = picture.Location.Y;

                    if (picture.Name.Contains("shot"))
                    {
                        picture.Location = new Point(picture.Location.X, picturY - 25);
                        if (picture.Location.Y < 0)
                        {
                            this.Controls.Remove(picture);
                        }
                    }

                    else if (picture.Name.Contains("fake"))
                    {
                        picture.Location = new Point(picturX, picturY + 20);
                        if (picture.Location.Y > this.Height)
                        {
                            this.Controls.Remove(picture);
                        }
                    }


                    else if (picture.Name.Contains("enemy"))
                    {
                        enemyFanc(picturX, picturY, picture);
                        if (checkGameOver(picture))
                        {
                            break;
                        }
                    }

                    else if (picture.Name.Contains("shape"))
                    {
                        shapeFunc(picture);
                    }

                    else if (picture.Name.Contains("remove"))
                    {
                        this.Controls.Remove(picture);
                    }

                }
            }


            if (ghostTime != 0)
            {
                ghostTime--;
            }
            else if (ghostTime == 0 && ghost.Visible == true && !gameStop)
            {
                ghost.Visible = false;
            }

        }



        private void CreatEnemyTimer_click(object sender, EventArgs e)
        {
            enemySpeed += 1;
            //هر دفعه سرعت دشمن را بیشتر کن
            score_Func(score++);
            //توی تابع امتیاز ،امتیاز را پلاس پلاس کن

            if (score % 3 == 0)
            //زمان بیشتری برای ایجاد شکل
            {
                creatButifulShape();
            }

            createEnemy();
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            player.Location = new Point(player.Location.X, this.Height - 150);
            //siaze the player
        }


        private void Start_Game_Click(object sender, EventArgs e)
        {
            main_Timer.Start();
            CreatNewEnemy.Start();
            scoreLabel.Focus();
            Start_Game.Visible = false;
            gameStop = false;
            /* show_SelectScreen();*/
            label1.Visible = false;
        }


        private void jets_click(object sender, EventArgs e)
        {
            PictureBox jet_Picture = (PictureBox)sender;
            last_jet.BackColor = Color.Transparent;
            jet_Picture.BackColor = Color.Silver;
            last_jet = jet_Picture;
            player.Image = jet_Picture.Image;

        }


        private void Bullets_click(object sender, EventArgs e)
        {
            PictureBox Bullet_Picture = (PictureBox)sender;
            last_Bullet.BackColor = Color.Transparent;
            Bullet_Picture.BackColor = Color.Silver;
            last_Bullet = Bullet_Picture;
        }
    }
}