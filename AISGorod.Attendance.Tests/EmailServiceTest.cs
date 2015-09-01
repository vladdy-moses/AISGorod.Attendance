using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AISGorod.Attendance.App;
using System.Net.Mail;
using System.Collections.Generic;

namespace AISGorod.Attendance.Tests
{
    [TestClass]
    public class EmailServiceTest
    {
        [TestMethod]
        [ExpectedException(typeof(SmtpException))]
        public void EmailServiceTest_SendNull()
        {
            var service = new EmailService();
            service.Send(null, DateTime.Now);
        }

        [TestMethod]
        [ExpectedException(typeof(SmtpException))]
        public void EmailServiceTest_SendEmpty()
        {
            var service = new EmailService();
            service.Send(new List<EmployeeItem>(), DateTime.Now);
        }
    }
}
