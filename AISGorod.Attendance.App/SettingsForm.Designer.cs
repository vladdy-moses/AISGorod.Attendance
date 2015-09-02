namespace AISGorod.Attendance.App
{
    partial class SettingsForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.authGroupBox = new System.Windows.Forms.GroupBox();
            this.emailGroupBox = new System.Windows.Forms.GroupBox();
            this.emailBodyEndTextBox = new System.Windows.Forms.TextBox();
            this.emailBodyBeginTextBox = new System.Windows.Forms.TextBox();
            this.emailSubjectTextBox = new System.Windows.Forms.TextBox();
            this.emailToTextBox = new System.Windows.Forms.TextBox();
            this.emailFromNameTextBox = new System.Windows.Forms.TextBox();
            this.emailFromTextBox = new System.Windows.Forms.TextBox();
            this.emailFromNameLabel = new System.Windows.Forms.Label();
            this.emailBodyEndLabel = new System.Windows.Forms.Label();
            this.emailBodyBeginLabel = new System.Windows.Forms.Label();
            this.emailSubjectLabel = new System.Windows.Forms.Label();
            this.emailToLabel = new System.Windows.Forms.Label();
            this.emailFromLabel = new System.Windows.Forms.Label();
            this.authPassTextBox = new System.Windows.Forms.TextBox();
            this.authNameTextBox = new System.Windows.Forms.TextBox();
            this.authServerTextBox = new System.Windows.Forms.TextBox();
            this.authPortLabel = new System.Windows.Forms.Label();
            this.authPassLabel = new System.Windows.Forms.Label();
            this.authNameLabel = new System.Windows.Forms.Label();
            this.authServerLabel = new System.Windows.Forms.Label();
            this.authUseSSLCheckBox = new System.Windows.Forms.CheckBox();
            this.authPortNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.authGroupBox.SuspendLayout();
            this.emailGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authPortNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(334, 375);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 29);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // authGroupBox
            // 
            this.authGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authGroupBox.Controls.Add(this.authPortNumericUpDown);
            this.authGroupBox.Controls.Add(this.authUseSSLCheckBox);
            this.authGroupBox.Controls.Add(this.authPassTextBox);
            this.authGroupBox.Controls.Add(this.authNameTextBox);
            this.authGroupBox.Controls.Add(this.authServerTextBox);
            this.authGroupBox.Controls.Add(this.authPortLabel);
            this.authGroupBox.Controls.Add(this.authPassLabel);
            this.authGroupBox.Controls.Add(this.authNameLabel);
            this.authGroupBox.Controls.Add(this.authServerLabel);
            this.authGroupBox.Location = new System.Drawing.Point(13, 12);
            this.authGroupBox.Name = "authGroupBox";
            this.authGroupBox.Size = new System.Drawing.Size(431, 160);
            this.authGroupBox.TabIndex = 0;
            this.authGroupBox.TabStop = false;
            this.authGroupBox.Text = "Настройки SMTP-клиента";
            // 
            // emailGroupBox
            // 
            this.emailGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailGroupBox.Controls.Add(this.emailBodyEndTextBox);
            this.emailGroupBox.Controls.Add(this.emailBodyBeginTextBox);
            this.emailGroupBox.Controls.Add(this.emailSubjectTextBox);
            this.emailGroupBox.Controls.Add(this.emailToTextBox);
            this.emailGroupBox.Controls.Add(this.emailFromNameTextBox);
            this.emailGroupBox.Controls.Add(this.emailFromTextBox);
            this.emailGroupBox.Controls.Add(this.emailFromNameLabel);
            this.emailGroupBox.Controls.Add(this.emailBodyEndLabel);
            this.emailGroupBox.Controls.Add(this.emailBodyBeginLabel);
            this.emailGroupBox.Controls.Add(this.emailSubjectLabel);
            this.emailGroupBox.Controls.Add(this.emailToLabel);
            this.emailGroupBox.Controls.Add(this.emailFromLabel);
            this.emailGroupBox.Location = new System.Drawing.Point(13, 178);
            this.emailGroupBox.Name = "emailGroupBox";
            this.emailGroupBox.Size = new System.Drawing.Size(431, 191);
            this.emailGroupBox.TabIndex = 1;
            this.emailGroupBox.TabStop = false;
            this.emailGroupBox.Text = "Настройки письма";
            // 
            // emailBodyEndTextBox
            // 
            this.emailBodyEndTextBox.Location = new System.Drawing.Point(124, 156);
            this.emailBodyEndTextBox.Name = "emailBodyEndTextBox";
            this.emailBodyEndTextBox.Size = new System.Drawing.Size(303, 20);
            this.emailBodyEndTextBox.TabIndex = 23;
            // 
            // emailBodyBeginTextBox
            // 
            this.emailBodyBeginTextBox.Location = new System.Drawing.Point(124, 130);
            this.emailBodyBeginTextBox.Name = "emailBodyBeginTextBox";
            this.emailBodyBeginTextBox.Size = new System.Drawing.Size(303, 20);
            this.emailBodyBeginTextBox.TabIndex = 22;
            // 
            // emailSubjectTextBox
            // 
            this.emailSubjectTextBox.Location = new System.Drawing.Point(124, 104);
            this.emailSubjectTextBox.Name = "emailSubjectTextBox";
            this.emailSubjectTextBox.Size = new System.Drawing.Size(303, 20);
            this.emailSubjectTextBox.TabIndex = 21;
            // 
            // emailToTextBox
            // 
            this.emailToTextBox.Location = new System.Drawing.Point(124, 78);
            this.emailToTextBox.Name = "emailToTextBox";
            this.emailToTextBox.Size = new System.Drawing.Size(303, 20);
            this.emailToTextBox.TabIndex = 20;
            // 
            // emailFromNameTextBox
            // 
            this.emailFromNameTextBox.Location = new System.Drawing.Point(124, 52);
            this.emailFromNameTextBox.Name = "emailFromNameTextBox";
            this.emailFromNameTextBox.Size = new System.Drawing.Size(303, 20);
            this.emailFromNameTextBox.TabIndex = 19;
            // 
            // emailFromTextBox
            // 
            this.emailFromTextBox.Location = new System.Drawing.Point(124, 26);
            this.emailFromTextBox.Name = "emailFromTextBox";
            this.emailFromTextBox.Size = new System.Drawing.Size(303, 20);
            this.emailFromTextBox.TabIndex = 18;
            // 
            // emailFromNameLabel
            // 
            this.emailFromNameLabel.AutoSize = true;
            this.emailFromNameLabel.Location = new System.Drawing.Point(3, 55);
            this.emailFromNameLabel.Name = "emailFromNameLabel";
            this.emailFromNameLabel.Size = new System.Drawing.Size(96, 13);
            this.emailFromNameLabel.TabIndex = 13;
            this.emailFromNameLabel.Text = "Имя отправителя";
            // 
            // emailBodyEndLabel
            // 
            this.emailBodyEndLabel.AutoSize = true;
            this.emailBodyEndLabel.Location = new System.Drawing.Point(3, 159);
            this.emailBodyEndLabel.Name = "emailBodyEndLabel";
            this.emailBodyEndLabel.Size = new System.Drawing.Size(79, 13);
            this.emailBodyEndLabel.TabIndex = 17;
            this.emailBodyEndLabel.Text = "Конец письма";
            // 
            // emailBodyBeginLabel
            // 
            this.emailBodyBeginLabel.AutoSize = true;
            this.emailBodyBeginLabel.Location = new System.Drawing.Point(3, 133);
            this.emailBodyBeginLabel.Name = "emailBodyBeginLabel";
            this.emailBodyBeginLabel.Size = new System.Drawing.Size(85, 13);
            this.emailBodyBeginLabel.TabIndex = 16;
            this.emailBodyBeginLabel.Text = "Начало письма";
            // 
            // emailSubjectLabel
            // 
            this.emailSubjectLabel.AutoSize = true;
            this.emailSubjectLabel.Location = new System.Drawing.Point(3, 107);
            this.emailSubjectLabel.Name = "emailSubjectLabel";
            this.emailSubjectLabel.Size = new System.Drawing.Size(34, 13);
            this.emailSubjectLabel.TabIndex = 15;
            this.emailSubjectLabel.Text = "Тема";
            // 
            // emailToLabel
            // 
            this.emailToLabel.AutoSize = true;
            this.emailToLabel.Location = new System.Drawing.Point(3, 81);
            this.emailToLabel.Name = "emailToLabel";
            this.emailToLabel.Size = new System.Drawing.Size(92, 13);
            this.emailToLabel.TabIndex = 14;
            this.emailToLabel.Text = "Email получателя";
            // 
            // emailFromLabel
            // 
            this.emailFromLabel.AutoSize = true;
            this.emailFromLabel.Location = new System.Drawing.Point(3, 29);
            this.emailFromLabel.Name = "emailFromLabel";
            this.emailFromLabel.Size = new System.Drawing.Size(99, 13);
            this.emailFromLabel.TabIndex = 12;
            this.emailFromLabel.Text = "Email отправителя";
            // 
            // authPassTextBox
            // 
            this.authPassTextBox.Location = new System.Drawing.Point(124, 101);
            this.authPassTextBox.Name = "authPassTextBox";
            this.authPassTextBox.Size = new System.Drawing.Size(303, 20);
            this.authPassTextBox.TabIndex = 30;
            // 
            // authNameTextBox
            // 
            this.authNameTextBox.Location = new System.Drawing.Point(124, 75);
            this.authNameTextBox.Name = "authNameTextBox";
            this.authNameTextBox.Size = new System.Drawing.Size(303, 20);
            this.authNameTextBox.TabIndex = 29;
            // 
            // authServerTextBox
            // 
            this.authServerTextBox.Location = new System.Drawing.Point(124, 23);
            this.authServerTextBox.Name = "authServerTextBox";
            this.authServerTextBox.Size = new System.Drawing.Size(303, 20);
            this.authServerTextBox.TabIndex = 27;
            // 
            // authPortLabel
            // 
            this.authPortLabel.AutoSize = true;
            this.authPortLabel.Location = new System.Drawing.Point(3, 52);
            this.authPortLabel.Name = "authPortLabel";
            this.authPortLabel.Size = new System.Drawing.Size(32, 13);
            this.authPortLabel.TabIndex = 23;
            this.authPortLabel.Text = "Порт";
            // 
            // authPassLabel
            // 
            this.authPassLabel.AutoSize = true;
            this.authPassLabel.Location = new System.Drawing.Point(3, 104);
            this.authPassLabel.Name = "authPassLabel";
            this.authPassLabel.Size = new System.Drawing.Size(45, 13);
            this.authPassLabel.TabIndex = 25;
            this.authPassLabel.Text = "Пароль";
            // 
            // authNameLabel
            // 
            this.authNameLabel.AutoSize = true;
            this.authNameLabel.Location = new System.Drawing.Point(3, 78);
            this.authNameLabel.Name = "authNameLabel";
            this.authNameLabel.Size = new System.Drawing.Size(38, 13);
            this.authNameLabel.TabIndex = 24;
            this.authNameLabel.Text = "Логин";
            // 
            // authServerLabel
            // 
            this.authServerLabel.AutoSize = true;
            this.authServerLabel.Location = new System.Drawing.Point(3, 26);
            this.authServerLabel.Name = "authServerLabel";
            this.authServerLabel.Size = new System.Drawing.Size(83, 13);
            this.authServerLabel.TabIndex = 22;
            this.authServerLabel.Text = "Адрес сервера";
            // 
            // authUseSSLCheckBox
            // 
            this.authUseSSLCheckBox.AutoSize = true;
            this.authUseSSLCheckBox.Location = new System.Drawing.Point(6, 128);
            this.authUseSSLCheckBox.Name = "authUseSSLCheckBox";
            this.authUseSSLCheckBox.Size = new System.Drawing.Size(122, 17);
            this.authUseSSLCheckBox.TabIndex = 31;
            this.authUseSSLCheckBox.Text = "Использовать SSL";
            this.authUseSSLCheckBox.UseVisualStyleBackColor = true;
            // 
            // authPortNumericUpDown
            // 
            this.authPortNumericUpDown.Location = new System.Drawing.Point(124, 50);
            this.authPortNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.authPortNumericUpDown.Name = "authPortNumericUpDown";
            this.authPortNumericUpDown.Size = new System.Drawing.Size(301, 20);
            this.authPortNumericUpDown.TabIndex = 28;
            this.authPortNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 416);
            this.Controls.Add(this.emailGroupBox);
            this.Controls.Add(this.authGroupBox);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.authGroupBox.ResumeLayout(false);
            this.authGroupBox.PerformLayout();
            this.emailGroupBox.ResumeLayout(false);
            this.emailGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authPortNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox authGroupBox;
        private System.Windows.Forms.GroupBox emailGroupBox;
        private System.Windows.Forms.TextBox emailBodyEndTextBox;
        private System.Windows.Forms.TextBox emailBodyBeginTextBox;
        private System.Windows.Forms.TextBox emailSubjectTextBox;
        private System.Windows.Forms.TextBox emailToTextBox;
        private System.Windows.Forms.TextBox emailFromNameTextBox;
        private System.Windows.Forms.TextBox emailFromTextBox;
        private System.Windows.Forms.Label emailFromNameLabel;
        private System.Windows.Forms.Label emailBodyEndLabel;
        private System.Windows.Forms.Label emailBodyBeginLabel;
        private System.Windows.Forms.Label emailSubjectLabel;
        private System.Windows.Forms.Label emailToLabel;
        private System.Windows.Forms.Label emailFromLabel;
        private System.Windows.Forms.TextBox authPassTextBox;
        private System.Windows.Forms.TextBox authNameTextBox;
        private System.Windows.Forms.TextBox authServerTextBox;
        private System.Windows.Forms.Label authPortLabel;
        private System.Windows.Forms.Label authPassLabel;
        private System.Windows.Forms.Label authNameLabel;
        private System.Windows.Forms.Label authServerLabel;
        private System.Windows.Forms.CheckBox authUseSSLCheckBox;
        private System.Windows.Forms.NumericUpDown authPortNumericUpDown;
    }
}