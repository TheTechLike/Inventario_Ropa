using Azure.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace Inventario_Base.Datos
{
    internal class Insertar
    {
        private static readonly HttpClient client = new HttpClient();
        private string conect = Conexion.conectionstring;
        private string conectlocal = Conexion.conectionstringlocal;

        public async Task<string> PostInv(MInventario parametros)
        {
            var json = JsonSerializer.Serialize(parametros);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(conect + "InventarioU", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> PutInv(MInventario parametros)
        {
            var json = JsonSerializer.Serialize(parametros);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(conect + "InventarioU", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> DeleteInv(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync(conect + "InventarioU/" + id);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> PostInvSinlcl(MInventario parametros, DateTime FechaModificacion)
        {
            using (SqlConnection connection = new SqlConnection(conectlocal))
            {
                await connection.OpenAsync();
                using (SqlCommand command = new SqlCommand("InsertarSinInv", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ObjetoID", parametros.ObjetoID);
                    command.Parameters.AddWithValue("@MarcaID", parametros.MarcaID);
                    command.Parameters.AddWithValue("@TipoID", parametros.TipoID);
                    command.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                    command.Parameters.AddWithValue("@SizeID", parametros.SizeID);
                    command.Parameters.AddWithValue("@Color", parametros.Color);
                    command.Parameters.AddWithValue("@Precio", parametros.Precio);
                    command.Parameters.AddWithValue("@Cantidad", parametros.Cantidad);
                    command.Parameters.AddWithValue("@UbicacionID", parametros.UbicacionID);
                    command.Parameters.AddWithValue("@FechaAquisicion", parametros.FechaAquisicion);
                    if (parametros.FechaActualizacion == null)
                        command.Parameters.AddWithValue("@FechaActualizacion", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@FechaActualizacion", parametros.FechaActualizacion);
                    command.Parameters.AddWithValue("@FechaModificacion", FechaModificacion);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }

                    await connection.CloseAsync();
                    return "Inventario Guardado";
                }
            }
        }
    }
}
