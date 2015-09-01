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
            int h = 10;
            foreach (var item in employeeList)
            {
                var control = new EmployeeControl(item);
                control.Parent = this;
                control.Top = h;
                control.Left = 10;
                control.Width = this.ClientSize.Width - 20;
                control.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                control.Changed += control_Changed;
                control.Show();

                controllsList.Add(control);
                h += control.Height;
            }
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
            service.Send(db.GetList(), DateTime.Now);
        }
    }
}
