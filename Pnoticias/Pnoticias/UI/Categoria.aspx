<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Categoria.aspx.cs" Inherits="Pnoticias.UI.Categoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ID: (Automático)
            <br />
            Descrição:
            <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" style="height: 26px" />
            <br />
            <a href="Index.aspx" target="_top">Voltar</a>
        </div>
    </form>
</body>
</html>
