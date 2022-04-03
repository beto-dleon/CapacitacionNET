﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela_DAL
{
    public class UniversidadDAL
    {
        public DataTable cargarUniversidades()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=DESKTOP-DQ0KHF3;Database=Escuela;Trusted_connection=true";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_cargarUniversidades";
            command.Connection = connection;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dtUniversidades = new DataTable();

            connection.Open();

            adapter.SelectCommand = command;
            adapter.Fill(dtUniversidades);

            connection.Close();

            return dtUniversidades;
        }
    }
}
