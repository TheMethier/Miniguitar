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
{
    public partial class Form2 : Form
    {
        bool p = false;
        public Form2()
        {
            InitializeComponent();
            
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1();
            game.ShowDialog();            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void Form2_Leave(object sender, EventArgs e)
        {
       
           
        }
    }
}
