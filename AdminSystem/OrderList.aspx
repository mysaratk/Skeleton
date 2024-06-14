<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order List</title>
</head>
<body>
    <form id="frmOrderList" runat="server">
        <h1><asp:Label ID="lblTitle" runat="server" Text="Showing All Orders"></asp:Label></h1>

        <div>
            <asp:Label ID="lblSearch" runat="server" CssClass="label" Text="Search by Delivery Address"></asp:Label>
            <asp:TextBox ID="txtSearch" runat="server" CssClass="field"></asp:TextBox>
            <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
        </div>

        <div>
            <asp:Label ID="lblError" runat="server" ForeColor="Red" Text=""></asp:Label>
        </div>

        <div>
            <asp:ListBox ID="lstOrderListBox" runat="server" SelectionMode="Single" Height="200px" Width="400px"></asp:ListBox>
        </div>

        <div>
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnView" runat="server" Text="View" OnClick="btnView_Click" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        </div>
    </form>
</body>
</html>
