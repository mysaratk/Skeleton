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
        <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 113px; top: 42px; position: absolute" OnTextChanged="txtStaffId_TextChanged"></asp:TextBox>
        <p>
            <asp:Label ID="IblFullName" runat="server" style="z-index: 1; left: 14px; top: 84px; position: absolute; bottom: 734px" Text="FullName" width="76px"></asp:Label>
        </p>
        <asp:TextBox ID="txtFullName" runat="server" style="z-index: 1; left: 112px; top: 82px; position: absolute"></asp:TextBox>
        <div style="margin-left: 1040px">
            <asp:Label ID="IblDOB" runat="server" style="z-index: 1; left: 11px; top: 114px; position: absolute" Text="Date of birth"></asp:Label>
        </div>
        <p style="height: 34px; width: 631px">
        <asp:CheckBox ID="ChkActive" runat="server" style="z-index: 1; left: 15px; top: 151px; position: absolute" Text="Active" width="76px" />
        </p>
        <asp:TextBox ID="TxtDOB" runat="server" style="z-index: 1; left: 111px; top: 116px; position: absolute" OnTextChanged="TxtDOB_TextChanged"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <asp:Button ID="BtnOk" runat="server" OnClick="BtnOk_Click" Text="OK" Width="48px" />
        <asp:Button ID="BtnCncl" runat="server" Text="Cancel" />
        <p>
            &nbsp;</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    </form>
    </body>
</html>
