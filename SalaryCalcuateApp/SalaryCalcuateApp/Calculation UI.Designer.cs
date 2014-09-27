namespace SalaryCalcuateApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxBasic = new System.Windows.Forms.TextBox();
            this.txtBoxHouseRent = new System.Windows.Forms.TextBox();
            this.txtBoxMedical = new System.Windows.Forms.TextBox();
            this.btnTotalSalary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Basic Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "House Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medical Allowance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "% of Basic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "% of Basic";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(102, 14);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(189, 20);
            this.txtBoxName.TabIndex = 6;
            // 
            // txtBoxBasic
            // 
            this.txtBoxBasic.Location = new System.Drawing.Point(102, 52);
            this.txtBoxBasic.Name = "txtBoxBasic";
            this.txtBoxBasic.Size = new System.Drawing.Size(189, 20);
            this.txtBoxBasic.TabIndex = 7;
            // 
            // txtBoxHouseRent
            // 
            this.txtBoxHouseRent.Location = new System.Drawing.Point(102, 83);
            this.txtBoxHouseRent.Name = "txtBoxHouseRent";
            this.txtBoxHouseRent.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHouseRent.TabIndex = 8;
            // 
            // txtBoxMedical
            // 
            this.txtBoxMedical.Location = new System.Drawing.Point(102, 113);
            this.txtBoxMedical.Name = "txtBoxMedical";
            this.txtBoxMedical.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMedical.TabIndex = 9;
            // 
            // btnTotalSalary
            // 
            this.btnTotalSalary.Location = new System.Drawing.Point(102, 160);
            this.btnTotalSalary.Name = "btnTotalSalary";
            this.btnTotalSalary.Size = new System.Drawing.Size(192, 23);
            this.btnTotalSalary.TabIndex = 10;
            this.btnTotalSalary.Text = "Show Me Salary";
            this.btnTotalSalary.UseVisualStyleBackColor = true;
            this.btnTotalSalary.Click += new System.EventHandler(this.btnTotalSalary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.btnTotalSalary);
            this.Controls.Add(this.txtBoxMedical);
            this.Controls.Add(this.txtBoxHouseRent);
            this.Controls.Add(this.txtBoxBasic);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Salary Calculator UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxBasic;
        private System.Windows.Forms.TextBox txtBoxHouseRent;
        private System.Windows.Forms.TextBox txtBoxMedical;
        private System.Windows.Forms.Button btnTotalSalary;
    }
}

