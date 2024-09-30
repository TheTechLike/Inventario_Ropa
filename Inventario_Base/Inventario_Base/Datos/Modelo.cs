using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_Base.Datos
{
    internal class Marca
    {
        public int MarcaID { get; set; }
        public string Nombre { get; set; }
    }

    internal class Tipo
    {
        public int TipoID { get; set; }
        public string Nombre { get; set; }
    }
    internal class Inventario
    {
        public int ObjetoID { get; set; }
        public int MarcaID { get; set; }
        public int TipoID { get; set; }
        public string Nombre { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public int UbicacionID { get; set; }
        public DateTime FechaAquisicion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
    internal class InventarioM
    {
        public int ObjetoID { get; set; }
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string Sector { get; set; }
        public string Pasillo { get; set; }
        public string Fila { get; set; }
        public DateTime FechaAquisicion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
