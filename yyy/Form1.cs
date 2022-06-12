using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace yyy
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int Score = 0;
        int ospeed;
        int ospeed1;
        int ospeed2;
        int ospeed3;
        int sec = 0;
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

        if (pressq || pressw || presse || pressz) { sec++; }
            else { sec = 0; }
            label1.Text = "Score: " + Score;//wyświetlanie wyniku                
            
            foreach (Control x in this.Controls)
                //ta pętla przechodzi po wszystkich elementach formsa
            {
                if (x is PictureBox && (string)x.Tag == ("note1") || x is PictureBox && (string)x.Tag == ("note2") || x is PictureBox && (string)x.Tag == ("note3") || x is PictureBox && (string)x.Tag == ("note4"))
                    //gdy znajdzie picturebox o tagu note1 wykonują się instrukcje:
                {
                    if((string)x.Tag == ("note1"))
                        x.Left -= ospeed;
                    if ((string)x.Tag == ("note2"))// ruch klocków
                        x.Left -= ospeed1;
                    if ((string)x.Tag == ("note3"))
                        x.Left -= ospeed2;
                    if ((string)x.Tag == ("note4"))
                        x.Left -= ospeed3;
                    if (obj.Peek().Left<-130&&obj.Peek().Name=="Tak")
                      //gdy okazuje się że najpóźniej wygenerowany element
                      //(obj.Peek(), który w generacji ma nazwę "Tak) przebije -130:
                                                                    
                    {
                        Gen(obj, "note1", Kanwa, pictureBox3);//generuje nowy peek
                        obj.Peek().Left = 800+random.Next(100,300);//nadaje mu pozycję
                        Gen(obj, "note1", Kanwa, pictureBox3);
                      for(int i =0;i<9;i++)//generuje 10 następnych elementów
                        {
                            Gen(obj, "note1", Kanwa, pictureBox3);
                        }

                    }
                    if (obj2.Peek().Left < -130 && obj2.Peek().Name == "Tak")
                    

                    {
                        Gen(obj2, "note3", Kanwa2, pictureBox5);
                        obj2.Peek().Left = 800 + random.Next(100, 300);
                        Gen(obj2, "note3", Kanwa2, pictureBox5);
                        for (int i = 0; i < 9; i++)
                        {
                            Gen(obj2, "note3", Kanwa2, pictureBox5);
                        }

                    }
                    if(obj1.Peek().Left<-130&&obj1.Peek().Name=="Tak")
                      
                                                                    
                    {
                        Gen(obj1, "note2", Kanwa1, pictureBox4);
                        obj1.Peek().Left = 800+random.Next(100,300);
                        Gen(obj1, "note2", Kanwa1, pictureBox4);
                        for (int i =0;i<9;i++)
                        {
                            Gen(obj1, "note2", Kanwa1, pictureBox4);
                        }

                    }
                    if (obj3.Peek().Left < -130 && obj3.Peek().Name == "Tak")


                    {
                        Gen(obj3, "note4", Kanwa3, pictureBox6);
                        obj3.Peek().Left = 800 + random.Next(100, 300);
                        Gen(obj3, "note4", Kanwa3, pictureBox6);
                        for (int i = 0; i < 9; i++)
                        {
                            Gen(obj3, "note4", Kanwa3, pictureBox6);
                        }

                    }
                    if ( sec<15&&pressq && x.Left < Hitbox.Right && x.Left > Hitbox.Left&&x.Right<Hitbox.Right|| sec < 15 && pressw && x.Left < Hitbox1.Right && x.Left > Hitbox1.Left && x.Right < Hitbox1.Right ||sec<15&&presse && x.Left < Hitbox2.Right && x.Left > Hitbox2.Left&&x.Right<Hitbox2.Right|| sec < 15 && pressz && x.Left < Hitbox3.Right && x.Left > Hitbox3.Left && x.Right < Hitbox3.Right)
                    //Warunek wygranej gdzie jest sprawdzana poprzez sec długość pressa i
                    //czy klocek znajduje się w danym obszarze    
                    {
                            if (Score % 10 == 0) { ospeed += random.Next(2, 5); ospeed1 += random.Next(2, 5); ospeed2 += random.Next(2, 5); ospeed3 += random.Next(2, 5); }//Przyspieszanie co 10                     
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
            if (presse)
            {
                presse = false;
                Hitbox2.BackColor = Color.BlanchedAlmond;
            }
            if (pressz)
            {
                pressz = false;
                Hitbox3.BackColor = Color.BlanchedAlmond;
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
            if (e.KeyCode == Keys.D3 && !presse)
            {
                presse = true;
                Hitbox2.BackColor = Color.Yellow;
            }
            if (e.KeyCode == Keys.D4 && !pressz)
            {
                pressz = true;
                Hitbox3.BackColor = Color.Blue;
            }


        }
        public void Run()
        {

            ospeed = 10;
            ospeed1 = random.Next(2,10);
            ospeed2 = random.Next(2,10);
            ospeed3 = random.Next(2,10);
            Hitbox.Top = Kanwa.Top;
            Hitbox1.Top = Kanwa1.Top;
            Hitbox2.Top = Kanwa2.Top;
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
             Size= new Size(80,80),
                Location = new Point(p.Left +2*p.Width+ random.Next(200, 550), image.Top),
                Image = image.Image,
                
            };   //jest stworzony nowy element z danym wyżej konstruktorem
          
          Controls.Add(pic);//dodawanie na scene tego elementu
            pic.BringToFront();//na przód
            i.Push(pic);
        }
        //Trzeba jeszcze dodać generacje elementów podobną na innych strunach,
        //stosy przechowujące elementy na danych strunach
        //w Run() nadanie pozycji pierwszemu elementowi
        //obsługę innych przycisków w keydown/keyup 
        //w GameEvent() zmiennione z tagiem(np. note2) warunki wygranej i generacje na żywo
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
    }
}