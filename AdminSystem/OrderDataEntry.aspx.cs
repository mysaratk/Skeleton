using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder.DlvrAddress = txtDlvrAddress.Text;
        AnOrder.OrderD8 = Convert.ToDateTime(txtOrderD8.Text);
        AnOrder.TtlAmount = Convert.ToDouble(txtTtlAmount.Text);    
        AnOrder.OrdrPaid = chkOrdrPaid.Checked;
        AnOrder.Sorted = chkSorted.Checked;

        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderId;
        Boolean Found = false;
        OrderId = Convert.ToInt32(txtOrderId.Text);
        Found = AnOrder.Find(OrderId);

        if (Found == true)
        {
            txtDlvrAddress.Text = AnOrder.DlvrAddress;
            txtOrderD8.Text = AnOrder.OrderD8.ToString();
            txtTtlAmount.Text = AnOrder.TtlAmount.ToString();
            chkOrdrPaid.Checked = AnOrder.OrdrPaid;
            chkSorted.Checked = AnOrder.Sorted;
        }
    }
}