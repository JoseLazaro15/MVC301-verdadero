using MVC301.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MVC301.Vistas
{
    public partial class Vendedor : System.Web.UI.Page
    {
        Database1Entities1 db = new Database1Entities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Agrega un nuevo registro
            vendedor ven1 = new vendedor();

            ven1.IdVendedor = int.Parse(TextBox1.Text);
            ven1.NombreVendedor = TextBox2.Text;
            ven1.Edad = int.Parse(TextBox3.Text);
            ven1.Direccion = TextBox4.Text;
            db.vendedor.Add(ven1);
            db.SaveChanges();
            Label5.Text = "Se ha agregado exitosamente";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Muestra los datos y los ingresa en una tabla
            try
            {
                int IdVen = int.Parse(TextBox1.Text);
                vendedor ven1 = db.vendedor.Find(IdVen);

                if (ven1 != null)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Id del Vendedor");
                    dt.Columns.Add("Nombre del Vendedor");
                    dt.Columns.Add("Edad");
                    dt.Columns.Add("Direccion");

                    DataRow dr = dt.NewRow();
                    dr["Id del Vendeor"] = ven1.IdVendedor.ToString();
                    dr["Nombre del vendedor"] = ven1.NombreVendedor;
                    dr["Edad"] = ven1.Edad.ToString();
                    dr["Direccion"] = ven1.Direccion;


                    dt.Rows.Add(dr);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();

                    Label3.Text = "Se mostraron los datos";
                }
                else
                {
                    Label3.Text = "No se encontró el proveedor con el ID especificado";
                }
            }
            catch (Exception ex)
            {
                Label3.Text = "Ocurrió un error: " + ex.Message;
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Elimina un registro por ID
            vendedor ven1 = db.vendedor.Find(int.Parse(TextBox1.Text));
            ven1.IdVendedor = int.Parse(TextBox1.Text);
            ven1.NombreVendedor = TextBox2.Text;
            ven1.Edad= int.Parse(TextBox3.Text);
            ven1.Direccion = TextBox4.Text;
            db.vendedor.Remove(ven1);
            db.SaveChanges();
            Label5.Text = "Se ha eliminado con exito";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //Modifica un registro por ID
            vendedor ven1 = db.vendedor.Find(int.Parse(TextBox1.Text));
            ven1.IdVendedor = int.Parse(TextBox1.Text);
            ven1.NombreVendedor = TextBox2.Text;
            ven1.Edad = int.Parse(TextBox3.Text);
            ven1.Direccion = TextBox4.Text;
            db.Entry(ven1).State = EntityState.Modified;
            db.SaveChanges();
            Label5.Text = "Se ha modificado con exito";
        }
    }
}