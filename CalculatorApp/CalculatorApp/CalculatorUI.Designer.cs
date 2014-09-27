namespace CalculatorApp
{
    partial class CalculatorUI
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
            this.txtBoxFirstNumber = new System.Windows.Forms.TextBox();
            this.txtBoxSecndNumber = new System.Windows.Forms.TextBox();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtrac = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // txtBoxFirstNumber
            // 
            this.txtBoxFirstNumber.Location = new System.Drawing.Point(134, 36);
            this.txtBoxFirstNumber.Name = "txtBoxFirstNumber";
            this.txtBoxFirstNumber.Size = new System.Drawing.Size(263, 20);
            this.txtBoxFirstNumber.TabIndex = 3;
            // 
            // txtBoxSecndNumber
            // 
            this.txtBoxSecndNumber.Location = new System.Drawing.Point(134, 81);
            this.txtBoxSecndNumber.Name = "txtBoxSecndNumber";
            this.txtBoxSecndNumber.Size = new System.Drawing.Size(263, 20);
            this.txtBoxSecndNumber.TabIndex = 4;
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Location = new System.Drawing.Point(134, 121);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new System.Drawing.Size(263, 20);
            this.txtBoxResult.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(49, 183);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtrac
            // 
            this.btnSubtrac.Location = new System.Drawing.Point(184, 183);
            this.btnSubtrac.Name = "btnSubtrac";
            this.btnSubtrac.Size = new System.Drawing.Size(75, 23);
            this.btnSubtrac.TabIndex = 7;
            this.btnSubtrac.Text = "Subtract";
            this.btnSubtrac.UseVisualStyleBackColor = true;
            this.btnSubtrac.Click += new System.EventHandler(this.btnSubtrac_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(322, 183);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 23);
            this.btnMultiply.TabIndex = 8;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(451, 183);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 9;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // CalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 261);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtrac);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.txtBoxSecndNumber);
            this.Controls.Add(this.txtBoxFirstNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalculatorUI";
            this.Text = "CalculatorUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxFirstNumber;
        private System.Windows.Forms.TextBox txtBoxSecndNumber;
        private System.Windows.Forms.TextBox txtBoxResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtrac;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
    }
}

