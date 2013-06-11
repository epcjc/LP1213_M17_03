<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="reserva.aspx.cs" Inherits="reserva" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <p>
    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Morada"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Telefone"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Sexo"></asp:Label>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Masculino</asp:ListItem>
                <asp:ListItem>Feminino</asp:ListItem>
            </asp:RadioButtonList>
            &nbsp;<asp:Label ID="Label6" runat="server" Text="Nº de qurto"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList 
                ID="DropDownList1" runat="server" Height="16px" 
                Width="35px">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem>13</asp:ListItem>
                <asp:ListItem>14</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>17</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>19</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>21</asp:ListItem>
                <asp:ListItem>22</asp:ListItem>
                <asp:ListItem>23</asp:ListItem>
                <asp:ListItem>24</asp:ListItem>
                <asp:ListItem>25</asp:ListItem>
                <asp:ListItem>26</asp:ListItem>
                <asp:ListItem>27</asp:ListItem>
                <asp:ListItem>28</asp:ListItem>
                <asp:ListItem>29</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Nº de Adultoss"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList2" runat="server" Height="19px" 
                Width="36px">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label11" runat="server" Text="Nº de crianças"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList7" runat="server" Height="17px" 
                Width="37px">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Andar do quarto"></asp:Label>
            &nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList3" runat="server" Width="81px">
                <asp:ListItem>1º Andar</asp:ListItem>
                <asp:ListItem>2º Andar</asp:ListItem>
                <asp:ListItem>3º Andar</asp:ListItem>
                <asp:ListItem>4º Andar</asp:ListItem>
                <asp:ListItem>5º Andar</asp:ListItem>
                <asp:ListItem>6º Andar</asp:ListItem>
                <asp:ListItem>7º Andar</asp:ListItem>
                <asp:ListItem>8º Andar</asp:ListItem>
                <asp:ListItem>9º Andar</asp:ListItem>
                <asp:ListItem>10º Andar</asp:ListItem>
                <asp:ListItem>11º Andar</asp:ListItem>
                <asp:ListItem>12º Andar</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Checkin"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            <br />
            <asp:Label ID="Label10" runat="server" Text="Checkout"></asp:Label>
            &nbsp;&nbsp;&nbsp;<asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Inserir" 
                onclick="Button1_Click" />
            <br />
            <br />
            <br />
        </asp:View>
        <asp:View ID="View2" runat="server">
            <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label19" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label20" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label21" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label22" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Validar" 
                onclick="Button2_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button3" 
                runat="server" Text="Editar" onclick="Button3_Click" />
            <br />
            <br />
            <br />
        </asp:View>
        <asp:View ID="View3" runat="server">
            <asp:Label ID="Label23" runat="server" Text="Nome"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label24" runat="server" Text="Morada"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label25" runat="server" Text="Telefone"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label26" runat="server" Text="Email"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label27" runat="server" Text="Sexo"></asp:Label>
            <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                <asp:ListItem>Masculino</asp:ListItem>
                <asp:ListItem>Feminino</asp:ListItem>
            </asp:RadioButtonList>
            &nbsp;<asp:Label ID="Label28" runat="server" Text="Nº de qurto"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList 
                ID="DropDownList11" runat="server" Height="16px" 
                Width="34px">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem>13</asp:ListItem>
                <asp:ListItem>14</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>17</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>19</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>21</asp:ListItem>
                <asp:ListItem>22</asp:ListItem>
                <asp:ListItem>23</asp:ListItem>
                <asp:ListItem>24</asp:ListItem>
                <asp:ListItem>25</asp:ListItem>
                <asp:ListItem>26</asp:ListItem>
                <asp:ListItem>27</asp:ListItem>
                <asp:ListItem>28</asp:ListItem>
                <asp:ListItem>29</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label29" runat="server" Text="Nº de Adultoss"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList12" 
                runat="server" Height="17px" 
                Width="34px">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label30" runat="server" Text="Nº de crianças"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList13" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label31" runat="server" Text="Andar do quarto"></asp:Label>
            &nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList14" runat="server" Width="81px">
                <asp:ListItem>1º Andar</asp:ListItem>
                <asp:ListItem>2º Andar</asp:ListItem>
                <asp:ListItem>3º Andar</asp:ListItem>
                <asp:ListItem>4º Andar</asp:ListItem>
                <asp:ListItem>5º Andar</asp:ListItem>
                <asp:ListItem>6º Andar</asp:ListItem>
                <asp:ListItem>7º Andar</asp:ListItem>
                <asp:ListItem>8º Andar</asp:ListItem>
                <asp:ListItem>9º Andar</asp:ListItem>
                <asp:ListItem>10º Andar</asp:ListItem>
                <asp:ListItem>11º Andar</asp:ListItem>
                <asp:ListItem>12º Andar</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label32" runat="server" Text="Checkin"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Calendar ID="Calendar3" runat="server"></asp:Calendar>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="Label33" runat="server" Text="Checkout"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Calendar ID="Calendar4" runat="server"></asp:Calendar>
            &nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="Guardar " 
                onclick="Button4_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button5" runat="server" Text="Fechar" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:View>
        <br />
        <br />
        <br />
        <br />
    </asp:MultiView>
    </p>
</asp:Content>

