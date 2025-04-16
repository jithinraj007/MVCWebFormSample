<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MVCWebFormSample._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <div class="row">
        <div class="col-md-4">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>

    </div>

</asp:Content>
