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
    public partial class Venta : System.Web.UI.Page
    {
        Database1Entities1 db = new Database1Entities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Boton agregar ventas
            ventas ven1 = new ventas();

            ven1.IdVenta = int.Parse(TextBox1.Text);
            ven1.IdVendedor = int.Parse(TextBox2.Text);
            ven1.ClaveP = int.Parse(TextBox3.Text);
            ven1.Iva = int.Parse(TextBox4.Text);
            ven1.Total = float.Parse(TextBox5.Text);
            db.ventas.Add(ven1);
            db.SaveChanges();
            Label6.Text = "Se agrego una nueva venta";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Muestra los datos y los ingresa en una tabla
            try
            {
                int IdVenta = int.Parse(TextBox1.Text);
                ventas ven1 = db.ventas.Find(IdVenta);

                if (ven1 != null)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Id de la venta");
                    dt.Columns.Add("Id del Vendedor");
                    dt.Columns.Add("Clave del producto");
                    dt.Columns.Add("IVA");
                    dt.Columns.Add("Total");

                    DataRow dr = dt.NewRow();
                    dr["Id de la venta"] = ven1.IdVenta.ToString();
                    dr["Id del vendedor"] = ven1.IdVendedor.ToString();
                    dr["Clave del producto"] = ven1.ClaveP.ToString();
                    dr["IVA"] = ven1.Iva.ToString();
                    dr["Total"] = ven1.Total.ToString();

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
            ventas ven1 = db.ventas.Find(int.Parse(TextBox1.Text));
            ven1.IdVenta = int.Parse(TextBox1.Text);
            ven1.IdVendedor = int.Parse(TextBox2.Text);
            ven1.ClaveP = int.Parse(TextBox3.Text);
            ven1.Iva = int.Parse(TextBox4.Text);
            ven1.Total = float.Parse(TextBox5.Text);
            db.ventas.Remove(ven1);
            db.SaveChanges();
            Label6.Text = "Se ha eliminado con exito";

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //Modifica un registro por ID
            ventas ven1 = db.ventas.Find(int.Parse(TextBox1.Text));
            ven1.IdVenta = int.Parse(TextBox1.Text);
            ven1.IdVendedor = int.Parse(TextBox2.Text);
            ven1.ClaveP = int.Parse(TextBox3.Text);
            ven1.Iva = int.Parse(TextBox4.Text);
            ven1.Total = float.Parse(TextBox5.Text);
            db.Entry(ven1).State = EntityState.Modified;
            db.SaveChanges();
            Label6.Text = "Se ha modificado con exito";
        }
    }
}