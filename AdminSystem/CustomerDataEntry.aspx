<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 433px">
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 146px; top: 12px; position: absolute; height: 17px;" width="128px"></asp:TextBox>
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 24px; top: 16px; position: absolute; height: 46px; width: 113px" Text="Customer ID"></asp:Label>

            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 368px; top: 14px; position: absolute" Text="Find" />

        </div>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 24px; top: 45px; position: absolute; width: 113px" Text="First Name"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 25px; top: 113px; position: absolute" Text="Email" width="113px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 25px; top: 78px; position: absolute; height: 22px; width: 113px" Text="Last Name"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 146px; top: 41px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblLogin" runat="server" style="z-index: 1; left: 23px; top: 180px; position: absolute" Text="Login" width="113px"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 24px; top: 212px; position: absolute; bottom: 124px" Text="Password" width="113px"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 24px; top: 146px; position: absolute" Text="Phone Number" width="113px"></asp:Label>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 23px; top: 246px; position: absolute" Text="Date Added" width="113px"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" height="22px" style="z-index: 1; left: 146px; top: 70px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" height="22px" style="z-index: 1; left: 146px; top: 106px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNumber" runat="server" height="22px" style="z-index: 1; left: 146px; top: 143px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtLogin" runat="server" height="22px" style="z-index: 1; left: 146px; top: 176px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" height="22px" style="z-index: 1; left: 146px; top: 205px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" height="22px" style="z-index: 1; left: 146px; top: 241px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" BorderColor="Red" BorderStyle="None" style="z-index: 1; left: 27px; top: 294px; position: absolute; height: 19px; width: 56px" Text="  [lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 24px; top: 338px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 95px; top: 337px; position: absolute" Text="Cancel" />
        <p style="width: 136px">
            &nbsp;</p>
    </form>
</body>
</html>
