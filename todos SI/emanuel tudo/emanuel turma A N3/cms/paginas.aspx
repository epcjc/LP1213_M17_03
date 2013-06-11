<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="paginas.aspx.cs" Inherits="cms_paginas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" 
        AutoGenerateRows="False" DataKeyNames="id" DataSourceID="SqlDataSource1" 
        Height="50px" Width="125px">
        <EmptyDataTemplate>
            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="New">New</asp:LinkButton>
        </EmptyDataTemplate>
        <Fields>
            <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" 
                SortExpression="id" />
            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
            <asp:BoundField DataField="Pagina" HeaderText="Pagina" 
                SortExpression="Pagina" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                ShowInsertButton="True" />
        </Fields>
    </asp:DetailsView>
    <asp:FormView ID="FormView1" runat="server" AllowPaging="True" 
        DataKeyNames="id" DataSourceID="SqlDataSource1" Height="117px" Width="496px">
        <EditItemTemplate>
            id:
            <asp:Label ID="idLabel1" runat="server" Text='<%# Eval("id") %>' />
            <br />
            Nome:
            <asp:TextBox ID="NomeTextBox" runat="server" Text='<%# Bind("Nome") %>' />
            <br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                CommandName="Update" Text="Update" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </EditItemTemplate>
        <InsertItemTemplate>
            id:
            <asp:TextBox ID="idTextBox" runat="server" Text='<%# Bind("id") %>' />
            <br />
            Nome:
            <asp:TextBox ID="NomeTextBox" runat="server" Text='<%# Bind("Nome") %>' />
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                CommandName="Insert" Text="Insert" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
        <ItemTemplate>
            id:
            <asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>' />
            <br />
            Nome:
            <asp:Label ID="NomeLabel" runat="server" Text='<%# Bind("Nome") %>' />
            <br />

        </ItemTemplate>
    </asp:FormView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ASPNETDBConnectionString1 %>" 
        DeleteCommand="DELETE FROM [Paginas] WHERE [id] = @id" 
        InsertCommand="INSERT INTO [Paginas] ([id], [Nome], [Pagina]) VALUES (@id, @Nome, @Pagina)" 
        SelectCommand="SELECT * FROM [Paginas]" 
        UpdateCommand="UPDATE [Paginas] SET [Nome] = @Nome, [Pagina] = @Pagina WHERE [id] = @id">
        <DeleteParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="id" Type="Int32" />
            <asp:Parameter Name="Nome" Type="String" />
            <asp:Parameter Name="Pagina" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Nome" Type="String" />
            <asp:Parameter Name="Pagina" Type="String" />
            <asp:Parameter Name="id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>

