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
    public partial class MainForm : Form
    {
        private DB db = new DB();
        private List<EmployeeControl> controllsList = new List<EmployeeControl>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var employeeList = db.GetList();
            int h = 0;
            foreach (var item in employeeList)
            {
                var control = new EmployeeControl(item);
                control.Parent = itemsPanel;
                control.Top = h;
                control.Left = 0;
                control.Width = itemsPanel.ClientSize.Width;
                control.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                control.Changed += control_Changed;
                control.Show();

                controllsList.Add(control);
                h += control.Height;
            }
            this.Height = itemsPanel.Top + itemsPanel.Height + itemsPanel.Bottom + 10;
        }

        private void control_Changed(object sender, EventArgs e)
        {
            var employeeList = new List<EmployeeItem>();
            foreach (var control in controllsList)
            {
                employeeList.Add(control.GetItem());
            }
            db.Save(employeeList);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var service = new EmailService();
            try
            {
                service.Send(db.GetList(), DateTime.Now);
                MessageBox.Show("Письмо было успешно отправлено на указанный адрес.", "Отправка почты", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка отправки почты", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            using (var form = new SettingsForm())
            {
                form.ShowDialog();
            }
        }
    }
}
