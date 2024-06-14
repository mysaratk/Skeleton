using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;

namespace Testing5
{
    /// <summary>
    /// Summary description for tstOrderCollection
    /// </summary>
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();

            TestItem.OrderId = 1;
            TestItem.DlvrAddress = "48 Town road";
            TestItem.OrderD8 = DateTime.Now;
            TestItem.TtlAmount = 18.57;
            TestItem.OrdrPaid = true;
            TestItem.Sorted = true;

            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;

            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();

            TestOrder.OrderId = 1;
            TestOrder.DlvrAddress = "48 Town road";
            TestOrder.OrderD8 = DateTime.Now;
            TestOrder.TtlAmount = 18.57;
            TestOrder.OrdrPaid = true;
            TestOrder.Sorted = true;

            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();

            TestItem.OrderId = 1;
            TestItem.DlvrAddress = "48 Town road";
            TestItem.OrderD8 = DateTime.Now;
            TestItem.TtlAmount = 18.57;
            TestItem.OrdrPaid = true;
            TestItem.Sorted = true; 

            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

    }
}
