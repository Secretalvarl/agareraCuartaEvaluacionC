using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace agareraCuartaEvaluacionC.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuPrincipal()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("|0. Cerrar menu           |");
            Console.WriteLine("|1. Registro de llegada   |");
            Console.WriteLine("|2. Listado de consultas  |");
            Console.WriteLine("---------------------------");

            int opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }

        public int mostrarSubmenu()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("|0. Volver              |");
            Console.WriteLine("|1. Mostrar consulta    |");
            Console.WriteLine("|2. Imprimir consultas  |");
            Console.WriteLine("-------------------------");

            int opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }

        public int mostrarConsultas() 
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("|0. Psicología      |");
            Console.WriteLine("|1. Traumatología   |");
            Console.WriteLine("|2. fisioterapia    |");
            Console.WriteLine("---------------------");

            int opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }
    }
}
