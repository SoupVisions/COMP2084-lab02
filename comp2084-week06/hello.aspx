<%@ Page Title="Week 04: Hello" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="hello.aspx.cs" Inherits="comp2084_week06.hello" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Week 04: Hello Page</h1>
    <p class="jumbotron">Hello there! This is the hello page.</p>
    <asp:TextBox ID="txtName" runat="server" placeholder="Enter your name"></asp:TextBox>
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="btnSubmit_Click" />
    <br />
    <br />
    <div>
    <asp:Label ID="lblMessage" runat="server" Visible="false"></asp:Label>
    </div>
    </asp:Content>

   
