<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Tuote.aspx.cs" Inherits="Views_Tuote" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <asp:FormView ID="FormView1" runat="server" DataKeyNames="TuoteID" DataSourceID="SqlDataSource1" >
        <EditItemTemplate>
            TuoteID:
            <asp:Label ID="TuoteIDLabel1" runat="server" Text='<%# Eval("TuoteID") %>' />
            <br />
            Nimi:
            <asp:TextBox ID="NimiTextBox" runat="server" Text='<%# Bind("Nimi") %>' />
            <br />
            Hinta:
            <asp:TextBox ID="HintaTextBox" runat="server" Text='<%# Bind("Hinta") %>' />
            <br />
            Veroprosentti:
            <asp:TextBox ID="VeroprosenttiTextBox" runat="server" Text='<%# Bind("Veroprosentti") %>' />
            <br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </EditItemTemplate>
        <InsertItemTemplate>
            TuoteID:
            <asp:TextBox ID="TuoteIDTextBox" runat="server" Text='<%# Bind("TuoteID") %>' />
            <br />
            Nimi:
            <asp:TextBox ID="NimiTextBox" runat="server" Text='<%# Bind("Nimi") %>' />
            <br />
            Hinta:
            <asp:TextBox ID="HintaTextBox" runat="server" Text='<%# Bind("Hinta") %>' />
            <br />
            Veroprosentti:
            <asp:TextBox ID="VeroprosenttiTextBox" runat="server" Text='<%# Bind("Veroprosentti") %>' />
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
        <ItemTemplate>
            TuoteID:
            <asp:Label ID="TuoteIDLabel" runat="server" Text='<%# Eval("TuoteID") %>' />
            <br />
            Nimi:
            <asp:Label ID="NimiLabel" runat="server" Text='<%# Bind("Nimi") %>' />
            <br />
            Hinta:
            <asp:Label ID="HintaLabel" runat="server" Text='<%# Bind("Hinta") %>' />
            <br />
            Veroprosentti:
            <asp:Label ID="VeroprosenttiLabel" runat="server" Text='<%# Bind("Veroprosentti") %>' />
            <br />

        </ItemTemplate>
    </asp:FormView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Tuote]"></asp:SqlDataSource>
</asp:Content>

