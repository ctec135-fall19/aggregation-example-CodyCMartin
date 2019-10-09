using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    class ScheduleItem
    {
        public string Department { get; set; }
        public int CourseNumber { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public string Description { get; set; }
        public string CourseOutcomes { get; set; }

        // constructors
        public ScheduleItem() { }

        public ScheduleItem(string d, int cn, string name, int credits)
        {
            Department = d;
            CourseNumber = cn;
            CourseName = name;
            Credits = credits;
        }
    }
}
