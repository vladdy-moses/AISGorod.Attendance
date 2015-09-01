using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AISGorod.Attendance.App
{
    public partial class EmployeeControl : UserControl
    {
        public event EventHandler Changed;

        public EmployeeControl()
        {
            InitializeComponent();
        }

        public EmployeeControl(EmployeeItem item)
            : this()
        {
            needCheckBox.Checked = item.NeedToSend;
            nameLabel.Text = item.Name;
            statusComboBox.Text = item.Status;
        }

        public EmployeeItem GetItem()
        {
            return new EmployeeItem()
            {
                Name = nameLabel.Text,
                Status = statusComboBox.Text,
                NeedToSend = needCheckBox.Checked
            };
        }

        private void EmployeeControl_Load(object sender, EventArgs e)
        {
            needCheckBox.CheckedChanged += needCheckBox_CheckedChanged;
            statusComboBox.TextChanged += statusComboBox_TextChanged;
        }

        private void statusComboBox_TextChanged(object sender, EventArgs e)
        {
            if(Changed != null)
                Changed(sender, e);
        }

        private void needCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Changed != null)
                Changed(sender, e);
        }
    }
}
