<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastrodeusuario.aspx.cs" Inherits="Pnoticias.UI.Cadastrodeusuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../View/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form class="card" id="form1" runat="server">
        <div>
            <h1>Cadastro de Usuario</h1>
            <hr />
             Login:
            <asp:TextBox ID="txtUsuarioLogin" runat="server"></asp:TextBox>
            <br />
            Senha:
            <asp:TextBox ID="txtSenha1" TextMode="Password" runat="server"></asp:TextBox>
            <br />
            &nbsp;Confirmar Senha:
            <asp:TextBox ID="txtSenha2" TextMode="Password" runat="server"></asp:TextBox>
            <br />
            Tipo de Usurio:
            <br />
            Administrador
            <asp:CheckBox ID="checkAdministrador" runat="server" />
            <br />
            <asp:Button class="btn btn-primary" ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
            <br />
            <a href="Login.aspx" target="_top">Entrar</a>
        </div>
    </form>
</body>
</html>
