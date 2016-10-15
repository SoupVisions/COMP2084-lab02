<%@ Page Title="Week 04: Tips" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="tips.aspx.cs" Inherits="comp2084_week06.tip" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Week 04: Tip Calculator</h1>
    <div class="form-group">
        <label for="txtAmount" class="control-label col-sm-2">Amount: </label>
        <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
        </div>
        
    <div class="form-group">
        <label for="ddlPercent" class="control-label col-sm-2">Tip %</label>
        <asp:DropDownList ID="ddlPercent" runat="server">
            <asp:ListItem Value=".1" Text="10%"></asp:ListItem>
            <asp:ListItem Value=".15" Text="15%"></asp:ListItem>
            <asp:ListItem Value=".2" Text="20%"></asp:ListItem>
        </asp:DropDownList>
    </div>
        
         <div>
        <asp:Button ID="btnCalculate" runat="server" Text="Calculate Tip" CssClass="btn btn-success col-sm-offset-2" OnClick="btnCalculate_Click" />
             </div>

        <div>
        Tip: <asp:Label ID="lblTip" runat="server" CssClass="alert alert-info"></asp:Label>
        </div>

        <div>
        Total: <asp:Label ID="lblTotal" runat="server" CssClass="alert alert-info"></asp:Label>
        </div>
      
       
    

</asp:Content>
