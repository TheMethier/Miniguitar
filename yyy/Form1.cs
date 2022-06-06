using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace yyy
{
    public partial class Form1 : Form
    {

        int p = 4;
        int Score = 0;
        int ospeed = 0;
        int sec = 0;
        bool press = false;
        bool win = false;
        
        Random random = new Random();
     
      Stack<PictureBox> obj = new Stack<PictureBox>();
        
       
        public Form1()
        {         
            InitializeComponent();
            Run();
        }
        private void label1_Click(object sender, EventArgs e)
        { }
        private void GameEvent(object sender, EventArgs e)
        {
          
            if (press) sec++;
            label1.Text = "Score: " + Score;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == ("note") )
                {
                    x.Left -= ospeed;
                    if (x.Left<-500)
                    {
                    }                      
                    if (sec < 3 && press && x.Left < Hitbox.Right && x.Right > Hitbox.Left)
                    {
                        win = true;
                    }
                }
            }
        }
        private void KeyUP(object sender, KeyEventArgs e)
        {
            if (press)
            {
                press = false;
                Hitbox.BackColor = Color.BlanchedAlmond;
            }
        }
        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !press)
            {
                press = true;
                Hitbox.BackColor = Color.Green;
            }
        }
        public void Run()
        {
            Licz();
            ospeed = 10 + Score / (3);
            sec = 0;
             Hitbox.Top = Kanwa.Top;
            foreach (Control x in Controls)
            {
                if (x is PictureBox && (string)x.Tag == "note")
                {
                    
                    x.Left = 500 ;
                }
            }
            obj.Push(pictureBox3);
            for(int i = 0; i < 20; i++)
            {
                Gen(obj);
            }
            timer1.Start();
        }
        public void Licz()
        {
            if(win)
            {
            
            }
            win = false;
        }
       
        public void Gen(Stack <PictureBox> i)
        {
            PictureBox p;
                p = i.Peek();
            var pic = new PictureBox()
            {
                Name = "Tak",
                Tag = "note",
                Parent = Kanwa,
             Size= new Size(80,80),
                Location = new Point(p.Left + random.Next(100, 300), pictureBox3.Top),
                Image = pictureBox3.Image,
                
            };   
          Controls.Add(pic);
            pic.BringToFront();
            i.Push(pic);
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
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }
    }
}