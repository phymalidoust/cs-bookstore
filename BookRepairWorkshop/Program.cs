
// Create a new Workshop object
using BookRepairWorkshop;

var workshop = new Workshop();
// Create a new Random object
var random = new Random();
// An array of vehicle types
var types = new[] { "Ancient", "Old", "Young" };

// Register some vehicles
for (int i = 0; i < 5; i++)
{
    // Generate a random registration number
    string registrationNumber = Tools.GenerateRandomNumber();
    // Choose a random type from the types array
    string type = types[random.Next(types.Length)];
    // Register the vehicle
    workshop.RegisterBook(registrationNumber, type);
}

// Register some repairs
for (int i = 0; i < 5; i++)
{
    // Choose a random vehicle from the list of vehicles
    string registrationNumber = workshop.books[random.Next(workshop.books.Count)].RegistrationNumber;
    string description = "Repair " + i;
    decimal cost = (decimal)random.Next(100, 1000);
    DateTime date = new DateTime(random.Next(2020, 2023), random.Next(1, 13), random.Next(1, 29));

    workshop.RegisterRepair(registrationNumber, description, cost, date);
}

// Retrieve some repair information
for (int i = 0; i < 5; i++)
{
    var repairId = workshop.repairs[i].Id;

    workshop.GetRepairInformation(repairId);
    Console.WriteLine("-----------------------------");
}