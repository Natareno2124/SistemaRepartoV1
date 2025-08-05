using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRepartoG4.Clases
{
    public class DireccionSucursal
    {
        int id, zona;
        string calle, avenida, ciudad, municipo;

        public int Id { get => id; set => id = value; }
        public int Zona { get => zona; set => zona = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Avenida { get => avenida; set => avenida = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Municipo { get => municipo; set => municipo = value; }
    }
}
