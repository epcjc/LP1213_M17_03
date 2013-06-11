<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Ver Imagensaspx.aspx.vb" Inherits="Ver_Imagensaspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>
    &nbsp;<asp:GridView ID="GridView1" runat="server" AllowPaging="True" DataKeyNames="ImagemID" 
            DataSourceID="SqlDataSource1" AutoGenerateColumns="False">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="ImagemTitulo" HeaderText="ImagemTitulo" 
                SortExpression="ImagemTitulo" />
            <asp:ImageField DataImageUrlField="ImagemID" 
                DataImageUrlFormatString="~/trataImagem.aspx?id={0}" Visible="False">
            </asp:ImageField>
            <asp:ImageField DataImageUrlField="ImagemID" 
                DataImageUrlFormatString="trataImagem.aspx?id={0}">
            </asp:ImageField>
        </Columns>
    </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            DeleteCommand="DELETE FROM [Imagem] WHERE [ImagemID] = @ImagemID" 
            InsertCommand="INSERT INTO [Imagem] ([Imagem], [ImagemTitulo], [ImagemTipo], [ImagemTamanho]) VALUES (@Imagem, @ImagemTitulo, @ImagemTipo, @ImagemTamanho)" 
            SelectCommand="SELECT * FROM [Imagem]" 
            UpdateCommand="UPDATE [Imagem] SET [Imagem] = @Imagem, [ImagemTitulo] = @ImagemTitulo, [ImagemTipo] = @ImagemTipo, [ImagemTamanho] = @ImagemTamanho WHERE [ImagemID] = @ImagemID">
            <DeleteParameters>
                <asp:Parameter Name="ImagemID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Imagem" Type="Object" />
                <asp:Parameter Name="ImagemTitulo" Type="String" />
                <asp:Parameter Name="ImagemTipo" Type="String" />
                <asp:Parameter Name="ImagemTamanho" Type="Int64" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Imagem" Type="Object" />
                <asp:Parameter Name="ImagemTitulo" Type="String" />
                <asp:Parameter Name="ImagemTipo" Type="String" />
                <asp:Parameter Name="ImagemTamanho" Type="Int64" />
                <asp:Parameter Name="ImagemID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    <br />
</p>
</asp:Content>

