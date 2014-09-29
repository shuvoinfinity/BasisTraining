using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyEmployeeApp
{
	class Employee
	{
	    public string name;
	    public string id;
	    public double basic;
	    public double conveyance;
	    public double medicalAllowance;

        public double GetNetSalary()
        {
            return Get
        }

        private double GetGrossSalary()
        {
            return basic + conveyance + medicalAllowance;
        }

        private double CalculateTax()
        {
            double taxAmount = 0;
            double grossSalary = GetGrossSalary();
            if (grossSalary >= 100000)
            {
                return taxAmount = (grossSalary/100)*10;
            }
            else if (grossSalary < 100000 && grossSalary >= 50000)
            {
                return taxAmount = (grossSalary/100)*5;
            }
            else
            {
                return taxAmount;
            }
        }
	}
}
