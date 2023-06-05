<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EjemploProyectoWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server"  Text="Ingrese el valor:"></asp:Label>
            <asp:TextBox ID="tbValor" runat="server" Text=""></asp:TextBox>
            <asp:Button ID="btnAgregarValor" runat="server"
                        OnClick="btnAgregarValor_Click"
                        Text="Ingresar Valor"></asp:Button>
            
        </div>
        <br/>
        <div>
            <asp:Label  runat="server" Text="Promedio calculado:"></asp:Label>
            <asp:TextBox ID="tbPromedio" runat="server" Text=""></asp:TextBox>
            <asp:Button ID="btnCalcularPromedio" runat="server"
                        OnClick="btnCalcularPromedio_Click"
                        Text="Calcular Promedio"></asp:Button>
        </div>
    </form>
</body>
</html>
