using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            string str = " ";

            //Brazil
            if (Brazil.Checked == true)
            {
                str = str + Brazil.Text;
                str += " ";
            }
            //Japan
            if (Japan.Checked == true)
            {
                str = str + Japan.Text;
                str += " ";
            }
            //CheckBox1 = Singapore
            if (Singapore.Checked == true)
            {
                str = str + Singapore.Text;
                str += " ";
            }
            //Korea
            if (Korea.Checked == true)
            {
                str = str + Korea.Text;
                str += " ";
            }
            //others
            if (Others.Checked == true)
            {
                str = str + textbox.Text;
                str += " ";
            }
            if (str != null)
            {
                MessageBox.Show("You Selected: \n" + str + "\n Thank You!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Korea_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Japan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Singapore_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Brazil_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Others_CheckedChanged(object sender, EventArgs e)
        {
            if(Others.Checked)
            {
                label2.Visible = true;
                textbox.Visible = true;
            }
            else
             {
                label2.Visible = false;
                textbox.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            textbox.Visible = false;
        }
    }
}
