using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class PlayerInfo : Form
    {
        public PlayerInfo()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tbScore.Text = "Your final score is: " + Settings.Score ;
            tbTime.Text = "Survive in: " + Settings.time;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //condition with the name
            if(tbName.Text == "" || tbName.Text.Length > 18)
            {
                
                MessageBox.Show("Invalid Name.\nName should not be empty or greater than 18 characters",
                    "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Form1.isModeEasy == true)
                {
                    //Mode easy
                    Settings.player.namePlayer = tbName.Text.ToString();
                    if (Form1.highestPlayer.namePlayer == "")
                    {
                        //still don't have top 1
                        Form1.highestPlayer = Settings.player;
                    }
                    else
                    {
                        if (Form1.highestPlayer.scorePlayer < Settings.player.scorePlayer)
                        {
                            Form1.highestPlayer = Settings.player;
                        }
                        else if (Form1.highestPlayer.scorePlayer == Settings.player.scorePlayer)
                        {
                            if (String.Compare(Form1.highestPlayer.timePlayer, Settings.player.timePlayer) < 0)
                            {
                                Form1.highestPlayer = Settings.player;
                            }
                        }
                    }
                }
                else
                {
                    //Mode Nightmare
                    Settings.player.namePlayer = tbName.Text.ToString();
                    if (Form1.highestPlayer_Nightmare.namePlayer == "")
                    {
                        //still don't have top 1
                        Form1.highestPlayer_Nightmare = Settings.player;
                    }
                    else
                    {
                        if (Form1.highestPlayer_Nightmare.scorePlayer < Settings.player.scorePlayer)
                        {
                            Form1.highestPlayer_Nightmare = Settings.player;
                        }
                        else if (Form1.highestPlayer_Nightmare.scorePlayer == Settings.player.scorePlayer)
                        {
                            if (String.Compare(Form1.highestPlayer_Nightmare.timePlayer, Settings.player.timePlayer) < 0)
                            {
                                Form1.highestPlayer_Nightmare = Settings.player;
                            }
                        }
                    }
                }


                this.Close();

            }


        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void bntNo_Click(object sender, EventArgs e)
        {
            if(Form1.isModeEasy == true)
            {
                //Mode easy
                Settings.player.namePlayer = "Unknown Person";
                if (Form1.highestPlayer.namePlayer == "")
                {
                    //still don't have top 1
                    Form1.highestPlayer = Settings.player;
                }
                else
                {
                    if (Form1.highestPlayer.scorePlayer < Settings.player.scorePlayer)
                    {
                        Form1.highestPlayer = Settings.player;
                    }
                    else if (Form1.highestPlayer.scorePlayer == Settings.player.scorePlayer)
                    {
                        if (String.Compare(Form1.highestPlayer.timePlayer, Settings.player.timePlayer) < 0)
                        {
                            Form1.highestPlayer = Settings.player;
                        }
                    }
                }
            }
            else
            {
                //Mode Nightmare
                Settings.player.namePlayer = "Unknown Person";
                if (Form1.highestPlayer_Nightmare.namePlayer == "")
                {
                    //still don't have top 1
                    Form1.highestPlayer_Nightmare = Settings.player;
                }
                else
                {
                    if (Form1.highestPlayer_Nightmare.scorePlayer < Settings.player.scorePlayer)
                    {
                        Form1.highestPlayer_Nightmare = Settings.player;
                    }
                    else if (Form1.highestPlayer_Nightmare.scorePlayer == Settings.player.scorePlayer)
                    {
                        if (String.Compare(Form1.highestPlayer_Nightmare.timePlayer, Settings.player.timePlayer) < 0)
                        {
                            Form1.highestPlayer_Nightmare = Settings.player;
                        }
                    }
                }
            }
            this.Close();
        }
    }
}
