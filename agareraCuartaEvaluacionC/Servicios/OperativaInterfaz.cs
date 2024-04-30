using agareraCuartaEvaluacionC.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace agareraCuartaEvaluacionC.Servicios
{
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Mentodo que valida en dni
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void registroLlegada(List<CitasDTos> listaAntigua);
        /// <summary>
        /// Metodo de pedida de fecha y muestra de las citas 
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void mostrarConsultas(List<CitasDTos> listaAntigua);
    }
}
