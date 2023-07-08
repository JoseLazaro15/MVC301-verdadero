using MVC301.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
            //Boton agregar producto
            productos prod1 = new productos();

            prod1.ClaveP = int.Parse(TextBox1.Text);
            prod1.Descripcion = TextBox2.Text;
            prod1.Precio = float.Parse(TextBox3.Text);
            prod1.Existencias= int.Parse(TextBox4.Text);
            prod1.IdP= int.Parse(TextBox5.Text);
            db.productos.Add(prod1);
            db.SaveChanges();
            Label6.Text = "Se agrego un nuevo producto";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Muestra los datos y los ingresa en una tabla
            try
            {
                int idProducto = int.Parse(TextBox1.Text);
                productos prod1 = db.productos.Find(idProducto);

                if (prod1 != null)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Id del Producto");
                    dt.Columns.Add("Descripcion del producto");
                    dt.Columns.Add("Precio del producto");
                    dt.Columns.Add("Existencias");
                    dt.Columns.Add("Id del proveedor");

                    DataRow dr = dt.NewRow();
                    dr["Id del producto"] = prod1.ClaveP.ToString();
                    dr["Descripcion del producto"] = prod1.Descripcion;
                    dr["Precio del producto"] = prod1.Precio.ToString();
                    dr["Existencias"] = prod1.Existencias.ToString();
                    dr["Id del proveedor"] = prod1.IdP.ToString();

                    dt.Rows.Add(dr);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();

                    Label6.Text = "Se mostraron los datos";
                }
                else
                {
                    Label6.Text = "No se encontró el proveedor con el ID especificado";
                }
            }
            catch (Exception ex)
            {
                Label6.Text = "Ocurrió un error: " + ex.Message;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Elimina un registro por ID
            productos prod1 = db.productos.Find(int.Parse(TextBox1.Text));
            prod1.ClaveP = int.Parse(TextBox1.Text);
            prod1.Descripcion = TextBox2.Text;
            prod1.Precio = float.Parse(TextBox3.Text);
            prod1.Existencias = int.Parse(TextBox4.Text);
            prod1.IdP = int.Parse(TextBox5.Text);
            db.productos.Remove(prod1);
            db.SaveChanges();
            Label6.Text = "Se ha eliminado con exito";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //Modifica un registro por ID
            productos prod1 = db.productos.Find(int.Parse(TextBox1.Text));
            prod1.ClaveP = int.Parse(TextBox1.Text);
            prod1.Descripcion = TextBox2.Text;
            prod1.Precio = float.Parse(TextBox3.Text);
            prod1.Existencias = int.Parse(TextBox4.Text);
            prod1.IdP = int.Parse(TextBox5.Text);
            db.Entry(prod1).State = EntityState.Modified;
            db.SaveChanges();
            Label6.Text = "Se ha modificado con exito";
        }
    }
}