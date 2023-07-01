using MVC301.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MVC301.Vistas
{
    public partial class Productos : System.Web.UI.Page
    {
        Database1Entities1 db = new Database1Entities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            productos prod1 = new productos();

            prod1.ClaveP = int.Parse(TextBox1.Text);
            prod1.Descripcion = TextBox2.Text;
            prod1.Precio = float.Parse(TextBox3.Text);
            prod1.Existencias= int.Parse(TextBox4.Text);
            prod1.IdP= int.Parse(TextBox5.Text);
            db.productos.Add(prod1);
            db.SaveChanges();
        }
    }
}