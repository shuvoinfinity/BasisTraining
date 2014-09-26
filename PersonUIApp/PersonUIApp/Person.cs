using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonUIApp
{
    class Person
    {
        public string firstName;
        public string middlename;
        public string lastName;

        public string GetFullName()
        {
            return firstName + " " + middlename + " " + lastName;

        }

        public string GetFullReverseName()
        {
           char[] arr = GetFullName().ToCharArray();
	                Array.Reverse(arr);
	       return new string(arr);
        }
    }
}
