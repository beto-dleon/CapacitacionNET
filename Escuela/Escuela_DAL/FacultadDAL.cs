using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela_DAL
{
    public class FacultadDAL
    {
        public DataTable cargarFacultades()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=DESKTOP-DQ0KHF3;Database=Escuela;Trusted_connection=true";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_cargarFacultades";
            command.Connection = connection;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dtFacultades = new DataTable();

            connection.Open();

            adapter.SelectCommand = command;
            adapter.Fill(dtFacultades);

            connection.Close();

            return dtFacultades;
        }

        public void agregarFacultad( string codigo, string nombre, DateTime fechaCreacion, int universidad)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=DESKTOP-DQ0KHF3;Database=Escuela;Trusted_connection=true";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_agregarFacultad";
            command.Connection = connection;


            command.Parameters.AddWithValue("pCodigo", codigo);
            command.Parameters.AddWithValue("pNombre", nombre);
            command.Parameters.AddWithValue("pFechaCreacion", fechaCreacion);
            command.Parameters.AddWithValue("pUniversidad", universidad);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public DataTable cargarFacultad(int ID_Facultad)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=DESKTOP-DQ0KHF3;Database=Escuela;Trusted_connection=true";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_cargarFacultadPorID";
            command.Connection = connection;

            command.Parameters.AddWithValue("pIDFacultad", ID_Facultad);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dtFacultad = new DataTable();

            connection.Open();

            adapter.SelectCommand = command;
            adapter.Fill(dtFacultad);

            connection.Close();


            return dtFacultad;
        }

        public void modificarFacultad(int IDFacultad, string codigo, string nombre, DateTime fechaCreacion, int universidad)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=DESKTOP-DQ0KHF3;Database=Escuela;Trusted_connection=true";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_modificarFacultad";
            command.Connection = connection;

            command.Parameters.AddWithValue("pIDFacultad", IDFacultad);
            command.Parameters.AddWithValue("pCodigo", codigo);
            command.Parameters.AddWithValue("pNombre", nombre);
            command.Parameters.AddWithValue("pFechaCreacion", fechaCreacion);
            command.Parameters.AddWithValue("pUniversidad", universidad);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void eliminarFacultad(int IDFacultad)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=DESKTOP-DQ0KHF3;Database=Escuela;Trusted_connection=true";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_eliminarFacultad";
            command.Connection = connection;


            command.Parameters.AddWithValue("pIDFacultad", IDFacultad);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

    }
}
