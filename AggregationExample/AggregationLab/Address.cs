using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    class Address
    {
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        // constructors
        public Address() { }

        public Address(int number, string street, string city, string state, string zip)
        {
            StreetNumber = number;
            StreetName = street;
            City = city;
            State = state;
            Zip = zip;
        }

        // methods
        public void PrintAddress()
        {
            Console.WriteLine("{0} {1}", StreetNumber, StreetName);
            Console.WriteLine("{0}, {1} {2}", City, State, Zip);
        }
    }
}
