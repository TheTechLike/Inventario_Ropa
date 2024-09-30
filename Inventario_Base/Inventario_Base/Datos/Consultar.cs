using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario_Base.Datos;

namespace Inventario_Base.Datos
{
    internal class Consultar
    {
        private string conect = Conexion.conectionstring;

        public async Task<List<Marca>> Marcas()
        {
            var lista = new List<Marca>();
            using (var con = new SqlConnection(conect))
            {
                using (var cmd = new SqlCommand("Select * from Marca", con))
                {
                    await con.OpenAsync();
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (var item = await cmd.ExecuteReaderAsync())
                    {
                        while (await item.ReadAsync())
                        {
                            var marca = new Marca();

                            marca.MarcaID = (int)item[0];
                            marca.Nombre = (string)item[1];
                            lista.Add(marca);

                        }
                    }

                }
            }
            return lista;
        }

        public async Task<List<Tipo>> Tipos()
        {
            var lista = new List<Tipo>();
            using (var con = new SqlConnection(conect))
            {
                using (var cmd = new SqlCommand("Select * from Tipo", con))
                {
                    await con.OpenAsync();
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (var item = await cmd.ExecuteReaderAsync())
                    {
                        while (await item.ReadAsync())
                        {
                            var tipo = new Tipo();
                            tipo.TipoID = (int)item[0];
                            tipo.Nombre = (string)item[1];
                            lista.Add(tipo);
                        }
                    }
                }
            }
            return lista;
        }

        public async Task<int> UltimoObjeto()
        {
            int id = 0;
            using (var sql = new SqlConnection(conect))
            {
                using (var cmd = new SqlCommand("select top 1 objetoid from Inventario order by objetoid desc", sql))
                {
                    await sql.OpenAsync();
                    cmd.CommandType = CommandType.Text;
                    using (var item = await cmd.ExecuteReaderAsync())
                    {
                        while (await item.ReadAsync())
                        {
                            id = (int)item[0];
                        }
                    }
                }
            }
            return id;
        }

        public async Task<List<InventarioM>> Inventarios(string buscar)
        {
            var lista = new List<InventarioM>();
            using (var sql = new SqlConnection(conect))
            {
                using (var cmd = new SqlCommand("buscarINV", sql))
                {
                    await sql.OpenAsync();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Buscar", buscar);
                    using (var item = await cmd.ExecuteReaderAsync())
                    {
                        while (await item.ReadAsync())
                        {
                            var inventario = new InventarioM();
                            inventario.ObjetoID = (int)item[0];
                            inventario.Marca = (string)item[1];
                            inventario.Tipo = (string)item[2];
                            inventario.Nombre = (string)item[3];
                            inventario.Size = (string)item[4];
                            inventario.Color = (string)item[5];
                            inventario.Precio = (decimal)item[6];
                            inventario.Cantidad = (int)item[7];
                            inventario.Sector = (string)item[8];
                            inventario.Pasillo = (string)item[9];
                            inventario.Fila = (string)item[10];
                            inventario.FechaAquisicion = (DateTime)item[11];
                            inventario.FechaActualizacion = (DateTime)item[12];
                            lista.Add(inventario);

                        }
                    }
                }
            }
            return lista;
        }
    }
}