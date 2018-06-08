using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EQUIZ
{
    public partial class Form1 : Form
    {
        int count, marks;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Enabled = true;
            label3.Visible = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            groupBox5.Enabled = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
            radioButton17.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            button1.Enabled = false;
            label2.Text = count.ToString();
            if (count == 25)
            {
                button2_Click(null, null);
                label2.Text = "";
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (radioButton4.Checked) marks++;
            if (radioButton8.Checked) marks++;
            if (radioButton11.Checked) marks++;
            if (radioButton14.Checked) marks++;
            if (radioButton17.Checked) marks++;
            if (count < 10)
            {
                MessageBox.Show("Congratulations!....\nYou have Recently Finish Your Quiz-1\nYOUR SCORE IS :  " + marks);
            }
            else if (count == 10)
            {
                MessageBox.Show("Sorry! Times up..\nYOUR SCORE Is :  " + marks);
                button2.Enabled = false;
            }
            button1.Enabled = true;
            marks = 0;
            count = 0;

        }
    }
}
