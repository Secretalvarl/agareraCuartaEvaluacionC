using agareraCuartaEvaluacionC.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace agareraCuartaEvaluacionC.Servicios
{
    internal interface FicheroInterfaz
    {
        /// <summary>
        /// Mentodo de la carga inicial del fichero
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void escribirFichero(List<CitasDTos> listaAntigua);
        /// <summary>
        /// Metodo que imprime las consultas de una hora indicada
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void ficheroConsultas(List<CitasDTos> listaAntigua);



    }
}
