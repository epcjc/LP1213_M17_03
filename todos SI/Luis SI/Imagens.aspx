<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Imagens.aspx.vb" Inherits="Imagens" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
        width: 262px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>
    <br />
    <table class="style1">
        <tr>
            <td class="style2">
                <asp:Label ID="Label1" runat="server" Text="Imagens"></asp:Label>
                <br />
                <br />
                <br />
            </td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="FileUpload1" ErrorMessage="Ficheiro nao caregada"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label2" runat="server" Text="Titulo"></asp:Label>
                <br />
                <br />
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="217px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="Titulo não ensirido"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <br />
                <br />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <br />
                <br />
            </td>
            <td>
                <asp:Label ID="lbStatus" runat="server"></asp:Label>
&nbsp;
                <asp:Label ID="lblStatus0" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <br />
                <br />
            </td>
            <td>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Enviar" />
                <br />
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server">Ver Imagem</asp:HyperLink>
                <br />
            </td>
        </tr>
    </table>
</p>
</asp:Content>

