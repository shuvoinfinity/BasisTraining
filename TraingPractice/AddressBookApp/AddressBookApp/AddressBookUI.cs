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
using CSVLib;

namespace AddressBookApp
{
    public partial class AddressBookUI : Form
    {
        public AddressBookUI()
        {
            InitializeComponent();
        }

        private string fileLocation = @"AddressBook.CSV";
        private void btnSave_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(fileLocation, FileMode.Open);

            CsvFileReader aReader = new CsvFileReader(aFileStream);

            List<string> aRecordList = new List<string>();

            while (aReader.ReadRow(aRecordList))
            {
                string number = aRecordList[0];

                if(number == txtPhoneNumber.Text)
                {
                    MessageBox.Show("Wrong Entry");
                    aFileStream.Close();
                    return;
                }
            }

            aFileStream.Close();

            FileStream aStream = new FileStream(fileLocation, FileMode.Append);
            CsvFileWriter aWriter = new CsvFileWriter(aStream);

            List<string> addressRecord = new List<string>();

            addressRecord.Add(txtPhoneNumber.Text);
            addressRecord.Add(txtName.Text);
            addressRecord.Add(txtEmail.Text);
            addressRecord.Add(txtAddress.Text);
            addressRecord.Add(txtHomePhone.Text);
            
            aWriter.WriteRow(addressRecord);
            
            aStream.Close();

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);

            List<string> outList = new List<string>();

            lstViewOut.SelectedIndices[0];
        }

        private void AddressBookUI_Load(object sender, EventArgs e)
        {

        }
    }
}
