using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Треугольник
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int x = a + b;
            int y = a + c;
            int z = b + c;
            if ((x > c) && (y > b) && (z > a))
            {
                label4.Text="Треугольник реализуется";
                if (a == b && a == c)
                {
                    label5.Text="Треугольник равносторонний";
                    return;
                }
                if ((a == b) || (a == c) || (b == c))
                {
                    label5.Text="Треугольник равнобедненный";
                }
                if ((c*c== a*a+b*b)|| (b * b == a * a +c*c )||( c*c == a * a +b * b))
                { label6.Text = "Треугольник прямоугольный"; }
                if ((c * c < a * a + b * b) || (b * b < a * a + c * c) || (c * c < a * a + b * b))
                { label6.Text = "Треугольник остроугольный"; }
                else { label6.Text = "Треугольник тупоугольный"; }
                double p = (a + b + c) / 2;
               double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                s = (double)Math.Round(s, 2);
                string S1 = Convert.ToString(s);
                label7.Text = "Площадь треугольника равна " + S1;
            }
            else { label4.Text = "Треугольник не реализуется"; }

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {

        }
    }
}
