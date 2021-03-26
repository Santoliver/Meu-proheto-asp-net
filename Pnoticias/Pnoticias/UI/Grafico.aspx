<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grafico.aspx.cs" Inherits="Pnoticias.UI.Grafico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Chart ID="Chart1" runat="server">
                <Series>
                    <asp:Series Name="Series1"></asp:Series>
                    <Points>
                        <asp:DataPoint AxisLabel ="João" YValues="800">
                        <asp:DataPoint AxisLabel ="Maria" YValues="800">
                        <asp:DataPoint AxisLabel ="Jose" YValues="800">
                        <asp:DataPoint AxisLabel ="Maria" YValues="800">
                    </Points>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
        </div>
    </form>
</body>
</html>
