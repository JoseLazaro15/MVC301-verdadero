<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MVC301.WebForms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
                <h1>INDEX</h1><br />
            <br />
            <h2>Bienvenido a la aplicacion MVC 301</h2>

    <form id="form1" runat="server">
            <p><a href="Productos.aspx">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 29px" Text="Productos" />
            </a></p>

            <p><a href="Productos.aspx">Productos</a></p>
        <p>&nbsp;</p>

        <div>

        </div>
    </form>
</body>
</html>
