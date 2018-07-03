using System;
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

                case "Multiply":
                    result = firstValue * secondValue;
                    break;

                case "Divide":
                    result = firstValue / secondValue;
                    break;
                    
                default:
                    throw new Exception("Неизвестная операция");
            }

            label1.Text = result.ToString();

        }
    } 
}