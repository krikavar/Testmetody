using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testmetody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int faktorial(int a) //maly datovy typ
        {
            int fakt = 1;
            for (int i = 1; i <= a; i++) 
            { 
                fakt *= i; 
            }
            return fakt;
        }
        public long faktorial(long a) 
        {
            if (a == 0) { return 1; }
            else {a *= faktorial((a - 1)); }
            return a;
        }
        public string faktorial(int a, int b)
        {
            long c1 = long.Parse(textBox2.Text);
            long c2 = long.Parse(textBox3.Text);
            String neco = "";
            while (c1 <= c2) {

                neco += c1 + ",";
                neco += faktorial(c1) + ",";
                c1++;
            }
            return neco;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int cislo = int.Parse(textBox1.Text);
            MessageBox.Show("Faktoriál je: " + faktorial((cislo)).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long longcislo = long.Parse(textBox1.Text);
            MessageBox.Show("Faktoriál " + faktorial((longcislo)).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            long c1 = long.Parse(textBox2.Text);
            long c2 = long.Parse(textBox3.Text);
            if(c1 > c2) { MessageBox.Show("První hodnota musí být větší"); }
            
        }
    }
}
