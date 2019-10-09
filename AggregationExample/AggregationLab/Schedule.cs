using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    class Schedule
    {
        ScheduleItem[] schedule = new ScheduleItem[10];

        public void AddScheduleItem(ScheduleItem item)
        {
            for(int i=0; i < schedule.Length; i++)
            {
                // put item in next open spot in array then quit
                if(schedule[i] == null)
                {
                    schedule[i] = item;
                    break;
                }
            }
        }

        public void PrintSchedule()
        {
            foreach(ScheduleItem item in schedule)
            {
                if(item != null)
                {
                    Console.WriteLine("{0} {1}\t{2}", item.Department, item.CourseNumber, item.CourseName);
                }
            }
        }
    }
}
