using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> _OrderList = new List<clsOrder>();

        public List<clsOrder> OrderList
        {
            get
            {
                return _OrderList;
            }
            set
            {
                _OrderList = value;
            }
        }

        public int Count
        {
            get
            {
                return _OrderList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsOrder ThisOrder { get; set; }

        public clsOrderCollection()
        {
            /*clsOrder TestItem = new clsOrder();

            TestItem.OrderId = 1;
            TestItem.DlvrAddress = "48 Town road";
            TestItem.OrderD8 = DateTime.Now.Date;
            TestItem.TtlAmount = 18.57;
            TestItem.OrdrPaid = true;
            TestItem.Sorted = true;

            _OrderList.Add(TestItem);
            TestItem = new clsOrder();

            TestItem.OrderId = 2;
            TestItem.DlvrAddress = "Another address";
            TestItem.OrderD8 = DateTime.Now.Date;
            TestItem.TtlAmount = 20;
            TestItem.OrdrPaid = true;
            TestItem.Sorted = true;

            _OrderList.Add(TestItem);*/

            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrders_SelectAll");
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();

                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.DlvrAddress = Convert.ToString(DB.DataTable.Rows[Index]["DlvrAddress"]);
                AnOrder.OrderD8 = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderD8"]);
                AnOrder.TtlAmount = Convert.ToDouble(DB.DataTable.Rows[Index]["TtlAmount"]);
                AnOrder.OrdrPaid = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrdrPaid"]);
                AnOrder.Sorted = Convert.ToBoolean(DB.DataTable.Rows[Index]["Sorted"]);
            
                _OrderList.Add(AnOrder);

                Index++;
            }
        }

    }
}
