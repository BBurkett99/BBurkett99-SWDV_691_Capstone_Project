<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BloodPressureInputs.aspx.cs" Inherits="asp.netloginpage.BloodPressureInputs" %>

<!DOCTYPE html>
<!--Brad Burkett

Blood Pressure Inputs

SWDV 691: Capstone Project
-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Health Tracker Blood Pressure</title>

    <link href="style.css" rel="stylesheet" />
    <a href="home.aspx">Home</a>
    <a href="BloodPressureInputs.aspx">Blood Presure</a>
    <a href="GlucoseInputs.aspx">Glucose</a>
    <a href="WeightInputs.aspx">Weight</a>
    <meta charset="utf-8">
</head>

<body>
    <form id="form1" runat="server">

        <center>
        <h1>Health Tracker</h1>

        <h2>Blood Pressure Inputs</h2>
    </center>

        <p>Systolic = Top Number</p>
        <p>Diastolic = Bottom Number</p>
        <div class="infoClass">
            <h3 align="center">

                <p><mark>Please be sure you are sitting down when taking your blood pressure </mark></p>
                <br>
                <br>
                <br>
                <br>

                <form>
                    <asp:Label ID="Label1" runat="server" Text="Systolic"></asp:Label>
                    <!-- <input type="text" name="systolic_input"/><br><br>-->
                    <asp:TextBox ID="systolic_input" runat="server"></asp:TextBox>

                    <asp:Label ID="Label2" runat="server" Text="Diastolic"></asp:Label>
                    <asp:TextBox ID="diastolic_input" runat="server"></asp:TextBox>
                    <br>
                    <br>
                    <br>
                    <br>
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />

                </form>
    </form>
</body>
</html>
