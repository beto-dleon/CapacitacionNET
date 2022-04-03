using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Escuela_BLL;

namespace Escuela.Facultades
{
    public partial class facultad_d : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int IDFacultad = int.Parse(Request.QueryString["pIDFacultad"]);
                cargarUniversidades();
                cargarFacultad(IDFacultad);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarFacultad();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alta", "alert('Se ha eliminado la facultad exitosamente.')", true);
        }

        #endregion

        #region Métodos
        public void cargarFacultad(int ID_Facultad)
        {
            FacultadBLL facuBLL = new FacultadBLL();
            DataTable dtFacultad = new DataTable();

            dtFacultad = facuBLL.cargarFacultad(ID_Facultad);

            lblIDFacultad.Text = dtFacultad.Rows[0]["ID_Facultad"].ToString();
            lblCodigo.Text = dtFacultad.Rows[0]["codigo"].ToString();
            lblNombre.Text = dtFacultad.Rows[0]["nombre"].ToString();
            lblFechaCreacion.Text = dtFacultad.Rows[0]["fechaCreacion"].ToString().Substring(0, 10);
            ddlUniversidad.SelectedValue = dtFacultad.Rows[0]["universidad"].ToString();

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

        public void eliminarFacultad()
        {
            FacultadBLL facuBLL = new FacultadBLL();
            int IDFacultad = int.Parse(lblIDFacultad.Text);
            facuBLL.eliminarFacultad(IDFacultad);

        }


        #endregion

       
    }
}