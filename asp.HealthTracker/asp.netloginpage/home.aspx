<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="asp.netloginpage.home" %>

<!DOCTYPE html>
<!--Brad Burkett

Home Page

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

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name='keywords' content='Health, blood pressure, weight, BMI, glucose, blood sugar'>
    <meta name="author" content="">

    <title>Health Tracker Home</title>

</head>
<body>
    <form id="form1" runat="server">
<body>

    <center>
        <h1>Health Tracker</h1>

        <h2>Home Page</h2>
    </center>

    <div class="infoClass">
        <h3 align="center">

            <p>The Health Tracker is a simple way to keep track of your Blood Pressure readings </p>
            <p>Glucose numbers and your Body Mass Index </p><br>
            <p><u>Please click on one of the links below to start</u></p><br><br><br>

            <div class="buttons">

                <a href="http://localhost:9629/BloodPressureInputs.aspx"<type ="button">Blood Pressure Input</type="button">

                <a href="http://localhost:9629/GlucoseInputs.aspx"<type ="button">Glucose Inputs</type="button"></a>

                <a href="http://localhost:9629/WeightInputs.aspx"<type ="button">Weight Inputs</type="button"></a>

                </div>

        <br><br>
         <div class="buttons"> 

             <a href="http://localhost:9629/BloodPressure_Monthly.aspx"<type ="button" >Blood Pressure Readings</type="button"></a>

             <a href="http://localhost:9629/Glucose_Monthly.aspx"<type ="button" >Glucose Readings</type="button"></a>

             <a href="http://localhost:9629/Weight_Monthly.aspx"<type ="button" >Weight Readings</type="button"></a>

        </div>

            </div>
    </form>
</body>
</html>
