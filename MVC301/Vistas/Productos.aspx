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
            <asp:Label ID="Label1" runat="server" Text="Clave de producto"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <div>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Descripcion del producto"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Precio"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Existencias"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Id del proveedor"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" />
            &nbsp;<asp:Button ID="Button2" runat="server" Text="Mostrar" />
            &nbsp;<asp:Button ID="Button3" runat="server" Text="Eliminar" />
            &nbsp;<asp:Button ID="Button4" runat="server" Text="Modificar" />
        </div>
    </form>
</body>
</html>
