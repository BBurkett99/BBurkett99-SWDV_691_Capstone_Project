<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Glucose_Monthly.aspx.cs" Inherits="asp.netloginpage.Glucose_Monthly" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>
<!--Brad Burkett

Glucose Monthly

SWDV 691: Capstone Project
-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link href="style.css" rel="stylesheet" />
    <!--Links to other pages-->
    <a href="home.aspx">Home</a>
    <a href="BloodPressureInputs.aspx">Blood Presure</a>
    <a href="GlucoseInputs.aspx">Glucose</a>
    <a href="WeightInputs.aspx">Weight</a>

    <title>Health Tracker Glucose</title>
</head>
<center>
    <h1>Health Tracker</h1>
</center>
<div class="infoClass">
    <h3 align="center">

        <p>Please use the update button below to see the latest Glucose readings</p>
        </p><br>
        <br>
        <br>

        <div class="buttons">
            <!--Bar chart code-->
            <body>
                <form id="form1" runat="server">
                    <div>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update Reading" />

                    </div>
        </div>
        <asp:chart id="Chart1" runat="server" datasourceid="SqlDataSource1">
                    <Series>
                        <asp:Series Name="Series1" XValueMember="Month" YValueMembers="Gluecose_Reading">
                        </asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="ChartArea1">
                        </asp:ChartArea>
                    </ChartAreas>
                </asp:chart>
        <asp:sqldatasource id="SqlDataSource1" runat="server" connectionstring="<%$ ConnectionStrings:CapstoneDataConnectionString %>" selectcommand="SELECT [Month], [Gluecose_Reading] FROM [Monthly_Glucose_Average]"></asp:sqldatasource>
                </form>
</body>
</html>
