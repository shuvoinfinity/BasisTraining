using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerQueueApp
{
    public partial class CustomerQueueUI : Form
    {
        public CustomerQueueUI()
        {
            InitializeComponent();
        }

        //List<CustomerComplain> customerComplainList = new List<CustomerComplain>();

        Queue<CustomerComplain> aCustomerComplains = new Queue<CustomerComplain>();
        private CustomerComplain complain;

        //public int count = 1; 

        

        //private CustomerComplain AddToList(string name, string complain)
        //{
        //    CustomerComplain c = new CustomerComplain();
        //    c.serial = customerComplainList.Count() + 1;
        //    c.name = name;
        //    c.complain = complain;
        //    customerComplainList.Add(c);
        //    return c;
        //}

      



        private void btnEnqueue_Click(object sender, EventArgs e)
        {
        //    CustomerComplain complain = AddToList(txtBoxEnqName.Text, txtBoxEnqComplain.Text);
        //    AddToListView(complain);
        //    ClearForm();
            
            //ListViewItem iteams = new ListViewItem();
            //iteams.Text = complain.serial.ToString();
            //iteams.SubItems.Add(complain.name);
            //iteams.SubItems.Add(complain.complain);

            //lstViewQueue.Items.Add(iteams);

            complain = new CustomerComplain();

            complain.serial = aCustomerComplains.Count()+1;
            complain.name = txtBoxEnqName.Text;
            complain.complain = txtBoxEnqComplain.Text;

            aCustomerComplains.Enqueue(complain);
            AddToListView(complain);

            //count++;

            ClearForm();
           

        }

        private void ClearForm()
        {
            txtBoxEnqName.Text = string.Empty;
            txtBoxEnqComplain.Text = string.Empty;
        }

        private void AddToListView(CustomerComplain complain)
        {
            ListViewItem item = new ListViewItem(complain.serial.ToString());
            item.SubItems.Add(complain.name);
            item.SubItems.Add(complain.complain);
            lstViewQueue.Items.Add(item);
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {

                //lstViewQueue.Items.RemoveAt(0);
                //CustomerComplain c = customerComplainList.FirstOrDefault();
                //customerComplainList.RemoveAt(0);
                //FillDequeBox(c);

            complain = aCustomerComplains.Dequeue();


            FillDequeBox(complain);
        }

        private void FillDequeBox(CustomerComplain complain)
        {
            //txtBoxDqName.Text = c.name;
            //txtBoxSerialNo.Text = c.serial.ToString();
            //txtBoxDqComplain.Text = c.complain;

            txtBoxDqName.Text = complain.name;
            txtBoxSerialNo.Text = complain.serial.ToString();
            txtBoxDqComplain.Text = complain.complain;

            lstViewQueue.Items[0].Remove();
        }
    }
}
