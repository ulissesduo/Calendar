using Calendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.ViewModel
{
    public class StudentViewModel
    {
        private StudentContext _context;

        public StudentViewModel()
        {
            _context = new StudentContext();
        }

        public List<Students> GetStudents(DateTime selectedDate)
        {
            DateTime currentDate = DateTime.Now;
            using (var context = new StudentContext())
            {
                var getStudents = context.Students
                    .Where(std => std.Status == true &&
                            std.WeekDays == selectedDate.DayOfWeek.ToString() &&
                            std.ContractEndDate > currentDate)
                    .ToList();

                return getStudents;


            }
        }
    }
}
