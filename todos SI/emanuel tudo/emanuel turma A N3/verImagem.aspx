<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="verImagem.aspx.cs" Inherits="verImagem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="ImagemID" DataSourceID="SqlDataSource1" Width="380px" 
        AllowPaging="True">
        <Columns>
            <asp:BoundField DataField="ImagemTitulo" HeaderText="ImagemTitulo" 
                SortExpression="ImagemTitulo" />
            <asp:BoundField DataField="ImagemID" HeaderText="ImagemID" 
                InsertVisible="False" ReadOnly="True" SortExpression="ImagemID" 
                Visible="False" />
            <asp:ImageField DataImageUrlField="ImagemID" 
                DataImageUrlFormatString="~/trataImagem.aspx?id={0}" ReadOnly="True">
                <ControlStyle Width="200px" />
            </asp:ImageField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ASPNETDBConnectionString1 %>" 
        SelectCommand="SELECT [ImagemTitulo], [ImagemID] FROM [Imagem]">
    </asp:SqlDataSource>
</asp:Content>



