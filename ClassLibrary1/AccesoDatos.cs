using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class AccesoDatos
    {
        public static DataTable ObtenerProductos()
        {
            SqlCommand _comando = MetodoDatos.CrearComando();
            _comando.CommandText = "SELECT * FROM TDocente";
            return MetodoDatos.EjecutarComandoSelect(_comando);
        }
        public static DataTable Obteneralumno()
        {
            SqlCommand _comando = MetodoDatos.CrearComando();
            _comando.CommandText = "SELECT * FROM TAlumno";
            return MetodoDatos.EjecutarComandoSelect(_comando);
        }
        public static DataTable obtenercatalogo()
        {
            SqlCommand _comando = MetodoDatos.CrearComando();
            _comando.CommandText = "SELECT * FROM Tcatalogo";
            return MetodoDatos.EjecutarComandoSelect(_comando);
        }
        public static DataTable obtenerasignatura()
        {
            SqlCommand _comando = MetodoDatos.CrearComando();
            _comando.CommandText = "SELECT * FROM TAsignatura";
            return MetodoDatos.EjecutarComandoSelect(_comando);
        }

    }
}
