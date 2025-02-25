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
        [JsonPropertyName("sizeID")]
        public int SizeID { get; set; }
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
    internal class MSize
    {
        [JsonPropertyName("sizeID")]
        public int SizeID { get; set; }
        [JsonPropertyName("tipoID")]
        public int TipoID { get; set; }
        [JsonPropertyName("size")]
        public string Size { get; set; }
    }
    internal class MSincronizacion
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }
        [JsonPropertyName("fechaCreada")]   
        public DateTime FechaCreada { get; set; }
        [JsonPropertyName("fechaModificacion")]
        public DateTime? FechaModificacion { get; set; }
    }
    internal class MUsuario
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }
        [JsonPropertyName("apellido")]
        public string Apellido { get; set; }
        [JsonPropertyName("numero")]
        public string Numero { get; set; }
        [JsonPropertyName("correo")]
        public string Correo { get; set; }
        [JsonPropertyName("usuario")]
        public string Usuario { get; set; }
        [JsonPropertyName("contraseña")]
        [PasswordPropertyText]
        public string Contraseña { get; set; }
        [JsonPropertyName("fechaCreacion")]
        public DateTime FechaCreacion { get; set; }
        [JsonPropertyName("fechaActualizacion")]
        public DateTime? FechaActualizacion { get; set; }
        [JsonPropertyName("rolID")]
        public int RolID { get; set; }
    }
    internal class MRol
    {
        [JsonPropertyName("rolID")]
        public int RolID { get; set; }
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }
    }

    internal class MUsuariou
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }
        [JsonPropertyName("apellido")]
        public string Apellido { get; set; }
        [JsonPropertyName("numero")]
        public string Numero { get; set; }
        [JsonPropertyName("correo")]
        public string Correo { get; set; }
        [JsonPropertyName("usuario")]
        public string Usuario { get; set; }
        [JsonPropertyName("fechaCreacion")]
        public DateTime FechaCreacion { get; set; }
        [JsonPropertyName("rol")]
        public string Rol { get; set; }
    }
}
