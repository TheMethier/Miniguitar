﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Media;

namespace yyy
{  public partial class Form1 : Form
    {
        Random random = new Random();
        int Score = 0;
        int ospeed = 10;
        bool pressq = false;
        bool pressw = false;
        bool presse = false;
        bool pressz = false;
      Stack<PictureBox> obj = new Stack<PictureBox>();
      Stack<PictureBox> obj1 = new Stack<PictureBox>();
      Stack<PictureBox> obj2 = new Stack<PictureBox>();
      Stack<PictureBox> obj3 = new Stack<PictureBox>();
        public Form1()
        {         
            InitializeComponent();
            Run();   
        }
        private void label1_Click(object sender, EventArgs e)
        { 
        }
    private void GameEvent(object sender, EventArgs e)
        {
             label1.Text = "Score: " + Score;//wyświetlanie wyniku                
            foreach (Control x in this.Controls)
                //ta pętla przechodzi po wszystkich elementach formy
            {
                if (x is PictureBox && (string)x.Tag == ("note1") || x is PictureBox && (string)x.Tag == ("note2") || x is PictureBox && (string)x.Tag == ("note3") || x is PictureBox && (string)x.Tag == ("note4"))
                    //gdy znajdzie picturebox o tagu note(liczba) wykonują się instrukcje:
                {
                    x.Left -= ospeed;
                    
                    if (obj.Peek().Left<-130)
                      //gdy okazuje się że najpóźniej wygenerowany element
                      // przebije -130
                                                                    
                    {
                        Gen(obj, "note1", Kanwa, pictureBox3);//generuje nowy peek
                        obj.Peek().Left = 800+random.Next(700,900);//nadaje mu pozycję
                        Gen(obj, "note1", Kanwa, pictureBox3);
                      for(int i =0;i<5;i++)//generuje 10 następnych elementów
                        {
                            Gen(obj, "note1", Kanwa, pictureBox3);
                        }
                    }
                    if (obj2.Peek().Left < -130)                    
                    {
                        Gen(obj2, "note3", Kanwa2, pictureBox5);
                        obj2.Peek().Left = 800 + random.Next(700, 900);
                        Gen(obj2, "note3", Kanwa2, pictureBox5);
                        for (int i = 0; i < 5; i++)
                        {
                            Gen(obj2, "note3", Kanwa2, pictureBox5);
                        }
                    }
                    if(obj1.Peek().Left<-130)                                                
                    {
                        Gen(obj1, "note2", Kanwa1, pictureBox4);
                        obj1.Peek().Left = 800+random.Next(700,900);
                        Gen(obj1, "note2", Kanwa1, pictureBox4);
                        for (int i =0;i<5;i++)
                        {
                            Gen(obj1, "note2", Kanwa1, pictureBox4);
                        }

                    }
                    if (obj3.Peek().Left < -130)


                    {
                        Gen(obj3, "note4", Kanwa3, pictureBox6);
                        obj3.Peek().Left = 800 + random.Next(700, 900);
                        Gen(obj3, "note4", Kanwa3, pictureBox6);
                        for (int i = 0; i < 5; i++)
                        {
                            Gen(obj3, "note4", Kanwa3, pictureBox6);
                        }

                    }
                    if (x.Visible==true && pressq && x.Left < Hitbox.Right && x.Left > Hitbox.Left && x.Right < Hitbox.Right || x.Visible==true && pressw && x.Left < Hitbox1.Right && x.Left > Hitbox1.Left && x.Right < Hitbox1.Right || x.Visible == true && presse && x.Left < Hitbox2.Right && x.Left > Hitbox2.Left && x.Right < Hitbox2.Right || x.Visible == true && pressz && x.Left < Hitbox3.Right && x.Left > Hitbox3.Left && x.Right < Hitbox3.Right)
                    //Warunek wygranej gdzie jest sprawdzana, czy klocek jest widoczny i
                    //czy klocek znajduje się w danym obszarze    
                    {
                                            
                        Score++;
                        x.Visible = false;//ustawia widoczność na false
                    }
                }
            }
        }
        private void KeyUP(object sender, KeyEventArgs e)
        {
            if (pressq)
            {
                pressq = false;                                                
            }
            if (pressw)
            {
                pressw = false;               
            }
            if (presse)
            {
                presse = false;
            }
            if (pressz)
            {
                pressz = false;
            }
        }
        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 && !pressq)
            {
                pressq = true;              
            }
            if (e.KeyCode == Keys.D2 && !pressw)
            {
                pressw = true;
            }
            if (e.KeyCode == Keys.D3 && !presse)
            {
                presse = true;
            }
            if (e.KeyCode == Keys.D4 && !pressz)
            {
                pressz = true;
            }
        }
        public void Run()
        {

            //playSimpleSound();
            timer1.Stop();
            //---------------
           //Ustawianie sceny
           //----------------
            Hitbox.Top = 83;
            Hitbox.Left= 20;
            Kanwa.Top=Hitbox.Top;
            Hitbox.Size = new System.Drawing.Size(120, 100);
            Hitbox1.Top = 220;
            Hitbox1.Left = 20;
            Kanwa1.Top = Hitbox1.Top;
            Kanwa1.Top = 220;
            pictureBox4.Top = Kanwa1.Top;
            Hitbox1.Size = new System.Drawing.Size(120, 100);
            Hitbox1.Top = Kanwa1.Top; Hitbox2.Top = 220;
            Hitbox2.Left = 20;
            Kanwa2.Top = Hitbox2.Top;
            Kanwa2.Top = 340;
            pictureBox5.Top = Kanwa2.Top;
            Hitbox2.Size = new System.Drawing.Size(120, 100);
            Hitbox2.Top = Kanwa2.Top;
            Hitbox3.Left = 20;
            Kanwa3.Top = Hitbox3.Top;
            Kanwa3.Top = 460;
            pictureBox6.Top = Kanwa3.Top;
            Hitbox3.Size = new System.Drawing.Size(120, 100);
            Hitbox3.Top = Kanwa3.Top;
            Hitbox3.Top = Kanwa3.Top;
            foreach (Control x in Controls)//pętla ustawia pierwszy klocek na stałej pozycji
            {
                if (x is PictureBox && (string)x.Tag == "note1"|| x is PictureBox && (string)x.Tag == "note2" || x is PictureBox && (string)x.Tag == "note3" || x is PictureBox && (string)x.Tag == "note4")
                {
                    x.Left = random.Next(900, 1500);
                }
            }
            obj.Push(pictureBox3);
            obj1.Push(pictureBox4);
            obj2.Push(pictureBox5);
            obj3.Push(pictureBox6);//element jest pushowany na stos
            for (int i = 0; i <10; i++)
            {
                Gen(obj,"note1",Kanwa, pictureBox3);//generacja
                Gen(obj1, "note2", Kanwa1, pictureBox4);
                Gen(obj2, "note3", Kanwa2, pictureBox5);
                Gen(obj3, "note4", Kanwa3, pictureBox6);
            }
            timer1.Start();//rozpoczęcie trwania timera
        }
       
       
        public void Gen(Stack <PictureBox> i, string tag, PictureBox locat, PictureBox image) 
        {            
            PictureBox p;
                p = i.Peek();
            var pic = new PictureBox()
            {
                Name = "Tak",
                Tag = tag,
                Parent = locat,
             Size= new Size(100,100),
                Location = new Point(p.Left +2*p.Width+ random.Next(300, 900), locat.Top),
                BackColor = image.BackColor,
                
            };   //jest stworzony nowy element z danym wyżej konstruktorem
          
          Controls.Add(pic);//dodawanie na scene tego elementu
            pic.BringToFront();//na przód
            i.Push(pic);
        }
        private void playSimpleSound()
        {

            SoundPlayer simpleSound = new SoundPlayer(yyy.Properties.Resources.muzyka);
            simpleSound.Play();
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

        private void timer2_Tick(object sender, EventArgs e)
        {
           
     
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
          
        }

        private void Mouse(object sender, MouseEventArgs e)
        {

        }

     
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}