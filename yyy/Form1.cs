using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace yyy
{
    public partial class Form1 : Form
    { 
        
        int score = 0;
        int p = 0;
        int Score = 0;
        int ospeed = 10;
        int sec = 0;
        bool pressq = false;
        bool pressw = false;
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

            if (pressq) { sec++; }
            else { sec = 0; }
            label1.Text = "Score: " + (Score-score); //fix it                 
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == ("note") )
                {
                    x.Left -= ospeed;
                    if (x.Left<0)

                    {

                        
                        
                        
                    }
                    if(obj.Peek().Left<-130&&obj.Peek().Name=="Tak")
                    {
                        obj.Clear();
                        Run();
                    }
                    if (sec == 2&& pressq && x.Left < Hitbox.Right && x.Left > Hitbox.Left)
                    {
                        if (Score % 10 == 0) { ospeed += 1; }
                       
              
                            Score++;
                            
                        
                    }
                    
                }
            }
        }
        private void KeyUP(object sender, KeyEventArgs e)
        {
            if (pressq)
            {


                pressq = false;
                Hitbox.BackColor = Color.BlanchedAlmond;
            }
            if(pressw)
            {
                pressw = false;
                
                Hitbox1.BackColor = Color.BlanchedAlmond;
            }
        }
        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 && !pressq)
            {
                pressq = true;
                Hitbox.BackColor = Color.Green;
            }
            if (e.KeyCode == Keys.D2 && !pressw)
            {
                pressw = true;
                Hitbox1.BackColor = Color.OrangeRed;
            }


        }
        public void Run()
        {
            obj.Clear();
            p++;
            if(p!=1)
            {
                score = Score;
            }
            sec = 0;
             Hitbox.Top = Kanwa.Top;
            foreach (Control x in Controls)
            {
                if (x is PictureBox && (string)x.Tag == "note")
                {

                    x.Left = 500;
                }
            }
            obj.Push(pictureBox3);
            for(int i = 0; i <10; i++)
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
                Location = new Point(p.Left +p.Width+ random.Next(100, 300), pictureBox3.Top),
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}