using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Datos;

namespace Logica
{
    public class AccesoLogica
    {
        public static DataTable ObtenerProductos()
        {
            return AccesoDatos.ObtenerProductos();
        }
        public static DataTable Obteneralumno()
        {
            return AccesoDatos.Obteneralumno();
        }
        public static DataTable obtenercatalogo()
        {
            return AccesoDatos.obtenercatalogo();
        }
        public static DataTable obtenerasignatura()
        {
            return AccesoDatos.obtenerasignatura();
        }
    }
}
