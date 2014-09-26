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

namespace DailyEntry
{
    public partial class DailyEntryUI : Form
    {
        public DailyEntryUI()
        {
            InitializeComponent();
        }

        private string fileLocation = @"DailyEntry.CSV";

        double amount = 0;
        string remark;
        private void btnSave_Click(object sender, EventArgs e)
        {

            FileStream aFileStream = new FileStream(fileLocation, FileMode.Append);
            
            CsvFileWriter aCsvFileWriter = new CsvFileWriter(aFileStream);

            List<string> aRecordList = new List<string>();

            GetValue(aRecordList);
            MessageBox.Show("Saved");


            aCsvFileWriter.WriteRow(aRecordList);
            aFileStream.Close();
        }

        private void GetValue(List<string> aRecordList)
        {
            string selectedName = ComboBoxEntry.Text;
            if (selectedName == "House Rent")
            {
                amount = Convert.ToDouble(txtBoxAmount.Text);
                remark = txtBoxParticular.Text;
                aRecordList.Add(amount.ToString());
                aRecordList.Add(remark);
                txtBoxAmount.Text = string.Empty;
                txtBoxParticular.Text = String.Empty;
            }
            else if (selectedName == "Utility Bill")
            {
                amount = Convert.ToDouble(txtBoxAmount.Text);
                remark = txtBoxParticular.Text;
                aRecordList.Add(amount.ToString());
                aRecordList.Add(remark);
                txtBoxAmount.Text = string.Empty;
                txtBoxParticular.Text = String.Empty;
            }
            else if (selectedName == "Conveyance")
            {
                amount = Convert.ToDouble(txtBoxAmount.Text);
                remark = txtBoxParticular.Text;
                aRecordList.Add(amount.ToString());
                aRecordList.Add(remark);
                txtBoxAmount.Text = string.Empty;
                txtBoxParticular.Text = String.Empty;
            }
            else if (selectedName == "Grocery")
            {
                amount = Convert.ToDouble(txtBoxAmount.Text);
                remark = txtBoxParticular.Text;
                aRecordList.Add(amount.ToString());
                aRecordList.Add(remark);
                txtBoxAmount.Text = string.Empty;
                txtBoxParticular.Text = String.Empty;
            }
            else if (selectedName == "Misc")
            {
                amount = Convert.ToDouble(txtBoxAmount.Text);
                remark = txtBoxParticular.Text;
                aRecordList.Add(amount.ToString());
                aRecordList.Add(remark);
                txtBoxAmount.Text = string.Empty;
                txtBoxParticular.Text = String.Empty;
            }
        }

        private void btnEntryShow_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);

            List<string> record = new List<string>();

            while (aReader.ReadRow(record))
            {
                string bill = record[0];
                double aBill = Convert.ToDouble(bill);
                aBill += aBill;
                txtBoxTotalExpns.Text = aBill.ToString();
            }
            aStream.Close();
        }
    }
}
