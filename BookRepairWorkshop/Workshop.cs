using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRepairWorkshop
{
    public class Workshop
    {
        // Declare a list to store all books and repairs
        public List<Book> books { get; set; } = null!;
        public List<Repair> repairs { get; set; } = null!;

        public Workshop()
        {
            books = new List<Book>();
            repairs = new List<Repair>();
        }

        // Register a new book in the system
        public void RegisterBook(string registrationNumber, string type)
        {
            // Check if the book already exists in the system
            if (IsExist(registrationNumber))
            {
                Console.WriteLine("This book already registered.");
                return;
            }
            // Create a new book object
            var book = new Book(registrationNumber, type);
            // Add the book object to the books list
            books.Add(book);
        }

        // Register a new repair in the system
        public void RegisterRepair(string registrationNumber, string description, decimal cost, DateTime date)
        {
            // Find the book that the repair belongs to
            var book = books.Find(x => x.RegistrationNumber == registrationNumber);
            // Check if the book exists in the system
            if (book == null)
            {
                Console.WriteLine("This book doesn't exist in the system.");
                return;
            }
            // Create a new repair object
            var repair = new Repair(description, cost, date, book);
            // Add the repair object to the repairs list
            repairs.Add(repair);
        }

        // Retrieve all information about a repair and the book the repair belongs to
        public void GetRepairInformation(string repairId)
        {
            // Find the repair with the specified ID
            var repair = repairs.Find(x => x.Id == repairId);
            if (repair == null)
            {
                Console.WriteLine("Repair with this ID doesn't exist in the system.");
                return;
            }
            Console.WriteLine("Repair Information:");
            Console.WriteLine($"ID: {repair.Id}");
            Console.WriteLine($"Description: {repair.Description}");
            Console.WriteLine($"Cost: {repair.Cost}");
            Console.WriteLine($"Date: {repair.Date}");
            Console.WriteLine("Book Information:");
            Console.WriteLine($"Registration Number: {repair.Book.RegistrationNumber}");
            Console.WriteLine($"Type: {repair.Book.Type}");
        }

        private bool IsExist(string registrationNumber)
        {
            // Check if there is any book in the books list with the specified registration number
            return books.Any(x => x.RegistrationNumber == registrationNumber);
        }
    }

}
