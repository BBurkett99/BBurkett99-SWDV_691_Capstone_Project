<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BloodPressure_Monthly.aspx.cs" Inherits="asp.netloginpage.BloodPressure_Monthly" %>

<!DOCTYPE html>
<!--Brad Burkett

Blood Pressure Monthly

SWDV 691: Capstone Project
-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!--Links to other pages-->
    <link href="style.css" rel="stylesheet" />
    <a href="home.aspx">Home</a>
    <a href="BloodPressureInputs.aspx">Blood Presure</a>
    <a href="GlucoseInputs.aspx">Glucose</a>
    <a href="WeightInputs.aspx">Weight</a>

    <title>Health Tracker Blood Pressure</title>
</head>
<body>
    <center>
    <h1>Health Tracker</h1>
    </center>

    <div class="infoClass">
        <h3 align="center">

            <p>Please use the update button below to see the latest Blood Pressure readings</p>
            </p><br>
            <br>
            <br>

            <div class="buttons">

                <form id="form1" runat="server">
                    <body>
                        <div>
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update Systolic Reading" />
                            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update Diastolic Reading" />
                        </div>
            </div>
            <asp:Chart ID="Systolic" runat="server" DataSourceID="SqlDataSource1">
                <Series>
                    <asp:Series Name="Series1" XValueMember="Month" YValueMembers="systolic_Reading">
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CapstoneDataConnectionString %>" SelectCommand="SELECT [Month], [systolic_Reading] FROM [Monthly_BP_Average]"></asp:SqlDataSource>

            <asp:Chart ID="Diastolic" runat="server" DataSourceID="SqlDataSource2">
                <Series>
                    <asp:Series Name="Series1" XValueMember="Month" YValueMembers="diastolic_Reading">
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CapstoneDataConnectionString %>" SelectCommand="SELECT [Month], [diastolic_Reading] FROM [Monthly_BP_Average]"></asp:SqlDataSource>

            <br>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Overline="True" Text="Systolic"></asp:Label>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Overline="True" Text="Diastolic"></asp:Label>
            <br>
    </div>
    </form>
</body>
</html>
