using agareraCuartaEvaluacionC.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace agareraCuartaEvaluacionC.Servicios
{
    internal class OperativaImplemtacion : OperativaInterfaz
    {
        public void registroLlegada(List<CitasDTos> listaAntigua)
        { 

            Console.WriteLine("Escriba su numero del dni");
            int numeroDni = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba su letra del dni");
            string letraDni = Console.ReadLine();

            string dniCompleto = string.Concat(numeroDni, letraDni);

            string[] letras = { "T", "R", "W", "A", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E"};

            if (letras[numeroDni % 23].Equals(letraDni))
            {
                foreach (CitasDTos buscar in listaAntigua)
                {
                    if (dniCompleto.Equals(buscar.Dni))
                    {
                        Console.WriteLine("Espere su turno para su consulta en la sala de espera.Su especialista le avisara");
                    }
                    else
                    {
                        Console.WriteLine("No dispone de cita previa para hoy");
                    }
                }
                

            }
        }

        public void mostrarConsultas(List<CitasDTos> listaAntigua)
        {
            CitasDTos buscar = new CitasDTos();

            bool cerrarBucle = false;

            do
            {
                Console.WriteLine("Escriba la fecha de la consulta");
                string fecha = Console.ReadLine();
                DateTime fechaCambiada = Convert.ToDateTime(fecha);

                if (fechaCambiada.Equals(buscar.FechaDeCita) && buscar.Especialidad.Equals("Psicología"))
                {
                    Console.WriteLine($"Nombre completo: {buscar.Nombre} {buscar.Apellidos}, Hora: {buscar.FechaDeCita.ToString("hh-mm")}" );
                }
                if (fechaCambiada.Equals(buscar.FechaDeCita) && buscar.Especialidad.Equals("Traumatología"))
                {
                    Console.WriteLine($"Nombre completo: {buscar.Nombre} {buscar.Apellidos}, Hora: {buscar.FechaDeCita.ToString("hh-mm")}");
                }
                if (fechaCambiada.Equals(buscar.FechaDeCita) && buscar.Especialidad.Equals("Fisioterapia"))
                {
                    Console.WriteLine($"Nombre completo: {buscar.Nombre} {buscar.Apellidos}, Hora: {buscar.FechaDeCita.ToString("hh-mm")}");
                }




            } while (cerrarBucle);
        }

      

    }
}
