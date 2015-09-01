using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISGorod.Attendance.App
{
    public class DB
    {
        private IEnumerable<string> _data;
        private const string FILE_NAME = "db.txt";

        public DB()
        {
            _FillData();
        }

        private void _FillData()
        {
            if (!File.Exists(FILE_NAME))
                File.WriteAllText(FILE_NAME, string.Empty);
            _data = File.ReadAllLines(FILE_NAME).ToList();
        }

        public IEnumerable<EmployeeItem> GetList()
        {
            List<EmployeeItem> result = new List<EmployeeItem>();
            foreach (var item in _data)
                result.Add(EmployeeItem.ParseFromString(item));
            return result;
        }

        public void Save(IEnumerable<EmployeeItem> list)
        {
            File.WriteAllLines(FILE_NAME, list.Select(i => i.ToString()));
            _FillData();
        }
    }
}
