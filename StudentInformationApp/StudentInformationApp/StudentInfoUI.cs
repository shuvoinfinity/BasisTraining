using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationApp
{
    public partial class StudentInfoUI : Form
    {
        public StudentInfoUI()
        {
            InitializeComponent();
        }
        Student aStudent = new Student();
        private void buttonShow_Click(object sender, EventArgs e)
        {
            aStudent.regNo = textBoxRegNo.Text;
            aStudent.firstName = textBoxfirstName.Text;
            aStudent.lastName = textBoxLastName.Text;

            

            string messg = aStudent.GetFullName() + ", Your Registration Number is :" + aStudent.regNo;
            MessageBox.Show(messg);

            textBoxRegNo.Text = string.Empty;
            textBoxfirstName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
        }

        private void buttonRetrieve_Click(object sender, EventArgs e)
        {
            textBoxRegNo.Text = aStudent.regNo;
            textBoxfirstName.Text = aStudent.firstName;
            textBoxLastName.Text = aStudent.lastName;
        }
    }
}
