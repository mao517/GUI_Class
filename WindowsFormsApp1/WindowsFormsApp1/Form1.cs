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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button按我一下_Click(object sender, EventArgs e)
        {
            //button按鍵.Text = "我已經被按過了";
            Form form = new FormButton();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(textBox1.Text);
                b = Int32.Parse(textBox2.Text);

            }
            catch(System.FormatException)
            {
                MessageBox.Show("請輸入數字!");
                a = 0;
                b = 0;
            }

            int sum = a + b;
            button1.Text = sum.ToString();

        }


    }
}
