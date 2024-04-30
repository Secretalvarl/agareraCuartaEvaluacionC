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
        /// <summary>
        /// Metodo que muestra el menu principal y su seleccion
        /// </summary>
        /// <returns></returns>
        public int menuPrincipal();
        /// <summary>
        /// Metodo que muestra el sub menu y su seleccion
        /// </summary>
        /// <returns></returns>
        public int mostrarSubmenu();
        /// <summary>
        /// Metodo que muestra las consultas y su seleccion
        /// </summary>
        /// <returns></returns>
        public int mostrarConsultas();
    }
}
