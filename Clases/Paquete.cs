using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRepartoG4.Clases
{
    public class Paquete
    {
        public int IdGuiaMadre { get; set; }
        public float PesoKg { get; set; }
        public float LargoCm { get; set; }
        public float AnchoCm { get; set; }
        public float AltoCm { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public string Fragil { get; set; } // aqui colocar S si es si, una N si es no 
        public int TiempoEntrega { get; set; }
        public int IdBodega { get; set; } // esto ya debe estar en la BD porque llama a la tabla de bodega
        public int IdSucursal { get; set; } // esto ya debe estar en la BD porque llama a la tabla de sucursal
    }
}