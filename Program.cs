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
            DateTime primeraFecha = CSComprobaciones.FechaCorrecta();
            int diasPrimero = (int)(DateTime.Today - primeraFecha).TotalDays; 
            DateTime segundaFecha = CSComprobaciones.FechaCorrecta();           
            int diasSegundo = (int)(DateTime.Today - segundaFecha).TotalDays;
            int diferenciaFechas = Math.Abs(diasPrimero - diasSegundo);


            //int EdadAños = 
            //string prueba2 = "15/03/2010";
            //DateTime datoPrueba2 = Convert.ToDateTime(prueba2);

            //Console.WriteLine((datoPrueba2  -  datoPrueba2)TotalDays);
            //Console.ReadKey();
        }
    }
}
