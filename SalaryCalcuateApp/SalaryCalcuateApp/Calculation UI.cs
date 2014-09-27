using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalcuateApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnTotalSalary_Click(object sender, EventArgs e)
        {
            Salary aSalary = new Salary();
            

            aSalary.name = txtBoxName.Text;
            aSalary.basicSalary = Convert.ToDouble(txtBoxBasic.Text);
            aSalary.houseRent = Convert.ToDouble(txtBoxHouseRent.Text);
            aSalary.medicalAllowance = Convert.ToDouble(txtBoxMedical.Text);

            string total = aSalary.CalculateTotalSalary().ToString();
            
            
            MessageBox.Show(aSalary.name +" Your Total Salary is: "+ total);
        }

        private void GetSalaryDetails()
        {
            
        }
    }
}
