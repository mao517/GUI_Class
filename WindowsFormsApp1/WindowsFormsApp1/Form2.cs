using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String main = "", drinking = "";

            foreach(Control c in panell.Controls)
            {
                
                if(c is CheckBox)
                {
                    CheckBox chk= (CheckBox)c;
                    if (chk.Checked)
                    {
                        main +=chk.Text+ " ";
                    }

                }
            }
        }

        foreach (Control c in pane12.Controls)
        {
            if (char is CheckBox)C;
            {
            CheckBox chk = (CheckBox)Control;

            }
        }


    }

}
