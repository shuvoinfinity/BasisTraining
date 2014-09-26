using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonUIApp
{
    public partial class PersonInfoForm : Form
    {
        public PersonInfoForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Person aPerson = new Person();

            aPerson.firstName = txtBoxFstName.Text;
            aPerson.middlename = txtBoxMdlName.Text;
            aPerson.lastName = txtBoxLstName.Text;

            txtBoxFullName.Text = aPerson.GetFullName();
            txtBoxReverseName.Text = aPerson.GetFullReverseName();
        }
        
    }
}
