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
        public string error = "";

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
        public async Task<string> PostUsuSinlcl(MUsuario parametros, DateTime FechaModificacion)
        {
            using (SqlConnection connection = new SqlConnection(conectlocal))
            {
                await connection.OpenAsync();
                using (SqlCommand command = new SqlCommand("InsertarSinUsu", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", parametros.ID);
                    command.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                    command.Parameters.AddWithValue("@Apellido", parametros.Apellido);
                    command.Parameters.AddWithValue("@Telefono", parametros.Numero);
                    command.Parameters.AddWithValue("@Correo", parametros.Correo);
                    command.Parameters.AddWithValue("@Usuario", parametros.Usuario); 
                    command.Parameters.AddWithValue("@Contraseña", parametros.Contraseña);
                    command.Parameters.AddWithValue("@FechaCreacion", parametros.FechaCreacion);
                    command.Parameters.AddWithValue("FechaActualizacion", parametros.FechaActualizacion);
                    command.Parameters.AddWithValue("RolID", parametros.RolID); 
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
                    return "Usuario Guardado";
                }
            }
        }

        public async Task<bool>PostUser(MUsuario parametros)
        {
            var json = JsonSerializer.Serialize(parametros);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(conect + "Usuario", content);
            var result = await response.Content.ReadAsStringAsync();
            if ( result=="true")
            {
                return true;
            }
            else
            {
                error = result;
                return false;
            }
        }

        public async Task<bool> PostUserlcl(MUsuario parametros)
        {
            parametros.Contraseña = parametros.Nombre.Substring(0, 1).ToUpper() + parametros.Apellido.Substring(0, 1).ToLower() + parametros.Numero.Substring(5, 4)+"@!";
            using (SqlConnection connection = new SqlConnection(conectlocal))
            {
                await connection.OpenAsync();
                using (SqlCommand command = new SqlCommand("Insertuserlcl", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@user", parametros.Usuario);
                    command.Parameters.AddWithValue("@Password", parametros.Contraseña);
                    command.Parameters.AddWithValue("@RolID", parametros.RolID);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        error = ex.Message;
                        await connection.CloseAsync();
                        return false;
                    }
                    
                    return true;
                }
            }
        }
    }
}
