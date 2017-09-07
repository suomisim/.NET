<%@ Page Title="Tuotteet" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Tuotteet.aspx.cs" Inherits="Views_Tuotteet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2><%: Title %>.</h2>
    <p>Tuotteet jotka löytyvät varastostamme</p>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="TuoteID" DataSourceID="SqlDataSource1" >
        <Columns>
            <asp:BoundField DataField="TuoteID" HeaderText="TuoteID" ReadOnly="True" SortExpression="TuoteID" />
            <asp:BoundField DataField="Nimi" HeaderText="Nimi" SortExpression="Nimi" />
            <asp:BoundField DataField="Hinta" HeaderText="Hinta" SortExpression="Hinta" />
            <asp:BoundField DataField="Veroprosentti" HeaderText="Veroprosentti" SortExpression="Veroprosentti" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Tuote]"></asp:SqlDataSource>
</asp:Content>

