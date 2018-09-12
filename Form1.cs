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
    public partial class Form1 : Form
    {
        static bool c1, c2, c3;

        Form2 f2;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (checkBox2.Checked == false & checkBox1.Checked==false & checkBox3.Checked==false)
            {
                MessageBox.Show("Choose level");
            }
            else
            {
                f2 = new Form2(checkBox1.Checked, checkBox2.Checked, checkBox3.Checked);
                f2.Show();
            }
            
        }
    }
}
