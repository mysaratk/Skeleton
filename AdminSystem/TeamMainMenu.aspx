<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 269px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblmain" runat="server" style="z-index: 1; left: 164px; top: 47px; position: absolute" Text="Sneaker Fever Main Menu"></asp:Label>
        <p>
            <asp:Button ID="btnStaff" runat="server" OnClick="btnStaff_Click" style="z-index: 1; left: 213px; top: 111px; position: absolute" Text="Staff" />
        </p>
    </form>
</body>
</html>
