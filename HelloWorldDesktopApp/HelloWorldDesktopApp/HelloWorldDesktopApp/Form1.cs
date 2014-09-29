using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldDesktopApp
{
    public partial class HelloWorldAppUI : Form
    {
        public HelloWorldAppUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
