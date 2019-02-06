using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komp
{
    public partial class Form1 : Form
    {
        private string bin = "";
        private bool liczone = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (liczone)
            {
                textBox2.Text = "";
                liczone = false;
                bin = "";
            }
            if (bin.Length < 32)
            {
                bin += "0";
                textBox1.Text = bin;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (liczone)
            {
                textBox2.Text = "";
                liczone = false;
                bin = "";
            }
            if (bin.Length < 32)
            {
                bin += "1";
                textBox1.Text = bin;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            liczone = true;
            int binNum = Int32.Parse(bin);
            int i = 0, dec = 0;
            while (binNum > 0)
            {
                dec += (binNum % 10) * Convert.ToInt32(Math.Pow(2, i));
                binNum /= 10;
                i++;
            }
            textBox2.Text = dec.ToString();
            //bin = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
