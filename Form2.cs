using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        Random r;
        int hei;
        int wid;
        public Form2(bool c1 ,bool c2 , bool c3)
        {
            InitializeComponent();

            if (c1 == true)
            {
                timer1.Enabled = true;
                timer1.Interval = 800;
                pictureBox1.Height = pictureBox1.Height + pictureBox1.Height * 50 / 100;
                pictureBox1.Width = pictureBox1.Width + pictureBox1.Width * 50 / 100;
                wid = pictureBox1.Width;
                hei = pictureBox1.Height;
                toolStripTextBox2.Text = "Level 1";
                timer2.Enabled = true;
            }
            if (c2 == true)
            {
                timer1.Enabled = true;
                timer1.Interval = 500;
                pictureBox1.Height = pictureBox1.Height + pictureBox1.Height * 30 / 100;
                pictureBox1.Width = pictureBox1.Width + pictureBox1.Width * 30 / 100;
                wid = pictureBox1.Width;
                hei = pictureBox1.Height;
                toolStripTextBox2.Text = "Level 2";
                timer2.Enabled = true;

            }

            if (c3==true)
            {
                timer1.Enabled = true;
                timer1.Interval = 400;
                wid = pictureBox1.Width;
                hei = pictureBox1.Height;
                toolStripTextBox2.Text = "Level 3";
                timer2.Enabled = true;
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            r = new Random();
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p1 = new Point(r.Next(0, this.Width-wid), r.Next(24, this.Height-hei));
            pictureBox1.Location = p1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
        int num = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            num++;
            toolStripTextBox1.Text = "Score: " + num;
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
        int t1 = 01;
        int t2 = 60;
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            
            t1 = 00;
            t2--;
            if (t2 < 10)
            {
                toolStripTextBox3.Text = "Timer    0" + t1 + ":0" + t2;
            }
            else
            {
            toolStripTextBox3.Text ="Timer    0"+ t1 + ":" + t2;
            }
            if (t2 == 00)
            {
                this.BackColor = Color.Red;
                timer2.Enabled = false;
                timer1.Enabled = false;
                MessageBox.Show("Your Score is: " + num.ToString());
                
                this.Close();
            }
        }
    }
}
