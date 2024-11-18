using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ภาษาไทย1","BOX1");
            Console.WriteLine();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ต้องการปิดจริงหรือไม่", "แน่ใจนะ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.BackColor = Color.FromArgb(rand.Next(0,256), rand.Next(0,256), rand.Next(0,256));
            this.Text = rand.ToString() + ", " + rand.ToString() + ", " + rand.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor=Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.BackColor= Color.White;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor= Color.Blue;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Blue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            Button1.BackColor = Color.Pink;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            Button1.BackColor = Color.Purple;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "UDRU")
            {
                label1.Text = "UDRU123";
            }
            else {
                label1.Text = "UDRU";
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.Aqua;
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Orange;
            label1.ForeColor = Color.Blue;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            Random rand = new Random();
            int r = rand.Next(0,255);
            int g = rand.Next(0, 255);
            int b = rand.Next(0, 255);

            //this.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
            //this.Text = rand.ToString() + ", " + rand.ToString() + ", " + rand.ToString();
            label1.ForeColor = Color.FromArgb(r,g,b);
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = null;
            //textBox1.Text = String.Empty;

        }
    }
}
