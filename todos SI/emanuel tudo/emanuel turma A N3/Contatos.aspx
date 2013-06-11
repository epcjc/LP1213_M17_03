<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contatos.aspx.cs" Inherits="Contatos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server">
            <br />
            <asp:Label ID="Label1" runat="server" Text="Nome" 
                style="color: #1818E4; font-weight: 700; font-size: x-large;"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="23px" Width="274px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TextBox1" ErrorMessage="Falta Nome">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" style="color: #1818E4; font-weight: 700; font-size: x-large;" 
                Text="Morada"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Height="22px" Width="262px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="TextBox2" ErrorMessage="Falta Morada">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" style="color: #1818E4; font-weight: 700; font-size: x-large;" 
                Text="Telefone"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Height="23px" Width="261px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="TextBox3" ErrorMessage="Falta Telefone">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" style="color: #1818E0; font-weight: 700; font-size: x-large;" 
                Text="Email"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Height="21px" Width="266px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="TextBox4" ErrorMessage="Falta Email">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" style="color: #1818E4; font-weight: 700; font-size: x-large;" 
                Text="Sexo"></asp:Label>
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                style="color: #4718E0; font-weight: 700; font-size: large;">
                <asp:ListItem>Masculino</asp:ListItem>
                <asp:ListItem>Femininio</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="Label7" runat="server" style="color: #4718E0; font-weight: 700; font-size: x-large;" 
                Text="Automoveis"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" 
                style="color: #4718E0; font-weight: 700">
                <asp:ListItem>BMW</asp:ListItem>
                <asp:ListItem>AUDI</asp:ListItem>
                <asp:ListItem>PORSCHE</asp:ListItem>
                <asp:ListItem>HUMMER</asp:ListItem>
                <asp:ListItem>MERCEDES</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <input id="Reset1" type="reset" 
    value="Limpar" style="color: #4718E0; font-weight: 700; font-size: large; background-color: #FFFF00;" onclick="return Reset1_onclick()" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" 
                
                style="color: #8A18E0; font-weight: 700; font-size: large; background-color: #FFFF00;" Text="Inserir" 
                onclick="Button2_Click" />
            <br />
            <br />
            <br />
            <br />
        </asp:View>
        <asp:View ID="View2" runat="server">
            <div style="text-align: justify">
                <span style="color: #0000CC; font-size: xx-large"><strong>Dados enserido</strong></span><br />
                <br />
                <asp:Label ID="Label8" runat="server" style="color: #0000CC; font-weight: 700; font-size: x-large;" 
                    Text="Label"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label9" runat="server" style="color: #0000CC; font-weight: 700; font-size: x-large;" 
                    Text="Label"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label10" runat="server" style="color: #0000CC; font-weight: 700; font-size: x-large;" 
                    Text="Label"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label11" runat="server" style="color: #0000CC; font-weight: 700; font-size: x-large;" 
                    Text="Label"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label12" runat="server" style="color: #0000CC; font-weight: 700; font-size: x-large;" 
                    Text="Label"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label13" runat="server" style="color: #0000CC; font-weight: 700; font-size: x-large;" 
                    Text="Label"></asp:Label>
                <br />
                <br />
                <br />
                <asp:Button ID="Button4" runat="server" onclick="Button4_Click" 
                    style="font-weight: 700; color: #0000CC" Text="Validar" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" 
                    style="font-weight: 700; color: #0000CC" Text="Editar" 
                    onclick="Button3_Click" />
                <br />
            </div>
        </asp:View>
        <asp:View ID="View3" runat="server">
            <asp:Label ID="Label14" runat="server" 
                style="color: #0000CC; font-size: x-large;" Text="Nome"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Width="225px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label15" runat="server" 
                style="color: #0000CC; font-size: x-large;" Text="Morada"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server" Width="216px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label16" runat="server" 
                style="color: #003AE6; font-size: x-large;" Text="Telefone"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox7" runat="server" Width="219px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label17" runat="server" 
                style="color: #003AE6; font-size: x-large;" Text="Email"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox8" runat="server" Width="224px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label18" runat="server" 
                style="color: #003AE6; font-size: x-large;" Text="Sexo"></asp:Label>
            <asp:RadioButtonList ID="RadioButtonList2" runat="server" 
                style="color: #0000CC; font-size: large;">
                <asp:ListItem>Masulino</asp:ListItem>
                <asp:ListItem>Feminino</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            <br />
            <asp:Label ID="Label19" runat="server" 
                style="color: #3A3AE6; font-size: x-large;" Text="Veiculos"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" 
                style="color: #0000CC; font-weight: 700; margin-left: 25px">
                <asp:ListItem>BMW</asp:ListItem>
                <asp:ListItem>AUDI</asp:ListItem>
                <asp:ListItem>PORSCHE</asp:ListItem>
                <asp:ListItem>HUMMER</asp:ListItem>
                <asp:ListItem>MERCEDES</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" 
                
                style="color: #0000CC; font-weight: 700; font-size: large; background-color: #FFFF00;" Text="Guardar" 
                onclick="Button5_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button6" runat="server" 
                
                style="color: #0000CC; font-weight: 700; font-size: large; background-color: #FFFF00;" 
                Text="Fechar" />
        </asp:View>
    </asp:MultiView>
    <script language="javascript" type="text/javascript">
// <![CDATA[

        function Reset1_onclick() {

        }

// ]]>
    </script>
</asp:Content>


