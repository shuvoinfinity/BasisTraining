using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployInformation
{
    public partial class InformationUI : Form
    {
        public InformationUI()
        {
            InitializeComponent();
        }


        // user define data type 
        
        Employee anEmployee = new Employee();
        List<Employee> employeeList = new List<Employee>();

        //private int aID;
        //private string aName;
        //private double aSalary;
        //private string address;
        private void btnSave_Click(object sender, EventArgs e)
        {

            //user defined data typed
            anEmployee.Id = Convert.ToInt16(txtID.Text);
            anEmployee.Name = txtname.Text;
            anEmployee.Salary = Convert.ToDouble(txtSalary.Text);
            anEmployee.Address = txtAddress.Text;


            //aID = Convert.ToInt16(txtID.Text);
            //aName = txtname.Text;
            //aSalary = Convert.ToDouble(txtSalary.Text);
            //address = txtAddress.Text;
            
            // add in lists 
            //idList.Add(aID);
            //nameList.Add(aName);
            //salaryList.Add(aSalary);
            //addresList.Add(address);

            //user defined data type 

            employeeList.Add(anEmployee);

            MessageBox.Show("Save successful");

            // inserting to the list view by call ListViewIteam control

            //ListViewItem listViewItem = new ListViewItem(aID.ToString());
            //listViewItem.SubItems.Add(aName);
            //listViewItem.SubItems.Add(aSalary.ToString());

            ListViewItem listViewItem = new ListViewItem(anEmployee.Id.ToString());
            listViewItem.SubItems.Add(anEmployee.Name);
            listViewItem.SubItems.Add(anEmployee.Salary.ToString());
           
            myListView.Items.Add(listViewItem);

            txtID.Text = string.Empty;
            txtname.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtAddress.Text = string.Empty;
            
        }

        private void myListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //int selectedIndex = myListView.SelectedIndices[0];

            //// double click seleted values returned to lists
            //txtID.Text = idList[selectedIndex].ToString();
            //txtname.Text = nameList[selectedIndex].ToString();
            //txtSalary.Text = salaryList[selectedIndex].ToString();
            //txtAddress.Text = addresList[selectedIndex].ToString();

            int selectedIndex = myListView.SelectedIndices[0];

            // double click seleted values returned to lists
             Employee retriveEmployee = employeeList[selectedIndex];
            txtID.Text = anEmployee.Id.ToString();
            txtname.Text = anEmployee.Name;
            txtSalary.Text = anEmployee.Salary.ToString();
            txtAddress.Text = anEmployee.Address;
            
            
        }

        private void InformationUI_Load(object sender, EventArgs e)
        {

        }
    }
}
