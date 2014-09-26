using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsApp
{
    public partial class StudentsInfoUI : Form
    {
        public StudentsInfoUI()
        {
            InitializeComponent();
        }
        List<Student> studentlist = new List<Student>();
        private void buttonShow_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();

            aStudent.regNo = textBoxRegNo.Text;
            aStudent.firstName = textBoxfirstName.Text;
            aStudent.lastName = textBoxLastName.Text;

            studentlist.Add(aStudent);
            MessageBox.Show("Save successfull");
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            textBoxRegNo.Text = string.Empty;
            textBoxfirstName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;

        }

        private void buttonRetrieve_Click(object sender, EventArgs e)
        {
            string mesg = "RegNo\tFull Name\n";
            foreach (Student allStudent in studentlist)
            {
                mesg += allStudent.regNo + "\t" + allStudent.GetFullname() + "\n";
            }
            MessageBox.Show(mesg);
        }
    }
}
