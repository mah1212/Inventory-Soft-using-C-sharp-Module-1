namespace DesktopInventoryManagementApp.UI
{
    partial class RodSizeEntryUI
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
            this.rodSizeEntryTextBox = new System.Windows.Forms.TextBox();
            this.rodSizeSaveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rodSizeSaveButton);
            this.groupBox1.Controls.Add(this.rodSizeEntryTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rod Size Entry";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size";
            // 
            // rodSizeEntryTextBox
            // 
            this.rodSizeEntryTextBox.Location = new System.Drawing.Point(61, 40);
            this.rodSizeEntryTextBox.Name = "rodSizeEntryTextBox";
            this.rodSizeEntryTextBox.Size = new System.Drawing.Size(173, 20);
            this.rodSizeEntryTextBox.TabIndex = 1;
            // 
            // rodSizeSaveButton
            // 
            this.rodSizeSaveButton.Location = new System.Drawing.Point(22, 92);
            this.rodSizeSaveButton.Name = "rodSizeSaveButton";
            this.rodSizeSaveButton.Size = new System.Drawing.Size(212, 51);
            this.rodSizeSaveButton.TabIndex = 2;
            this.rodSizeSaveButton.Text = "Save";
            this.rodSizeSaveButton.UseVisualStyleBackColor = true;
            this.rodSizeSaveButton.Click += new System.EventHandler(this.rodSizeSaveButton_Click);
            // 
            // RodSizeEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 210);
            this.Controls.Add(this.groupBox1);
            this.Name = "RodSizeEntryUI";
            this.Text = "RodSizeEntryUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button rodSizeSaveButton;
        private System.Windows.Forms.TextBox rodSizeEntryTextBox;
        private System.Windows.Forms.Label label1;
    }
}