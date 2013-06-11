<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="cms_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <br />
                <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" 
                    AutoGenerateRows="False" BackColor="#DEBA84" BorderColor="#DEBA84" 
                    BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" 
                    DataKeyNames="ID" DataSourceID="SqlDataSource1" DefaultMode="Insert" 
                    Height="50px" 
                    Width="223px" onpageindexchanging="DetailsView1_PageIndexChanging">
                    <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <Fields>
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
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                            ShowInsertButton="True" />
                    </Fields>
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                </asp:DetailsView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                    DeleteCommand="DELETE FROM [hotel] WHERE [ID] = @ID" 
                    InsertCommand="INSERT INTO [hotel] ([Nome_cliente], [Numero_quarto], [Tipo_quarto], [Andar_quarto], [Numero_pessoas], [Data_checkin], [Data_checkout], [Preco_total]) VALUES (@Nome_cliente, @Numero_quarto, @Tipo_quarto, @Andar_quarto, @Numero_pessoas, @Data_checkin, @Data_checkout, @Preco_total)" 
                    SelectCommand="SELECT * FROM [hotel]" 
                    UpdateCommand="UPDATE [hotel] SET [Nome_cliente] = @Nome_cliente, [Numero_quarto] = @Numero_quarto, [Tipo_quarto] = @Tipo_quarto, [Andar_quarto] = @Andar_quarto, [Numero_pessoas] = @Numero_pessoas, [Data_checkin] = @Data_checkin, [Data_checkout] = @Data_checkout, [Preco_total] = @Preco_total WHERE [ID] = @ID">
                    <DeleteParameters>
                        <asp:Parameter Name="ID" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="Nome_cliente" Type="String" />
                        <asp:Parameter Name="Numero_quarto" Type="Int32" />
                        <asp:Parameter Name="Tipo_quarto" Type="String" />
                        <asp:Parameter Name="Andar_quarto" Type="Int32" />
                        <asp:Parameter Name="Numero_pessoas" Type="Int32" />
                        <asp:Parameter DbType="Date" Name="Data_checkin" />
                        <asp:Parameter DbType="Date" Name="Data_checkout" />
                        <asp:Parameter Name="Preco_total" Type="Int32" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Nome_cliente" Type="String" />
                        <asp:Parameter Name="Numero_quarto" Type="Int32" />
                        <asp:Parameter Name="Tipo_quarto" Type="String" />
                        <asp:Parameter Name="Andar_quarto" Type="Int32" />
                        <asp:Parameter Name="Numero_pessoas" Type="Int32" />
                        <asp:Parameter DbType="Date" Name="Data_checkin" />
                        <asp:Parameter DbType="Date" Name="Data_checkout" />
                        <asp:Parameter Name="Preco_total" Type="Int32" />
                        <asp:Parameter Name="ID" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <br />
                <br />
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                    AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
                    BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                    DataKeyNames="ID" DataSourceID="SqlDataSource1" 
                    EmptyDataText="There are no data records to display." Height="41px" 
                    style="font-size: xx-small" Width="529px">
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                            ReadOnly="True" SortExpression="ID" Visible="False" />
                        <asp:BoundField DataField="Nome_cliente" HeaderText="Nome" 
                            SortExpression="Nome_cliente" />
                        <asp:BoundField DataField="Numero_quarto" HeaderText="Nº quarto" 
                            SortExpression="Numero_quarto" />
                        <asp:BoundField DataField="Tipo_quarto" HeaderText="T. Quarto" 
                            SortExpression="Tipo_quarto" />
                        <asp:BoundField DataField="Andar_quarto" HeaderText="Andar" 
                            SortExpression="Andar_quarto" />
                        <asp:BoundField DataField="Numero_pessoas" HeaderText="Nº pessoas" 
                            SortExpression="Numero_pessoas" />
                        <asp:BoundField DataField="Data_checkin" HeaderText="checkin" 
                            SortExpression="Data_checkin" />
                        <asp:BoundField DataField="Data_checkout" HeaderText="checkout" 
                            SortExpression="Data_checkout" />
                        <asp:BoundField DataField="Preco_total" HeaderText="Preco" 
                            SortExpression="Preco_total" />
                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
                <br />
            </asp:View>
           
        </asp:MultiView>
    </p>
    <p>
        <br />
    </p>
</asp:Content>

