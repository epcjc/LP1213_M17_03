<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Sobre Hotel.aspx.cs" Inherits="Sobre_Hotel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
    DataKeyNames="ID" DataSourceID="SqlDataSource1">
    <Columns>
        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
            ReadOnly="True" SortExpression="ID" />
        <asp:BoundField DataField="Nome_cliente" HeaderText="Nome_cliente" 
            SortExpression="Nome_cliente" />
        <asp:BoundField DataField="Numero_quarto" HeaderText="Numero_quarto" 
            SortExpression="Numero_quarto" />
        <asp:BoundField DataField="Tipo_quarto" HeaderText="Tipo_quarto" 
            SortExpression="Tipo_quarto" />
        <asp:BoundField DataField="Andar_quarto" HeaderText="Andar_quarto" 
            SortExpression="Andar_quarto" />
        <asp:BoundField DataField="Numero_pessoas" HeaderText="Numero_pessoas" 
            SortExpression="Numero_pessoas" />
        <asp:BoundField DataField="Data_checkin" HeaderText="Data_checkin" 
            SortExpression="Data_checkin" />
        <asp:BoundField DataField="Data_checkout" HeaderText="Data_checkout" 
            SortExpression="Data_checkout" />
        <asp:BoundField DataField="Preco_total" HeaderText="Preco_total" 
            SortExpression="Preco_total" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
    SelectCommand="SELECT * FROM [hotel]"></asp:SqlDataSource>
</asp:Content>

