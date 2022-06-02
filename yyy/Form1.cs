using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace yyy
{public partial class Form1 : Form
    {
        int Score = 0;
        int ospeed = 0;
        int sec = 0;
        bool press=false;
        bool win = false;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            Run();
        }
        private void label1_Click(object sender, EventArgs e)
        {}
        private void GameEvent(object sender, EventArgs e)
        {
            if (press) sec++;
            label1.Text = "Score: " + Score;
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "note")
                { 
                    x.Left -= ospeed;
                    if (x.Left < pictureBox1.Left)
                    {
                        Run();
                    }
                    if (sec<3&&press&&x.Left<Hitbox.Right)
                    {
                        win = true; }
                }
              }  
        }
        private void KeyUP(object sender, KeyEventArgs e)
        {
            if(press)
            {
                press = false;
                Hitbox.BackColor = Color.BlanchedAlmond;
            }
        }
        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space && !press)
            {
                press = true;
                Hitbox.BackColor=Color.Green;
}
        }
        public void Run()
        {if (win) { Score++; }
            
            win = false;
            ospeed = 10+Score/(3);
            sec = 0;
            Hitbox.Top = pictureBox1.Top;
            foreach(Control x in Controls)
            {
                if (x is PictureBox && (string)x.Tag == "note")
               {
                    int pos = random.Next(63, 700);
                    x.Left = pos + Hitbox.Width;
                }
            }
            timer1.Start();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void keyp(object sender, KeyPressEventArgs e)
        {
        }
        private void note_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
        }
        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
        }
    }
}