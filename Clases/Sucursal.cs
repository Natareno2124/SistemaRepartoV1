using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRepartoG4.Clases
{
    public class Sucursal
    {
        int id, codigo_sucursal, id_encargado, id_direccion_sucursal, id_contacto_sucursal;

        public int Id { get => id; set => id = value; }
        public int CodigoSucursal { get => codigo_sucursal; set => codigo_sucursal = value; }
        public int IdEncargado { get => id_encargado; set => id_encargado = value; }
        public int IdDireccionSucursal { get => id_direccion_sucursal; set => id_direccion_sucursal = value; }
        public int IdContactoSucursal { get => id_contacto_sucursal; set => id_contacto_sucursal = value; }
    }
}
