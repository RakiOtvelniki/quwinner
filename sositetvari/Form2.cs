using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sositetvari
{
    public partial class Form2 : Form
    {
        bool reg = false;
        public Form2()
        {
            InitializeComponent();
            qq();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            //


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reg = !reg;
            qq();
        }
        private void qq()
        {
            if(reg)
            {
                linkLabel1.Text = "К входу";
                textBox3.Visible = true;
                label3.Visible = true;
                button1.Text = "Зарегистрироваться";
            }
            else
            {
                button1.Text = "Вход";
                linkLabel1.Text = "Регистрация";
                textBox3.Visible = false;
                label3.Visible = false;
            }
        }


        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
