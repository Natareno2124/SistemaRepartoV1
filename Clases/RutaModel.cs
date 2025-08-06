using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//creado por Rocio Lopez 9959-263-740
namespace SistemaRepartoG4
{
    public class RutaModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public DateTime Fecha { get; set; }

        // Para las horas
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFinal { get; set; }

        public int IdConductor { get; set; }
    }
}
