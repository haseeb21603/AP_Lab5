using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace counter
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            labelcount.Text = count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count = 0;
            labelcount.Text = count.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
