using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string firstValueText = TextBox1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string secondValueText = textBox2.Text;
            double secondValue = Convert.ToDouble(secondValueText);
            double result = firstValue + secondValue;
            label1.Text = result.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string firstValueText = TextBox1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string secondValueText = textBox2.Text;
            double secondValue = Convert.ToDouble(secondValueText);
            double result = firstValue - secondValue;
            label1.Text = result.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string firstValueText = TextBox1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string secondValueText = textBox2.Text;
            double secondValue = Convert.ToDouble(secondValueText);
            double result = firstValue * secondValue;
            label1.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string firstValueText = TextBox1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string secondValueText = textBox2.Text;
            double secondValue = Convert.ToDouble(secondValueText);
            double result = firstValue / secondValue;
            label1.Text = result.ToString();
        }
    } 
}