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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            this.ActiveControl = button1;
            button1.Focus();
            if(Form1.highestPlayer.namePlayer == null)
            {
                label4.Text = "UNKNOWN PERSON";
            }
            else
            {
                label4.Text = Form1.highestPlayer.namePlayer.ToString();
            }
            
            label5.Text = Form1.highestPlayer.scorePlayer.ToString();
            label6.Text = Form1.highestPlayer.timePlayer;

            if (Form1.highestPlayer_Nightmare.namePlayer == null)
            {
                label10.Text = "UNKNOWN PERSON";
            }
            else
            {
                label10.Text = Form1.highestPlayer_Nightmare.namePlayer.ToString();
            }

            label9.Text = Form1.highestPlayer_Nightmare.scorePlayer.ToString();
            label8.Text = Form1.highestPlayer_Nightmare.timePlayer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
