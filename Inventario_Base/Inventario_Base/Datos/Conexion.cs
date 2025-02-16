using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_Base.Datos
{
    internal class Conexion
    {
        public static string conectionstring = "http://10.0.0.129:1025/api/";

        public static string conectionstringlocal = GetLocalConnectionString();

        private static string GetLocalConnectionString()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = @"..\..\..\Datos\Inventario Ropa.mdf";
            string fullPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(baseDirectory, relativePath));
            return $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"{fullPath}\";Integrated Security=True";
        }
    }
}
