<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Paginas.aspx.cs" Inherits="cms_Paginas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>
        <asp:DetailsView ID="DetailsView2" runat="server" AllowPaging="True" 
            AutoGenerateRows="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" 
            Height="50px" Width="125px">
            <EmptyDataTemplate>
                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="New">New</asp:LinkButton>
            </EmptyDataTemplate>
            <Fields>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                    ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                <asp:BoundField DataField="Paginas" HeaderText="Paginas" 
                    SortExpression="Paginas" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                    ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT * FROM [Paginas]" 
            DeleteCommand="DELETE FROM [Paginas] WHERE [ID] = @ID" 
            InsertCommand="INSERT INTO [Paginas] ([Nome], [Paginas]) VALUES (@Nome, @Paginas)" 
            UpdateCommand="UPDATE [Paginas] SET [Nome] = @Nome, [Paginas] = @Paginas WHERE [ID] = @ID">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Nome" Type="String" />
                <asp:Parameter Name="Paginas" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nome" Type="String" />
                <asp:Parameter Name="Paginas" Type="String" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
    <p>
        <br />
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" 
            DataKeyNames="ID" DataSourceID="SqlDataSource1">
            <EditItemTemplate>
                ID:
                <asp:Label ID="IDLabel1" runat="server" Text='<%# Eval("ID") %>' />
                <br />
                Nome:
                <asp:TextBox ID="NomeTextBox" runat="server" Text='<%# Bind("Nome") %>' />
                <br />
                Paginas:
                <asp:TextBox ID="PaginasTextBox" runat="server" Text='<%# Bind("Paginas") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                    CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                    CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                Nome:
                <asp:TextBox ID="NomeTextBox" runat="server" Text='<%# Bind("Nome") %>' />
                <br />
                Paginas:
                <asp:TextBox ID="PaginasTextBox" runat="server" Text='<%# Bind("Paginas") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                    CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                    CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                ID:
                <asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' />
                <br />
                Nome:
                <asp:Label ID="NomeLabel" runat="server" Text='<%# Bind("Nome") %>' />
                <br />
                Paginas:
                <asp:Label ID="PaginasLabel" runat="server" Text='<%# Bind("Paginas") %>' />
                <br />

                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                    CommandName="Edit" Text="Edit" />
                &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" 
                    CommandName="Delete" Text="Delete" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" 
                    CommandName="New" Text="New" />

            </ItemTemplate>
        </asp:FormView>
    </p>
</asp:Content>

