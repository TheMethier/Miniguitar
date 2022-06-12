using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace yyy
{
    public partial class Form1 : Form
    {  
       
        int Score = 0;//licznik zdobytych punkty
        int ospeed = 10;//prędkość kwadratów
        int sec = 0;//licznik czasu nacisku przycisku
        bool pressq = false;
        bool pressw = false;  
        Random random = new Random();
      Stack<PictureBox> obj = new Stack<PictureBox>();       
        public Form1()
        {         
            InitializeComponent();
            Run();//fanskfandfkadnfas
        }
        private void label1_Click(object sender, EventArgs e)
        { 
        }

    private void GameEvent(object sender, EventArgs e)
        {

        if (pressq) { sec++; }//liczenie czasu nacisku
            else { sec = 0; }//hgh
            label1.Text = "Score: " + Score;//wyświetlanie wyniku                
            
            foreach (Control x in this.Controls)
                //ta pętla przechodzi po wszystkich elementach formsa
            {
                if (x is PictureBox && (string)x.Tag == ("note1") )
                    //gdy znajdzie picturebox o tagu note1 wykonują się instrukcje:
                {
                    x.Left -= ospeed;// ruch klocków
                    
                    if(obj.Peek().Left<-130&&obj.Peek().Name=="Tak")
                      //gdy okazuje się że najpóźniej wygenerowany element
                      //(obj.Peek(), który w generacji ma nazwę "Tak) przebije -130:
                                                                    
                    {
                        Gen(obj);//generuje nowy peek
                        obj.Peek().Left = 800+random.Next(100,300);//nadaje mu pozycję
                        Gen(obj);
                      for(int i =0;i<9;i++)//generuje 10 następnych elementów
                        {
                            Gen(obj);
                        }

                    }                   
                    if ( sec<15&&pressq && x.Left < Hitbox.Right && x.Left > Hitbox.Left&&x.Right<Hitbox.Right)
                    //Warunek wygranej gdzie jest sprawdzana poprzez sec długość pressa i
                    //czy klocek znajduje się w danym obszarze    
                    {
                            if (Score % 10 == 0) { ospeed += 5; }//Przyspieszanie co 10                     
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
            
            
             Hitbox.Top = Kanwa.Top;
            foreach (Control x in Controls)//pętla ustawia pierwszy klocek na stałej pozycji
            {
                if (x is PictureBox && (string)x.Tag == "note1")
                {
                    x.Left = 900;
                }
            }
            obj.Push(pictureBox3);//element jest pushowany na stos
            for(int i = 0; i <10; i++)
            {
                Gen(obj);//generacja
            }
            timer1.Start();//rozpoczęcie trwania timera
        }
       
       
        public void Gen(Stack <PictureBox> i)
        {            
            PictureBox p;
                p = i.Peek();
            var pic = new PictureBox()
            {
                Name = "Tak",
                Tag = "note1",
                Parent = Kanwa,
             Size= new Size(80,80),
                Location = new Point(p.Left +2*p.Width+ random.Next(200, 550), pictureBox3.Top),
                Image = pictureBox3.Image,
                
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