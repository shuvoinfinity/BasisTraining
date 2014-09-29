using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConditinalExample_DayOfWeek
{
    public partial class WeekAppUI : Form
    {
        public WeekAppUI()
        {
            InitializeComponent();
        }

        private void numberOfWeekButton_Click(object sender, EventArgs e)
        {
            if (weekComboBox.Text == "Friday")
            {
                MessageBox.Show("It's your holiday! Have fun :)");
            }
            else if (weekComboBox.Text == "Saturday")
            {
                MessageBox.Show("Its the second day of week");
            }
            else
            {
                MessageBox.Show("Its a boring working day, so get stressed");
            }
        }
    }
}
