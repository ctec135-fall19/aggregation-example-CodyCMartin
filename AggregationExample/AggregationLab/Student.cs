using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    class Student
    {
        public string Name { get; set; }
        private Address address;
        private Schedule schedule;

        // constructor
        public Student(string name)
        {
            Name = name;
            address = new Address();
            schedule = new Schedule();
        }

        // methods
        public void UpdateAddress(int number, string street, string city, string state, string zip)
        {
            address.StreetNumber = number;
            address.StreetName = street;
            address.City = city;
            address.State = state;
            address.Zip = zip;
        }

        public void AddScheduleItem(ScheduleItem item)
        {
            schedule.AddScheduleItem(item);
        }

        public void PrintAddress()
        {
            address.PrintAddress();
        }

        public void PrintSchedule()
        {
            schedule.PrintSchedule();
        }
    }
}
