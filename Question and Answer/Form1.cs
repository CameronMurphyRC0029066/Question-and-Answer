using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_and_Answer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct answer" + textBox1.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome" + textBox1.Text + "Question: 17-2x8=1, yes or no");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect answer" + textBox1.Text);
        }
    }
}
