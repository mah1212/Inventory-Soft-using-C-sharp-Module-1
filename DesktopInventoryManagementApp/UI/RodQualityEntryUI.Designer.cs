namespace DesktopInventoryManagementApp.UI
{
    partial class RodQualityEntryUI
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
            this.rodQualityEntryTextBox = new System.Windows.Forms.TextBox();
            this.saveRodQualityButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveRodQualityButton);
            this.groupBox1.Controls.Add(this.rodQualityEntryTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rod Quailty Entry";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quality";
            // 
            // rodQualityEntryTextBox
            // 
            this.rodQualityEntryTextBox.Location = new System.Drawing.Point(93, 45);
            this.rodQualityEntryTextBox.Name = "rodQualityEntryTextBox";
            this.rodQualityEntryTextBox.Size = new System.Drawing.Size(206, 20);
            this.rodQualityEntryTextBox.TabIndex = 1;
            // 
            // saveRodQualityButton
            // 
            this.saveRodQualityButton.Location = new System.Drawing.Point(25, 108);
            this.saveRodQualityButton.Name = "saveRodQualityButton";
            this.saveRodQualityButton.Size = new System.Drawing.Size(274, 59);
            this.saveRodQualityButton.TabIndex = 2;
            this.saveRodQualityButton.Text = "Save";
            this.saveRodQualityButton.UseVisualStyleBackColor = true;
            this.saveRodQualityButton.Click += new System.EventHandler(this.saveRodQualityButton_Click);
            // 
            // RodQualityEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 238);
            this.Controls.Add(this.groupBox1);
            this.Name = "RodQualityEntryUI";
            this.Text = "RodQualityEntryUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveRodQualityButton;
        private System.Windows.Forms.TextBox rodQualityEntryTextBox;
        private System.Windows.Forms.Label label1;
    }
}