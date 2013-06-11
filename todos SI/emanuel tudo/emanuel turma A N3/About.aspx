<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="About.aspx.vb" Inherits="About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="imgGrid" runat="server" AutoGenerateColumns="False" 
        Height="236px" onselectedindexchanged="Unnamed1_SelectedIndexChanged" 
        Width="482px">
        <Columns>
            <asp:BoundField DataField="Titulo" HeaderText="Titulo" />
            <asp:ImageField DataAlternateTextField="Imagem" DataImageUrlField="Imagem" 
                HeaderText="Imagem">
            </asp:ImageField>
        </Columns>
    </asp:GridView>
</asp:Content>

