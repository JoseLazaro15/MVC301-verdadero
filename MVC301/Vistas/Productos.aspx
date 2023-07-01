<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="MVC301.Vistas.Productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        <br />
    </p>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <div>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <asp:Button ID="Button2" runat="server" Text="Button" />
            <asp:Button ID="Button3" runat="server" Text="Button" />
            <asp:Button ID="Button4" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
