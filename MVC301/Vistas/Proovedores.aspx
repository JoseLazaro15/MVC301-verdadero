<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Proovedores.aspx.cs" Inherits="MVC301.Vistas.Proovedores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Id del proovedor"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Nombre del proovedor"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" />
            &nbsp;
            <asp:Button ID="Button2" runat="server" Text="Mostrar" OnClick="Button2_Click" />
            &nbsp;
            <asp:Button ID="Button3" runat="server" Text="Eliminar" OnClick="Button3_Click" />
            &nbsp;
            <asp:Button ID="Button4" runat="server" Text="Modificar" OnClick="Button4_Click" />
        </div>
    </form>
</body>
</html>
