using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Escuela_BLL;

namespace Escuela.Facultades
{
    public partial class facultad_s : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                grd_facultades.DataSource = cargarFacultades();
                grd_facultades.DataBind();
            }
        }

        protected void grd_facultades_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Editar")
            {
                Response.Redirect("~/Facultades/facultad_u.aspx?pIDFacultad="+e.CommandArgument);
            }
            else
            {
                Response.Redirect("~/Facultades/facultad_d.aspx?pIDFacultad="+e.CommandArgument);
            }
        }

        #endregion


        #region Métodos
        public DataTable cargarFacultades()
        {
            FacultadBLL facuBLL = new FacultadBLL();
            DataTable dtFacultades = new DataTable();

            dtFacultades = facuBLL.cargarFacultades();

            return dtFacultades;
        }

        #endregion
    }
}