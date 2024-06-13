using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing5
{
    [TestClass]
    public class tstOrder
    {
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
        public void Order8OK()
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



    }
}
