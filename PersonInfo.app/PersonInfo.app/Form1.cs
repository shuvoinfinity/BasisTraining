using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInfo.app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Person aPerson = new Person();
        private void fullNameButton_Click(object sender, EventArgs e)
        {

            aPerson.firstName = firstNameTextBox.Text;
            aPerson.middleName = middleNameTextBox.Text;
            aPerson.lastName = lastNameTextBox.Text;
            fullNameTextBox.Text = aPerson.GetFullName();

        }

        private void reverseNameButton_Click(object sender, EventArgs e)
        {
            reverseNameTextBox.Text = aPerson.GetReverseName();
        }
    }
}
