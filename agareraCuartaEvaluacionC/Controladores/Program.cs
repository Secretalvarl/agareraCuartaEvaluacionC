using agareraCuartaEvaluacionC.DTOs;
using agareraCuartaEvaluacionC.Servicios;
using System.IO;

namespace agareraCuartaEvaluacionC.Controladores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuInterfaz alpha = new MenuImplementacion();
            OperativaInterfaz omega = new OperativaImplemtacion();

            List<CitasDTos> listaCitas = new List<CitasDTos>();

            CitasDTos añadir = new CitasDTos();

            int opcionSeleccionada;
            bool cerrarMenu = false;
            try
            {
                while (!cerrarMenu)
                {
                    opcionSeleccionada = alpha.menuPrincipal();

                    switch (opcionSeleccionada)
                    {
                        case 0:
                            Console.WriteLine("Menu cerrado");
                            cerrarMenu = true;
                            break;
                        case 1:
                            Console.WriteLine("Registro de llegada");
                            omega.registroLlegada(listaCitas);
                            break;
                        case 2:
                            Console.WriteLine("Listado de consultas");
                            int opcion;
                            bool cerrarSubmenu = false;
                            while (!cerrarSubmenu)
                            {
                                opcion = alpha.mostrarSubmenu();

                                switch (opcion)
                                {
                                    case 0:
                                        Console.WriteLine("Menu principal");
                                        cerrarSubmenu = true;
                                        break;
                                    case 1:
                                        Console.WriteLine("Mostrar consultas");
                                        int opcion2;
                                        bool cerrarSubmenu2 = false;

                                        while (!cerrarSubmenu2)
                                        {
                                            opcion2 = alpha.mostrarConsultas();

                                            switch (opcion2)
                                            {
                                                case 0:
                                                    Console.WriteLine("Psicología");
                                                    omega.mostrarConsultas(listaCitas);
                                                    cerrarSubmenu2 = true;
                                                    break;
                                                case 1:
                                                    Console.WriteLine("Traumatología");
                                                    omega.mostrarConsultas(listaCitas);
                                                    cerrarSubmenu2 = true;
                                                    break;
                                                case 2:
                                                    Console.WriteLine("Fisioterapia");
                                                    omega.mostrarConsultas(listaCitas);
                                                    cerrarSubmenu2 = true;
                                                    break;
                                                default:
                                                    Console.WriteLine("Opcion no valida");
                                                    break;


                                            }
                                        }

                                        break;
                                    case 2:
                                        Console.WriteLine("Imprimir consulta");
                                        break;
                                    default:
                                        Console.WriteLine("Opcion no valida");
                                        break;


                                }
                            }

                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            break;

                    }
                }
            }catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            
        }
    }
}