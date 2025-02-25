using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_Base.Datos
{

    class Sincronizacion
    {
        private Consultar cn = new Consultar();
        private string conect = Conexion.conectionstring;
        private string conectlocal = Conexion.conectionstringlocal;
        private static readonly HttpClient client = new HttpClient();
        private Insertar ins = new Insertar();
        public string Error { get; set; }
        public async Task<bool> Sincronizar()
        {
            // Codigo para sincronizar la base de datos
            return await Revision();

        }

        public async Task<bool> Revision()
        {
            var listApi = new List<MSincronizacion>();
            var ListLocal = new List<MSincronizacion>();

            listApi = await cn.GetSincronizacion();
            ListLocal =await cn.GetSincronizacionlcl();

            bool result = false;
            foreach (var item in listApi)
            {
                foreach (var item2 in ListLocal)
                {
                    if (item.Nombre == item2.Nombre)
                    {
                        if (item.FechaModificacion > item2.FechaModificacion)
                        {
                            switch (item2.Nombre)
                            {
                                case "Inventario":
                                    var listI = await cn.GetInventario();
                                    foreach (var item3 in listI)
                                    {
                                        result =InsertarInvLCL(item3, item.FechaModificacion ?? DateTime.MinValue).Result;
                                    }
                                    break;
                                case "Marca":
                                    break;
                                case "Usuario":
                                    var listU = await cn.GetUsuario();
                                    foreach (var item3 in listU)
                                    {
                                        result = InsertarUsuLCL(item3, item.FechaModificacion ?? DateTime.MinValue).Result;
                                    }
                                    break;
                            }

                        }
                    }
                }
            }
            return result;
        }
        public  async Task<bool> InsertarInvLCL(MInventario parametros, DateTime fecha)
        {
            try
            {
                await ins.PostInvSinlcl(parametros,fecha);
                return true;
            }
            catch (Exception e)
            {
                Error = e.Message;
                return false;
            }
        }
        public async Task<bool> InsertarUsuLCL(MUsuario parametros,DateTime fecha)
        {
            try
            {
                await ins.PostUsuSinlcl(parametros,fecha);
                return true;
            }
            catch (Exception e)
            {
                Error = e.Message;
                return false;
            }
        }
    }
}
