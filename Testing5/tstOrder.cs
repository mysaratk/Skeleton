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
    }
}
