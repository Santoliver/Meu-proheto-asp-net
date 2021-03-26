<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Descricao.aspx.cs" Inherits="Pnoticias.UI.Descricao" %>

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
            <asp:GridView ID="gvResultado" runat="server" OnRowCommand="gvResultado_RowCommand">
                <Columns>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:Button ID="btnExcluir" runat="server" CausesValidation="false" CommandName="cmdExcluir" CommandArgument='<%#Eval("ID")%>' OnClientClick="return confirm('Deseja Realmente Excluir ?')" Text="Excluir" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:Button ID="btnAtualizar" runat="server" CausesValidation="false" CommandName="cmdAtualizar" CommandArgument='<%#Eval("ID")%>' Text="Atualizar" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

            <a href="Index.aspx" target="_top">Voltar</a>
        </div>
    </form>
</body>
</html>
