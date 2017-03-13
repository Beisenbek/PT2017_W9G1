using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        CalcBrain brain = new CalcBrain();
        public Form1()
        {
            InitializeComponent();
        }

        private void digit_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            display.Text += btn.Text;
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.Text == "+")
            {
                brain.firstOperand = double.Parse(display.Text);
                display.Text = "";
            }
            else
            {
                brain.secondOperand = double.Parse(display.Text);
                display.Text = brain.SumOperation().ToString();
            }
        }
    }
}
