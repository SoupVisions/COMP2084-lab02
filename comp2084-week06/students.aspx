<%@ Page Title="Students" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="students.aspx.cs" Inherits="comp2084_week06.students" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Students</h1>
    <div class="well">
    <a href="student-details.aspx" class="alert alert-link">Add a Student</a>
    </div>

    <asp:GridView ID="grdStudents" runat="server" CssClass="table table-striped" AutoGenerateColumns="false">

        <Columns>
            <asp:BoundField DataField="StudentID" HeaderText="Student ID" />
            <asp:BoundField DataField="LastName" HeaderText="Last Name" />
            <asp:BoundField DataField="FirstMidName" HeaderText="First Name" />
            <asp:BoundField DataField="EnrollmentDate" HeaderText="Enrollment" />
        </Columns>

    </asp:GridView>

</asp:Content>
