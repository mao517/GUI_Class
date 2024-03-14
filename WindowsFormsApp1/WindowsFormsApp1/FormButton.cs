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
    public partial class FormButton : Form
    {
        public FormButton()
        {
            InitializeComponent();
        }

        private void FormButton_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnClick.Text == "請按我一下")
                btnClick.Text = "我已經被按過了";
            else if (btnClick.Text == "我已經被按過了")
                btnClick.Text = "請按我一下";

        }
    }
}
