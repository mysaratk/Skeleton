using System;
using System.Data;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics.Eventing.Reader;

namespace ClassLibrary
{

    public class clsOrder : ClsOrderBase
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

        public bool Find(int OrderId)
        {
            clsDataConnection DB = new clsDataConnection();
           
            DB.AddParameter("@OrderId", OrderId);
            DB.Execute("sproc_tblOrders_FilterByOrderId");

            if (DB.Count == 1)
            {
                _orderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                _dlvrAddress = Convert.ToString(DB.DataTable.Rows[0]["DlvrAddress"]);
                _orderD8 = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderD8"]);
                _ttlAmount = Convert.ToDouble(DB.DataTable.Rows[0]["TtlAmount"]);
                _ordrPaid = Convert.ToBoolean(DB.DataTable.Rows[0]["OrdrPaid"]);
                _sorted = Convert.ToBoolean(DB.DataTable.Rows[0]["Sorted"]);

                return true;
            }
            else
            {
                return false;
            }
         
          
        }

       public string Valid(string DlvrAddress, string OrderD8, string TtlAmount)
        {
            String Error = "";
            if (DlvrAddress.Length == 0)
            {
                Error = Error + "The DlvrAddress may not be blank : ";
            }
                return Error;

        }
       
    }
}