<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Reserva.aspx.vb" Inherits="Reserva" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
 
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="Label3" runat="server" ForeColor="Black" Text="Label"></asp:Label>
            <br class="style10" />
            <asp:Label ID="Label2" runat="server" CssClass="style10" Text="Label"></asp:Label>
            <br class="style10" />
            <br />
        </asp:View>
        <asp:View ID="View2" runat="server">
            <br />
            <br />
            <br />
        </asp:View>
        <asp:View ID="View3" runat="server">
            <br />
            <br />
            <br />
        </asp:View>
    </asp:MultiView>
    </asp:Content>

