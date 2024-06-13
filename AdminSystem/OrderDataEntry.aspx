<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitle" runat="server" Text="Order Data Entry"></asp:Label>
            <br />
            <asp:Label ID="lblOrderId" runat="server" Text="Order ID"></asp:Label>
            <asp:TextBox ID="txtOrderId" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
            <br />
            <asp:Label ID="lblDlvrAddress" runat="server" Text="Delivery address"></asp:Label>
            <asp:TextBox ID="txtDlvrAddress" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblOrderD8" runat="server" Text="Order date"></asp:Label>
            <asp:TextBox ID="txtOrderD8" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblTtlAmount" runat="server" Text="Amount"></asp:Label>
            <asp:TextBox ID="txtTtlAmount" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="chkOrdrPaid" runat="server" Text="Order Paid"></asp:CheckBox>
            <br />
            <asp:CheckBox ID="chkSorted" runat="server" Text="Sorted"></asp:CheckBox>
            <br />
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            <br />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
