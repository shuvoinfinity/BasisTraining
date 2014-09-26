using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameSortingApp
{
    public partial class NameSortingUI : Form
    {
        public NameSortingUI()
        {
            InitializeComponent();
        }
        List<string> usersList = new List<string>();
        private string name;
        private int nameCount = 0;
        private int setCount=0;

        private void addButton_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            if (nameCount <= setCount)
            {
                usersList.Add(name);
            }
            else
            {
                MessageBox.Show("error");
            }
        }




    }

        private void countTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setButton_Click(object sender, EventArgs e)
        {

            int setCounter = Convert.ToInt16(setCounterTextBox.Text);
            this.addButton.Enabled = true;
          
        }

        private void NameSortingUI_Load(object sender, EventArgs e)
        {
            this.addButton.Enabled = false;
        }
    }
}
