using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace agareraCuartaEvaluacionC.Servicios
{
    internal interface MenuInterfaz
    {
        public int menuPrincipal();

        public int mostrarSubmenu();

        public int mostrarConsultas();
    }
}
