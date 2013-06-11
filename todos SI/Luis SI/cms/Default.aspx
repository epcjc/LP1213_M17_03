<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="cms_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px">
                    <Fields>
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
                        <asp:BoundField DataField="Data_checkout" HeaderText="Data_checkout" 
                            SortExpression="Data_checkout" />
                        <asp:BoundField DataField="Preco_total" HeaderText="Preco_total" 
                            SortExpression="Preco_total" />
                        <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                        <asp:CommandField />
                    </Fields>
                </asp:DetailsView>
                <br />
                <br />
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </asp:View>
        </asp:MultiView>
        <br />
    </p>
</asp:Content>

