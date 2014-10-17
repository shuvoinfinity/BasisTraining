using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop
{
    public partial class SuperShopUI : Form
    {
        private Shop aShop;

        public SuperShopUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aShop = new Shop(nameTextBox.Text, addressTextBox.Text);
        }

        private void addIteamButton_Click(object sender, EventArgs e)
        {
            Product aProduct = new Product(productTextBox.Text, Convert.ToInt16(quantityTextBox.Text));
            string msg = aShop.Add(aProduct);
            MessageBox.Show(msg);
        }

        private void showAll_Click(object sender, EventArgs e)
        {
            string msg = aShop.Name + "\t" + aShop.Address + "\n";
            msg += "Iteam Numer\t" + "Quantity\n";
            MessageBox.Show(msg);
        }
    }
}
