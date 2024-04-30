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
        public void escribirFichero(List<CitasDTos> listaAntigua);

        
    }
}
