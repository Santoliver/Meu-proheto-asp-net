<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadfunc.aspx.cs" Inherits="Pnoticias.UI.Cadfunc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../View/bootstrap.css" rel="stylesheet" />
</head>
<body>


    <div class="card" style="width: 18rem;">
  <!-- <img src="..." class="card-img-top" alt="..."> -->
  <div class="card-body">
    
  
</div>
    <form id="form1" runat="server">
        <div>
            ID:(AUTOMATICO)<br />
            <div class="input-box">
            Nome:
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            Sobrenome:
            <asp:TextBox ID="txtsobreNome" runat="server"></asp:TextBox>
            <br />
            Email:
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            CPF:
            <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
            <br />
            RG:
            <asp:TextBox ID="txtRg" placeholder="Digite seu RG" runat="server" ></asp:TextBox>
            <br />
            Cidade:
            <asp:TextBox ID="txtCidade" runat="server"></asp:TextBox>
            <br />
            Bairro:
            <asp:TextBox ID="txtBairro" runat="server"></asp:TextBox>
            <br />
            Endereco:
            <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
            <br />
            UF:
            <asp:TextBox ID="txtUf" runat="server"></asp:TextBox>
            <br />
            Profissão
            <asp:TextBox ID="txtProfissao" runat="server"></asp:TextBox>
            <br />
             
            <asp:Button ID="BtnCadastrar" runat="server" class="btn btn-success btn-block" Text="Cadastro de funcionarios" OnClick="BtnCadastrar_Click" />
            <br />
        </div>

    </form>
</body>
</html>
