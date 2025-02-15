using Azure.Core;
using System;
using System.Collections.Generic;
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

        public async Task<string> PostInv( MInventario parametros)
        {
            var json = JsonSerializer.Serialize(parametros);   
            var content  = new StringContent(json,Encoding.UTF8,"application/json");
            HttpResponseMessage response = await client.PostAsync(conect + "InventarioU",content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> PutInv(MInventario parametros)
        {
            var json = JsonSerializer.Serialize(parametros);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(conect + "InventarioU", content);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
