namespace NameSortingApp
{
    partial class NameSortingUI
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
            this.addButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.allNamesListBox = new System.Windows.Forms.ListBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.counterLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.setCounterTextBox = new System.Windows.Forms.TextBox();
            this.setButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(353, 64);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(353, 128);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(353, 206);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 23);
            this.showAllButton.TabIndex = 2;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Name";
            // 
            // allNamesListBox
            // 
            this.allNamesListBox.FormattingEnabled = true;
            this.allNamesListBox.Location = new System.Drawing.Point(140, 160);
            this.allNamesListBox.Name = "allNamesListBox";
            this.allNamesListBox.Size = new System.Drawing.Size(120, 199);
            this.allNamesListBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(209, 67);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Location = new System.Drawing.Point(140, 128);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(63, 13);
            this.counterLabel.TabIndex = 6;
            this.counterLabel.Text = "Add Count :";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(353, 336);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // setCounterTextBox
            // 
            this.setCounterTextBox.Location = new System.Drawing.Point(209, 24);
            this.setCounterTextBox.Name = "setCounterTextBox";
            this.setCounterTextBox.Size = new System.Drawing.Size(100, 20);
            this.setCounterTextBox.TabIndex = 9;
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(353, 20);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 10;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // NameSortingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 421);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.setCounterTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.allNamesListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.addButton);
            this.Name = "NameSortingUI";
            this.Text = "Name Sort UI";
            this.Load += new System.EventHandler(this.NameSortingUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox allNamesListBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox setCounterTextBox;
        private System.Windows.Forms.Button setButton;
    }
}

