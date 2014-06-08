namespace DesktopInventoryManagementApp.UI
{
    partial class ManufacturerEntryUI
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
            this.companyEntryTextBox = new System.Windows.Forms.TextBox();
            this.companySaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manufacturer Name";
            // 
            // companyEntryTextBox
            // 
            this.companyEntryTextBox.Location = new System.Drawing.Point(157, 46);
            this.companyEntryTextBox.Name = "companyEntryTextBox";
            this.companyEntryTextBox.Size = new System.Drawing.Size(185, 20);
            this.companyEntryTextBox.TabIndex = 1;
            // 
            // companySaveButton
            // 
            this.companySaveButton.Location = new System.Drawing.Point(53, 99);
            this.companySaveButton.Name = "companySaveButton";
            this.companySaveButton.Size = new System.Drawing.Size(289, 41);
            this.companySaveButton.TabIndex = 2;
            this.companySaveButton.Text = "Save";
            this.companySaveButton.UseVisualStyleBackColor = true;
            this.companySaveButton.Click += new System.EventHandler(this.companySaveButton_Click);
            // 
            // ManufacturerEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 183);
            this.Controls.Add(this.companySaveButton);
            this.Controls.Add(this.companyEntryTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ManufacturerEntryUI";
            this.Text = "ManufacturerEntryUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox companyEntryTextBox;
        private System.Windows.Forms.Button companySaveButton;
    }
}