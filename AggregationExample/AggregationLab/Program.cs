using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            // create student
            Student bill = new Student("Bill Baker");
            bill.UpdateAddress(123, "Elm St.", "Vancouver", "WA", "90807");
            ScheduleItem tempItem = new ScheduleItem("CTEC", 135, "Microsoft Software Development With C#", 5);
            bill.AddScheduleItem(tempItem);

            // Let's print stuff out
            Console.WriteLine("Student: {0}", bill.Name);
            Console.WriteLine();
            bill.PrintAddress();
            Console.WriteLine();
            bill.PrintSchedule();
        }
    }
}
