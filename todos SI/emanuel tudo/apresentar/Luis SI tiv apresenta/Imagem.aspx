<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Imagem.aspx.cs" Inherits="Imagem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 95%;
            height: 172px;
        }
        .style2
        {
            width: 260px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="style1">
        <tr>
            <td class="style2">
                <asp:Label ID="Label1" runat="server" Text="Imagem"></asp:Label>
                <br />
                <br />
            </td>
            <td>
                <br />
                <asp:FileUpload ID="FileUploadImagem" runat="server" />
                <br />
&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="FileUploadImagem" ErrorMessage="Ficheiro nao caregada"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label2" runat="server" Text="Titulo"></asp:Label>
                <br />
                <br />
            </td>
            <td>
                <br />
                <asp:TextBox ID="TextBoxTitulo" runat="server" Width="208px"></asp:TextBox>
                <br />
&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBoxTitulo" ErrorMessage="Titulo não ensirido"></asp:RequiredFieldValidator>
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
                <br />
            </td>
            <td>
                <asp:Label ID="lbStatus" runat="server"></asp:Label>
&nbsp;&nbsp;
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
&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Text="Enviar" onclick="Button1_Click" />
                <br />
                <br />
&nbsp;
                <asp:HyperLink ID="HyperLink1" runat="server" 
                    NavigateUrl="~/Ver Imagensaspx.aspx">Ver Imagem</asp:HyperLink>
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

