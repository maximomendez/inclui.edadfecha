using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclui.edadfecha
{
    class Program
    {
        static void Main(string[] args)
        {

            DatosAnio.InformacionAnio primeraFecha = new DatosAnio.InformacionAnio();
            DatosAnio.InformacionAnio segundaFecha = new DatosAnio.InformacionAnio();
            DatosAnio.InformacionAnio fechaActual = new DatosAnio.InformacionAnio
            {
                fecha = DateTime.Today,
                antesCristo = false
            };

            int opcion;
            int diferenciaAnio;
            int diferenciaDias;
            do
            {
                MostrarMenu.Menu();
                opcion = OpcionesMenu.LeerOpciones();
                switch (opcion)
                {
                    case 1:
                        primeraFecha = CSComprobaciones.SolicitarFecha("Introduzca la primera fecha");
                        segundaFecha = CSComprobaciones.SolicitarFecha("Introduzca la segunda fecha"); 
                        break;
                    case 2:
                        diferenciaAnio = CSComprobaciones.ComprobarEdadFechas(primeraFecha, fechaActual);
                        Console.WriteLine("La diferencia de años entre {0} y {1} es de {2} años", primeraFecha.fecha, fechaActual.fecha, diferenciaAnio);
                        break;
                    case 3:
                        diferenciaDias = CSComprobaciones.DevolverDias(primeraFecha, fechaActual);
                        Console.WriteLine("La diferencia de días entre {0} y {1} es de {2} días", primeraFecha.fecha, fechaActual.fecha, diferenciaDias);
                        break;
                    case 4:
                        diferenciaAnio = CSComprobaciones.ComprobarEdadFechas(segundaFecha, fechaActual);
                        Console.WriteLine("La diferencia de años entre {0} y {1} es de {2} años", segundaFecha.fecha, fechaActual.fecha, diferenciaAnio); 
                        break;
                    case 5:
                        diferenciaDias = CSComprobaciones.DevolverDias(segundaFecha, fechaActual);
                        Console.WriteLine("La diferencia de días entre {0} y {1} es de {2} días", segundaFecha.fecha, fechaActual.fecha, diferenciaDias); 
                        break;
                    case 6:
                        diferenciaAnio = CSComprobaciones.ComprobarEdadFechas(primeraFecha, segundaFecha);
                        Console.WriteLine("La diferencia de años entre {0} y {1} es de {2} años", primeraFecha.fecha, segundaFecha.fecha, diferenciaAnio);
                        break;
                    case 7:
                        diferenciaDias = CSComprobaciones.DevolverDias(primeraFecha, segundaFecha);
                        Console.WriteLine("La diferencia de días entre {0} y {1} es de {2} días", primeraFecha.fecha, segundaFecha.fecha, diferenciaDias);
                        break;
                    
                }


            } while (opcion != 8);




            ////5- Calcular la edad de la primera fecha, frente a la fecha actual en años

            

            //int numAnio = primeraFecha.Year;

            ////6- Calcular la edad de la primera fecha, frente a la fecha actual en días


            ////7- Calcular la edad de la segunda fecha, frente a la fecha actual en años


            ////8- Calcular la edad de la segunda fecha, frente a la fecha actual en días

            //int diasSegundo = (int)(DateTime.Today - segundaFecha).TotalDays;


            ////9- Calcular la diferencia entre las dos fechas, en años y en días

            //int diferenciaFechas = Math.Abs(diasPrimero - diasSegundo);
        }
    }
}
