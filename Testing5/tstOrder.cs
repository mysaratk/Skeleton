using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing5
{

    [TestClass]
    public class tstOrder
    {
        string DlvrAddress = "33 Castle Street";
        string TtlAmount = "20.45";
        string OrderD8 = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder(); 
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void DlvrAddressOk()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "33 Castle Street";
            AnOrder.DlvrAddress = TestData;
            Assert.AreEqual(AnOrder.DlvrAddress, TestData);
        }

        [TestMethod]
        public void OrderD8OK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.OrderD8 = TestData;
            Assert.AreEqual(AnOrder.OrderD8, TestData);
        }

        [TestMethod]
        public void TtlAmountOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.TtlAmount = TestData;
            Assert.AreEqual(AnOrder.TtlAmount, TestData);
        }

        [TestMethod]
        public void OrdrPaidOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.OrdrPaid = TestData;
            Assert.AreEqual(AnOrder.OrdrPaid, TestData);
        }

        [TestMethod]
        public void SortedOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.Sorted = TestData;
            Assert.AreEqual(AnOrder.Sorted, TestData);
        }

        //Testing for find method

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void OrderIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);

            if (AnOrder.OrderId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DlvrAddressFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);

            if (AnOrder.DlvrAddress != "48 Town road")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void OrderD8Found()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);

            if (AnOrder.OrderD8 != Convert.ToDateTime("11/08/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TtlAmountFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);

            if (AnOrder.TtlAmount != Convert.ToDouble("18.57"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void OrdrPaidFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);

            if (AnOrder.OrdrPaid != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SortedFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);

            if (AnOrder.Sorted != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]

        
        public void ValidMethodOk()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Error = AnOrder.Valid(DlvrAddress, OrderD8, TtlAmount);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        
        public void DlvrAddressNoMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DlvrAddress = "";
            Error = AnOrder.Valid(DlvrAddress, OrderD8, TtlAmount);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
       
        public void DlvrAddressNoMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DlvrAddress = "1";
            Error = AnOrder.Valid(DlvrAddress, OrderD8, TtlAmount);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        
        public void DlvrAddressNoMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DlvrAddress = "2";
            Error = AnOrder.Valid(DlvrAddress, OrderD8, TtlAmount);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        
        public void DlvrAddressNoMaxLessOne()
        { 
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DlvrAddress = "49";
            Error = AnOrder.Valid(DlvrAddress, OrderD8, TtlAmount);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DlvrAddressNoMax()
        {

            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DlvrAddress = "50";
            Error = AnOrder.Valid(DlvrAddress, OrderD8, TtlAmount);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void DlvrAddressNoMaxPlusOne()
        {

            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DlvrAddress = "51";
            Error = AnOrder.Valid(DlvrAddress, OrderD8, TtlAmount);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void DlvrAddressNoMid()
        {

            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DlvrAddress = "25";
            Error = AnOrder.Valid(DlvrAddress, OrderD8, TtlAmount);
            Assert.AreEqual(Error, "");

            }
        }
}

