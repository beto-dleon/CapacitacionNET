using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escuela_DAL;

namespace Escuela_BLL
{
    public class FacultadBLL
    {
        public DataTable cargarFacultades() 
        {
            FacultadDAL facultad = new FacultadDAL();
            return facultad.cargarFacultades();
        }

        public void agregarFacultad(string codigo, string nombre, DateTime fechaCreacion, int universidad)
        {
            FacultadDAL facultad = new FacultadDAL();
            facultad.agregarFacultad(codigo, nombre, fechaCreacion, universidad);
        }

        public DataTable cargarFacultad(int ID_Facultad)
        {
            FacultadDAL facultad = new FacultadDAL();
            return facultad.cargarFacultad(ID_Facultad);
        }

        public void modificarFacultad(int IDFacultad, string codigo, string nombre, DateTime fechaCreacion, int universidad)
        {
            FacultadDAL facultad = new FacultadDAL();
            facultad.modificarFacultad(IDFacultad, codigo, nombre, fechaCreacion, universidad);
        }

        public void eliminarFacultad(int IDFacultad)
        {
            FacultadDAL facultad = new FacultadDAL();
            facultad.eliminarFacultad(IDFacultad);
        }

    }
}
