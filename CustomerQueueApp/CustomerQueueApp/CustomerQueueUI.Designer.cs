namespace CustomerQueueApp
{
    partial class CustomerQueueUI
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
            this.btnDequeue = new System.Windows.Forms.Button();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.txtBoxDqComplain = new System.Windows.Forms.TextBox();
            this.txtBoxDqName = new System.Windows.Forms.TextBox();
            this.txtBoxSerialNo = new System.Windows.Forms.TextBox();
            this.txtBoxEnqComplain = new System.Windows.Forms.TextBox();
            this.txtBoxEnqName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstViewQueue = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstViewQueue);
            this.groupBox1.Location = new System.Drawing.Point(12, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waiting Queue";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDequeue);
            this.groupBox2.Controls.Add(this.btnEnqueue);
            this.groupBox2.Controls.Add(this.txtBoxDqComplain);
            this.groupBox2.Controls.Add(this.txtBoxDqName);
            this.groupBox2.Controls.Add(this.txtBoxSerialNo);
            this.groupBox2.Controls.Add(this.txtBoxEnqComplain);
            this.groupBox2.Controls.Add(this.txtBoxEnqName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 164);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enqueue Customer";
            // 
            // btnDequeue
            // 
            this.btnDequeue.Location = new System.Drawing.Point(591, 12);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(75, 23);
            this.btnDequeue.TabIndex = 11;
            this.btnDequeue.Text = "Dequeue";
            this.btnDequeue.UseVisualStyleBackColor = true;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.Location = new System.Drawing.Point(206, 124);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(75, 23);
            this.btnEnqueue.TabIndex = 10;
            this.btnEnqueue.Text = "Enqueue";
            this.btnEnqueue.UseVisualStyleBackColor = true;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            // 
            // txtBoxDqComplain
            // 
            this.txtBoxDqComplain.Location = new System.Drawing.Point(451, 99);
            this.txtBoxDqComplain.Multiline = true;
            this.txtBoxDqComplain.Name = "txtBoxDqComplain";
            this.txtBoxDqComplain.Size = new System.Drawing.Size(232, 48);
            this.txtBoxDqComplain.TabIndex = 9;
            // 
            // txtBoxDqName
            // 
            this.txtBoxDqName.Location = new System.Drawing.Point(451, 56);
            this.txtBoxDqName.Name = "txtBoxDqName";
            this.txtBoxDqName.Size = new System.Drawing.Size(232, 20);
            this.txtBoxDqName.TabIndex = 8;
            // 
            // txtBoxSerialNo
            // 
            this.txtBoxSerialNo.Location = new System.Drawing.Point(451, 12);
            this.txtBoxSerialNo.Name = "txtBoxSerialNo";
            this.txtBoxSerialNo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSerialNo.TabIndex = 7;
            // 
            // txtBoxEnqComplain
            // 
            this.txtBoxEnqComplain.Location = new System.Drawing.Point(94, 60);
            this.txtBoxEnqComplain.Multiline = true;
            this.txtBoxEnqComplain.Name = "txtBoxEnqComplain";
            this.txtBoxEnqComplain.Size = new System.Drawing.Size(188, 52);
            this.txtBoxEnqComplain.TabIndex = 6;
            // 
            // txtBoxEnqName
            // 
            this.txtBoxEnqName.Location = new System.Drawing.Point(94, 20);
            this.txtBoxEnqName.Name = "txtBoxEnqName";
            this.txtBoxEnqName.Size = new System.Drawing.Size(188, 20);
            this.txtBoxEnqName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Complain";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Serial Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Complain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // lstViewQueue
            // 
            this.lstViewQueue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstViewQueue.Location = new System.Drawing.Point(22, 20);
            this.lstViewQueue.Name = "lstViewQueue";
            this.lstViewQueue.Size = new System.Drawing.Size(668, 166);
            this.lstViewQueue.TabIndex = 0;
            this.lstViewQueue.UseCompatibleStateImageBehavior = false;
            this.lstViewQueue.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial Number";
            this.columnHeader1.Width = 113;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Complain";
            this.columnHeader3.Width = 357;
            // 
            // CustomerQueueUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 398);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerQueueUI";
            this.Text = "Customer Queue UI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.TextBox txtBoxDqComplain;
        private System.Windows.Forms.TextBox txtBoxDqName;
        private System.Windows.Forms.TextBox txtBoxSerialNo;
        private System.Windows.Forms.TextBox txtBoxEnqComplain;
        private System.Windows.Forms.TextBox txtBoxEnqName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstViewQueue;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

