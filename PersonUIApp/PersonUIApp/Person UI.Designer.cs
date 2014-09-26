namespace PersonUIApp
{
    partial class PersonInfoForm
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
            this.txtBoxFstName = new System.Windows.Forms.TextBox();
            this.txtBoxMdlName = new System.Windows.Forms.TextBox();
            this.txtBoxLstName = new System.Windows.Forms.TextBox();
            this.txtBoxFullName = new System.Windows.Forms.TextBox();
            this.txtBoxReverseName = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Full Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reverse Name";
            // 
            // txtBoxFstName
            // 
            this.txtBoxFstName.Location = new System.Drawing.Point(150, 19);
            this.txtBoxFstName.Name = "txtBoxFstName";
            this.txtBoxFstName.Size = new System.Drawing.Size(167, 20);
            this.txtBoxFstName.TabIndex = 5;
            // 
            // txtBoxMdlName
            // 
            this.txtBoxMdlName.Location = new System.Drawing.Point(150, 55);
            this.txtBoxMdlName.Name = "txtBoxMdlName";
            this.txtBoxMdlName.Size = new System.Drawing.Size(167, 20);
            this.txtBoxMdlName.TabIndex = 6;
            // 
            // txtBoxLstName
            // 
            this.txtBoxLstName.Location = new System.Drawing.Point(150, 92);
            this.txtBoxLstName.Name = "txtBoxLstName";
            this.txtBoxLstName.Size = new System.Drawing.Size(167, 20);
            this.txtBoxLstName.TabIndex = 7;
            // 
            // txtBoxFullName
            // 
            this.txtBoxFullName.Location = new System.Drawing.Point(150, 168);
            this.txtBoxFullName.Name = "txtBoxFullName";
            this.txtBoxFullName.Size = new System.Drawing.Size(270, 20);
            this.txtBoxFullName.TabIndex = 8;
            // 
            // txtBoxReverseName
            // 
            this.txtBoxReverseName.Location = new System.Drawing.Point(150, 204);
            this.txtBoxReverseName.Name = "txtBoxReverseName";
            this.txtBoxReverseName.Size = new System.Drawing.Size(270, 20);
            this.txtBoxReverseName.TabIndex = 9;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(333, 134);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // PersonInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 261);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtBoxReverseName);
            this.Controls.Add(this.txtBoxFullName);
            this.Controls.Add(this.txtBoxLstName);
            this.Controls.Add(this.txtBoxMdlName);
            this.Controls.Add(this.txtBoxFstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonInfoForm";
            this.Text = "UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxFstName;
        private System.Windows.Forms.TextBox txtBoxMdlName;
        private System.Windows.Forms.TextBox txtBoxLstName;
        private System.Windows.Forms.TextBox txtBoxFullName;
        private System.Windows.Forms.TextBox txtBoxReverseName;
        private System.Windows.Forms.Button btnShow;
    }
}

