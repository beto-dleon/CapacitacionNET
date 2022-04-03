﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Escuela_BLL;

namespace Escuela.Facultades
{
    public partial class facultad_i : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                cargarUniversidades();
            }
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarFacultad();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alta", "alert('Facultad agregada exitosamente.')", true);
        }
        #endregion

        #region Métodos
        public void agregarFacultad()
        {
            FacultadBLL facuBLL = new FacultadBLL();

            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            DateTime fechaCreacion = Convert.ToDateTime(txtFechaCreacion.Text);
            int universidad = int.Parse(ddlUniversidad.Text);

            facuBLL.agregarFacultad(codigo, nombre, fechaCreacion, universidad);
        }

        public void cargarUniversidades()
        {
            UniversidadBLL universidadBLL = new UniversidadBLL();
            DataTable dtUniversidades = new DataTable();

            dtUniversidades = universidadBLL.cargarUniversidades();

            ddlUniversidad.DataSource = dtUniversidades;
            ddlUniversidad.DataTextField = "nombre";
            ddlUniversidad.DataValueField = "ID_Universidad";
            ddlUniversidad.DataBind();

            ddlUniversidad.Items.Insert(0, new ListItem("Seleccione la Universidad", "0"));
        }

        #endregion

    }
}