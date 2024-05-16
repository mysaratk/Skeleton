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
            clsStaff AnStaff = new clsStaff();
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
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a boolean variable to store the results of the validation
            bool found = false;
            //create some test data to use with the method
            Int32 StaffID = 21;
            //invoke the method
            found = AnStaff.Find(StaffID);
            //test to see if the result is true
            Assert.IsTrue(found);
        }
        [TestMethod]
        public void TestAdressIDFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test to use with the method
            Int32 StaffId = 21;
            //invoke the method
            found = AnStaff.Find(StaffId);
            //check the staff ID
            if ((Int32)AnStaff.StaffID != 21)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }
    }



    }