<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastronoticia.aspx.cs" Inherits="Pnoticias.UI.Cadastronoticia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ID: (Automático) <br />
            Descrição:
            <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
            <br />
            Titulo:
            <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
            <br />
            Conteudo:
            <asp:TextBox ID="txtConteudo" runat="server"></asp:TextBox>
            <br />
             Imagem:
            <asp:TextBox ID="txtImagem" runat="server"></asp:TextBox>
            <br />

            Categoria(id):
            <asp:DropDownList ID="ddlCategoria" runat="server"></asp:DropDownList>
            <br />
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
            <br />
            <a href="Index.aspx" target="_top">Voltar</a>
        </div>
    </form>
</body>
</html>
