<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Votos.aspx.cs" Inherits="Pnoticias.UI.Votos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div>
            
            <asp:RadioButton ID="rdVoto1" runat="server" Text="Pedro" GroupName="VotosGroup" />
            <img src="../img/ui-zac.jpg" width="100" height="100" /><div class="col-1">
            <asp:RadioButton ID="rdVoto2" runat="server" Text="João" GroupName="VotosGroup" OnCheckedChanged="Voto2_CheckedChanged" />
            <img src="../img/ui-sherman.jpg" width="100" height="100" /></div>
            <asp:RadioButton ID="rdVoto3" runat="server" Text="Marta" GroupName="VotosGroup" />
            <img src="../img/ui-divya.jpg" width="100" height="100" /></div>
            <br />
            <asp:Button ID="BtnVoto" runat="server" Text="Votar" OnClick="BtnVoto_Click" />
           
        </form>
    </body>
    </html>
