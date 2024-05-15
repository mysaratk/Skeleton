using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff ();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void ActiveProbertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Active, TestData);
        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            // Create an instance of the class we want to test
            clsStaff Anstaff = new clsStaff();

            // Create some test data to assign to the property
            int TestData = 1234; // Assuming staff IDs are integers

            // Assign the data to the property
            Anstaff.StaffID = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(Anstaff.StaffID, TestData);
        }
        [TestMethod]
        public void FullNamePropertyOK()
        {
            // Create an instance of the class we want to test
            clsStaff Anstaff = new clsStaff();

            // Create some test data to assign to the property
            string TestData = "John Doe";

            // Assign the data to the property
            Anstaff.FullName = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(Anstaff.FullName, TestData);
        }
        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            // Create an instance of the class we want to test
            clsStaff Anstaff = new clsStaff();

            // Create some test data to assign to the property
            DateTime TestData = new DateTime(1990, 5, 15); // Example date of birth

            // Assign the data to the property
            Anstaff.DateOfBirth = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(Anstaff.DateOfBirth, TestData);
        }
    }
}