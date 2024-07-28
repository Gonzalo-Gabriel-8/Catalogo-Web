﻿using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Catalogo_Web.Vistas
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio= new ArticuloNegocio();            
            if (!IsPostBack)
            {
                repRepetidor.DataSource = negocio.listar();
                repRepetidor.DataBind();                
                RepeaterCarrusel.DataSource= negocio.ListaArticulo();
                RepeaterCarrusel.DataBind();    


            }
        }
    }
}