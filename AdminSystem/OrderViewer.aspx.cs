﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.DlvrAddress);
        Response.Write(AnOrder.OrderD8);
        Response.Write(AnOrder.TtlAmount);
        Response.Write(AnOrder.OrdrPaid);
        Response.Write(AnOrder.Sorted);
    }
}