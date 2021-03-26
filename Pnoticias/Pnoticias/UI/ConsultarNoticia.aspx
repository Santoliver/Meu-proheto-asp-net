<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarNoticia.aspx.cs" Inherits="Pnoticias.UI.ConsultarNoticia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
               Filtro:
            <asp:TextBox ID="txtFiltro" runat="server"></asp:TextBox>
            <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
            <br />
            <asp:GridView ID="gvNoticias" runat="server" OnRowCommand="gvNoticias_RowCommand" Width="297px">
                <Columns>
                       <asp:TemplateField>
                    </asp:TemplateField>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                                                </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <a href="Index.aspx" target="_top">Voltar</a>
        </div>
    </form>
</body>
</html>
