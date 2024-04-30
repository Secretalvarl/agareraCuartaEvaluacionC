using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace agareraCuartaEvaluacionC.DTOs
{
    internal class CitasDTos
    {
        string dni = ("aaaaa");
        string nombre = ("aaaaa");
        string apellidos = ("aaaaa");
        string especialidad = ("aaaaaa");
        DateTime fechaDeCita = new DateTime(9999 - 12 - 31);
        string asistenciaACita = ("aaaa");

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public DateTime FechaDeCita { get => fechaDeCita; set => fechaDeCita = value; }
        public string AsistenciaACita { get => asistenciaACita; set => asistenciaACita = value; }

        public CitasDTos() { }

        public CitasDTos(string dni, string nombre, string apellidos, string especialidad, DateTime fechaDeCita, string asistenciaACita)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.especialidad = especialidad;
            this.fechaDeCita = fechaDeCita;
            this.asistenciaACita = asistenciaACita;
        }
    }
}
