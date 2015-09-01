using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using AISGorod.Attendance.App;

namespace AISGorod.Attendance.Tests
{
    [TestClass]
    public class DBTest
    {
        private DB db = new DB();

        [TestInitialize]
        [TestCleanup]
        public void DBTest_Init()
        {
            if (File.Exists(DB.FILE_NAME))
                File.Delete(DB.FILE_NAME);
            var db = new DB();
        }

        [TestMethod]
        public void DBTest_EmptyGetList()
        {
            var listCount = db.GetList().Count;

            Assert.AreEqual(0, listCount);
        }

        [TestMethod]
        public void DBTest_EmptySaveEmpty_null()
        {
            db.Save(null);
            var listCount = db.GetList().Count;

            Assert.AreEqual(0, listCount);
        }

        [TestMethod]
        public void DBTest_EmptySaveEmpty_notNull()
        {
            db.Save(new List<EmployeeItem>());
            var listCount = db.GetList().Count;

            Assert.AreEqual(0, listCount);
        }

        [TestMethod]
        public void DBTest_AddOneItem()
        {
            db.Save(new List<EmployeeItem>() {
                new EmployeeItem() { Name = "n", NeedToSend = true, Status = "s" }
            });
            var listCount = db.GetList().Count;

            Assert.AreEqual(1, listCount);
        }

        [TestMethod]
        public void DBTest_AddTwoItems()
        {
            db.Save(new List<EmployeeItem>() {
                new EmployeeItem() { Name = "n", NeedToSend = true, Status = "s" },
                new EmployeeItem() { Name = "n", NeedToSend = true, Status = "s" }
            });
            var listCount = db.GetList().Count;

            Assert.AreEqual(2, listCount);
        }
    }
}
