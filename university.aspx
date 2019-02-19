<%@ Page Title="" Language="C#" MasterPageFile="~/Index.master" AutoEventWireup="true" CodeFile="university.aspx.cs" Inherits="university" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
       <style type="text/css">
        .auto-style1 {
            font-size: large;
            color: #FF0000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
           <div style="background:#00ff90;color:red">
        <h1>University Life</h1>
       <img src="Images/daffodil.jpg" style="height: 166px; width: 282px" />
        <br />
        <p class="auto-style1"><strong>2017-Running<br />Subject:Computer Science & Engineering(CSE)<br />Location: Dhanmondi Dhaka Bangladesh</strong></p>
    </div>
</asp:Content>

