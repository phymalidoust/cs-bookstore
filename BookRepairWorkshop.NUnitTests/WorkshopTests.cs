namespace BookRepairWorkshop.NUnitTests
{
    public class WorkshopTests
    {
        private Workshop _workshop { get; set; } = null!;
        private string _validRegistrationNumber;
        private string _invalidRegistrationNumber;
        private string _validType;
        private string _validDescription;
        private decimal _validCost;
        private DateTime _validDate;

        [SetUp]
        public void Setup()
        {
            _validRegistrationNumber = "123-ABC";
            _invalidRegistrationNumber = "456-DEF";
            _validType = "Ancient";
            _validDescription = "Repair Test";
            //_validCost = 500;
            //_validDate = DateTime.Now;
            _workshop = new Workshop();
            _workshop.RegisterBook(_validRegistrationNumber, _validType);
        }

        [Test]
        public void RegisterVehicle_ValidInput_ShouldAddVehicle()
        {
            _workshop.RegisterBook("789-GHI", "Old");
            var books = _workshop.books;
            Assert.That(2, Is.EqualTo(books.Count));
        }

        [Test]
        public void RegisterVehicle_DuplicateRegistrationNumber_ShouldNotAddVehicle()
        {
            _workshop.RegisterBook(_validRegistrationNumber, "Old");
            var books = _workshop.books;
            Assert.That(1, Is.EqualTo(books.Count));
        }

        [Test]
        public void RegisterRepair_ValidInput_ShouldAddRepair()
        {
            _workshop.RegisterRepair(_validRegistrationNumber, _validDescription, _validCost, _validDate);
            var repairs = _workshop.repairs;
            Assert.That(1, Is.EqualTo(repairs.Count));
        }

        [Test]
        public void RegisterRepair_InvalidRegistrationNumber_ShouldNotAddRepair()
        {
            _workshop.RegisterRepair(_invalidRegistrationNumber, _validDescription, _validCost, _validDate);
            var repairs = _workshop.repairs;
            Assert.That(0, Is.EqualTo(repairs.Count));
        }

    }
}