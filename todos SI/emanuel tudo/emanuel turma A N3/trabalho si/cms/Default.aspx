<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="cms_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View2" runat="server">
                <br />
                <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
                    BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="3" CellSpacing="2" DataSourceID="SqlDataSource1" Height="50px" 
                    Width="223px" DefaultMode="Insert" AllowPaging="True" DataKeyNames="id">
                    <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <Fields>
                        <asp:BoundField DataField="modelo" HeaderText="modelo" 
                            SortExpression="modelo" />
                        <asp:BoundField DataField="marca" HeaderText="marca" SortExpression="marca" />
                        <asp:BoundField DataField="preço" HeaderText="preço" SortExpression="preço" />
                        <asp:BoundField DataField="aluguer" HeaderText="aluguer" 
                            SortExpression="aluguer" />
                        <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" 
                            SortExpression="id" />
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                            ShowInsertButton="True" />
                    </Fields>
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                </asp:DetailsView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ASPNETDBConnectionString1 %>" 
                    
                    SelectCommand="SELECT [modelo], [marca], [preço], [aluguer], [id] FROM [Veiculos]" 
                    DeleteCommand="DELETE FROM [Veiculos] WHERE [id] = @id" 
                    InsertCommand="INSERT INTO [Veiculos] ([modelo], [marca], [preço], [aluguer], [id]) VALUES (@modelo, @marca, @preço, @aluguer, @id)" 
                    UpdateCommand="UPDATE [Veiculos] SET [modelo] = @modelo, [marca] = @marca, [preço] = @preço, [aluguer] = @aluguer WHERE [id] = @id">
                    <DeleteParameters>
                        <asp:Parameter Name="id" Type="Int64" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="modelo" Type="String" />
                        <asp:Parameter Name="marca" Type="String" />
                        <asp:Parameter Name="preço" Type="Decimal" />
                        <asp:Parameter Name="aluguer" Type="String" />
                        <asp:Parameter Name="id" Type="Int64" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="modelo" Type="String" />
                        <asp:Parameter Name="marca" Type="String" />
                        <asp:Parameter Name="preço" Type="Decimal" />
                        <asp:Parameter Name="aluguer" Type="String" />
                        <asp:Parameter Name="id" Type="Int64" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <br />
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource2" 
                    EmptyDataText="There are no data records to display." Width="554px" 
                    AllowPaging="True" AllowSorting="True">
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                            ShowSelectButton="True" />
                        <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" 
                            SortExpression="id" Visible="False" />
                        <asp:BoundField DataField="modelo" HeaderText="modelo" 
                            SortExpression="modelo" />
                        <asp:BoundField DataField="marca" HeaderText="marca" SortExpression="marca" />
                        <asp:BoundField DataField="preço" HeaderText="preço" SortExpression="preço" />
                        <asp:BoundField DataField="aluguer" HeaderText="aluguer" 
                            SortExpression="aluguer" />
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
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ASPNETDBConnectionString1 %>" 
                    DeleteCommand="DELETE FROM [Veiculos] WHERE [id] = @id" 
                    InsertCommand="INSERT INTO [Veiculos] ([id], [modelo], [marca], [preço], [aluguer]) VALUES (@id, @modelo, @marca, @preço, @aluguer)" 
                    ProviderName="<%$ ConnectionStrings:ASPNETDBConnectionString1.ProviderName %>" 
                    SelectCommand="SELECT [id], [modelo], [marca], [preço], [aluguer] FROM [Veiculos]" 
                    UpdateCommand="UPDATE [Veiculos] SET [modelo] = @modelo, [marca] = @marca, [preço] = @preço, [aluguer] = @aluguer WHERE [id] = @id">
                    <DeleteParameters>
                        <asp:Parameter Name="id" Type="Int64" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="id" Type="Int64" />
                        <asp:Parameter Name="modelo" Type="String" />
                        <asp:Parameter Name="marca" Type="String" />
                        <asp:Parameter Name="preço" Type="Decimal" />
                        <asp:Parameter Name="aluguer" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="modelo" Type="String" />
                        <asp:Parameter Name="marca" Type="String" />
                        <asp:Parameter Name="preço" Type="Decimal" />
                        <asp:Parameter Name="aluguer" Type="String" />
                        <asp:Parameter Name="id" Type="Int64" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <br />
                <br />
                <br />
                <br />
            </asp:View>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:MultiView>
</asp:Content>

