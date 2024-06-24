using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingMsTestIntro;

namespace Tests
{
    [TestClass]
    public class CollectionSampleTests
    {
        [TestMethod]
        public void GetCustomer_ShouldGetSameCustomer()
        {
            // Arrange
            Customer[] customers = new Customer[2]
            {
                new() { FirstName = "John", LastName = "Doe" },
                new() { FirstName = "Jane", LastName = "Doe" }
            };

            int index = 1;
            Customer expected = customers[1];

            // Act
            Customer actual = CollectionsSample.GetCustomer(customers, index);

            // Assert
            Assert.IsInstanceOfType(actual, typeof(Customer));
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetCustomer_ShouldThrowIndexOutofRangeException()
        {
            // Arrange
            Customer[] customers = new Customer[2]
            {
                new() { FirstName = "John", LastName = "Doe" },
                new() { FirstName = "Jane", LastName = "Doe" }
            };

            int index = 3;

            // Act 
            CollectionsSample.GetCustomer(customers, index);

            // Assert "This is handle in ExpectedException decorator".
        }
    }
}
