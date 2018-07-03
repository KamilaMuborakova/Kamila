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

        private void ButtonClick(object sender, EventArgs e)
        {
            string firstValueText = TextBox1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string secondValueText = textBox2.Text;
            double secondValue = Convert.ToDouble(secondValueText);
            double result;
            switch (((Button)sender).Name)
            {
      
                case "Add":
                    result = firstValue + secondValue;
                    break;
        
                case "Substract":
                    result = firstValue - secondValue;
                    break;

                case "multiplication":
                    result = firstValue * secondValue;
                    break;

                case "division":
                    result = firstValue / secondValue;
                    break;
                    
                default:
                    throw new Exception("Неизвестная операция");
            }

            label1.Text = result.ToString();

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
            double result1 = firstValue - secondValue;
            label1.Text = result1.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string firstValueText = TextBox1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string secondValueText = textBox2.Text;
            double secondValue = Convert.ToDouble(secondValueText);
            double result2 = firstValue * secondValue;
            label1.Text = result2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string firstValueText = TextBox1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string secondValueText = textBox2.Text;
            double secondValue = Convert.ToDouble(secondValueText);
            double result3 = firstValue / secondValue;
            label1.Text = result3.ToString();
        }
    } 
}