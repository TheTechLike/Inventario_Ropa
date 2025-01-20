using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inventario_Base.Datos
{
    internal class MLogin
    {
        [JsonPropertyName("user")]
        public string User { get; set; }
        [JsonPropertyName("password")]
        [PasswordPropertyText]
        public string Password { get; set; }
    }
    internal class MMarca
    {
        [JsonPropertyName("marcaID")]
        public int MarcaID { get; set; }
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }
    }

    internal class MTipo
    {
        [JsonPropertyName("tipoID")]
        public int TipoID { get; set; }
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }
    }
    internal class MInventario
    {
        [JsonPropertyName("objetoID")]
        public int ObjetoID { get; set; }
        [JsonPropertyName("marcaID")]
        public int MarcaID { get; set; }
        [JsonPropertyName("tipoID")]
        public int TipoID { get; set; }
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }
        [JsonPropertyName("size")]
        public string Size { get; set; }
        [JsonPropertyName("color")]
        public string Color { get; set; }
        [JsonPropertyName("precio")]
        public decimal Precio { get; set; }
        [JsonPropertyName("cantidad")]
        public int Cantidad { get; set; }
        [JsonPropertyName("ubicacionID")]
        public int UbicacionID { get; set; }
        [JsonPropertyName("fechaAquisicion")]
        public DateTime FechaAquisicion { get; set; }
        [JsonPropertyName("fechaActualizacion")]
        public DateTime? FechaActualizacion { get; set; }
    }
    internal class MInventariou
    {
        [JsonPropertyName("objetoID")]
        public int ObjetoID { get; set; }

        [JsonPropertyName("marca")]
        public string Marca { get; set; }

        [JsonPropertyName("tipo")]
        public string Tipo { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("precio")]
        public decimal Precio { get; set; }

        [JsonPropertyName("cantidad")]
        public int Cantidad { get; set; }

        [JsonPropertyName("sector")]
        public string Sector { get; set; }

        [JsonPropertyName("pasillo")]
        public string Pasillo { get; set; }

        [JsonPropertyName("fila")]
        public string Fila { get; set; }

        [JsonPropertyName("fechaAquisicion")]
        public DateTime FechaAquisicion { get; set; }

        [JsonPropertyName("fechaActualizacion")]
        public DateTime? FechaActualizacion { get; set; }
    }

    internal class MUbicacion
    {
        [JsonPropertyName("ubicacionID")]
        public int UbicacionID { get; set; }
        [JsonPropertyName("pasillo")]
        public string Pasillo { get; set; }
        [JsonPropertyName("sector")]
        public string Sector { get; set; }
        [JsonPropertyName("fila")]
        public string Fila { get; set; }
    }
}
