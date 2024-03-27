using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Garage
{
    [TestFixture]
    public class TestGarage
    {
        private Garage<Vehicle> garage;

        [SetUp]
        public void Setup()
        {
            // Skapa ett garage med en kapacitet på 5 fordon för varje test
            garage = new Garage<Vehicle>(5);
        }

        [Test]
        public void Park_WhenGarageHasSpace_ShouldReturnTrue()
        {
            // Arrange
            Car car = new Car { RegistrationNumber = "ABC123", Color = "Red", NumberOfWheels = 4, FuelType = "Gasoline", NumberOfSeats = 5 };

            // Act
            bool result = garage.Park(car);

            // Assert
            //Assert.IsTrue(result);
        }

        // Skriv fler tester för de andra metoder som du vill testa...
    }
}
