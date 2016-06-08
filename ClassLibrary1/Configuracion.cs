using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class Configuracion
    {
        static string cadenaConexion = @"Data Source=CPSI-21\SISTEMAS;Initial Catalog=master;Integrated Security=True";
        public static string CadenaConexion
        {
            get { return cadenaConexion; }
        }
    }
}
