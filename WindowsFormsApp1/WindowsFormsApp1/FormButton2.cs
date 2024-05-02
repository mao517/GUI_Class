using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormButton2 : Form
    {
        public FormButton2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(textBox1.Text);
                b = Int32.Parse(textBox2.Text);

            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字!");
                a = 0;
                b = 0;
            }

            int sum = a + b;
            label9.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(textBox3.Text);
                b = Int32.Parse(textBox4.Text);

            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字!");
                a = 0;
                b = 0;
            }

            int sum = a - b;
            label10.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(textBox5.Text);
                b = Int32.Parse(textBox6.Text);

            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字!");
                a = 0;
                b = 0;
            }

            int sum = a * b;
            label11.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(textBox7.Text);
                b = Int32.Parse(textBox8.Text);

            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字!");
                a = 0;
                b = 0;
            }

            int sum = a / b;
            label12.Text = sum.ToString();
        }
    }
}
