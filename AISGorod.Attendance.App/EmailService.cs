using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AISGorod.Attendance.App
{
    public class EmailService
    {
        SmtpClient _client;
        MailMessage _message;

        public EmailService()
        {
            var s = Properties.Settings.Default;

            _client = new SmtpClient(s.AuthServer, s.AuthPort)
            {
                Timeout = 20000,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(s.AuthName, s.AuthPass),
                EnableSsl = s.AuthUseSSL
            };
            _message = new MailMessage(new MailAddress(s.EmailFrom, s.EmailFromName), new MailAddress(s.EmailTo)) {
                IsBodyHtml = true,
            };
        }

        public void Send(IEnumerable<EmployeeItem> list, DateTime date)
        {
            _FormMessage(list, date);
            _client.Send(_message);
        }

        private void _FormMessage(IEnumerable<EmployeeItem> list, DateTime date)
        {
            if (list == null) return;
            var s = Properties.Settings.Default;

            _message.Subject = string.Format(s.EmailSubject, date.ToShortDateString());
            _message.Body = string.Format(s.EmailBodyBegin, date.ToShortDateString());
            foreach (var item in list)
            {
                _message.Body += item.ToEmailString();
            }
            _message.Body += s.EmailBodyEnd;
        }
    }
}
