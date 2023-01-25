# Sample code in C#
Created by Mohammad Alidoust

## Bookstore and book repair workshop

Imagine a bookstore receives books that need to be repaired. According to the workshop, the bookstore should divide the books into three categories (1) 'Ancient': Age>30yr (2) "Old": 30yr>Age>10yr (3) "Young": Age<10yr.

The code simulates a primitive registration system where it registers books and repairs' history with unique book and repair IDs.

When registering a new item, it gives an alarm if a book or repair was already registered in the system and retrieves information for registered books.
## Directories
### BookRepairWorkshop
It contains the main code `Program.cs` and classes `Book.cs`, `Repair.cs`, `WorkShop.cs`, `Tools.cs`. The comments in the codes describe individual tasks that each part of the code performs.

### BookRepairWorkshop.NUnitTests
It contains unit tests to check out the proper functionality of the different parts of the code.
The main code is stored in the `WorkshopTests.cs` class.
