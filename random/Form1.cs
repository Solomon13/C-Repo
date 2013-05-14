using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int a = 5;

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
             int b=rand.Next(0, 2);
             if (b == 1) richTextBox1.Text = "Ivan";
             else richTextBox1.Text = "Rommmaaaa";
             int ss;
             List<int> ll = new List<int>();
             ll.Where(p => p == 344);
            djigurda.romadjuurda();

        }

    }

    abstract class djigurda {
        static public void romadjuurda(){Console.WriteLine("AAAAAAAAAAAAA!!!!");}
        //void lexzadjigurda();
    }
}
