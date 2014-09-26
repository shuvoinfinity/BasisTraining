namespace DailyEntry
{
    partial class DailyEntryUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxAmount = new System.Windows.Forms.TextBox();
            this.txtBoxParticular = new System.Windows.Forms.TextBox();
            this.txtBoxTotalExpns = new System.Windows.Forms.TextBox();
            this.txtBoxMaxExpns = new System.Windows.Forms.TextBox();
            this.txtBoxSummary = new System.Windows.Forms.TextBox();
            this.ComboBoxEntry = new System.Windows.Forms.ComboBox();
            this.comboBoxSummary = new System.Windows.Forms.ComboBox();
            this.TxtBoxSummaryTotal = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEntryShow = new System.Windows.Forms.Button();
            this.btnShowSummary = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEntryShow);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.ComboBoxEntry);
            this.groupBox1.Controls.Add(this.txtBoxMaxExpns);
            this.groupBox1.Controls.Add(this.txtBoxTotalExpns);
            this.groupBox1.Controls.Add(this.txtBoxParticular);
            this.groupBox1.Controls.Add(this.txtBoxAmount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entry Group";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowSummary);
            this.groupBox2.Controls.Add(this.TxtBoxSummaryTotal);
            this.groupBox2.Controls.Add(this.comboBoxSummary);
            this.groupBox2.Controls.Add(this.txtBoxSummary);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(456, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 397);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily Expense Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Particular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "View Summary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Expense";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Maximum Expense";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "View Categorywise Expense";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Total";
            // 
            // txtBoxAmount
            // 
            this.txtBoxAmount.Location = new System.Drawing.Point(124, 51);
            this.txtBoxAmount.Name = "txtBoxAmount";
            this.txtBoxAmount.Size = new System.Drawing.Size(215, 20);
            this.txtBoxAmount.TabIndex = 7;
            // 
            // txtBoxParticular
            // 
            this.txtBoxParticular.Location = new System.Drawing.Point(123, 116);
            this.txtBoxParticular.Multiline = true;
            this.txtBoxParticular.Name = "txtBoxParticular";
            this.txtBoxParticular.Size = new System.Drawing.Size(216, 80);
            this.txtBoxParticular.TabIndex = 9;
            // 
            // txtBoxTotalExpns
            // 
            this.txtBoxTotalExpns.Location = new System.Drawing.Point(124, 282);
            this.txtBoxTotalExpns.Name = "txtBoxTotalExpns";
            this.txtBoxTotalExpns.Size = new System.Drawing.Size(215, 20);
            this.txtBoxTotalExpns.TabIndex = 10;
            // 
            // txtBoxMaxExpns
            // 
            this.txtBoxMaxExpns.Location = new System.Drawing.Point(123, 320);
            this.txtBoxMaxExpns.Name = "txtBoxMaxExpns";
            this.txtBoxMaxExpns.Size = new System.Drawing.Size(215, 20);
            this.txtBoxMaxExpns.TabIndex = 11;
            // 
            // txtBoxSummary
            // 
            this.txtBoxSummary.Location = new System.Drawing.Point(125, 144);
            this.txtBoxSummary.Multiline = true;
            this.txtBoxSummary.Name = "txtBoxSummary";
            this.txtBoxSummary.Size = new System.Drawing.Size(267, 196);
            this.txtBoxSummary.TabIndex = 3;
            // 
            // ComboBoxEntry
            // 
            this.ComboBoxEntry.FormattingEnabled = true;
            this.ComboBoxEntry.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.ComboBoxEntry.Location = new System.Drawing.Point(124, 85);
            this.ComboBoxEntry.Name = "ComboBoxEntry";
            this.ComboBoxEntry.Size = new System.Drawing.Size(215, 21);
            this.ComboBoxEntry.TabIndex = 12;
            // 
            // comboBoxSummary
            // 
            this.comboBoxSummary.FormattingEnabled = true;
            this.comboBoxSummary.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.comboBoxSummary.Location = new System.Drawing.Point(125, 58);
            this.comboBoxSummary.Name = "comboBoxSummary";
            this.comboBoxSummary.Size = new System.Drawing.Size(267, 21);
            this.comboBoxSummary.TabIndex = 4;
            // 
            // TxtBoxSummaryTotal
            // 
            this.TxtBoxSummaryTotal.Location = new System.Drawing.Point(235, 355);
            this.TxtBoxSummaryTotal.Name = "TxtBoxSummaryTotal";
            this.TxtBoxSummaryTotal.Size = new System.Drawing.Size(157, 20);
            this.TxtBoxSummaryTotal.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(262, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEntryShow
            // 
            this.btnEntryShow.Location = new System.Drawing.Point(261, 245);
            this.btnEntryShow.Name = "btnEntryShow";
            this.btnEntryShow.Size = new System.Drawing.Size(75, 23);
            this.btnEntryShow.TabIndex = 14;
            this.btnEntryShow.Text = "Show";
            this.btnEntryShow.UseVisualStyleBackColor = true;
            this.btnEntryShow.Click += new System.EventHandler(this.btnEntryShow_Click);
            // 
            // btnShowSummary
            // 
            this.btnShowSummary.Location = new System.Drawing.Point(317, 85);
            this.btnShowSummary.Name = "btnShowSummary";
            this.btnShowSummary.Size = new System.Drawing.Size(75, 23);
            this.btnShowSummary.TabIndex = 6;
            this.btnShowSummary.Text = "Show";
            this.btnShowSummary.UseVisualStyleBackColor = true;
            // 
            // DailyEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 422);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DailyEntryUI";
            this.Text = "Daily Entry UI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEntryShow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox ComboBoxEntry;
        private System.Windows.Forms.TextBox txtBoxMaxExpns;
        private System.Windows.Forms.TextBox txtBoxTotalExpns;
        private System.Windows.Forms.TextBox txtBoxParticular;
        private System.Windows.Forms.TextBox txtBoxAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowSummary;
        private System.Windows.Forms.TextBox TxtBoxSummaryTotal;
        private System.Windows.Forms.ComboBox comboBoxSummary;
        private System.Windows.Forms.TextBox txtBoxSummary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

