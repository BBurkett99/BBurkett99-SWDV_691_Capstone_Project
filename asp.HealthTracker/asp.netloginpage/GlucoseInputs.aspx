<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GlucoseInputs.aspx.cs" Inherits="asp.netloginpage.GlucoseInputs" %>

<!DOCTYPE html>
<!--Brad Burkett

Glucose Inputs

SWDV 691: Capstone Project
-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="style.css" rel="stylesheet" />
    <a href="home.aspx">Home</a>
    <a href="BloodPressureInputs.aspx">Blood Presure</a>
    <a href="GlucoseInputs.aspx">Glucose</a>
    <a href="WeightInputs.aspx">Weight</a>
    <meta charset="utf-8" />

    <title>Health Tracker Glucose</title>
</head>

<body>

    <center>
        <h1>Health Tracker</h1>
    </center>

    <div class="infoClass">
        <h3 align="center">

            <p><mark>Please be sure you have been fasting for eight hours before testing </mark></p>
            <br>
            <form runat="server">

                <h2>Glucose Inputs</h2>

                <br>
                <br>

                <br>
                <br>

                <div>
                    <asp:Label ID="Label1" runat="server" Text="Weekly Readings"></asp:Label>

                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />

                </div>
            </form>

        </h3>
    </div>

    <p>
    </p>
</body>
</html>
