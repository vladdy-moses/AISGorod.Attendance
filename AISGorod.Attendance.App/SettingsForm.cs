using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AISGorod.Attendance.App
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            var s = Properties.Settings.Default;

            authServerTextBox.Text = s.AuthServer;
            authPortNumericUpDown.Value = s.AuthPort;
            authNameTextBox.Text = s.AuthName;
            authPassTextBox.Text = s.AuthPass;
            authUseSSLCheckBox.Checked = s.AuthUseSSL;

            emailFromTextBox.Text = s.EmailFrom;
            emailFromNameTextBox.Text = s.EmailFromName;
            emailToTextBox.Text = s.EmailTo;
            emailSubjectTextBox.Text = s.EmailSubject;
            emailBodyBeginTextBox.Text = s.EmailBodyBegin;
            emailBodyEndTextBox.Text = s.EmailBodyEnd;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var s = Properties.Settings.Default;

            s.AuthServer = authServerTextBox.Text;
            s.AuthPort = Convert.ToInt32(authPortNumericUpDown.Value);
            s.AuthName = authNameTextBox.Text;
            s.AuthPass = authPassTextBox.Text;
            s.AuthUseSSL = authUseSSLCheckBox.Checked;

            s.EmailFrom = emailFromTextBox.Text;
            s.EmailFromName = emailFromNameTextBox.Text;
            s.EmailTo = emailToTextBox.Text;
            s.EmailSubject = emailSubjectTextBox.Text;
            s.EmailBodyBegin = emailBodyBeginTextBox.Text;
            s.EmailBodyEnd = emailBodyEndTextBox.Text;

            s.Save();
            this.Close();
        }
    }
}
