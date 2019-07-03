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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Отправить";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text != "")
            {
                int stringotpravki = textBox2.Text.Length;
                for (int i = textBox2.Text.Length - 1; i >= 0; i--)
                {
                    if (textBox2.Text[i] != '\n' && textBox2.Text[i] != '\r' && textBox2.Text[i] != ' ')
                    { break; }
                    stringotpravki--;
                }
                
                if (stringotpravki == textBox2.Text.Length)
                {
                    textBox1.Text += "\r\n" + textBox2.Text;
                }
                else
                {
                    if(stringotpravki != 0)
                    textBox1.Text += "\r\n" + textBox2.Text.Remove(stringotpravki);
                }
                textBox2.Text = ""; 
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
