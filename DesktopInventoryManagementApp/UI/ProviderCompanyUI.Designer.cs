namespace DesktopInventoryManagementApp.UI
{
    partial class ProviderCompanyUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameProviderCompanyEntryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contactProviderCompnayEntrytextBox = new System.Windows.Forms.TextBox();
            this.saveProviderCompanyButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveProviderCompanyButton);
            this.groupBox1.Controls.Add(this.contactProviderCompnayEntrytextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameProviderCompanyEntryTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Provider Company Entry";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameProviderCompanyEntryTextBox
            // 
            this.nameProviderCompanyEntryTextBox.Location = new System.Drawing.Point(73, 35);
            this.nameProviderCompanyEntryTextBox.Name = "nameProviderCompanyEntryTextBox";
            this.nameProviderCompanyEntryTextBox.Size = new System.Drawing.Size(236, 20);
            this.nameProviderCompanyEntryTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact";
            // 
            // contactProviderCompnayEntrytextBox
            // 
            this.contactProviderCompnayEntrytextBox.Location = new System.Drawing.Point(73, 92);
            this.contactProviderCompnayEntrytextBox.Name = "contactProviderCompnayEntrytextBox";
            this.contactProviderCompnayEntrytextBox.Size = new System.Drawing.Size(236, 20);
            this.contactProviderCompnayEntrytextBox.TabIndex = 3;
            // 
            // saveProviderCompanyButton
            // 
            this.saveProviderCompanyButton.Location = new System.Drawing.Point(26, 145);
            this.saveProviderCompanyButton.Name = "saveProviderCompanyButton";
            this.saveProviderCompanyButton.Size = new System.Drawing.Size(283, 44);
            this.saveProviderCompanyButton.TabIndex = 4;
            this.saveProviderCompanyButton.Text = "Save";
            this.saveProviderCompanyButton.UseVisualStyleBackColor = true;
            this.saveProviderCompanyButton.Click += new System.EventHandler(this.saveProviderCompanyButton_Click);
            // 
            // ProviderCompanyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProviderCompanyUI";
            this.Text = "ProviderCompanyUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveProviderCompanyButton;
        private System.Windows.Forms.TextBox contactProviderCompnayEntrytextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameProviderCompanyEntryTextBox;
        private System.Windows.Forms.Label label1;
    }
}