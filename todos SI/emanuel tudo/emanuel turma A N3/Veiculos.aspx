<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Veiculos.aspx.cs" Inherits="Veiculos" Title="Untitled Page" %>

<script runat="server">

  
</script>
<%-- Add content controls here --%><asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <p style="width: 1108px">
    <span lang="pt">kkkkk<asp:GridView ID="GridView1" runat="server" 
            AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" 
            EmptyDataText="There are no data records to display." Height="264px" 
            style="font-size: x-large; color: #FFFFFF" Width="1096px" 
        AllowPaging="True" AllowSorting="True">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" 
                    SortExpression="id" />
                <asp:BoundField DataField="modelo" HeaderText="modelo" 
                    SortExpression="modelo" />
                <asp:BoundField DataField="marca" HeaderText="marca" SortExpression="marca" />
                <asp:BoundField DataField="preço" HeaderText="preço" SortExpression="preço" />
                <asp:BoundField DataField="aluguer" HeaderText="aluguer" 
                    SortExpression="aluguer" />
            </Columns>
        </asp:GridView>
        </span>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
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
    </p>
    <p>
        <table border="0" cellpadding="0" cellspacing="0" 
            style="margin: 0px; padding: 0px; color: rgb(255, 255, 255); font-family: Arial, Helvetica, sans-serif; font-size: 13px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 17px; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; width: 112%; height: 835px;">
            <tbody style="margin: 0px; padding: 0px;">
                <tr style="margin: 0px; padding: 0px;">
                    <td colspan="3" style="margin: 0px; padding: 0px 0px 10px;">
                        &nbsp;</td>
                </tr>
                <tr style="margin: 0px; padding: 0px;">
                    <td colspan="3" style="margin: 0px; padding: 0px;">
                        &nbsp;</td>
                </tr>
                <tr style="margin: 0px; padding: 0px;">
                    <td colspan="3" height="15" style="margin: 0px; padding: 0px;">
                    </td>
                </tr>
                <tr style="margin: 0px; padding: 0px;">
                    <td style="margin: 0px; padding: 0px 0px 20px; width: 559px;" valign="top">
                        <table cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px;">
                            <tbody style="margin: 0px; padding: 0px;">
                                <tr style="margin: 0px; padding: 0px;">
                                    <td height="121" style="margin: 0px; padding: 0px;" valign="top" width="180">
                                        <div style="margin: 0px; padding: 0px; position: relative; width: 241px; height: 121px; top: 0px; left: 0px;">
                                            <div style="margin: 0px; padding: 0px; position: absolute; right: 0px; bottom: 5px;">
                                                <img src="http://www.joaomaiaautomoveis.com/images/barra_novo.jpg" 
                                                    style="margin: 0px; padding: 0px; border: none;" width="80" /></div>
                                            <a href="http://www.joaomaiaautomoveis.com/viaturas_detalhes.asp?id_veiculo=550" 
                                                style="margin: 0px; padding: 0px; text-decoration: initial; color: rgb(130, 0, 0); font-size: 13px;">
                                            <img 
                                                src="http://www.joaomaiaautomoveis.com/veiculos_galeria/foto(7451).jpg" 
                                                
                                                style="border-style: none; border-color: inherit; border-width: medium; margin: 0px; padding: 0px; width: 238px; height: 136px;" 
                                                title="Nissan" /></a></div>
                                    </td>
                                    <td style="margin: 0px; padding: 0px; width: 13px;" valign="top">
                                    </td>
                                    <td style="margin: 0px; padding: 0px; font-size: 11px; width: 244px;" 
                                        valign="top">
                                        <table cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px;">
                                            <tbody style="margin: 0px; padding: 0px;">
                                                <tr style="margin: 0px; padding: 0px;">
                                                    <td style="margin: 0px; padding: 0px;">
                                                        <h4 style="margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 15px; font-weight: normal;">
                                                            Nissan</h4>
                                                    </td>
                                                    <td style="margin: 0px; padding: 0px; color: rgb(0, 0, 0);">
                                                        &nbsp;&nbsp;</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                        <span style="color: rgb(0, 0, 0)">Qashqai 1.6 dCi 130Cv Tekna Sport 18<br 
                                            style="margin: 0px; padding: 0px;" />
                                        <b style="margin: 0px; padding: 0px;">Novo</b><br 
                                            style="margin: 0px; padding: 0px;" />
                                        <b style="margin: 0px; padding: 0px;">PVP:</b></span>&nbsp;<span 
                                            style="margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 12px;"><b 
                                            style="margin: 0px; padding: 0px;">31.380&nbsp;&#8364;</b></span><span 
                                            style="color: rgb(0, 0, 0)"><br style="margin: 0px; padding: 0px;" />
                                        <font style="margin: 0px; padding: 0px; font-size: 12px;">
                                        <b style="margin: 0px; padding: 0px;">Promocão:&nbsp;26.990&nbsp;&#8364;</b></font><br 
                                            style="margin: 0px; padding: 0px;" />
                                        </span>
                                        <div style="margin: 5px 0px 0px; padding: 0px;">
                                            <a href="http://www.joaomaiaautomoveis.com/viaturas_detalhes.asp?id_veiculo=550" 
                                                onmouseout="MM_swapImgRestore()" 
                                                onmouseover="MM_swapImage('Nissan','','images/btn_detalhes2.jpg',1)" 
                                                style="margin: 0px; padding: 0px; text-decoration: initial; color: rgb(130, 0, 0); font-size: 13px;">
                                            <img height="17" name="Nissan" 
                                                src="http://www.joaomaiaautomoveis.com/images/btn_detalhes.jpg" 
                                                style="margin: 0px; padding: 0px; border: none;" width="70" /></a></div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td style="margin: 0px; padding: 0px 0px 20px;" width="15">
                    </td>
                    <td style="margin: 0px; padding: 0px 0px 20px;" valign="top">
                        <table cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px;">
                            <tbody style="margin: 0px; padding: 0px;">
                                <tr style="margin: 0px; padding: 0px;">
                                    <td height="121" style="margin: 0px; padding: 0px;" valign="top" width="180">
                                        <div style="margin: 0px; padding: 0px; position: relative; width: 244px; height: 121px; top: 0px; left: 0px;">
                                            <div style="margin: 0px; padding: 0px; position: absolute; right: 0px; bottom: 5px;">
                                                <img src="http://www.joaomaiaautomoveis.com/images/barra_novo.jpg" 
                                                    style="margin: 0px; padding: 0px; border: none;" width="80" /></div>
                                            <a href="http://www.joaomaiaautomoveis.com/viaturas_detalhes.asp?id_veiculo=523" 
                                                style="margin: 0px; padding: 0px; text-decoration: initial; color: rgb(130, 0, 0); font-size: 13px;">
                                            <img 
                                                src="http://www.joaomaiaautomoveis.com/veiculos_galeria/foto(6978).jpg" 
                                                
                                                style="border-style: none; border-color: inherit; border-width: medium; margin: 0px; padding: 0px; width: 245px; height: 123px;" 
                                                title="Seat" /></a></div>
                                    </td>
                                    <td style="margin: 0px; padding: 0px; width: 15px;" valign="top">
                                    </td>
                                    <td style="margin: 0px; padding: 0px; font-size: 11px; width: 264px;" 
                                        valign="top">
                                        <table cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px;">
                                            <tbody style="margin: 0px; padding: 0px;">
                                                <tr style="margin: 0px; padding: 0px;">
                                                    <td style="margin: 0px; padding: 0px;">
                                                        <h4 style="margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 15px; font-weight: normal;">
                                                            Seat</h4>
                                                    </td>
                                                    <td style="margin: 0px; padding: 0px; color: rgb(0, 0, 0);">
                                                        &nbsp;&nbsp;</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                        <span style="color: rgb(0, 0, 0)">Leon TDi EDIÇÃO LIMITADA (76 Viaturas) By Seat 
                                        Sport<br style="margin: 0px; padding: 0px;" />
                                        <b style="margin: 0px; padding: 0px;">Novo</b><br 
                                            style="margin: 0px; padding: 0px;" />
                                        <b style="margin: 0px; padding: 0px;">PVP:</b></span>&nbsp;<span 
                                            style="margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 12px;"><b 
                                            style="margin: 0px; padding: 0px;">27.700&nbsp;&#8364;</b></span><span 
                                            style="color: rgb(0, 0, 0)"><br style="margin: 0px; padding: 0px;" />
                                        <font style="margin: 0px; padding: 0px; font-size: 12px;">
                                        <b style="margin: 0px; padding: 0px;">Promocão:&nbsp;23.240&nbsp;&#8364;</b></font><br 
                                            style="margin: 0px; padding: 0px;" />
                                        </span>
                                        <div style="margin: 5px 0px 0px; padding: 0px;">
                                            <a href="http://www.joaomaiaautomoveis.com/viaturas_detalhes.asp?id_veiculo=523" 
                                                onmouseout="MM_swapImgRestore()" 
                                                onmouseover="MM_swapImage('Seat','','images/btn_detalhes2.jpg',1)" 
                                                style="margin: 0px; padding: 0px; text-decoration: initial; color: rgb(130, 0, 0); font-size: 13px;">
                                            <img height="17" name="Seat" 
                                                src="http://www.joaomaiaautomoveis.com/images/btn_detalhes.jpg" 
                                                style="margin: 0px; padding: 0px; border: none;" width="70" /></a></div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td style="margin: 0px; padding: 0px 0px 20px;">
                    </td>
                </tr>
                <tr style="margin: 0px; padding: 0px;">
                    <td style="margin: 0px; padding: 0px 0px 20px; width: 559px;" valign="top">
                        <table cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px;">
                            <tbody style="margin: 0px; padding: 0px;">
                                <tr style="margin: 0px; padding: 0px;">
                                    <td height="121" style="margin: 0px; padding: 0px;" valign="top" width="180">
                                        <div style="margin: 0px; padding: 0px; position: relative; width: 242px; height: 121px; top: 0px; left: 0px;">
                                            <div style="margin: 0px; padding: 0px; position: absolute; right: 0px; bottom: 5px;">
                                                <img src="http://www.joaomaiaautomoveis.com/images/barra_novo.jpg" 
                                                    style="margin: 0px; padding: 0px; border: none;" width="80" /></div>
                                            <a href="http://www.joaomaiaautomoveis.com/viaturas_detalhes.asp?id_veiculo=685" 
                                                style="margin: 0px; padding: 0px; text-decoration: initial; color: rgb(130, 0, 0); font-size: 13px;">
                                            <img 
                                                src="http://www.joaomaiaautomoveis.com/veiculos_galeria/foto(9380).jpg" 
                                                
                                                style="border-style: none; border-color: inherit; border-width: medium; margin: 0px; padding: 0px; height: 121px; width: 243px;" 
                                                title="Seat" /></a></div>
                                    </td>
                                    <td style="margin: 0px; padding: 0px; width: 12px;" valign="top">
                                    </td>
                                    <td style="margin: 0px; padding: 0px; font-size: 11px; width: 245px;" 
                                        valign="top">
                                        <table cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px;">
                                            <tbody style="margin: 0px; padding: 0px;">
                                                <tr style="margin: 0px; padding: 0px;">
                                                    <td style="margin: 0px; padding: 0px;">
                                                        <h4 style="margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 15px; font-weight: normal;">
                                                            Seat</h4>
                                                    </td>
                                                    <td style="margin: 0px; padding: 0px; color: rgb(0, 0, 0);">
                                                        &nbsp;&nbsp;</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                        <span style="color: rgb(0, 0, 0)">Ibiza 1.6 TDi 105Cv Copa Plus<br 
                                            style="margin: 0px; padding: 0px;" />
                                        <b style="margin: 0px; padding: 0px;">Novo</b><br 
                                            style="margin: 0px; padding: 0px;" />
                                        <b style="margin: 0px; padding: 0px;">PVP:</b></span>&nbsp;<span 
                                            style="margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 12px;"><b 
                                            style="margin: 0px; padding: 0px;">21.500&nbsp;&#8364;</b></span><span 
                                            style="color: rgb(0, 0, 0)"><br style="margin: 0px; padding: 0px;" />
                                        <font style="margin: 0px; padding: 0px; font-size: 12px;">
                                        <b style="margin: 0px; padding: 0px;">Promocão:&nbsp;19.980&nbsp;&#8364;</b></font><br 
                                            style="margin: 0px; padding: 0px;" />
                                        </span>
                                        <div style="margin: 5px 0px 0px; padding: 0px;">
                                            <a href="http://www.joaomaiaautomoveis.com/viaturas_detalhes.asp?id_veiculo=685" 
                                                onmouseout="MM_swapImgRestore()" 
                                                onmouseover="MM_swapImage('Seat','','images/btn_detalhes2.jpg',1)" 
                                                style="margin: 0px; padding: 0px; text-decoration: initial; color: rgb(130, 0, 0); font-size: 13px;">
                                            <img height="17" name="Seat" 
                                                src="http://www.joaomaiaautomoveis.com/images/btn_detalhes.jpg" 
                                                style="margin: 0px; padding: 0px; border: none;" width="70" /></a></div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td style="margin: 0px; padding: 0px 0px 20px;" width="15">
                    </td>
                    <td style="margin: 0px; padding: 0px 0px 20px;" valign="top">
                        <table cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px;">
                            <tbody style="margin: 0px; padding: 0px;">
                                <tr style="margin: 0px; padding: 0px;">
                                    <td height="121" style="margin: 0px; padding: 0px;" valign="top" width="180">
                                        <div style="margin: 0px; padding: 0px; position: relative; width: 242px; height: 138px; top: 0px; left: 0px;">
                                            <div style="margin: 0px; padding: 0px; position: absolute; right: 0px; bottom: 5px;">
                                                <img src="http://www.joaomaiaautomoveis.com/images/barra_novo.jpg" 
                                                    style="margin: 0px; padding: 0px; border: none;" width="80" /></div>
                                            <a href="http://www.joaomaiaautomoveis.com/viaturas_detalhes.asp?id_veiculo=50" 
                                                style="margin: 0px; padding: 0px; text-decoration: initial; color: rgb(130, 0, 0); font-size: 13px;">
                                            <img 
                                                src="http://www.joaomaiaautomoveis.com/veiculos_galeria/foto(238).jpg" 
                                                
                                                style="border-style: none; border-color: inherit; border-width: medium; margin: 0px; padding: 0px; height: 138px; width: 243px;" 
                                                title="Seat " /></a></div>
                                    </td>
                                    <td style="margin: 0px; padding: 0px; width: 14px;" valign="top">
                                    </td>
                                    <td style="margin: 0px; padding: 0px; font-size: 11px; width: 284px;" 
                                        valign="top">
                                        <table cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px;">
                                            <tbody style="margin: 0px; padding: 0px;">
                                                <tr style="margin: 0px; padding: 0px;">
                                                    <td style="margin: 0px; padding: 0px;">
                                                        <h4 style="margin: 0px; padding: 0px; color: rgb(255, 255, 255); font-size: 15px; font-weight: normal;">
                                                            Seat</h4>
                                                    </td>
                                                    <td style="margin: 0px; padding: 0px;">
                                                        &nbsp;&nbsp;</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                        Ibiz<span style="color: rgb(0, 0, 0)">a FR 2.0TDi 143Cv (Bi-Xénon)<br 
                                            style="margin: 0px; padding: 0px;" />
                                        <b style="margin: 0px; padding: 0px;">Novo</b><br 
                                            style="margin: 0px; padding: 0px;" />
                                        <b style="margin: 0px; padding: 0px;">PVP:</b></span>&nbsp;<span 
                                            style="margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 12px;"><b 
                                            style="margin: 0px; padding: 0px;">27.430&nbsp;&#8364;</b></span><span 
                                            style="color: rgb(0, 0, 0)"><br style="margin: 0px; padding: 0px;" />
                                        <font style="margin: 0px; padding: 0px; font-size: 12px;">
                                        <b style="margin: 0px; padding: 0px;">Promocão:&nbsp;22.490&nbsp;&#8364;</b></font><br 
                                            style="margin: 0px; padding: 0px;" />
                                        </span>
                                        <div style="margin: 5px 0px 0px; padding: 0px;">
                                            <a href="http://www.joaomaiaautomoveis.com/viaturas_detalhes.asp?id_veiculo=50" 
                                                onmouseout="MM_swapImgRestore()" 
                                                onmouseover="MM_swapImage('Seat ','','images/btn_detalhes2.jpg',1)" 
                                                style="margin: 0px; padding: 0px; text-decoration: initial; color: rgb(130, 0, 0); font-size: 13px;">
                                            <img height="17" name="Seat " 
                                                src="http://www.joaomaiaautomoveis.com/images/btn_detalhes.jpg" 
                                                style="margin: 0px; padding: 0px; border: none;" width="70" /></a></div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td style="margin: 0px; padding: 0px 0px 20px;">
                    </td>
                </tr>
                <tr style="margin: 0px; padding: 0px;">
                    <td style="margin: 0px; padding: 0px 0px 20px; width: 559px;" valign="top">
                        <table cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px;">
                            <tbody style="margin: 0px; padding: 0px;">
                                <tr style="margin: 0px; padding: 0px;">
                                    <td height="121" style="margin: 0px; padding: 0px;" valign="top" width="180">
                                        <div style="margin: 0px; padding: 0px; position: relative; width: 247px; height: 121px; top: 0px; left: 0px;">
                                            <div style="margin: 0px; padding: 0px; position: absolute; right: 0px; bottom: 5px;">
                                                <img src="http://www.joaomaiaautomoveis.com/images/barra_novo.jpg" 
                                                    style="margin: 0px; padding: 0px; border: none;" width="80" /></div>
                                            <a href="http://www.joaomaiaautomoveis.com/viaturas_detalhes.asp?id_veiculo=207" 
                                                style="margin: 0px; padding: 0px; text-decoration: initial; color: rgb(130, 0, 0); font-size: 13px;">
                                            <img 
                                                src="http://www.joaomaiaautomoveis.com/veiculos_galeria/foto(2097).jpg" 
                                                
                                                style="border-style: none; border-color: inherit; border-width: medium; margin: 0px; padding: 0px; width: 249px; height: 123px;" 
                                                title="Seat" /></a></div>
                                    </td>
                                    <td style="margin: 0px; padding: 0px; width: 7px;" valign="top">
                                    </td>
                                    <td style="margin: 0px; padding: 0px; font-size: 11px; width: 243px;" 
                                        valign="top">
                                        <table cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px;">
                                            <tbody style="margin: 0px; padding: 0px;">
                                                <tr style="margin: 0px; padding: 0px;">
                                                    <td style="margin: 0px; padding: 0px;">
                                                        <h4 style="margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 15px; font-weight: normal;">
                                                            Seat</h4>
                                                    </td>
                                                    <td style="margin: 0px; padding: 0px; color: rgb(0, 0, 0);">
                                                        &nbsp;&nbsp;</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                        <span style="color: rgb(0, 0, 0)">Ibiza 1.2 TDi STYLE (Tecto Panorâmico)<br 
                                            style="margin: 0px; padding: 0px;" />
                                        <b style="margin: 0px; padding: 0px;">Novo</b><br 
                                            style="margin: 0px; padding: 0px;" />
                                        <b style="margin: 0px; padding: 0px;">PVP:</b>&nbsp;14.990&nbsp;&#8364;<br 
                                            style="margin: 0px; padding: 0px;" />
                                        </span>
                                        <div style="margin: 5px 0px 0px; padding: 0px;">
                                            <a href="http://www.joaomaiaautomoveis.com/viaturas_detalhes.asp?id_veiculo=207" 
                                                onmouseout="MM_swapImgRestore()" 
                                                onmouseover="MM_swapImage('Seat','','images/btn_detalhes2.jpg',1)" 
                                                style="margin: 0px; padding: 0px; text-decoration: initial; color: rgb(130, 0, 0); font-size: 13px;">
                                            <img height="17" name="Seat" 
                                                src="http://www.joaomaiaautomoveis.com/images/btn_detalhes.jpg" 
                                                style="margin: 0px; padding: 0px; border: none;" width="70" /></a></div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td style="margin: 0px; padding: 0px 0px 20px;" width="15">
                    </td>
                    <td style="margin: 0px; padding: 0px 0px 20px;" valign="top">
                        <table cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px;">
                            <tbody style="margin: 0px; padding: 0px;">
                                <tr style="margin: 0px; padding: 0px;">
                                    <td height="121" style="margin: 0px; padding: 0px;" valign="top" width="180">
                                        <div style="margin: 0px; padding: 0px; position: relative; width: 241px; height: 121px; top: 0px; left: 0px;">
                                            <div style="margin: 0px; padding: 0px; position: absolute; right: 0px; bottom: 5px;">
                                                <img src="http://www.joaomaiaautomoveis.com/images/barra_novo.jpg" 
                                                    style="margin: 0px; padding: 0px; border: none;" width="80" /></div>
                                            <a href="http://www.joaomaiaautomoveis.com/viaturas_detalhes.asp?id_veiculo=250" 
                                                style="margin: 0px; padding: 0px; text-decoration: initial; color: rgb(130, 0, 0); font-size: 13px;">
                                            <img 
                                                src="http://www.joaomaiaautomoveis.com/veiculos_galeria/foto(4051).jpg" 
                                                
                                                style="border-style: none; border-color: inherit; border-width: medium; margin: 0px; padding: 0px; height: 126px; width: 244px;" 
                                                title="Renault" /></a></div>
                                    </td>
                                    <td style="margin: 0px; padding: 0px; width: 17px;" valign="top">
                                    </td>
                                    <td style="margin: 0px; padding: 0px; font-size: 11px; width: 283px;" 
                                        valign="top">
                                        <table cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px;">
                                            <tbody style="margin: 0px; padding: 0px;">
                                                <tr style="margin: 0px; padding: 0px;">
                                                    <td style="margin: 0px; padding: 0px;">
                                                        <h4 style="margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 15px; font-weight: normal;">
                                                            Renault</h4>
                                                    </td>
                                                    <td style="margin: 0px; padding: 0px; color: rgb(0, 0, 0);">
                                                        &nbsp;&nbsp;</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                        <span style="color: rgb(0, 0, 0)">Clio 1.2 16V Fairway (75Cv)<br 
                                            style="margin: 0px; padding: 0px;" />
                                        <b style="margin: 0px; padding: 0px;">Novo</b><br 
                                            style="margin: 0px; padding: 0px;" />
                                        <b style="margin: 0px; padding: 0px;">PVP:</b></span>&nbsp;<span 
                                            style="margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 12px;"><b 
                                            style="margin: 0px; padding: 0px;">16.940&nbsp;&#8364;</b></span><span 
                                            style="color: rgb(0, 0, 0)"><br style="margin: 0px; padding: 0px;" />
                                        <font style="margin: 0px; padding: 0px; font-size: 12px;">
                                        <b style="margin: 0px; padding: 0px;">Promocão:&nbsp;14.300&nbsp;&#8364;</b></font><br 
                                            style="margin: 0px; padding: 0px;" />
                                        </span>
                                        <div style="margin: 5px 0px 0px; padding: 0px;">
                                            <a href="http://www.joaomaiaautomoveis.com/viaturas_detalhes.asp?id_veiculo=250" 
                                                onmouseout="MM_swapImgRestore()" 
                                                onmouseover="MM_swapImage('Renault','','images/btn_detalhes2.jpg',1)" 
                                                style="margin: 0px; padding: 0px; text-decoration: initial; color: rgb(130, 0, 0); font-size: 13px;">
                                            <img height="17" name="Renault" 
                                                src="http://www.joaomaiaautomoveis.com/images/btn_detalhes.jpg" 
                                                style="margin: 0px; padding: 0px; border: none;" width="70" /></a></div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td style="margin: 0px; padding: 0px 0px 20px;">
                    </td>
                </tr>
                <tr style="margin: 0px; padding: 0px;">
                    <td style="margin: 0px; padding: 0px 0px 20px; width: 559px;" valign="top">
                        <table cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px;">
                            <tbody style="margin: 0px; padding: 0px;">
                                <tr style="margin: 0px; padding: 0px;">
                                    <td height="121" style="margin: 0px; padding: 0px;" valign="top" width="180">
                                        <div style="margin: 0px; padding: 0px; position: relative; width: 248px; height: 121px; top: 0px; left: 0px;">
                                            <div style="margin: 0px; padding: 0px; position: absolute; right: 0px; bottom: 5px;">
                                                <img src="http://www.joaomaiaautomoveis.com/images/barra_novo.jpg" 
                                                    style="margin: 0px; padding: 0px; border: none;" width="80" /></div>
                                            <a href="http://www.joaomaiaautomoveis.com/viaturas_detalhes.asp?id_veiculo=251" 
                                                style="margin: 0px; padding: 0px; text-decoration: initial; color: rgb(130, 0, 0); font-size: 13px;">
                                            <img 
                                                src="http://www.joaomaiaautomoveis.com/veiculos_galeria/foto(3834).jpg" 
                                                
                                                style="border-style: none; border-color: inherit; border-width: medium; margin: 0px; padding: 0px; height: 125px; width: 249px;" 
                                                title="Renault" /></a></div>
                                    </td>
                                    <td style="margin: 0px; padding: 0px; width: 2px;" valign="top">
                                    </td>
                                    <td style="margin: 0px; padding: 0px; font-size: 11px; width: 245px;" 
                                        valign="top">
                                        <table cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px;">
                                            <tbody style="margin: 0px; padding: 0px;">
                                                <tr style="margin: 0px; padding: 0px;">
                                                    <td style="margin: 0px; padding: 0px;">
                                                        <h4 style="margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 15px; font-weight: normal;">
                                                            Renault</h4>
                                                    </td>
                                                    <td style="margin: 0px; padding: 0px; color: rgb(0, 0, 0);">
                                                        &nbsp;&nbsp;</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                        <span style="color: rgb(0, 0, 0)">Clio 1.5 dCi Fairway (90Cv)<br 
                                            style="margin: 0px; padding: 0px;" />
                                        <b style="margin: 0px; padding: 0px;">Novo</b><br 
                                            style="margin: 0px; padding: 0px;" />
                                        <b style="margin: 0px; padding: 0px;">PVP:</b></span>&nbsp;<span 
                                            style="margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 12px;"><b 
                                            style="margin: 0px; padding: 0px;">20.900&nbsp;&#8364;</b></span><span 
                                            style="color: rgb(0, 0, 0)"><br style="margin: 0px; padding: 0px;" />
                                        <font style="margin: 0px; padding: 0px; font-size: 12px;">
                                        <b style="margin: 0px; padding: 0px;">Promocão:&nbsp;16.940&nbsp;&#8364;</b></font><br 
                                            style="margin: 0px; padding: 0px;" />
                                        </span>
                                        <div style="margin: 5px 0px 0px; padding: 0px;">
                                            <a href="http://www.joaomaiaautomoveis.com/viaturas_detalhes.asp?id_veiculo=251" 
                                                onmouseout="MM_swapImgRestore()" 
                                                onmouseover="MM_swapImage('Renault','','images/btn_detalhes2.jpg',1)" 
                                                style="margin: 0px; padding: 0px; text-decoration: initial; color: rgb(130, 0, 0); font-size: 13px;">
                                            <img height="17" name="Renault" 
                                                src="http://www.joaomaiaautomoveis.com/images/btn_detalhes.jpg" 
                                                style="border-style: none; border-color: inherit; border-width: medium; margin: 0px; padding: 0px; color: rgb(0, 0, 0);" 
                                                width="70" /></a></div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td style="margin: 0px; padding: 0px 0px 20px;" width="15">
                    </td>
                    <td style="margin: 0px; padding: 0px 0px 20px;" valign="top">
                        <table cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px;">
                            <tbody style="margin: 0px; padding: 0px;">
                                <tr style="margin: 0px; padding: 0px;">
                                    <td height="121" style="margin: 0px; padding: 0px;" valign="top" width="180">
                                        <div style="margin: 0px; padding: 0px; position: relative; width: 243px; height: 132px; top: 0px; left: 0px;">
                                            <div style="margin: 0px; padding: 0px; position: absolute; right: 0px; bottom: 5px;">
                                                <img src="http://www.joaomaiaautomoveis.com/images/barra_novo.jpg" 
                                                    style="margin: 0px; padding: 0px; border: none;" width="80" /></div>
                                            <a href="http://www.joaomaiaautomoveis.com/viaturas_detalhes.asp?id_veiculo=548" 
                                                style="margin: 0px; padding: 0px; text-decoration: initial; color: rgb(130, 0, 0); font-size: 13px;">
                                            <img 
                                                src="http://www.joaomaiaautomoveis.com/veiculos_galeria/foto(7372).jpg" 
                                                
                                                style="border-style: none; border-color: inherit; border-width: medium; margin: 0px; padding: 0px; height: 133px; width: 244px;" 
                                                title="Nissan" /></a></div>
                                    </td>
                                    <td style="margin: 0px; padding: 0px; width: 16px;" valign="top">
                                    </td>
                                    <td style="margin: 0px; padding: 0px; font-size: 11px; width: 285px;" 
                                        valign="top">
                                        <table cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px;">
                                            <tbody style="margin: 0px; padding: 0px;">
                                                <tr style="margin: 0px; padding: 0px;">
                                                    <td style="margin: 0px; padding: 0px;">
                                                        <h4 style="margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 15px; font-weight: normal;">
                                                            Nissan</h4>
                                                    </td>
                                                    <td style="margin: 0px; padding: 0px; color: rgb(0, 0, 0);">
                                                        &nbsp;&nbsp;</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                        <span style="color: rgb(0, 0, 0)">Juke Tekna Sport 1.5 dCi 110Cv<br 
                                            style="margin: 0px; padding: 0px;" />
                                        <b style="margin: 0px; padding: 0px;">Novo</b><br 
                                            style="margin: 0px; padding: 0px;" />
                                        <b style="margin: 0px; padding: 0px;">PVP:</b></span>&nbsp;<span 
                                            style="margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 12px;"><b 
                                            style="margin: 0px; padding: 0px;">24.800&nbsp;&#8364;</b></span><span 
                                            style="color: rgb(0, 0, 0)"><br style="margin: 0px; padding: 0px;" />
                                        <font style="margin: 0px; padding: 0px; font-size: 12px;">
                                        <b style="margin: 0px; padding: 0px;">Promocão:&nbsp;21.400&nbsp;&#8364;</b></font><br 
                                            style="margin: 0px; padding: 0px;" />
                                        </span>
                                        <div style="margin: 5px 0px 0px; padding: 0px;">
                                            <a href="http://www.joaomaiaautomoveis.com/viaturas_detalhes.asp?id_veiculo=548" 
                                                onmouseout="MM_swapImgRestore()" 
                                                onmouseover="MM_swapImage('Nissan','','images/btn_detalhes2.jpg',1)" 
                                                style="margin: 0px; padding: 0px; text-decoration: initial; color: rgb(130, 0, 0); font-size: 13px;">
                                            <img height="17" name="Nissan" 
                                                src="http://www.joaomaiaautomoveis.com/images/btn_detalhes.jpg" 
                                                style="border-style: none; border-color: inherit; border-width: medium; margin: 0px; padding: 0px; color: rgb(0, 0, 0);" 
                                                width="70" /></a></div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td style="margin: 0px; padding: 0px 0px 20px;">
                    </td>
                </tr>
                <tr style="margin: 0px; padding: 0px;">
                    <td style="margin: 0px; padding: 0px 0px 20px; width: 559px;" valign="top">
                        <table cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px;">
                            <tbody style="margin: 0px; padding: 0px;">
                                <tr style="margin: 0px; padding: 0px;">
                                    <td height="121" style="margin: 0px; padding: 0px; width: 149px;" valign="top">
                                        <div style="margin: 0px; padding: 0px; position: relative; width: 252px; height: 121px; top: 0px; left: 0px;">
                                            <div style="margin: 0px; padding: 0px; position: absolute; right: 0px; bottom: 5px;">
                                                <img src="http://www.joaomaiaautomoveis.com/images/barra_novo.jpg" 
                                                    style="margin: 0px; padding: 0px; border: none;" width="80" /></div>
                                            <a href="http://www.joaomaiaautomoveis.com/viaturas_detalhes.asp?id_veiculo=568" 
                                                style="margin: 0px; padding: 0px; text-decoration: initial; color: rgb(130, 0, 0); font-size: 13px;">
                                            <img 
                                                src="http://www.joaomaiaautomoveis.com/veiculos_galeria/foto(7826).jpg" 
                                                
                                                style="border-style: none; border-color: inherit; border-width: medium; margin: 0px; padding: 0px; height: 129px; width: 252px;" 
                                                title="Seat" /></a></div>
                                    </td>
                                    <td style="margin: 0px; padding: 0px;" valign="top">
                                    </td>
                                    <td style="margin: 0px; padding: 0px; font-size: 11px; width: 245px;" 
                                        valign="top">
                                        <table cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px;">
                                            <tbody style="margin: 0px; padding: 0px;">
                                                <tr style="margin: 0px; padding: 0px;">
                                                    <td style="margin: 0px; padding: 0px;">
                                                        <h4 style="margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 15px; font-weight: normal;">
                                                            Seat</h4>
                                                    </td>
                                                    <td style="margin: 0px; padding: 0px; color: rgb(0, 0, 0);">
                                                        &nbsp;&nbsp;</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                        <span style="color: rgb(0, 0, 0)">Ibiza Station 1.2 TDi Fresc<br 
                                            style="margin: 0px; padding: 0px;" />
                                        <b style="margin: 0px; padding: 0px;">Novo</b><br 
                                            style="margin: 0px; padding: 0px;" />
                                        <b style="margin: 0px; padding: 0px;">PVP:</b></span>&nbsp;<span 
                                            style="margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 12px;"><b 
                                            style="margin: 0px; padding: 0px;">19.900&nbsp;&#8364;</b></span><span 
                                            style="color: rgb(0, 0, 0)"><br style="margin: 0px; padding: 0px;" />
                                        <font style="margin: 0px; padding: 0px; font-size: 12px;">
                                        <b style="margin: 0px; padding: 0px;">Promocão:&nbsp;17.740&nbsp;&#8364;</b></font><br 
                                            style="margin: 0px; padding: 0px;" />
                                        </span>
                                        <div style="margin: 5px 0px 0px; padding: 0px;">
                                            <a href="http://www.joaomaiaautomoveis.com/viaturas_detalhes.asp?id_veiculo=568" 
                                                onmouseout="MM_swapImgRestore()" 
                                                onmouseover="MM_swapImage('Seat','','images/btn_detalhes2.jpg',1)" 
                                                style="margin: 0px; padding: 0px; text-decoration: initial; color: rgb(130, 0, 0); font-size: 13px;">
                                            <img height="17" name="Seat" 
                                                src="http://www.joaomaiaautomoveis.com/images/btn_detalhes.jpg" 
                                                style="border-style: none; border-color: inherit; border-width: medium; margin: 0px; padding: 0px; color: rgb(0, 0, 0);" 
                                                width="70" /></a></div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                    <td style="margin: 0px; padding: 0px 0px 20px;" width="15">
                    </td>
                    <td style="margin: 0px; padding: 0px 0px 20px;" valign="top">
                        <table cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px;">
                            <tbody style="margin: 0px; padding: 0px;">
                                <tr style="margin: 0px; padding: 0px;">
                                    <td height="121" style="margin: 0px; padding: 0px;" valign="top" width="180">
                                        <div style="margin: 0px; padding: 0px; position: relative; width: 243px; height: 115px; top: 4px; left: 2px;">
                                            <div style="margin: 0px; padding: 0px; position: absolute; right: 0px; bottom: 5px; height: 17px;">
                                                <img src="http://www.joaomaiaautomoveis.com/images/barra_novo.jpg" 
                                                    style="margin: 0px; padding: 0px; border: none;" width="80" /></div>
                                            <div style="margin: 0px; padding: 0px; position: absolute; left: 12px; top: -1px; height: 114px; width: 207px;">
                                                <img 
                                                    src="http://www.joaomaiaautomoveis.com/images/barra_reservado.png" 
                                                    
                                                    style="border-style: none; border-color: inherit; border-width: medium; margin: 0px; padding: 0px; height: 113px; width: 205px;" /></div>
                                            <a href="http://www.joaomaiaautomoveis.com/viaturas_detalhes.asp?id_veiculo=287" 
                                                style="margin: 0px; padding: 0px; text-decoration: initial; color: rgb(130, 0, 0); font-size: 13px;">
                                            <img 
                                                src="http://www.joaomaiaautomoveis.com/veiculos_galeria/foto(3469).jpg" 
                                                
                                                style="border-style: none; border-color: inherit; border-width: medium; margin: 0px; padding: 0px; height: 117px; width: 238px;" 
                                                title="Volvo" /></a></div>
                                    </td>
                                    <td style="margin: 0px; padding: 0px; width: 17px;" valign="top">
                                    </td>
                                    <td style="margin: 0px; padding: 0px; font-size: 11px; width: 285px;" 
                                        valign="top">
                                        <table cellpadding="0" cellspacing="0" style="margin: 0px; padding: 0px;">
                                            <tbody style="margin: 0px; padding: 0px;">
                                                <tr style="margin: 0px; padding: 0px;">
                                                    <td style="margin: 0px; padding: 0px;">
                                                        <h4 style="margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 15px; font-weight: normal;">
                                                            Volvo</h4>
                                                    </td>
                                                    <td style="margin: 0px; padding: 0px; color: rgb(0, 0, 0);">
                                                        &nbsp;&nbsp;</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                        <span style="color: rgb(0, 0, 0)">V50 1.6D Drive Momentum<br 
                                            style="margin: 0px; padding: 0px;" />
                                        <b style="margin: 0px; padding: 0px;">Novo</b><br 
                                            style="margin: 0px; padding: 0px;" />
                                        </span>
                                        <div style="margin: 5px 0px 0px; padding: 0px;">
                                            <a href="http://www.joaomaiaautomoveis.com/viaturas_detalhes.asp?id_veiculo=287" 
                                                onmouseout="MM_swapImgRestore()" 
                                                onmouseover="MM_swapImage('Volvo','','images/btn_detalhes2.jpg',1)" 
                                                style="margin: 0px; padding: 0px; text-decoration: initial; color: rgb(130, 0, 0); font-size: 13px;">
                                            <img height="17" name="Volvo" 
                                                src="http://www.joaomaiaautomoveis.com/images/btn_detalhes.jpg" 
                                                style="border-style: none; border-color: inherit; border-width: medium; margin: 0px; padding: 0px; color: rgb(0, 0, 0);" 
                                                width="70" /></a></div>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </td>
                </tr>
            </tbody>
        </table>
    </p>
<p>
    &nbsp;</p>
</asp:Content>



