using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {

        string FullName = "Borislav";
        string DateOfBirth = DateTime.Now.AddYears(-10).ToString();

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
            int TestData = 1; // Assuming staff IDs are integers

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
            string TestData = "Piotr";

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
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 2;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 2;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //check the address id property
            if (AnStaff.StaffID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffFullNameFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 2;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.FullName != "Borislav")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 2;
            Found = AnStaff.Find(StaffId);
            if (AnStaff.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 2;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the date added property
            if (AnStaff.DateOfBirth != Convert.ToDateTime("12/06/2002"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            Error = AnStaff.Valid(FullName, DateOfBirth);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void FullNameMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string FullName = "";
            Error = AnStaff.Valid(FullName, DateOfBirth);
            Assert.AreNotEqual(Error, FullName, "");
            ;
        }
        [TestMethod]
        public void FullNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "x"; //this should be ok
                                   //invoke the method
            Error = AnStaff.Valid(FullName, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "xx"; //this should be ok
                                    //invoke the method
            Error = AnStaff.Valid(FullName, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = ""; //this should be ok
            FullName = FullName.PadRight(49, 'x');                          //invoke the method
            Error = AnStaff.Valid(FullName, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = ""; //this should be ok
            FullName = FullName.PadRight(50, 'x');                           //invoke the method
            Error = AnStaff.Valid(FullName, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"; //this should be ok
                                                                //invoke the method
            Error = AnStaff.Valid(FullName, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = ""; //this should be ok
            FullName = FullName.PadRight(51, 'x');                           //invoke the method
            Error = AnStaff.Valid(FullName, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Parse("02/02/2020");
            TestDate.AddDays(-1);
            //create some test data to pass to the method
            string DateOfBirth = TestDate.ToString(); //this should be ok
                                               //invoke the method
            Error = AnStaff.Valid(FullName, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Parse("02/02/2020");
            //create some test data to pass to the method
            string DateOfBirth = TestDate.ToString(); //this should be ok
                                                      //invoke the method
            Error = AnStaff.Valid(FullName, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Parse("02/02/2020");
            TestDate.AddDays(+1);
            //create some test data to pass to the method
            string DateOfBirth = TestDate.ToString();
            //create some test data to pass to the method
             //this should be ok
                                               //invoke the method
            Error = AnStaff.Valid(FullName, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Parse("02/02/2020");
            TestDate.AddYears(+100);
            //create some test data to pass to the method
            string DateOfBirth = TestDate.ToString(); //this should be ok                                  
            Error = AnStaff.Valid(FullName, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FullName, DateOfBirth);            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FullName, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddYears(-198);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FullName, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FullName, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
    }
}