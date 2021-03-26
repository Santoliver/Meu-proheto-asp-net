<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Pnoticias.UI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../View/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <center>
    <h2>Pesquisa eleitoral</h2>
        </center>

   <center>
    <form id="form1" runat="server">
        <div class="form-group">
            <br />

             <div class="card" style="width: 18rem;">
              <!--img src="..." class="card-img-top" alt="...">-->
              <div class="card-body">
                  <br />
            <label>Login:</label>
                  <br />
            <asp:TextBox ID="txtLogin" placeholder="Email" class="form-control" runat ="server"></asp:TextBox>
            <br />
            <label>Senha:</label>
                  <br />
            <asp:TextBox ID="txtSenha" TextMode="Password" class="form-control" placeholder="Senha" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:Button type="submit" class="btn btn-outline-success btn-block" ID="btnAutenticar" runat="server" Text="Autenticar" OnClick="btnAutenticar_Click" />
            <br />
            <br />
            <a href="Cadastrodeusuario.aspx" target="_top">Faça seu cadastro!!</a>
              </div>
            </div>
             </div>
    </form>
   </center>
</body>
</html>
