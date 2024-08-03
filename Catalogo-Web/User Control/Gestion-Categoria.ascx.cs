﻿using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Catalogo_Web.User_Control
{
    public partial class Gestion_Categoria : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Session.Add("Listado", negocio.listaCategoria());
            dgvCategoria.DataSource = Session["Listado"];
            dgvCategoria.DataBind();
        }
        protected void dgvCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Id = dgvCategoria.SelectedDataKey.Value.ToString();
            Response.Redirect("../Vistas/Formulario-Categoria.aspx?Id=" + Id);
        }

        protected void txtBusquedaRapida_Categoria_TextChanged(object sender, EventArgs e)
        {
            List<Categoria> lista = (List<Categoria>)Session["Listado"];
            List<Categoria> listaRapida = lista.FindAll(x => x.Descripcion.ToUpper().Contains(txtBusquedaRapida_Categoria.Text.ToUpper()));
            dgvCategoria.DataSource = listaRapida;
            dgvCategoria.DataBind();
        }
    }
}