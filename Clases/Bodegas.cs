using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRepartoG4.Clases
{
    public class Bodegas
    {
        int id, codigo_Bodega, id_encargado, id_Sucursal, capacidad_bodega;

        public int Id { get => id; set => id = value; }
        public int Codigo_Bodega { get => Codigo_Bodega; set => Codigo_Bodega = value; }
        public int Id_encargado { get => id_encargado; set => id_encargado = value; }
        public int Id_Sucursal { get => id_Sucursal; set => id_Sucursal = value; }
        public int Capacidad_bodega { get => Capacidad_bodega; set => Capacidad_bodega = value; }
    }
}
