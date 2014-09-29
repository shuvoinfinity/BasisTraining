namespace ConditinalExample_DayOfWeek
{
    partial class WeekAppUI
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
            this.weekComboBox = new System.Windows.Forms.ComboBox();
            this.numberOfWeekButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weekComboBox
            // 
            this.weekComboBox.FormattingEnabled = true;
            this.weekComboBox.Items.AddRange(new object[] {
            "Friday",
            "Saturday",
            "Sunday",
            "Monday",
            "TuesDay",
            "WednesDay",
            "Thursday"});
            this.weekComboBox.Location = new System.Drawing.Point(115, 29);
            this.weekComboBox.Name = "weekComboBox";
            this.weekComboBox.Size = new System.Drawing.Size(237, 21);
            this.weekComboBox.TabIndex = 0;
            // 
            // numberOfWeekButton
            // 
            this.numberOfWeekButton.Location = new System.Drawing.Point(164, 91);
            this.numberOfWeekButton.Name = "numberOfWeekButton";
            this.numberOfWeekButton.Size = new System.Drawing.Size(127, 23);
            this.numberOfWeekButton.TabIndex = 1;
            this.numberOfWeekButton.Text = "Number of Week";
            this.numberOfWeekButton.UseVisualStyleBackColor = true;
            this.numberOfWeekButton.Click += new System.EventHandler(this.numberOfWeekButton_Click);
            // 
            // WeekAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 262);
            this.Controls.Add(this.numberOfWeekButton);
            this.Controls.Add(this.weekComboBox);
            this.Name = "WeekAppUI";
            this.Text = "WeekApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox weekComboBox;
        private System.Windows.Forms.Button numberOfWeekButton;
    }
}

