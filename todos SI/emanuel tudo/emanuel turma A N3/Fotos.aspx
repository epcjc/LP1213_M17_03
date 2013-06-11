<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Fotos.aspx.cs" Inherits="Fotos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td style="width: 275px">
                <asp:Label ID="Label1" runat="server" Text="Imagens"></asp:Label>
            </td>
            <td style="width: 512px">
                <asp:FileUpload ID="FileUploadImagem" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="Ficheiro nao caregada" ForeColor="White" 
                    ControlToValidate="FileUploadImagem"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 275px">
                <asp:Label ID="Label2" runat="server" Text="Titulo Imagem"></asp:Label>
            </td>
            <td style="width: 512px">
                <asp:TextBox ID="TextBoxTitulo" runat="server" Width="214px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ErrorMessage="ficheiro nao caregada" ForeColor="White" 
                    ControlToValidate="TextBoxTitulo"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 275px">
                &nbsp;</td>
            <td style="width: 512px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 275px">
                &nbsp;</td>
            <td style="width: 512px">
                <asp:Label ID="lbStatus" runat="server"></asp:Label>
&nbsp;<asp:Label ID="lblStatus0" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td style="height: 22px; width: 275px">
            </td>
            <td style="height: 22px; width: 512px;">
                <asp:Button ID="EnviaFicheiro" runat="server" onclick="EnviaFicheiro_Click" 
                    Text="Enviar" />
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/verImagem.aspx">Ver Imagem</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>

