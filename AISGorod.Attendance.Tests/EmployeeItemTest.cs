using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AISGorod.Attendance.App;

namespace AISGorod.Attendance.Tests
{
    [TestClass]
    public class EmployeeItemTest
    {
        [TestMethod]
        public void EmployeeItemTest_ToString()
        {
            var item = new EmployeeItem() { Name = "n", NeedToSend = false, Status = "s" };
            Assert.AreEqual("n;s;0", item.ToString());

            item.Name = string.Empty;
            Assert.AreEqual(";s;0", item.ToString());

            item.Name = null;
            Assert.AreEqual(";s;0", item.ToString());

            item.NeedToSend = true;
            Assert.AreEqual(";s;1", item.ToString());

            item.Status = "!!!";
            Assert.AreEqual(";!!!;1", item.ToString());
        }

        [TestMethod]
        public void EmployeeItemTest_ParseName()
        {
            var item = EmployeeItem.ParseFromString("n;s;0");
            Assert.AreEqual("n", item.Name);

            item = EmployeeItem.ParseFromString(";s;0");
            Assert.AreEqual("", item.Name);

            item = EmployeeItem.ParseFromString(" ;s;0");
            Assert.AreEqual(" ", item.Name);
        }

        [TestMethod]
        public void EmployeeItemTest_ParseStatus()
        {
            var item = EmployeeItem.ParseFromString("n;s;0");
            Assert.AreEqual("s", item.Status);

            item = EmployeeItem.ParseFromString("n;;0");
            Assert.AreEqual("", item.Status);

            item = EmployeeItem.ParseFromString(";s;0");
            Assert.AreEqual("s", item.Status);
        }

        [TestMethod]
        public void EmployeeItemTest_ParseNeed()
        {
            var item = EmployeeItem.ParseFromString("n;s;0");
            Assert.AreEqual(false, item.NeedToSend);

            item = EmployeeItem.ParseFromString(";s;1");
            Assert.AreEqual(true, item.NeedToSend);

            item = EmployeeItem.ParseFromString(";;2");
            Assert.AreEqual(true, item.NeedToSend);

            item = EmployeeItem.ParseFromString(";;texttext");
            Assert.AreEqual(true, item.NeedToSend);
        }
    }
}
