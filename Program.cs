using System;

namespace inclui.edadfecha
{
    class Program
    {
        static void Main(string[] args)
        {

            DatosAnio.InformacionAnio primeraFecha;
            DatosAnio.InformacionAnio segundaFecha;

            int opcion = 0;
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
                    case 2:  break;
                    case 3: break;
                    case 4:  break;
                    case 5:  break;
                    case 6:  break;
                    case 7: break;
                    
                }


            } while (opcion != 8);




            ////5- Calcular la edad de la primera fecha, frente a la fecha actual en años

            //CSComprobaciones.ComprobarEdadFechas(primeraFecha, DateTime.Today);

            //int numAnio = primeraFecha.Year;

            ////6- Calcular la edad de la primera fecha, frente a la fecha actual en días

            //int diasPrimero = (int)(DateTime.Today - primeraFecha).TotalDays;

            ////7- Calcular la edad de la segunda fecha, frente a la fecha actual en años


            ////8- Calcular la edad de la segunda fecha, frente a la fecha actual en días

            //int diasSegundo = (int)(DateTime.Today - segundaFecha).TotalDays;


            ////9- Calcular la diferencia entre las dos fechas, en años y en días

            //int diferenciaFechas = Math.Abs(diasPrimero - diasSegundo);
        }
    }
}
