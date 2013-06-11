<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Paginas.aspx.cs" Inherits="cms_Paginas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>
        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                <asp:BoundField DataField="Pagina" HeaderText="Pagina" 
                    SortExpression="Pagina" />
                <asp:CommandField />
            </Fields>
        </asp:DetailsView>
        <br />
        <asp:FormView ID="FormView1" runat="server">
        </asp:FormView>
    </p>
</asp:Content>

