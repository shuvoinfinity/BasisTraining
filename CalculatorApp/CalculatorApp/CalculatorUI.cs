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
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }
        Calculator aCalculator = new Calculator();
        double firstNumber;
        double secondNumber;


        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetFirstSeceondNumber();
            txtBoxResult.Text = aCalculator.Add(firstNumber,
               secondNumber);
        }

        private void GetFirstSeceondNumber()
        {
            firstNumber = Convert.ToDouble(txtBoxFirstNumber.Text);
            secondNumber = Convert.ToDouble(txtBoxSecndNumber.Text);
        }

        private void btnSubtrac_Click(object sender, EventArgs e)
        {
            GetFirstSeceondNumber();
            txtBoxResult.Text = aCalculator.Subtract(firstNumber, secondNumber);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            GetFirstSeceondNumber();
            txtBoxResult.Text = aCalculator.Multiply(firstNumber, secondNumber);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            GetFirstSeceondNumber();
            txtBoxResult.Text = aCalculator.Divide(firstNumber, secondNumber);
        }
    }
}
