using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSampleApp
{
    public partial class NumberUI : Form
    {
        List<double> numbers = new List<double>(); 
        public NumberUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double aNumber = Convert.ToDouble(numberTextBox.Text);
            numbers.Add(aNumber);
            MessageBox.Show("Number added");
        }

        private void showAllNumberButton_Click(object sender, EventArgs e)
        {
            numbersListBox.DataSource = null;
            numbersListBox.DataSource = numbers;
        }
    }
}
