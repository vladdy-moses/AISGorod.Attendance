namespace AISGorod.Attendance.App
{
    partial class EmployeeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.needCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.Location = new System.Drawing.Point(72, 5);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(144, 21);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "%username%";
            // 
            // statusComboBox
            // 
            this.statusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "На работе",
            "На работе (во время отпуска)",
            "В отпуске",
            "В отпуске за свой счёт",
            "На больничном",
            "Уволен"});
            this.statusComboBox.Location = new System.Drawing.Point(222, 3);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(194, 21);
            this.statusComboBox.TabIndex = 2;
            // 
            // needCheckBox
            // 
            this.needCheckBox.AutoSize = true;
            this.needCheckBox.Location = new System.Drawing.Point(4, 4);
            this.needCheckBox.Name = "needCheckBox";
            this.needCheckBox.Size = new System.Drawing.Size(62, 17);
            this.needCheckBox.TabIndex = 0;
            this.needCheckBox.Text = "Учесть";
            this.needCheckBox.UseVisualStyleBackColor = true;
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.needCheckBox);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(419, 31);
            this.Load += new System.EventHandler(this.EmployeeControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.CheckBox needCheckBox;
    }
}
