using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRepairWorkshop
{
    public class Repair
    {
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public DateTime Date { get; set; }
        public Book Book { get; set; }
        public string Id { get; set; }
        public static uint CountRepair;

        public Repair(string description, decimal cost, DateTime date, Book book)
        {
            Description = description;
            Cost = cost;
            Date = date;
            Book = book;
            Id = Tools.GenerateRandomNumber();
            CountRepair++;
        }
    }
}
