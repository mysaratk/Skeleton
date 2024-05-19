<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #txtStaffID {
            height: 128px;
        }
    </style>
</head>
<body id="txtStaffID">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="IblStaffID" runat="server" style="z-index: 1; left: 17px; top: 42px; position: absolute" Text="StaffID" width="76px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 113px; top: 42px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="IblFullName" runat="server" style="z-index: 1; left: 14px; top: 84px; position: absolute; bottom: 734px" Text="FullName" width="76px"></asp:Label>
            <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click1" style="z-index: 1; left: 285px; top: 82px; position: absolute" Text="Find" />
        </p>
        <asp:TextBox ID="txtFullName" runat="server" style="z-index: 1; left: 112px; top: 82px; position: absolute"></asp:TextBox>
        <div style="margin-left: 1040px">
            <asp:Label ID="IblDOB" runat="server" style="z-index: 1; left: 11px; top: 114px; position: absolute" Text="Date of birth"></asp:Label>
        </div>
        <p style="height: 26px; width: 631px">
            &nbsp;</p>
        <asp:TextBox ID="TxtDOB" runat="server" style="z-index: 1; left: 111px; top: 116px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="ChkActive" runat="server" style="z-index: 1; left: 14px; top: 156px; position: absolute" Text="Active" width="76px" />
        <asp:Button ID="BtnOK" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 18px; top: 186px; position: absolute" Text="OK" width="76px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 114px; top: 185px; position: absolute" Text="Cancel" width="76px" />
        <p>
            &nbsp;</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    </form>
    </body>
</html>
