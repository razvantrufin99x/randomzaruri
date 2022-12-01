using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace randomzaruri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*36 posib. 6x6
         * 11 21 31 41 51 61
         * 12 22 32 42 52 62
         * 13 23 33 43 53 63
         * 14 24 34 44 54 64
         * 15 25 35 45 55 65
         * 16 26 36 46 56 66
         */
        public void random2()
        {
            Random z2 = new Random();
            int a = (z2.Next(1, 7) );
            if(a>0 && a<7){
            label2.Text = a.ToString();
            }
              
        }

        public void random1()
        {
            Random z1 = new Random();
            int b = (z1.Next(1, 7));
            if (b > 0 && b < 7)
            {
                label1.Text = b.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            random1();
          
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            random2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread.Sleep(5);
            random1();
            Thread.Sleep(5);
            random2();
            Thread.Sleep(5);
        }
    }
}
