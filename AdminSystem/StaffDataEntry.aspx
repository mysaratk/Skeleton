<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Data Entry</title>
    <style type="text/css">
        body {
            font-family: Arial, sans-serif;
        }
        .form-container {
            width: 300px;
            margin: 0 auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 10px;
            box-shadow: 2px 2px 12px #aaa;
            background-color: #f9f9f9;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
        }
        .form-group input[type="text"] {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
        }
        .form-actions {
            text-align: center;
        }
        .form-actions input[type="button"] {
            margin: 5px;
        }
        .error-message {
            color: red;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <div class="form-group">
                <asp:Label ID="IblStaffID" runat="server" Text="Staff ID"></asp:Label>
                <asp:TextBox ID="txtStaffId" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="IblFullName" runat="server" Text="Full Name"></asp:Label>
                <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="IblDOB" runat="server" Text="Date of Birth"></asp:Label>
                <asp:TextBox ID="TxtDOB" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:CheckBox ID="ChkActive" runat="server" Text="Active" />
            </div>
            <div class="form-actions">
                <asp:Button ID="btnmain" runat="server" Text="Return to Main Menu" OnClick="btnmain_Click" />
                <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
                <asp:Button ID="BtnOk" runat="server" OnClick="BtnOk_Click" Text="OK" Width="48px" />
                <asp:Button ID="BtnCncl" runat="server" Text="Cancel" OnClick="BtnCncl_Click" />
            </div>
            <div class="error-message">
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
