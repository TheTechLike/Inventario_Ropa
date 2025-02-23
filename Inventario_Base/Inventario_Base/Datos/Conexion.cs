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
            string dbPath = Path.Combine(Application.StartupPath, "Inventario_Ropa.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True;Connect Timeout=30";
            return connectionString;
        }
        //public static string conectionstringlocal = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\gabri\\Documentos\\TheTechLike\\Inventario_Ropa\\Inventario_Base\\Inventario_Base\\Inventario_Ropa.mdf;Integrated Security=True";
    }
}
