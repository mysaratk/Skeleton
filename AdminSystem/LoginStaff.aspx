<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginStaff.aspx.cs" Inherits="LoginStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 56px;
        }

        #txtpass {
            z-index: 1;
            left: 226px;
            top: 41px;
            position: absolute;
        }

        #txtuname {
            z-index: 1;
            top: 42px;
            position: absolute;
            left: 11px;
        }

        #lblError {
            z-index: 1;
            left: 179px;
            top: 89px;
            position: absolute;
            color: red;
        }

        #btnlogin {
            z-index: 1;
            left: 17px;
            top: 83px;
            position: absolute;
        }

        #btncancel {
            z-index: 1;
            left: 94px;
            top: 83px;
            position: absolute;
        }

        #lblusername {
            z-index: 1;
            left: 10px;
            top: 15px;
            position: absolute;
        }

        #lblpass {
            z-index: 1;
            left: 261px;
            top: 15px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
      
        <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="txtuname" runat="server"></asp:TextBox>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click" />
        <asp:Button ID="btncancel" runat="server" Text="Cancel" />
        <asp:Label ID="lblusername" runat="server" Text="UserName:"></asp:Label>
        <asp:Label ID="lblpass" runat="server" Text="Password:"></asp:Label>
        
      
    </form>
</body>
</html>
