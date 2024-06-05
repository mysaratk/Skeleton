<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff List Management</title>
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #e9ecef;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
            position: relative;
        }
        .container {
            background-color: #ffffff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            width: 400px;
        }
        .header {
            font-size: 24px;
            font-weight: 600;
            margin-bottom: 20px;
            text-align: center;
            color: #000000;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
        }
        .form-group input[type="text"],
        .form-group select,
        .form-group .asp-listbox {
            width: 100%;
            padding: 10px;
            border: 1px solid #ced4da;
            border-radius: 4px;
        }
        .form-group input[type="button"],
        .form-group button {
            width: 100%;
            padding: 10px;
            border: none;
            background-color: #007bff;
            color: white;
            border-radius: 4px;
            cursor: pointer;
            margin-top: 10px;
        }
        .form-group input[type="button"]:hover,
        .form-group button:hover {
            background-color: #0056b3;
        }
        .form-group .buttons {
            display: flex;
            justify-content: space-between;
        }
        .form-group .buttons button {
            flex: 1;
            margin: 0 5px;
        }
        .form-group .buttons button:first-child {
            margin-left: 0;
        }
        .form-group .buttons button:last-child {
            margin-right: 0;
        }
        .error-label {
            color: red;
            margin-top: 10px;
            text-align: center;
        }
        .logged-in-as {
            position: absolute;
            bottom: 10px;
            right: 10px;
            font-size: 14px;
            color: #333;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <div class="header">Staff List Management</div>
        
        <div class="form-group">
            <asp:ListBox ID="lstStaffList" runat="server" CssClass="asp-listbox" Height="200px"></asp:ListBox>
        </div>
        
        <div class="form-group buttons">
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEDIT" runat="server" OnClick="btnEDIT_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </div>

        <div class="form-group">
            <asp:Label ID="lblFName" runat="server" Text="Enter Full Name"></asp:Label>
            <asp:TextBox ID="txtFN" runat="server"></asp:TextBox>
        </div>

        <div class="form-group buttons">
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply Filter" />
            <asp:Button ID="btnCLEAR" runat="server" OnClick="btnCLEAR_Click" Text="Clear Filter" />
        </div>
        
        <asp:Label ID="lblError" runat="server" CssClass="error-label"></asp:Label>
        
        <div class="form-group">
            <asp:Button ID="btnreturn" runat="server" OnClick="btnreturn_Click" Text="Return to Main Menu" />
        </div>
        
        <asp:Label ID="lblLoggedInAs" runat="server" CssClass="logged-in-as" Text="Logged in as: Username"></asp:Label>
    </form>
</body>
</html>
