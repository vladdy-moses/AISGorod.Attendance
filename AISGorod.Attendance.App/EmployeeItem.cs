using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISGorod.Attendance.App
{
    public class EmployeeItem
    {
        public string Name { set; get; }
        public string Status { set; get; }
        public bool NeedToSend { set; get; }

        public override string ToString()
        {
            return string.Format("{0};{1};{2}", Name, Status, NeedToSend ? "1" : "0");
        }

        public string ToEmailString()
        {
            if (!NeedToSend)
                return string.Empty;
            return string.Format("<strong>{0}</strong> – {1}<br>", Name, Status);
        }

        public static EmployeeItem ParseFromString(string src)
        {
            var s = src.Split(';');
            return new EmployeeItem() { Name = s[0], Status = s[1], NeedToSend = (s[2] != "0") };
        }
    }
}
