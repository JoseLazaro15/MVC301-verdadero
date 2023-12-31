﻿using Microsoft.Ajax.Utilities;
using MVC301.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MVC301.Vistas
{
    public partial class Proovedores : System.Web.UI.Page
    {
        Database1Entities1 db = new Database1Entities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Agrega un nuevo registro
            proveedores prov1 = new proveedores();

            prov1.IdP = int.Parse(TextBox1.Text);
            prov1.NombreP = TextBox2.Text;
            db.proveedores.Add(prov1);
            db.SaveChanges();
            Label3.Text = "Se ha agregado exitosamente";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Muestra los datos y los ingresa en una tabla
            try
            {
                int idProveedor = int.Parse(TextBox1.Text);
                proveedores prov1 = db.proveedores.Find(idProveedor);

                if (prov1 != null)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Id del Proveedor");
                    dt.Columns.Add("Nombre del Proveedor");

                    DataRow dr = dt.NewRow();
                    dr["Id del proveedor"] = prov1.IdP.ToString();
                    dr["Nombre del Proveedor"] = prov1.NombreP;

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
            proveedores prov1 = db.proveedores.Find(int.Parse(TextBox1.Text));
            prov1.IdP = int.Parse(TextBox1.Text);
            prov1.NombreP = TextBox2.Text;
            db.proveedores.Remove(prov1);
            db.SaveChanges();
            Label3.Text ="Se ha eliminado con exito";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //Modifica un registro por ID
            proveedores prov1 = db.proveedores.Find(int.Parse(TextBox1.Text));
            prov1.IdP = int.Parse(TextBox1.Text);
            prov1.NombreP = TextBox2.Text;
            db.Entry(prov1).State = EntityState.Modified;
            db.SaveChanges();
            Label3.Text = "Se ha modificado con exito";
        }
    }
}