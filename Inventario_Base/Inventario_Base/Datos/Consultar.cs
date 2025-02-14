using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario_Base.Datos;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Inventario_Base.Datos
{
    internal class Consultar
    {
        private string conect = Conexion.conectionstring;
        private static readonly HttpClient client = new HttpClient();

        public async Task<List<MInventariou>> GetInventario(string? buscar)
        {
          
            HttpResponseMessage response = await client.GetAsync(conect+"inventariou/"+buscar);
            response.EnsureSuccessStatusCode();
            string responsebody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responsebody);
           List<MInventariou> list = JsonSerializer.Deserialize<List<MInventariou>>(responsebody);
            return list;
        }

        public async Task<List<MMarca>> GetMarcas()
        {
            HttpResponseMessage response = await client.GetAsync(conect + "marca");
            response.EnsureSuccessStatusCode();
            string responsebody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responsebody);
            List<MMarca> list = JsonSerializer.Deserialize<List<MMarca>>(responsebody);
            return list;
        }
        public async Task<List<MTipo>> GetTipo()
        {
            HttpResponseMessage response = await client.GetAsync(conect + "tipo");
            response.EnsureSuccessStatusCode();
            string responsebody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responsebody);
            List<MTipo> list = JsonSerializer.Deserialize<List<MTipo>>(responsebody);
            return list;
        }
        public async Task<List<MInventario>> GetLastInventario()
        {

            HttpResponseMessage response = await client.GetAsync(conect + "inventariou/last");
            response.EnsureSuccessStatusCode();
            string responsebody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responsebody);
            List<MInventario> list = JsonSerializer.Deserialize<List<MInventario>>(responsebody);
            return list;
        }

        public async Task<List<MUbicacion>> GetUbi()
        {
            HttpResponseMessage response = await client.GetAsync(conect + "ubicacion");
            response.EnsureSuccessStatusCode();
            string responsebody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responsebody);

            // Deserializar la lista original
            List<MUbicacion> originalList = JsonSerializer.Deserialize<List<MUbicacion>>(responsebody);

            // Crear una nueva lista con el formato requerido
            List<MUbicacion> formattedList = originalList.Select(ubi => new MUbicacion
            {
                UbicacionID = ubi.UbicacionID,
                Pasillo = $"{ubi.Pasillo}-{ubi.Sector}-{ubi.Fila}"
            }).ToList();

            return formattedList;
        }

        public async Task<List<MSize>> GetSize(int TipoID)
        {
            HttpResponseMessage response = await client.GetAsync(conect + "size"+"/"+TipoID);
            response.EnsureSuccessStatusCode();
            string responsebody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responsebody);
            List<MSize> list = JsonSerializer.Deserialize<List<MSize>>(responsebody);
            return list;
        }



    }
}