using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelLib.model;

namespace PersonTest
{
    [TestClass]
    public class UnitTest1
    {
        // f�lles instans felt
        private Person p = null;

        [TestInitialize]
        public void BeforeEachTestMethod()
        {
            p = new Person();
        }





        [TestMethod]
        [DataRow(1000)] // mindste lovlige v�rdi
        [DataRow(99999)] // h�jeste lovlige v�rdi
        [DataRow(5467)]  // v�rdi midt i mellem
        public void TestId1(int testId)
        {
            // Arrange
            //Person p = new Person(); -- findes i testInitiliaze
            int expectedValue = testId;

            // Act
            p.Id = testId;
            int actualValue = p.Id;

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        // -- Laver det vha. datarows
        //[TestMethod]
        //public void TestId2()
        //{
        //    // Arrange
        //    Person p = new Person();
        //    int expectedValue = 99999;

        //    // Act
        //    p.Id = 99999;
        //    int actualValue = p.Id;

        //    // Assert
        //    Assert.AreEqual(expectedValue, actualValue);

        //}

        [TestMethod]
        [DataRow(999)]
        [DataRow(100000)]
        [DataRow(-1001)]
        public void TestId3(int testId)
        {
            // arrange
            //Person p = new Person(); -- findes i testInitiliaze
            // exception forventet

            // act -- foreg�r i lambda-udtryk

            // Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => p.Id = testId);


        }

        [TestMethod]
        [DataRow(999)]
        public void TestId4(int testId)
        {
            // arrange
            //Person p = new Person();
            // exception forventet

            // act -- foreg�r i lambda-udtryk

            // Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
                {
                    Person p = new Person(testId, "dummy", "12345678");

                } 
                );


        }
    }
}
