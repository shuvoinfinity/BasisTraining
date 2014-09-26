using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileOperationApp
{
    public partial class frmOperation : Form
    {
        public frmOperation()
        {
            InitializeComponent();
        }

        private string fileLocation = @"D:\New folder\newtest.txt";
       
        private void frmOperation_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(fileLocation, FileMode.Append);
            StreamWriter aSteStreamWriter = new StreamWriter(aFileStream);

            aSteStreamWriter.Write(txtName.Text +","+ txtId.Text + "," + txtSalary.Text);
           
            aSteStreamWriter.WriteLine();
            aSteStreamWriter.Close();

            EmptyString();
        }

        private void EmptyString()
        {
            txtName.Text = string.Empty;
            txtId.Text = string.Empty;
            txtSalary.Text = string.Empty;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(fileLocation, FileMode.Open);
            StreamReader aStreamReader = new StreamReader(aFileStream);
            lstBoxShow.Items.Clear();

            double totalSalary = 0;
            while (!aStreamReader.EndOfStream)
            {
                string aLine = aStreamReader.ReadLine();
                lstBoxShow.Items.Add(aLine);

                char[] seperator = { ',' };
                string[] employeeInfo = aLine.Split(seperator);
                lstBoxShow.Items.Add(employeeInfo[0] + " " + employeeInfo[1] + " " + employeeInfo[2]);
                double salary = Convert.ToDouble(employeeInfo[2]);
                totalSalary += salary;
            }
            //txtTotalAmount.Text = totalSalary.ToString();
            //txtTotalAmount.Text = string.Empty;
            aStreamReader.Close();
        }
    }
}
