using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRepartoG4.Clases
{
    public class ContactoSucursal
    {
        int id_contacto_sucursal;
        string telefono_sucusal, correo_sucursal;

        public int IdContactoSucursal { get => id_contacto_sucursal; set => id_contacto_sucursal = value; }
        public string TelefonoSucursal { get => telefono_sucusal; set => telefono_sucusal = value; }
        public string CorreoSucursal { get => correo_sucursal; set => correo_sucursal = value; }
    }
}
