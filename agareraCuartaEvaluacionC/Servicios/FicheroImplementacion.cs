using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using agareraCuartaEvaluacionC.DTOs;
using System.Threading.Channels;

namespace agareraCuartaEvaluacionC.Servicios
{
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void escribirFichero(List<CitasDTos> listaAntigua)
        {
            string ruta = "citas.txt";
            try
            {
                using (StreamWriter sw = File.CreateText(ruta))
                {
                    sw.WriteLine("47966922T;Alfonso;Fernández García;Psicología;29-04-2024 12:30:00;true");
                    sw.WriteLine("47166912T;Marta;Fernández Fernández; Psicología; 29-04-2024 13:00:00;false");
                    sw.WriteLine("77851828W;Pedro;Collado Puente; Fisioterapia; 30-04-2024 11:00:00;");
                    sw.WriteLine("37165912P;Laura;Quintero García; Psicología; 29-04-2024 13:30:00;true");
                    sw.WriteLine("12345678Z;Pedro;Collado Puente; Fisioterapia; 29-04-2024 11:00:00;false");
                    sw.WriteLine("37165912P;Laura;Quintero García; Psicología; 25-04-2024 13:30:00;false");
                }

               

            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            CitasDTos citas = new CitasDTos();

            try 
            { 
            
                

                using (StreamReader sr = File.OpenText(ruta))
                {
                    string s = "";
                    while ((s = sr.ReadToEnd()) != null)
                    {

                        string[] arrayCitas = File.ReadAllLines(ruta);

                        for (int i = 0; i < arrayCitas.Length; i++)
                        {
                            arrayCitas[i].Split(';');
                            arrayCitas[0] = citas.Dni;
                            arrayCitas[1] = citas.Nombre;
                            arrayCitas[2] = citas.Apellidos;
                            arrayCitas[3] = citas.Especialidad;

                            string fechaFichero = arrayCitas[4];
                            DateTime fechaCambiada = Convert.ToDateTime(fechaFichero);
                            fechaCambiada = citas.FechaDeCita;

                            arrayCitas[5] = citas.AsistenciaACita;

                            listaAntigua.Add(citas);
                        }
                    }

                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public void ficheroLog(List<CitasDTos> listaAntigua)
        {
            DateTime fechaHoy = DateTime.Now;
            string ruta = ($"log-{fechaHoy.ToString("ddMMyyyy")}.txt");
        }

        public void ficheroConsultas(List<CitasDTos> listaAntigua)
        {
            DateTime fechaHoy = DateTime.Now;

            string ruta = ($"citasConAsistencia-{fechaHoy.ToString("ddMMyyyy")}");

            Console.WriteLine("Escriba la fecha de la consulta");
            string fecha = Console.ReadLine();

            Console.WriteLine("Escriba la especialidad");
            string especialidad = Console.ReadLine();
        }


    }
}
