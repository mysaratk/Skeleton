using System;
using System.Data;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    public class clsOrder
    {
        private int _orderId;
        private string _dlvrAddress;
        private DateTime _orderD8;
        private double _ttlAmount;
        private bool _ordrPaid;
        private bool _sorted;

        public int OrderId
        {
            get { return _orderId; }
            set { _orderId = value; }
        }

        public string DlvrAddress
        {
            get { return _dlvrAddress; }
            set { _dlvrAddress = value; }
        }

        public DateTime OrderD8
        {
            get { return _orderD8; }
            set { _orderD8 = value; }
        }

        public double TtlAmount
        {
            get { return _ttlAmount; }
            set { _ttlAmount = value; }
        }

        public bool OrdrPaid
        {
            get { return _ordrPaid; }
            set { _ordrPaid = value; }
        }

        public bool Sorted
        {
            get { return _sorted; }
            set { _sorted = value; }
        }

        public clsOrder()
        {
            // Default constructor
        }

        public clsOrder(int orderId, string dlvrAddress, DateTime orderD8, float ttlAmount, bool ordrPaid, bool sorted)
        {
            _orderId = orderId;
            _dlvrAddress = dlvrAddress;
            _orderD8 = orderD8;
            _ttlAmount = ttlAmount;
            _ordrPaid = ordrPaid;
            _sorted = sorted;
        }

        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(DlvrAddress) || DlvrAddress.Length > 500)
                throw new ArgumentException("Delivery Address must be between 1 and 500 characters", nameof(DlvrAddress));

            if (OrderD8 < DateTime.Now.Date || OrderD8 > DateTime.Now.Date.AddYears(100))
                throw new ArgumentException("Order Date must be on or after the current date and within the next 100 years", nameof(OrderD8));

            if (TtlAmount < 0)
                throw new ArgumentException("Total Cost must be a positive float value", nameof(TtlAmount));

            return true;
        }

        public bool Find(int orderId)
        {
            _orderId = 1;
            _dlvrAddress = "48 Town road";
            _orderD8 = Convert.ToDateTime("11/08/2024");
            _ttlAmount = Convert.ToDouble("18.57");
            _ordrPaid = true;
            _sorted = true;

            return true;
        }
    }
}