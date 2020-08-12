using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    public class InfoPlayer
    {
        public string namePlayer = "Unknown Person";
        public int scorePlayer = 0;
        public string timePlayer = "00:00"; 
    };

    class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }
        //time
        public static string time { get; set; }

        public static InfoPlayer player { get; set; } 

        public Settings()
        {
            Width = 16;         //Create a gird with 16x16
            Height = 16;
            Speed = 15;
            Score = 0;
            Points = 100;
            GameOver = false;
            direction = Direction.Down;
            time = "00:00";
            player = new InfoPlayer();
            player.namePlayer = "nh0znoisung";
            player.scorePlayer = 0;
            player.timePlayer = "00:00";
        }
    }
}
