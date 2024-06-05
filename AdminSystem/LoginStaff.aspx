<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginStaff.aspx.cs" Inherits="LoginStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 56px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
      
        <asp:TextBox ID="txtpass" runat="server" style="z-index: 1; left: 287px; top: 42px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="txtuname" runat="server" style="z-index: 1; top: 42px; position: absolute; left: 11px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 179px; top: 89px; position: absolute"></asp:Label>
        <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click1" style="z-index: 1; left: 17px; top: 83px; position: absolute" Text="Login" />
        <asp:Button ID="btncancel" runat="server" style="z-index: 1; left: 96px; top: 84px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblusername" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="UserName:"></asp:Label>
        <asp:Label ID="lblpass" runat="server" style="z-index: 1; left: 333px; top: 15px; position: absolute" Text="Password:"></asp:Label>
        
      
    </form>
</body>
</html>
