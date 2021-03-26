<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Pnoticias.UI.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../View/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
          
            Opções:
            <br />
            <div class="row">  
            <div class="col-1"></div>
            <img src="../img/Consulta.png" width="100" height="100"/>
            <div class="col-1"></div>
            <img src="../img/cadastrar.png" width="100" height="100"/>
            <div class="col-1"></div>
            <img src="../img/noticia.png" width="100" height="100" />
            <div class="col-1"></div>
            <img src="../img/Consultarnot.jpg" width="100" height="100"/>
            <div class="col-1"></div>
            <img src="../img/Sair.jpg" width="100" height="100" />
            <div class="col-1"></div>
            <img src="../img/img_avatar3.png" width="100" height="100" />

                
            </div>
            <br />
            <div class="row">  
                <div class="col-1"></div>
            <asp:Button class="btn btn-primary" ID="btnCadDescricao" runat="server" Text="Descrição" Enabled="false" OnClick="btnDescricao_Click" />
                <div class="col-1">1 of 1</div>
            <asp:Button class="btn btn-primary" ID="btnConCadastro" runat="server" Text="Cadastrar" Enabled="False" OnClick="btnCadastro_Click" />
                 <div class="col-1">1 of 2</div>
            <asp:Button class="btn btn-primary" ID="btnNoticia" runat="server" Text="Noticia" Enabled="False" OnClick="btnNoticia_Click" />
                 <div class="col-1">1 of 3</div>
            <asp:Button class="btn btn-primary" ID="btnConNoticia" runat="server" Text="Consultar Noticia" Enabled="False" OnClick="btnConsultarn_Click" />
             <div class="col-1">1 of 3</div>        
            <asp:Button class="btn btn-primary" ID="btnSair" runat="server" Text="Sair" OnClick="btnSair_Click" />
                <div class="col-1">1 of 5</div>
              
                <a href="Cadfunc.aspx" target="_top">CADASTRO DE ENDEREÇO</a>
            </div>  
    </form>
</body>
</html>
