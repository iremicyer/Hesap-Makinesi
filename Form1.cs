using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi_Ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        double s1, s2, s;

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf("-") < 0)
            {
                textBox1.Text += "-";
            }

             
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(",")<1)
            {
                textBox1.Text += ",";
            }
        }


        private void button20_Click(object sender, EventArgs e)
        {
            
            s2 = Convert.ToDouble(textBox1.Text.Substring(1, (textBox1.TextLength) - 1));
            textBox1.Clear();
            switch (a)
            {
                case "/":
                    s = s1 / s2;
                    break;
                case "*":
                    s = s1 * s2;
                    break;
                case "-":
                    s = s1 - s2;
                    break;
                case "+":
                    s = s1 + s2;
                    break;
                default:
                    break;
            }
            textBox1.Text = s.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;

        }

        

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        string a;
        private void button4_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            Button btn = (Button)sender;
            a = btn.Text;
            textBox1.Text += btn.Text;


        }
    }
}
