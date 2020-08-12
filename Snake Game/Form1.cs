using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class Form1 : Form
    {
        //Initalize a snake, foods
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        //list of food
        List<Image> Food = new List<Image>();
        Image image1 = Snake_Game.Properties.Resources.apple_fruit;
        Image image2 = Snake_Game.Properties.Resources.banana_fruit;
        Image image3 = Snake_Game.Properties.Resources.orange_fruit;
        Image image4 = Snake_Game.Properties.Resources.strawberry_fruit;
        Image image5 = Snake_Game.Properties.Resources.cherry_fruit;
        Image image6 = Snake_Game.Properties.Resources.mango_fruit;
        //index of image 
        int cnt;

        


        int second, minute;
        Timer t = new Timer();
        

        //mute sound
        bool isMute = false;

        //sound effect
        private SoundPlayer soundPlayer;

        //public static List<InfoPlayer> listPlayer = new List<InfoPlayer>();
        public static InfoPlayer highestPlayer = new InfoPlayer();
        public static InfoPlayer highestPlayer_Nightmare = new InfoPlayer();

        //Mode of game
        public static bool isModeEasy = true;

        //Pause the game
        private bool isPause = false;



        public Form1()
        {
            InitializeComponent();

            soundPlayer = new SoundPlayer("Eat.wav");
            //Set settings to default
            new Settings();

            //Set game speed and Start timer
            gameTimer.Interval = 1000/Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            //Start new game
            StartGame();

            //timer interval
            t.Interval = 1000; //miliseconds

            t.Tick += new EventHandler(this.t_Tick);

            //start timer when form loads
            t.Start();

            Food.Add(image1);
            Food.Add(image2);
            Food.Add(image3);
            Food.Add(image4);
            Food.Add(image5);
            Food.Add(image6);

            cnt = 0;
        }



        public void StartGame()
        {
            

            //Set settings to default
            new Settings();

            //Set the time as default
            second = minute = 0;

            //Create new player object
            Snake.Clear();
            Circle head = new Circle();
            head.X = 10;
            head.Y = 5;
            Snake.Add(head);

            lblScore.Text = Settings.Score.ToString();
            GenerateFood();

            lblTime.Text = "00:00";
            t.Start();

            gameTimer.Interval = 1000 / Settings.Speed;





        }

        //Place random food game
        private void GenerateFood()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;
            Random random = new Random();
            food = new Circle();
            Random rdm = new Random();
            //random the index of fruit
            cnt = rdm.Next(0, 6);
            food.X = random.Next(0, maxXPos); // random a interger from 0 to maxXPos
            food.Y = random.Next(0, maxYPos); // random a interger from 0 to maxYPos
        }


        private void UpdateScreen(object sender, EventArgs e) 
        {
            //Check for Game Over
            if(Settings.GameOver == true)
            {
                //Check if Enter is pressed
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                //if we are going right we can not go left and another
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                MovePlayer();
            }

            pbCanvas.Invalidate();
        }


        //paint the canvas
        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
         

            Graphics canvas = e.Graphics;
            //  Graphics g = Graphics.FromImage(bmp);
            //   g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            if(Settings.GameOver == false)
            {
                //Set color of snake
                Brush snakeColor;

                //Draw snake
                for(int i =0; i < Snake.Count; i++)
                {
                    
                    if (i == 0)
                        //Color head
                        snakeColor = Brushes.Yellow;
                    else
                        //Color the rest
                        snakeColor = Brushes.Blue;


                    //Draw snake
                    canvas.FillEllipse(snakeColor,
                    new Rectangle(Snake[i].X * Settings.Width,
                                    Snake[i].Y * Settings.Height,
                                    Settings.Width, Settings.Height));

                }
                Rectangle rect = new Rectangle(food.X * Settings.Width - Settings.Width,
                                    food.Y * Settings.Height - Settings.Height,
                                    Settings.Width * 3, Settings.Height * 3);
                canvas.DrawImage(Food[cnt], rect);

            }
        }

        private void MovePlayer()
        {
            for(int i = Snake.Count - 1; i >= 0; i--)
            {
                if(i == 0)
                {
                    //Change direction of head.If we go to right, change the coordinate X += 1;
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }
                    int maxXPos = pbCanvas.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas.Size.Height / Settings.Height;
                    //If head collision with the constrain border =>Die
                    if (Snake[i].X < 0 || Snake[i].Y <0 || Snake[i].X>=maxXPos || Snake[i].Y>=maxYPos)
                    {
                        Die();
                    }

                    //Detect collision with body =>Die
                    for(int j = 1; j<Snake.Count; j++)
                    {
                        if(Snake[i].X == Snake[j].X &&
                            Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                            break;
                        }
                    }

                    //Detect collision with food => Eat
                    if(Math.Abs(Snake[i].X - food.X)<= 1 && Math.Abs(Snake[i].Y - food.Y) <= 1)
                    {
                        Eat();
                    }
                }
                else
                {
                    //Move body, the previous cell update to next cell
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }


        private void Eat()
        {
            //Add a cell to tail
            Circle circle = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(circle);

            //Update Score
            if(isModeEasy == false)
            {
                switch (cnt)
                {
                    case 0:
                        //apple
                        Settings.Score += 50;
                        Settings.Speed += Settings.Speed / 20;
                        break;
                    case 1:
                        //banana
                        Settings.Score += 100;
                        Settings.Speed += Settings.Speed / 10;
                        break;
                    case 2:
                        //orange
                        Settings.Score += 150;
                        Settings.Speed += Settings.Speed / 5;
                        break;
                    case 3:
                        //straw berry
                        Settings.Score += 150;
                        Settings.Speed += Settings.Speed / 4;
                        break;
                    case 4:
                        //cherry
                        Settings.Score += 200;
                        Settings.Speed += Settings.Speed / 3;
                        break;
                    case 5:
                        //mango
                        Settings.Score += 300;
                        Settings.Speed += Settings.Speed / 2;
                        break;
                }
            }
            else
            {
                Settings.Score += Settings.Points;
            }

            gameTimer.Interval = 1000 / Settings.Speed;
            if (gameTimer.Interval < 1)
            {
                gameTimer.Interval = 1;
            }
            
            lblScore.Text = Settings.Score.ToString();

            //Create new food
            GenerateFood();

            //Play sound
            if (!isMute)
            {
                soundPlayer.Play();
            }
        }

        private void Die()
        {
            Settings.GameOver = true;
            t.Stop();
            PlayerInfo messageInfo = new PlayerInfo();
            messageInfo.Show();
            Settings.player.timePlayer = Settings.time;
            Settings.player.scorePlayer = Settings.Score;
        }

      



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //hotkeys
            Input.ChangeState(e.KeyCode, true);
            if(e.KeyCode == Keys.Q)
            {
                lblNewGame_Click(sender, e);
            }
            else if (e.KeyCode == Keys.W)
            {
                lblPause_Click(sender, e);
            }
            else if (e.KeyCode == Keys.E)
            {
                lblDashboard_Click(sender, e);
            }
            else if (e.KeyCode == Keys.R)
            {
                lblHelp_Click(sender, e);
            }
        }



        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }


        private void lblHelp_Click(object sender, EventArgs e)
        {
            //pause the game when help window opens
            if(isPause == false)
            {
                lblPause_Click(sender, e);
            }
            
            HelpMessage helpMessage = new HelpMessage();
            helpMessage.Show();
        }


        private void lblNewGame_Click(object sender, EventArgs e)
        {
            if(Settings.GameOver == false)
            {
                Die();
            }
            StartGame();
        }

        //sound on
        private void Mute_Click(object sender, EventArgs e)
        {
            isMute = false;
            Mute.Visible = false;
            Sound.Visible = true;
        }

        //sound off
        private void Sound_Click(object sender, EventArgs e)
        {
            isMute = true;
            Mute.Visible = true;
            Sound.Visible = false;
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            //game pause when dashboard window opens
            if (isPause == false)
            {
                lblPause_Click(sender, e);
            }
            DashBoard dashBoard = new DashBoard();

            dashBoard.Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Switch mode
        private void bntSwitch_Click(object sender, EventArgs e)
        {
            if(Settings.GameOver == true)
            {
                
                if(tbEasy.Visible == false)
                {
                    //we still nightmare
                    tbNightmare.Visible = false;
                    tbEasy.Visible = true;
                    isModeEasy = true;

                }
                else
                {
                    //we are in ez mode
                    tbNightmare.Visible = true;
                    tbEasy.Visible = false;
                    isModeEasy = false;

                }
            }
            else
            {
                if (isPause == false)
                {
                    lblPause_Click(sender, e);
                }
                MessageBox.Show("You can not change the mode now. You are playing game");
            }
        }

        //pause button
        private void lblPause_Click(object sender, EventArgs e)
        {
            if(Settings.GameOver == false)
            {
                if(isPause == false)
                {
                    lblPause.Text = "RESUME";
                    isPause = true;
                    gameTimer.Stop();
                    t.Stop();
                }
                else
                {
                    isPause = false;
                    gameTimer.Start();
                    t.Start();
                    lblPause.Text = "PAUSE";
                }
                
            }
        }






        //timer event handler
        private void t_Tick(object sender, EventArgs e)
        {
            second++;
            //mode nightmare
            if(isModeEasy == false)
            {
                if (second % 10 == 0)
                {
                    Settings.Speed += Settings.Speed / 5;
                    gameTimer.Interval = 1000 / Settings.Speed;
                    if (gameTimer.Interval < 1)
                    {
                        gameTimer.Interval = 1;
                    }
                }
            }

            //expect "00:00"
            if (second > 59)
            {
                minute++;
                second = 0;
            }
            Settings.time = "";
            //padding leading zero
            if (minute < 10)
            {
                Settings.time += "0" + minute;
            }
            else
            {
                Settings.time += minute;
            }
            Settings.time += ":";

            if(second < 10)
            {
                Settings.time += "0" + second;
            }
            else
            {
                Settings.time += second;
            }

            //illustrate on window
            lblTime.Text = Settings.time;
            label3.Text = Settings.Speed.ToString();
        }
    }
}
