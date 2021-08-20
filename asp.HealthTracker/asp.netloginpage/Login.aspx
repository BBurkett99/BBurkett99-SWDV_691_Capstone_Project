<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="asp.HealthTracker.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Health Tracker</title>
    <style>
        body{
            background-color:wheat;
        }
        .auto-style1 {
            width: 1034px;
            height: 274px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <h1>Health Tracker</h1>

        <h2>Login Page</h2>
        </center>

    <div>
    <table style="margin:auto;border:5px solid white">
        <h1>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                </td>
            <td>
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Label ID="lblErrorMessage" runat="server" Text="Incorrect User Credentials" ForeColor="Red"></asp:Label></td>
        </tr>

    </table>
        <br>
        <br>
          <center>
        <img class="auto-style1" src="Resources/Login.jpg" />
          </center>
    </div>
    </form>
</body>
</html>
