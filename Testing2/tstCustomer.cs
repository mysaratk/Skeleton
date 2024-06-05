using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see  that it exists
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "correct";
            //assign the data to the property
            AnCustomer.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "correct";
            //assign the data to the property
            AnCustomer.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.LastName, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "correct";
            //assign the data to the property
            AnCustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Email, TestData);
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            short TestData = 1;
            //assign the data to the property
            AnCustomer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.PhoneNumber, TestData);
        }

        [TestMethod]
        public void LoginPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "correct";
            //assign the data to the property
            AnCustomer.Login = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Login, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "correct";
            //assign the data to the property
            AnCustomer.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Password, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }

    }
}
