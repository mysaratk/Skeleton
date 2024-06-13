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
}