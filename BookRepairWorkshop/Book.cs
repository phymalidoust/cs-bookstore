using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRepairWorkshop
{
    public class Book
    {
        public string RegistrationNumber { get; set; }
        public string Type { get; set; }
        public static uint CountBook;

        public Book(string registrationNumber, string type)
        {
            RegistrationNumber = registrationNumber;
            Type = type;
            CountBook++;
        }
    }
}
