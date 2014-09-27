using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalcuateApp
{
    class Salary
    {
        public string name;
        public double basicSalary;
        public double houseRent;
        public double medicalAllowance;

        public double GethouseRent()
        {
            return (basicSalary*houseRent)/100;

        }

        public double GetMedicalAllwoance()
        {
            return (basicSalary*medicalAllowance)/100;
        }

        public double CalculateTotalSalary()
        {
            return basicSalary + GethouseRent() + GetMedicalAllwoance();
        }
    }
}
