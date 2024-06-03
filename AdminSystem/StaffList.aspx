<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" Height="357px" Width="496px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEDIT" runat="server" OnClick="btnEDIT_Click" Text="Edit" />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <p>
            <asp:Label ID="lblFName" runat="server" Text="Enter FullName"></asp:Label>
            <asp:TextBox ID="txtFN" runat="server"></asp:TextBox>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply Filter" />
            <asp:Button ID="btnCLEAR" runat="server" OnClick="btnCLEAR_Click" Text="Clear Filter" />
        </p>
    </form>
</body>
</html>
