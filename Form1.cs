using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Project
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String OperationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch(OperationPerformed)
            {
                case "+":
                    textbox_Result.Text = (resultValue + Double.Parse(textbox_Result.Text)).ToString();
                    break;
                case "-":
                    textbox_Result.Text = (resultValue - Double.Parse(textbox_Result.Text)).ToString();
                    break;
                case "*":
                    textbox_Result.Text = (resultValue * Double.Parse(textbox_Result.Text)).ToString();
                    break;
                case "/":
                    textbox_Result.Text = (resultValue / Double.Parse(textbox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textbox_Result.Text = "0";
            resultValue = 0;
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
           
        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if (textbox_Result.Text == "0")
               textbox_Result.Clear();
            isOperationPerformed = false;

            Button button = (Button)sender;
            textbox_Result.Text = textbox_Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            OperationPerformed = button.Text;
            resultValue = Double.Parse(textbox_Result.Text);
            isOperationPerformed = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textbox_Result.Text = "0";
        }
    }
}
